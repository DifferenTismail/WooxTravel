using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace Project2WooxTravel.Models.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        [StringLength(100)]
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}