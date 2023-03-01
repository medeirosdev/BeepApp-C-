using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beepsonc
{
    public class BeepMenu
    {

        BeepRun beeprun = new BeepRun();
        public static void Main(String[] args){
            Console.WriteLine("=======================================");
			Console.WriteLine("Beep: O programa que bipa!");
			Console.WriteLine("=======================================\n");
			Console.WriteLine("Escolha o modo do programa:");
			Console.WriteLine("---------------------------");
			Console.WriteLine("(1) Modo Toque - Bipa quando tecla for pressionada");
			Console.WriteLine("(2) Modo Constante - Bipa constantemente até o programa ser fechado");
			Console.WriteLine("(3) Modo Teclado - Cada tecla bipa com diferentes frequências\n");

            int anwser = Convert.ToInt32(Console.ReadLine());
            BeepFreq BF = new BeepFreq();
            BeepTime BT = new BeepTime();
            BeepRun BR = new BeepRun();
            BeepConstant BC = new BeepConstant();
            BeepPressConstant BPC = new BeepPressConstant();
            int freq = BF.BeepFrequence();
            int dum = BT.BeepTimer();
            switch(anwser){
                case 3:
                    
                    BR.BeepRunChoose(freq , dum);
                    break;
                case 1:
                   
                    BC.BeepConstantSound(freq , dum);

                    break;
                case 2:
                    
                    BPC.BeepPSSound(freq , dum);

                    break;                

                default:
                    break;
                    
            }
        }
        
    }
}