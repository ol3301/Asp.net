using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Party.Models
{
    public class GuestResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttent { get; set; }
    }
}