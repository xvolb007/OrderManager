using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager
{
    public static class Databaze
    {
        //list polozky kam budeme ukladat objekty
        public static BindingList<Item> Items { get; private set; } =
        new BindingList<Item>();
        




        static Databaze()
        {
            //inicializace objektu
            Items.Add(new MainCourse("Svickova", 200, 3000));
            Items.Add(new MainCourse("Krkovice", 180, 3200));
            Items.Add(new MainCourse("Gulas", 175, 3100));
            Items.Add(new Drinks("Pepsi", 50, 0.33));
            
        }

    }
}
