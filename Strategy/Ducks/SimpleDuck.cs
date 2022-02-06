using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    internal class SimpleDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("Hi! I'm a simple duck.");
        }
    }
}
