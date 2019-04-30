using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zealous.Models
{
    [NotMapped]
    public class ProgressDetail : EventTracking
    {
        [NotMapped]
        public string EventName { get; set; }
        [NotMapped]
        public string CustomerName { get; set; }
        [NotMapped]
        public string OrganizerName { get; set; }
        [NotMapped]
        public string SupplierName { get; set; }
    }
}