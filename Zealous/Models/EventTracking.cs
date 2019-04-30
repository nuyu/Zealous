using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zealous.Models
{
    public class EventTracking
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int CustomerId { get; set; }
        public int OrganizerId { get; set; }
        public int SupplierId { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public byte EventStatus { get; set; }
    }
}