using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beepsonc
{
    public class BeepConstant
    {
        public void BeepConstantSound(int freq , int temp){
            while(true){
                Console.Beep(freq,temp);
            }

        }
    }
}