using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beepsonc
{
    public class BeepTime
    {
        public  int BeepTimer(){
            Console.WriteLine("Quanto deseja que seja o tempo Multiplicador?");
            int temp = Convert.ToInt32(Console.ReadLine());
            return temp;
        }
        
    }
}