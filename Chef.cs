using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    internal class Chef
    {
        public void MakeChicken()
        {
          Console.WriteLine("chicken is made");
        }
        public void MakeSalad()
        {
            Console.WriteLine("salad is made");
        }
        public void MakePizza()
        {
            Console.WriteLine("pizza is made");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("bbq ribs are made");
        }
    }
}
