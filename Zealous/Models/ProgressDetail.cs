using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zealous.Models
{
    public class ProgressDetail : EventTracking
    {
        public string EventName { get; set; }
        public string CustomerName { get; set; }
        public string OrganizerName { get; set; }
        public string SupplierName { get; set; }
    }
}