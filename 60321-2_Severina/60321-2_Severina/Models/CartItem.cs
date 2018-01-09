using CAR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _60321_2_Severina.Models
{
    public class CartItem
    {
        public Car Car { get; set; }
        public int Quantity { get; set; }
    }
}