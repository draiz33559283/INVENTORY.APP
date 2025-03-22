using System.Collections.Generic; // Ensure this is included
using System.Linq; // Add this line for LINQ methods
using InventoryApp.Models;
using InventoryApp.Data; // Ensure this is included

namespace InventoryApp.Controllers
{
public class ProductController : ControllerBase

    {
        private readonly AppDbContext _context; // Declare the context
        private List<Product> products; // Declare products list

        // Constructor accepting AppDbContext
        public ProductController(AppDbContext context)
        {
            _context = context; // Initialize the context
            products = _context.Products.ToList(); // Load products from the database
        }

[HttpPost]
public IActionResult AddProduct(Product product)

        {
            products.Add(product);
        }

[HttpGet]
public IActionResult GetAllProducts()

        {
            return products;
        }

[HttpPut("{id}")]
public IActionResult UpdateProduct(int id, Product updatedProduct)

        {
            var product = products.Find(p => p.Id == id);
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.Quantity = updatedProduct.Quantity;
                product.Price = updatedProduct.Price;
                product.DateOfPurchase = updatedProduct.DateOfPurchase;
                product.SerialNumber = updatedProduct.SerialNumber;
                product.PurchasingPrice = updatedProduct.PurchasingPrice;
                product.DepartmentIssuedTo = updatedProduct.DepartmentIssuedTo;
                product.PersonUsing = updatedProduct.PersonUsing;
                product.ActiveIPAddresses = updatedProduct.ActiveIPAddresses;
                product.Status = updatedProduct.Status;
            }
        }

[HttpDelete("{id}")]
public IActionResult DeleteProduct(int id)

        {
            var product = _context.Products.Find(id);

            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();

            }
        }
    }
}
