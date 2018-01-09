using CAR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _60321_2_Severina.Models
{
    
    public class Cart
    {
       public List<CartItem> items { get; set; }
        public Cart()
        {
            items = new List<CartItem>();
        }
        public void AddItem(Car car)
        {
            var item = items.Find(i => i.Car.CarId == car.CarId);
            if (item == null)
            {
                items.Add(new CartItem { Car = car, Quantity = 1 });
            }
            else item.Quantity += 1;
        }
        public void RemoveItem(Car car)
        {
            var item = items.Find(i => i.Car.CarId == car.CarId);
            if (item.Quantity == 1) items.Remove(item);
            else item.Quantity -= 1;
        }
        public void Clear()
        {
            items.Clear();
        }
        public int GetTotal()
        {
            return items.Sum(i => i.Car.Price * i.Quantity);
        }
        public IEnumerable<CartItem> GetItems()
        {
            return items;
        }

    }
}