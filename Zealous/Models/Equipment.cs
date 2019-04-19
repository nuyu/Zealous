using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zealous.Models
{
    public class Add
    {
        public String name { set;get;}
        public int item { set; get; }
    }
    public class Book
    {
        public String name { set; get; }
        public String date { set; get; }
        public int item { set; get; }
    }
    public class Del
    {
        public String name { set; get; }
    }
    public class Upd
    {
        public String name { set; get; }
        public int item { set; get; }
    }
}
