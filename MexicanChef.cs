using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    internal class MexicanChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("enchiladas are made");
        }
        public void MakeTacos()
        {
            Console.WriteLine("Tacos are made");
        }
    }
}
