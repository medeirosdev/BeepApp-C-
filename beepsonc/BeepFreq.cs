using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beepsonc
{
    public class BeepFreq
    {
        public int BeepFrequence(){
            Console.WriteLine("Quanto deseja que seja a Frequência Multiplicadora?");
            int freq = Convert.ToInt32(Console.ReadLine());
            return freq;

        }
    }
}