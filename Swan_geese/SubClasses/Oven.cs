using Swan_geese.BaseClasses;
using Swan_geese.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese.SubClasses
{
    class Oven : Building, IOven
    {
        public Oven(string name, string type) : base(name, type) { }

        public void Eat_my_cake()
        {
            Console.WriteLine("-Поешь моего ржаного пирожка.");
        }

        public void Go_out_child()
        {
            Console.WriteLine("Не сказала печка.");
        }

        public void Keep_staying()
        {
            Console.WriteLine("Стоит печь");
        }

        public void Save_children()
        {
            Console.WriteLine("Спрятала печка деток в устьице");
        }
    }
}