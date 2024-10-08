using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2WooxTravel.Models.Entities
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address{ get; set; }
        public string MapLocation{ get; set; }
    }
}