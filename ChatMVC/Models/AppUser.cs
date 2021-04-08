using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMVC.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser() {
            PrevOrders = new List<Order>();
        }
        public virtual List<Order> PrevOrders { get; set; }
    }
}
