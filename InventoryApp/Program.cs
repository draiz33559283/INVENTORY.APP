using System;
using InventoryApp.Controllers;
using InventoryApp.Models;


namespace InventoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductController productController = new ProductController();
            Console.WriteLine("Welcome to the Inventory Management System!");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Exit");

            while (true)
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        // Add Product
                        Product newProduct = new Product();
                        Console.Write("Enter Product ID: ");
                        newProduct.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter Product Type (CPU, Monitor, Laptop, Router, Switch, UPS, Printer, Scanner): ");
            string productType = Console.ReadLine();
            Console.Write("Enter Product Name: ");

                        newProduct.Name = productType + " - " + Console.ReadLine();

                        Console.Write("Enter Quantity: ");
                        newProduct.Quantity = int.Parse(Console.ReadLine());
                        Console.Write("Enter Price: ");
                        newProduct.Price = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter Date of Purchase: ");
                        newProduct.DateOfPurchase = DateTime.Parse(Console.ReadLine());
                        Console.Write("Enter Serial Number: ");
                        newProduct.SerialNumber = Console.ReadLine();
                        Console.Write("Enter Purchasing Price: ");
                        newProduct.PurchasingPrice = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter Department Issued To: ");
                        newProduct.DepartmentIssuedTo = Console.ReadLine();
                        Console.Write("Enter Person Using: ");
                        newProduct.PersonUsing = Console.ReadLine();
                        newProduct.ActiveIPAddresses = new List<string>(); // Add logic to input IP addresses
                        Console.Write("Enter Status (Faulty/Good): ");
                        newProduct.Status = Console.ReadLine();
                        productController.AddProduct(newProduct);
                        break;

                    case "2":
                        // View Products
                        var products = productController.GetAllProducts();
                        Console.WriteLine("Current Products:");
                        foreach (var product in products)
                        {
                            Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Quantity: {product.Quantity}, Price: {product.Price}, Status: {product.Status}");
                        }
                        break;

                    case "3":
                    case "3":
                        // Update Product
                        Console.Write("Enter Product ID to update: ");
                        int updateId = int.Parse(Console.ReadLine());
                        var productToUpdate = productController.GetAllProducts().Find(p => p.Id == updateId);
                        if (productToUpdate != null)
                        {
                            Console.Write("Enter new Product Name (leave blank to keep current): ");
                            string newName = Console.ReadLine();
                            if (!string.IsNullOrEmpty(newName)) productToUpdate.Name = newName;

                            Console.Write("Enter new Quantity (leave blank to keep current): ");
                            string newQuantity = Console.ReadLine();
                            if (int.TryParse(newQuantity, out int quantity)) productToUpdate.Quantity = quantity;

                            Console.Write("Enter new Price (leave blank to keep current): ");
                            string newPrice = Console.ReadLine();
                            if (decimal.TryParse(newPrice, out decimal price)) productToUpdate.Price = price;

                            Console.Write("Enter new Date of Purchase (leave blank to keep current): ");
                            string newDate = Console.ReadLine();
                            if (DateTime.TryParse(newDate, out DateTime date)) productToUpdate.DateOfPurchase = date;

                            Console.Write("Enter new Serial Number (leave blank to keep current): ");
                            string newSerial = Console.ReadLine();
                            if (!string.IsNullOrEmpty(newSerial)) productToUpdate.SerialNumber = newSerial;

                            Console.Write("Enter new Purchasing Price (leave blank to keep current): ");
                            string newPurchasingPrice = Console.ReadLine();
                            if (decimal.TryParse(newPurchasingPrice, out decimal purchasingPrice)) productToUpdate.PurchasingPrice = purchasingPrice;

                            Console.Write("Enter new Department Issued To (leave blank to keep current): ");
                            string newDepartment = Console.ReadLine();
                            if (!string.IsNullOrEmpty(newDepartment)) productToUpdate.DepartmentIssuedTo = newDepartment;

                            Console.Write("Enter new Person Using (leave blank to keep current): ");
                            string newPersonUsing = Console.ReadLine();
                            if (!string.IsNullOrEmpty(newPersonUsing)) productToUpdate.PersonUsing = newPersonUsing;

                            Console.Write("Enter new Status (leave blank to keep current): ");
                            string newStatus = Console.ReadLine();
                            if (!string.IsNullOrEmpty(newStatus)) productToUpdate.Status = newStatus;

                            Console.WriteLine("Product updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Product not found.");
                        }

                        break;

                    case "4":
                    case "4":
                        // Delete Product
                        Console.Write("Enter Product ID to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        productController.DeleteProduct(deleteId);
                        Console.WriteLine("Product deleted successfully.");

                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }


        }
    }
}
</create_file>
