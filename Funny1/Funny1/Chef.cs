﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funny1
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef make chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes BBQ ribs");
        }
    }
}
