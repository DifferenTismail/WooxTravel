﻿using Project2WooxTravel.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project2WooxTravel.Context
{
    public class TravelContext: DbContext
    {
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations{ get; set; }
    }
}