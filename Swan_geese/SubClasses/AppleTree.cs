using Swan_geese.BaseClasses;
using Swan_geese.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese.SubClasses
{
    class AppleTree : Tree, IAppleTree
    {
        public AppleTree(string name, string type, int height_in_meters) : base(name, type, height_in_meters) { }

        public void Eat_my_apple()
        {
            Console.WriteLine("-Поешь моего лесного яблочка — скажу.");
        }

        public void Go_out_child()
        {
            Console.WriteLine("Яблоня не сказала. Побежала девочка дальше.");
        }

        public void Keep_staying()
        {
            Console.WriteLine("Стоит яблоня");
        }

        public void Save_children()
        {
            Console.WriteLine("Яблоня заслонила ветвями, прикрыла листами.");
        }
    }
}
