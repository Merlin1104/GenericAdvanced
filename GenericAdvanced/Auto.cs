using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdvanced
{
    abstract class Auto
    {
        public int VykonMotoru { get; set; }

        public void VypisVykon()
        {
            Console.WriteLine("Vykon je: {0}", VykonMotoru);
        }
    }
}
