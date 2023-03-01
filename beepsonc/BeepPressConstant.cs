using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beepsonc
{
    public class BeepPressConstant
    {
        public void BeepPSSound(int freq, int temp){
            Console.WriteLine("Pressione X ou CTRL + C para sair...\n");

			ConsoleKeyInfo keyinfo;
			do
			{
				keyinfo = Console.ReadKey();
				Console.Beep(freq,temp);
				Console.Write("\r");
			}
			while (keyinfo.Key != ConsoleKey.X);

        }
    }
}