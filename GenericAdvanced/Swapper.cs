using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdvanced
{
    class Swapper
    {
        public static void Swap<T>(ref T a, ref T b)    //ref je tam na to aby sa pridala referencia a nie hodnota  
                                                        // dava ref aby kazda premenna bola predana odkazom a to aby vnutrajsok funcie ovplyvnil povodne premenne
                                                        // bez ref zvlada nejake objekty ako classy a pod, ale nie hodnoty
        {
            T temp;
            temp = a;
            a = b;
            b = temp;

            
        }




    }
}
