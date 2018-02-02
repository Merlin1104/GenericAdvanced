using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdvanced
{
    class SpravcaAut <T> where T: Auto
    {
        public void PrehodMotor(T a1,T a2) //kebyze nedame T tak by sa dali prehodit nakladak s osobakom
                                            //ref tam nedavame lebo menime motory a nie cele auta
        {
            int tempVykonMotoru = a1.VykonMotoru;
            a1.VykonMotoru = a2.VykonMotoru;
            a2.VykonMotoru = tempVykonMotoru;
            
        }


    }
}
