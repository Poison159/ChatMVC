using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMVC.Models
{
    public class Meal
    {
        public int Id { get; set; }
        //public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public double Price { get; set; }
        public string imgPath { get; set; }
    }
}
