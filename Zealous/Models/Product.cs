using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zealous.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Not be empty")]
        [RegularExpression("\\d+", ErrorMessage = "Must be a number")]
        [Range(1000, 2000, ErrorMessage = "ID must be 1000 - 2000")]
        public int item_number { get; set; }

        [Required(ErrorMessage = "Not be empty")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Product names range from 5 to 100 characters")]
        public string item_name { get; set; }

        [Required(ErrorMessage = "Not be empty")]
        [Range(1.0, 900.0, ErrorMessage = "Price from 1 - 900 USD")]
        public double amount { get; set; }

        [Required(ErrorMessage = "Not be empty")]
        [RegularExpression("\\d+", ErrorMessage = "Must be a number")]
        [Range(1, 100, ErrorMessage = "The number must be between 1 - 100")]
        public int quantity { get; set; }
    }
}
