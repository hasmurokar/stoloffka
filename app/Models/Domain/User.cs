﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models.Domain
{
    public class User
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? FathersName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string? ImageUrl { get; set; }
        public RoleEnum Role { get; set; }
        public List<Order> ClientOrders { get; set; } = new();
        public List<Order> ChefOrders { get; set; } = new();

    }
}
