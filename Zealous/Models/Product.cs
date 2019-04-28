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
       

        [Key]
        public int Id { get; set; }

        public string Item_name { get; set; }
        public string product_id { get; set; }
        public string Product_des { get; set; }
      

 
        public decimal Amount { get; set; }


        public string Image { get; set; }


    }
}
