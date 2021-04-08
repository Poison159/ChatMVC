using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMVC.Models
{
    public class Order
    {
        public int Id { get; set; }
        //public int userId { get; set; }
        public string MealId { get; set; }
        public Meal Meal { get; set; }
        
        public string UserId { get; set; }
        public AppUser AppUser { get; set; }
        public Status Status { get; set; }
        public DateTime OrderTime { get; set; }

    }
}
