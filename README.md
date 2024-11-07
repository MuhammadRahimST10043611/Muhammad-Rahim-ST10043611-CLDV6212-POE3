Muhammad Rahim
ST10043611
CLDV6212
POE PART 3















![image](https://github.com/user-attachments/assets/2b021799-a234-483f-979d-0b712b2f8891)











Table of Contents
1.	Create an Azure SQL database	3
How to Create a Database in Azure	3
CREATE SQL SERVER FIRST	3
CREATE SQL DATABASE NEXT	6
How to connect your Azure SQL database to your SQL Server Management	11
Please Find below the table I have created in my SQL Server	15
How to Create Replica of Database	17
Website Link and in depth of what the website does:	20
The process for Creating your web application in Azure App Service	20
The process for deploying your web application on an App Service	23
Proof Of Data being collected in the database	37
GitHub Link and GitHub Commits:	39
2.	Document the technology choices for your solution	41
3.	Motivate the Azure Services used for each application functionality.	43
4.	Identify alternative Azure technologies	46
Disclaimer	50
References Used in POE PART 3	50
References	51











1.	Create an Azure SQL database
How to Create a Database in Azure
CREATE SQL SERVER FIRST
First click on search and search for, “SQL Servers” then click on it. (Please Zoom in to see image Clearer)
 
![image](https://github.com/user-attachments/assets/86ada243-6196-4a53-9f38-5f03a80c3116)

Then when you get Click on , “Create” . (Please Zoom in to see image Clearer)
 ![image](https://github.com/user-attachments/assets/417981c5-e92a-4731-831f-35a47ec8f7e2)

Make sure you are using the correct subscription and resource group, also you can give your server name anything you want. (Please Zoom in to see image Clearer)
 
![image](https://github.com/user-attachments/assets/0d64fc3e-2a84-4e02-b4fd-aae38a3cb603)

Make sure you are using South Africa North as the location. Also please note for Authentication Method you can use whatever you comfortable with but in my regards, I used SQL Authentication if you decide to follow what I did PLEASE REMEMBER YOUR SERVER ADMIN LOGIN AND PASSWORD. (Please Zoom in to see image Clearer)
 

![image](https://github.com/user-attachments/assets/01d2b941-ba68-4035-9f79-41f8c6b22a93)

Once you are done with that click on “Review and Create” and scroll down to the bottom of the page and click on, “Create”. (Please Zoom in to see image Clearer)
 ![image](https://github.com/user-attachments/assets/9945abc4-601f-4c48-89bd-85dafb81c295)


Once the deployment process is done click on the server you just created and go to the tab that says, “Networking” and then click on, “Selected Networks” and make sure your Start IPv4 address and End IPv4 address is exactly what I have then click on save otherwise if you do not have this your database cannot communicate with your server. (Please Zoom in to see image Clearer)
 ![image](https://github.com/user-attachments/assets/b24e6b1a-9982-440b-9786-b10469aceda4)


CREATE SQL DATABASE NEXT
First click on search and search for, “SQL Database” then click on it. (Please Zoom in to see image Clearer)
 ![image](https://github.com/user-attachments/assets/7b20b232-cd4d-4741-9302-d441c305388e)


Then when you get Click on , “Create” . (Please Zoom in to see image Clearer)
 
![image](https://github.com/user-attachments/assets/60af434e-7500-4ef1-8735-bca472ed6615)



Make sure you are using the correct subscription and resource group, also you can give your database name anything you want. PLEASE MAKE SURE THAT YOUR SERVER IS ON THE ONE YOU JUST CREATED ABOVE. (Please Zoom in to see image Clearer)
![image](https://github.com/user-attachments/assets/63a716f4-90bf-4c0d-a9e8-7ba16411a786)
 

Leave SQL Elastic pool and Workload Environment on, “No” and, “Development”. Then Click on, “Configure Database”. (Please Zoom in to see image Clearer)
 
![image](https://github.com/user-attachments/assets/e03f5cc6-3637-4607-a5d3-1eb223422b84)



You will then be brought to this tab where you must select the tier that suits you the best, The Pricing Plans are as follows: 
vCore-based purchasing model
•	General Purpose: For standard workloads, this is a cost-effective, versatile option. You may adjust vCores and storage to suit your needs thanks to its balanced performance and scalability. 
•	Hyperscale: Ideal for applications with irregular consumption trends. By charging per vCores-second, it dynamically modifies computation and storage based on demand, making it a great choice for workloads that fluctuate. 
•	Business Critical: Designed for applications needing scalability and high performance. It is perfect for data-intensive applications that require high availability and quick querying since it allows for the independent expansion of computation and storage resources. 
DTU-based purchasing model
•	Basic: A cost-effective option for simple, small jobs with reliable performance requirements. To ensure dependable performance, it provides a fixed number of Database Transaction Units (DTUs). 

•	Standard: For workloads of small to medium sizes, this level offers varying levels of performance and scalability. There are a specific number of designated DTUs allocated to the Standard service levels (S0, S1, S2, S3, S4, S6, S7, S9, and S12). 

•	Premium: A versatile option for general jobs. It is perfect for applications with varying resource requirements since it enables performance scaling by changing the allocated DTUs. The DTU distribution shows a rise in the Premium levels (P1, P2, P4, P6, P11, and P15). 








in this case, we do not have such a big database so there is no need to go all out as the BASIC tier meets all our requirements. (Please Zoom in to see image Clearer)
 
![image](https://github.com/user-attachments/assets/0c8ee4e2-f33b-4ae2-b0c1-2b5bcdbf2807)

Then click on, “Apply” after you chose the “basic” Tier. (Please Zoom in to see image Clearer)
 

![image](https://github.com/user-attachments/assets/ba687fe5-c9f5-45fd-92bc-9c1a6e24c3ed)


You can choose any backup storage redundancy that fits your requirements in my case I will be using, “Locally-redundant backup storage”. (Please Zoom in to see image Clearer)
 
![image](https://github.com/user-attachments/assets/54e507f4-19b4-44d3-91f1-0cde0d48edb6)

Once you done click on, “Review and Create” then click on, “Create” and after the deployment as succeeded you have successfully created a SQL Server and Database. (Please Zoom in to see image Clearer)
 
![image](https://github.com/user-attachments/assets/e8c16680-7b89-4b30-bb6a-d7f109205dc2)



How to connect your Azure SQL database to your SQL Server Management

Please head over to the specific database that you want to connect to then click on, “Overview” it will be the tab on the left hand side. Once inside here you will see a lot of content that might confuse but do not worry, we only looking for the link that will be found by, “Server name” COPY THAT SPECIFIC Link. (Please Zoom in to see image Clearer)
 


![image](https://github.com/user-attachments/assets/c5b4e52e-42a7-4fd4-b893-39472516f20f)










Once you have that, open SQL Server Management Studio and you will be prompted with this make sure your Authentication is exactly on what you choose in the 4th Photo/step of how to create a SQL Server that part which I stated do not forget these details will come into play now. (Please Zoom in to see image Clearer)
 

![image](https://github.com/user-attachments/assets/fd046e02-552f-45c6-b292-f35241d380e3)











Paste that link I asked you copy into the Server Name Tab make sure your authentication is correct in my case I used SQL Server Authentication. After that enter your Login name and password. It is completely up to you if you are wise to check the Remember password box for me, I find it more convenient but if you are working with multiple databases that can be a problem as not all databases will have the same Login name and password. So, keep that in mind. Once you are done filling in all those details click on, “Connect”. (Please Zoom in to see image Clearer)
 


![image](https://github.com/user-attachments/assets/6c58fb02-75af-4c78-be37-9f01d3ff2dd9)








If you see this, you have successfully connected your Azure database to SQL Server Management Studio and you can now begin with what is required from you. (Please zoom in to see image Clearer)
 



![image](https://github.com/user-attachments/assets/67f4a1df-e7a8-4e8f-9d7e-f924f70ef299)











Please Find below the table I have created in my SQL Server
BlobTable Created (Please zoom in to see image Clearer)
 ![image](https://github.com/user-attachments/assets/1a4de009-5ae3-4867-a7ba-0760dce935c4)


CustomerTable Created (Please zoom in to see image Clearer)
![image](https://github.com/user-attachments/assets/b600462f-029b-4cbe-8a0e-e7111cb9a93a)

OrderTable Created (Please zoom in to see image Clearer)

![image](https://github.com/user-attachments/assets/eb41b379-cb9b-46da-83ea-dfe8cfa335b1)















How to Create Replica of Database
When creating a replica of a database click on the database you want to replicate and look the tab called, “Replicas” you can either search for it in the database or if you go to, “Data management” tab you will see it there. Click on it. (Please zoom in to see image Clearer)
 

When you click on “Replicas” You will be brought here you should see nothing here at all. Click on, “Create Replica”. (Please zoom in to see image Clearer)
 



Please Make sure Project Details are correct as you won’t be able to edit these details so make sure you are on the correct database. (Please zoom in to see image Clearer)
 




Please note at this step you will have to make sure you are on the correct Subscription and Resource Group also please note you will have to create a new server as you cannot use the same server as replica. So, click on, ‘’Create New” under server name.  (Please zoom in to see image Clearer)
 


Follow the same steps for How to create a SQL server. By server name give it name that won’t confuse you from the original database in my instance I keep the same name and just put 
-Replica so I know that this is a replica of my original database. Please note you must choose a different region as this is a failsafe database so you would want it in a different region. Once you are done click, “OK”. You will be brought back to the screen step/photo 4. Leave SQL Elastic pool and Compute + Storage on, “No” and “Basic”. Then you can click on, “Review and Create”. Then on, “Create”.  (Please zoom in to see image Clearer)
 


If you followed all the steps correctly you will have successfully created a new Replica of your existing Database. (Please zoom in to see image Clearer)
 

Website Link and in depth of what the website does:
The process for Creating your web application in Azure App Service

Step 1: Search for App Service in Azure Platform and click on that one. (Please zoom in to see image Clearer) 


Step 2: Click on, “Create”. (Please zoom in to see image Clearer)
 




Step 3:  Click on, “Web App”. (Please zoom in to see image Clearer)
 
Step 4: Make sure the Subscription and resource group is all correct. You can give your web app any name, I prefer to un check the, “try a unique default hostname” as it makes the web address too long and not very UI appealing. Make sure Publish is on, “Code”, Runtime stack is on, “.NET8 (LTS)” make sure Operating System is on, “Windows” as that’s the most used OS. Make sure your region is on, “South Africa North”. (Please zoom in to see image Clearer)
 







Step 5: Make sure your Pricing plan is on Free F1 as that plan is the cheapest. (Please zoom in to see image Clearer)
 

Step 6: Go over to the deployment tab and make sure basic authentication is ENABLED. This is very important otherwise when you try to publish you will run into errors. (Please zoom in to see image Clearer)
 



The process for deploying your web application on an App Service
Step 1:  Click on Build, then on Publish (Please zoom in to see image Clearer)
 

Step 2: Click on New Profile the click on what ever service you used in this case we will click on Azure. Then click on next. (Please zoom in to see image Clearer)
 
Step 3: Make sure you chose the one you created for when you had to choose Operating system in my case that was windows.  (Please zoom in to see image Clearer)
 

Step 4: Then click on your resource group folder and all the web apps you created will be shown below click on the one you want then to click on finish once you done click on publish and by doing this you have successfully published your code to Azure Web Services. (Please zoom in to see image Clearer)
 
https://st10043611cldv.azurewebsites.net/

Please find below proof of the website being deployed. (Please zoom in to see image Clearer)
 


















Landing Page Part 1: if the user clicks on “Get Started” they will be taken to the dashboard page. (Please zoom in to see image Clearer) 




Landing Page Part 2: (Please zoom in to see image Clearer)
 





Dashboard Page Part 1: (Please zoom in to see image Clearer)
 


Dashboard Page Part 2: What it looks like when the user adds a customer. (Please zoom in to see image Clearer)
 








Dashboard Page Part 3: Gives a prompt that says Customer has been added successfully so the user is aware that it went through successfully. (Please zoom in to see image Clearer)
 


Dashboard Page Part 4: What it looks like when the user adds a product image. (Please zoom in to see image Clearer)
 




Dashboard Page Part 5: Gives a prompt that says Product Image has been added successfully so the user is aware that it went through successfully. (Please zoom in to see image Clearer)
 



Dashboard Page Part 6: What it looks like when the user adds an order, they can increase the order ID number by using the arrow keys on it or simply just type the number and they can upload a file as well. (Please zoom in to see image Clearer)
 



Dashboard Page Part 7: Gives a prompt that says Order has been added successfully so the user is aware that it went through successfully. (Please zoom in to see image Clearer)
 
























Manage Records Page Part 1: shows all the Customers that have been added to the database and reflects the data back to this page. (Please zoom in to see image Clearer)
 


Manage Records Page Part 2: shows all the Product images and Orders that have been added to the database and reflects the data back to this page. (Please zoom in to see image Clearer)
 






Manage Records Page Part 3: Gives this prompt if the user wants to delete a customer from the Manage Records table. (Please zoom in to see image Clearer)
 



Manage Records Page Part 4: Displays a message that will state that the customer has been removed and it will update the database accordingly and only display the remaining customers. (Please zoom in to see image Clearer)
 



Manage Records Page Part 5: Gives this prompt if the user wants to delete a Product Image from the Manage Records table. (Please zoom in to see image Clearer)
 



Manage Records Page Part 6: It will also Displays a message that will state that the Product has been removed and it will update the database accordingly and only display the remaining Products. (Please zoom in to see image Clearer)
 
Manage Records Page Part 7: Gives this prompt if the user wants to delete an Order from the Manage Records table. (Please zoom in to see image Clearer)
 


Manage Records Page Part 8: It will also Displays a message that will state that an Order has been removed and it will update the database accordingly and only display the remaining Orders.  (Please zoom in to see image Clearer)
 



Contact Us Page Part 1:  Gives the user just a brief way of getting in contact with us. (Please zoom in to see image Clearer)
 




Contact Us Page Part 2: What the form looks like filled in. (Please zoom in to see image Clearer)
 





Contact Us Page Part 3: The prompt the user will receive after they click on submit message. (Please zoom in to see image Clearer)
 
























Proof Of Data being collected in the database
Customer SQL Proof: (Please zoom in to see image Clearer)
 

Order SQL Proof: (Please zoom in to see image Clearer)
 



Product SQL Proof: (Please zoom in to see image Clearer)
 




















GitHub Link and GitHub Commits:
https://github.com/MuhammadRahimST10043611/Muhammad-Rahim-ST10043611-CLDV6212-POE3/commits/Final-Code/

Please look at the branch that is called Final-Code when marking my work as that is my final code or use the link provided above.


GitHub Branches Part 1: (Please zoom in to see image Clearer)
 


GitHub Branches Part 2: (Please zoom in to see image Clearer)
 

GitHub Commits Part 1: (Please zoom in to see image Clearer)
 





GitHub Commits Part 2: (Please zoom in to see image Clearer)
 







2.	Document the technology choices for your solution

Component	Technology Choice	Service	Hosting Model
Azure App Service	Compute	Web Application Hosting	PaaS
Azure Storage	Data Storage	Blob, Table, Queue, File Storage	PaaS
Azure Functions	Serverless Compute	Function App	FaaS (Function-as-a-Service)
Azure SQL Server	Database Management	SQL Database	PaaS
Azure SQL Database	Data Storage	SQL Database	PaaS
Azure SQL Database Replicas	Data Replication	Geo-Redundant Database	PaaS

An explanation of every component and in which part they were used:

1.	All POE components' web applications are hosted on Azure App Service, which offers scalability, ease of deployment, and a secure hosting environment. By taking care of server infrastructure, the PaaS model streamlines maintenance and frees you up to concentrate on the application code.

2.	Azure Storage: Used in Parts 1 and 2, this service offered file, queue, table, and blob storage for many kinds of data.
•	Blob Storage: Used to store multimedia files.
•	Table Storage: For client profiles and other structured data.
•	Queue Storage: Used for inventory messages and order processing.
•	File Storage: Used for log files and contracts. Every storage type, which is housed in a scalable PaaS paradigm, was selected based on its unique data management characteristics.

3.	Writing to Blob Storage, Table Storage, Queue Storage, and File Storage are examples of modular activities made possible by Azure Functions, which were implemented in Part 2 to allow a serverless architecture. For discrete workloads, FaaS offers an affordable, event-driven computing solution.

4.	In Part 3, Azure SQL Server and Azure SQL Database were added to handle customer, product, and order data and provide consolidated relational data storage. By providing a managed SQL environment, this PaaS solution lowers administrative burden.

5.	Azure SQL Database Replicas: Set up in Part 3 to improve data redundancy and reliability by establishing a replica in a different location, guaranteeing disaster recovery support and high availability across geographical areas.





































3.	Motivate the Azure Services used for each application functionality.
Application Requirement	Azure Service	Motivation
1. Hosting a scalable and secure web application	Azure App Service	Quick deployment, automatic scalability, and secure online application hosting are made possible by Azure App Service's Platform-as-a-Service (PaaS) paradigm, which eliminates the need to manage the underlying server infrastructure. This guarantees the web application's availability and dependable operation even during periods of high traffic.
2. Storage and retrieval of customer profiles and product data	Azure Table Storage	For the management of structured, non-relational data, such as customer profiles and product information, Table Storage provides an extremely scalable alternative. It is perfect for storing data in a key-value format, giving the program easy and inexpensive access to information that often needs to be read or searched.
3. Storage of product images and multimedia content	Azure Blob Storage	Blob Storage is perfect for hosting photos, videos, and other multimedia content because it is designed for unstructured data. The application may increase storage independently based on usage without sacrificing performance thanks to this service, which also offers safe entry to multimedia files.
4. Processing of order transactions and inventory updates	Azure Queue Storage	Sequential communications are supported by Queue Storage, making it perfect for handling orders and stock. It makes it possible for app parts to communicate reliably with one another, guaranteeing that orders are processed sequentially even during periods of high demand without overloading the primary application.

5. File storage for contracts and log files	Azure File Storage	Cloud-based, securely managed file shares are offered via Azure File Storage. For auditing and compliance needs, contract documents and log files can be easily stored and accessed thanks to this service's structured file storage capabilities. It can also be accessed from on-premises computers if necessary thanks to its support for the SMB protocol.
6. Centralized relational database for transactional data	Azure SQL Database	The hosted relational database solutions offered by Azure SQL Database is perfect for transactional information, including orders, clients, and goods. It has extensive safety precautions, allows complex queries, and guarantees excellent data integrity. This makes it possible for the program to securely and effectively manage relational data.

In-depth Reasons:

1.	Using Azure App Service to host websites: It makes scalability and deployment easier, freeing developers to concentrate on the functionality of their applications rather than infrastructure administration. Because of its integrated auto-scaling capability, it can handle the varying workloads found in online retail platforms.

2.	Azure Table Storage for Customer Profiles: Table Storage is an affordable option for storing substantial volumes of structured data and works well in situations where customers' information needs to be accessed quickly. Because consumer information is available almost instantly, this improves the user experience.

3.	Azure Blob Storage for Multimedia Content: Blob Storage enables storage to expand effectively and independently, which is important because multimedia files can take up a lot of storage and affect application performance. For quicker content delivery worldwide, Blob Storage also works well with content delivery networks (CDNs).

4.	Azure Queue Storage for Transaction Processing: Asynchronous processing is made possible by the queue, which is essential for a seamless user experience while placing orders and managing inventories. Without affecting the main user interface, the program can offload tasks and process them progressively by using a queue.

5.	Cloud file shares that are accessible from both on-premises and cloud settings can be seamlessly integrated with Azure File Storage for Contracts and Logs. This ensures that private records, including logs and contracts, are securely stored and easily accessible for compliance and administrative needs.

6.	Managing Transactional Data with Azure SQL Database: SQL Database is a reliable relational database service that supports complex querying requirements and structured data. It is perfect for managing sensitive transactional data because of its built-in high availability and data protection, which enhances application performance and data security.

7.	Replicas of Azure SQL databases for redundancy: By ensuring data accessible and continuous application performance during regional outages, data duplication across multiple regions improves high availability and disaster recovery. This meets the reliability and consistency requirements of businesses.



4.	Identify alternative Azure technologies

Application Requirement	Current Azure Service	Alternative Azure Service	Motivation for Alternative
1. Hosting a scalable and secure web application	Azure App Service	Azure Kubernetes Service (AKS)	AKS provides a containerized approach to application deployment, scalability, and management. Because it enables container orchestration and improved resource distribution management, this product is ideal for microservices architectures. It is very suitable for use cases that require more complex configurations and scalability than App Service provides. 
2. Storage of customer profiles and product data	Azure Table Storage	Azure Cosmos DB (Table API)	A worldwide distributed, multi-model database service that supports the Table storage data model is offered by Cosmos DB with the Table API. It is appropriate for applications requiring enhanced performance and scalability across multiple areas due to its low latency, high availability, and global distribution. 
3. Storage of multimedia content (images, videos)	Azure Blob Storage	Azure Media Services	Media asset handling, encoding, and streaming are the main objectives of Azure Media Services. It provides additional capabilities for content protection, live streaming, and video processing, which could be useful if the program requires complex multimedia management. 
4. Processing of order transactions and inventory updates	Azure Queue Storage	Azure Service Bus	Azure Service Bus is a messaging platform designed for business-level communication. For more complex workflows and connection with other enterprise systems, it offers additional features for message sequencing, transactions, and complex message routing. 
5. Centralized relational database for transactional data	Azure SQL Database	Azure Cosmos DB (SQL API)	The SQL API offered by Cosmos DB offers a NoSQL alternative with SQL-like queries. Because of its global distribution and low latency optimization, it is perfect for applications that need scalability and high read and write throughput. Cosmos DB can distribute data across multiple regions and is highly accessible. 




In-depth Reasons:

1.	AKS (Azure Kubernetes Service) for Web Application Hosting: Applications built with microservices, or container architectures benefit from AKS's increased flexibility, which makes resource separation, sophisticated scaling, and incremental upgrades possible. It is ideal for apps that require customized configurations beyond Azure App Service's capabilities. 

2.	Table API for Azure Cosmos DB for Non-Relational Data: Cosmos DB provides a globally distributed solution with millisecond response rates through the Table API. It is better suited for key-value data storage applications that need high availability and performance, especially when dispersed over multiple locations. 

3.	Azure Media Services for Multimedia Storage: Azure Media Services provides encoding, live streaming, and content security for programs that require professional media management. By optimizing multimedia handling and streaming effectiveness, these solutions may boost the user experience. 

4.	Azure Service Bus for Transactional Messaging: Service Bus is a powerful messaging solution made for businesses that can manage complex processes, large message volumes, and transactions. It is ideal for more complicated processing scenarios where messages require delivery assurance, scheduling, or connection with external apps or other Azure services. 

5.	SQL API for Distributed Transactional Data in Azure Cosmos DB: Along with the benefit of horizontal scaling across global locations, Cosmos DB's SQL API offers fast access to data. High-throughput applications that demand dependable data access between users spread across several geographic locations are ideally suited for it. 

6.	Redundancy with Azure Managed Instance (Failover Groups): Managed Instance with Failover Groups offers greater authority over settings together with improved dependability. Because it ensures seamless failover and enhanced data redundancy across regions, it is a great choice for programs that require continuous operation with stricter configuration or compliance control.
























Disclaimer 
Please note that ChatGPT has been used in this POE part 3 please look at the reference list for more information.
References Used in POE PART 3
(Microsoft Ignite, n.d.) (Schaffer & Tyson, 2024) (Dubey & Haas, 2022) (Andrews & Wang, 2024) (Dubey & Estabrook, 2022) (Microsoft Ignite, n.d.) (Estabrook & Dahan, 2023) (Pelluru & Glodha, 2024) (MSFT & Furman, 2024) (Microsoft Ignite, n.d.) (MSFT & (MSFT), 2024)  (C#!, 2023) (Skwiers-Koballa & Ghanayem, 2024) (w3schools, n.d.) (w3schools, n.d.) (ChatGpt, 2024) (ChatGPT, 2024) 





















References
Andrews, S. & Wang, W. W., 2024. What is Azure Cosmos DB for Table?. [Online] 
Available at: https://learn.microsoft.com/en-us/azure/cosmos-db/table/introduction
[Accessed 7 November 2024].
C#!, T. -., 2023. CREATE and CONNECT DATABASES in ASP.NET, s.l.: Youtube.
ChatGpt, 2024. Help me fix my error in HomeController. [Online] 
Available at: https://chatgpt.com/c/6724dbab-c22c-8011-bb6a-0d7284921da
[Accessed 7 November 2024].
ChatGPT, 2024. is the tables i created in SQL Server Management Correct. [Online] 
Available at: https://chatgpt.com/c/671809b4-49e8-8011-991a-3af1438f12
[Accessed 7 Novemeber 2024].
Dubey, A. & Estabrook, N., 2022. What is Azure Blob storage?. [Online] 
Available at: https://learn.microsoft.com/en-us/azure/storage/blobs/storage-blobs-overview
[Accessed 7 November 2024].
Dubey, A. & Haas, S., 2022. What is Azure Table storage?. [Online] 
Available at: https://learn.microsoft.com/en-us/azure/storage/tables/table-storage-overview
[Accessed 7 November 2024].
Estabrook, N. & Dahan, U., 2023. What is Azure Queue Storage?. [Online] 
Available at: https://learn.microsoft.com/en-us/azure/storage/queues/storage-queues-introduction
[Accessed 7 November 2024].
Microsoft Ignite, n.d. App Service documentation. [Online] 
Available at: https://learn.microsoft.com/en-us/azure/app-service/
[Accessed 7 Novemeber 2024].
Microsoft Ignite, n.d. Azure Media Services documentation. [Online] 
Available at: https://learn.microsoft.com/en-us/azure/media-services/
[Accessed 7 November 2024].
Microsoft Ignite, n.d. Queries in Azure Cosmos DB for NoSQL. [Online] 
Available at: https://learn.microsoft.com/en-us/azure/cosmos-db/nosql/query/
[Accessed 7 November 2024].
MSFT, W. A. & (MSFT), M. T., 2024. Failover groups overview & best practices (Azure SQL Database). [Online] 
Available at: https://learn.microsoft.com/en-us/azure/azure-sql/database/failover-group-sql-db?view=azuresql
[Accessed 7 November 2024].
MSFT, W. A. & Furman, D., 2024. What is Azure SQL Database?. [Online] 
Available at: https://learn.microsoft.com/en-us/azure/azure-sql/database/sql-database-paas-overview?view=azuresql
[Accessed 7 November 2024].
Pelluru, S. & Glodha, S., 2024. What is Azure Service Bus?. [Online] 
Available at: https://learn.microsoft.com/en-us/azure/service-bus-messaging/service-bus-messaging-overview
[Accessed 7 November 2024].
Schaffer, E. & Tyson, 2024. What is Azure Kubernetes Service (AKS)?. [Online] 
Available at: https://learn.microsoft.com/en-us/azure/aks/what-is-aks
[Accessed 7 November 2024].
Skwiers-Koballa, D. & Ghanayem, M., 2024. Quickstart: Use .NET (C#) to query a database. [Online] 
Available at: https://learn.microsoft.com/en-us/azure/azure-sql/database/connect-query-dotnet-core?view=azuresql
[Accessed 7 November 2024].
w3schools, n.d. SQL CREATE TABLE Statement. [Online] 
Available at: https://www.w3schools.com/sql/sql_create_table.asp
[Accessed 7 November 2024].
w3schools, n.d. SQL DROP TABLE Statement. [Online] 
Available at: https://www.w3schools.com/sql/sql_drop_table.asp
[Accessed 7 November 2024].




