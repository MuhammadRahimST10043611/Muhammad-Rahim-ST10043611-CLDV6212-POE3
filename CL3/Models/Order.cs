using System.ComponentModel.DataAnnotations;

namespace CL3.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [Required]
        public string UploadedFile { get; set; }
    }
}