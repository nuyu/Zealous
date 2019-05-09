using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zealous.Models
{
    public enum EventStatus
    {
        Create,
        Pending,
        Approved,
        Wait
    }

    public static class EnumHelper
    {
        public static List<ValueTextView> GetEventStatusView()
        {
            return ((IEnumerable<EventStatus>)Enum.GetValues(typeof(EventStatus)))
                    .Select(c => new ValueTextView() { Value = (byte)c, Text = c.ToString() })
                    .ToList();
        }
    }

    public class ValueTextView
    {
        public int Value { get; set; }
        public string Text { get; set; }
    }
}