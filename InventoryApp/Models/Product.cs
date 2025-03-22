using System;
using System.Collections.Generic; // Add this line

using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
        public decimal Price { get; set; }

        public DateTime DateOfPurchase { get; set; }

        [Required]
        public string SerialNumber { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Purchasing Price must be greater than zero.")]
        public decimal PurchasingPrice { get; set; }

        public string DepartmentIssuedTo { get; set; }
        public string PersonUsing { get; set; }
        public List<string> ActiveIPAddresses { get; set; }
        
        [Required]
        public string Status { get; set; }
    }
}
