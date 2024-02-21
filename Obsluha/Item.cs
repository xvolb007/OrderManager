using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OrderManager
{
    //class items for adding to List
    public abstract class Item
    {
        public string Name { get; set; }
        public int Price { get; private set; }
        public Item(string name, int price)
        {
            Name = name;
            Price = price;
        }
        
    }

    public class MainCourse : Item
    {
        public int Calories { get; private set; }
        public MainCourse(string name, int price, int calories) : base(name, price)
        {
            Calories = calories;
        }
    }
    public class Drinks : Item
    {
        public double Volume { get; private set; }
        public Drinks(string name, int price, double volume) : base(name, price)
        {
            Volume = volume;
        }
    }
}
    
