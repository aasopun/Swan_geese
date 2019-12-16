using Swan_geese.BaseClasses;
using Swan_geese.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese.SubClasses
{
    class GrandParent : Human, IGrandParent
    {
        public GrandParent(string name, string gender, int age) : base(name, gender, age) { }

        public void Ask_girl(GrandParent grandParent)
        {
            Console.WriteLine(grandParent.Name + " спрашивает:\n-Девица, прядешь ли?");
        }

        public void Come_to_hut(GrandParent grandParent)
        {
            Console.WriteLine(grandParent.Name + " баню вытопила и пошла за девочкой. А в избушке нет никого. Баба-яга закричала:\n -Гуси-лебеди! Летите в погоню! Сестра братца унесла!");
        }

        public void Give_spin(GrandParent grandParent)
        {
            Console.WriteLine(grandParent.Name + " дала ей веретено, а сама ушла.");
        }
    }
}
