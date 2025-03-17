using System;
using System.Collections.Generic;

namespace InventoryApp.Models
{
    public class Product
    {
        public DateTime DateOfPurchase { get; set; }
        public string SerialNumber { get; set; }
        public decimal PurchasingPrice { get; set; }
        public string DepartmentIssuedTo { get; set; }
        public string PersonUsing { get; set; }
        public List<string> ActiveIPAddresses { get; set; }
        public string Status { get; set; }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
