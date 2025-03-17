using System.Collections.Generic;
using InventoryApp.Models;

namespace InventoryApp.Controllers
{
    public class ProductController
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public void UpdateProduct(int id, Product updatedProduct)
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

        public void DeleteProduct(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }
}
