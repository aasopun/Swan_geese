using Swan_geese.BaseClasses;
using Swan_geese.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese.SubClasses
{
    class Goose : Animal, IGoose
    {
        public Goose(string name, string type, string color, double weight_in_meters, double height_in_meters, int count_of_foots)
        :base(name, type, color, weight_in_meters, height_in_meters, count_of_foots) { }

        public void Fly()
        {
            Console.WriteLine("Летят гуси-лебеди дальше");
        }

        public void Not_see()
        {
            Console.WriteLine("Гуси-лебеди не увидали, пролетели мимо.");
        }

        public void Steal_child()
        {
            Console.WriteLine("Налетели гуси-лебеди, подхватили мальчика, унесли на крыльях.");
        }
    }
}
