using System;
using System.Collections.Generic;
using System.Text;

namespace Vipikayko.DomainModel.Models
{
    public class Food
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public double Calories { get; set; }

    }
}
