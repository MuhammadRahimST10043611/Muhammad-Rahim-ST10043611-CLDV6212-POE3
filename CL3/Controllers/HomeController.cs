using Microsoft.AspNetCore.Mvc;
using CL3.Models;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CL3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Landing()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Add contact form processing logic here
                TempData["Message"] = "Thank you for your message. We'll get back to you soon!";
                return RedirectToAction("Contact");
            }
            return View(model);
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Customers = await _context.Customers.ToListAsync();
            ViewBag.Products = await _context.Products.ToListAsync();
            ViewBag.Orders = await _context.Orders.ToListAsync();
            return View();
        }

        public async Task<IActionResult> ManageRecords()
        {
            var viewModel = new ManageRecordsViewModel
            {
                Customers = await _context.Customers.ToListAsync(),
                Products = await _context.Products.ToListAsync(),
                Orders = await _context.Orders.ToListAsync()
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Customers.Add(customer);
                    await _context.SaveChangesAsync();
                    TempData["Message"] = "Customer added successfully!";
                }
                catch (Exception ex)
                {
                    TempData["Error"] = "Error adding customer: " + ex.Message;
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(IFormFile imageFile)
        {
            try
            {
                if (imageFile != null)
                {
                    string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + Path.GetFileName(imageFile.FileName);
                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");

                    if (!Directory.Exists(uploadsFolder))
                    {
                        Directory.CreateDirectory(uploadsFolder);
                    }

                    string filePath = Path.Combine(uploadsFolder, fileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(fileStream);
                    }

                    var product = new Product { Image = fileName };
                    _context.Products.Add(product);
                    await _context.SaveChangesAsync();
                    TempData["Message"] = "Product image added successfully!";
                }
                else
                {
                    TempData["Error"] = "Please select an image file.";
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error adding product: " + ex.Message;
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder([Bind("OrderID")] Order order, IFormFile uploadedFile)
        {
            try
            {
                if (uploadedFile != null && order.OrderID > 0)
                {
                    // Check if OrderID already exists
                    var existingOrder = await _context.Orders.FindAsync(order.OrderID);
                    if (existingOrder != null)
                    {
                        TempData["Error"] = "Order ID already exists!";
                        return RedirectToAction("Index");
                    }

                    // Process the file
                    string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + Path.GetFileName(uploadedFile.FileName);
                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");

                    if (!Directory.Exists(uploadsFolder))
                    {
                        Directory.CreateDirectory(uploadsFolder);
                    }

                    string filePath = Path.Combine(uploadsFolder, fileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await uploadedFile.CopyToAsync(fileStream);
                    }

                    order.UploadedFile = fileName;
                    _context.Orders.Add(order);
                    await _context.SaveChangesAsync();
                    TempData["Message"] = "Order added successfully!";
                }
                else
                {
                    TempData["Error"] = "Please provide both Order ID and upload a file.";
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error adding order: " + ex.Message;
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
                TempData["Message"] = "Customer deleted successfully!";
            }
            return RedirectToAction("ManageRecords");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                // Delete the image file
                var imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", product.Image);
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }

                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                TempData["Message"] = "Product deleted successfully!";
            }
            return RedirectToAction("ManageRecords");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order != null)
            {
                // Delete the uploaded file
                var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", order.UploadedFile);
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }

                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
                TempData["Message"] = "Order deleted successfully!";
            }
            return RedirectToAction("ManageRecords");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}