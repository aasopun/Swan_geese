using Swan_geese.SubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese.Interfaces
{
    interface IGrandParent
    {
        void Give_spin(GrandParent grandParent);
        void Ask_girl(GrandParent grandParent);
        void Come_to_hut(GrandParent grandParent);
    }
}
