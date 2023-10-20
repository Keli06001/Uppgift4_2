using System;
using System.ComponentModel.Design;

namespace uppgift4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int högstaTal = 0;

           while (true)
            {
                Console.WriteLine("Skriv in ett heltal");
                Console.WriteLine("Du kan skriva stopp när som helst för att få reda på vilket ditt högsta tal var");
                string svar = Console.ReadLine();
                if(svar == "stopp")
                {
                    break;                
                }else
                {
                    int heltal = int.Parse(svar);

                    if (heltal > högstaTal)
                    {
                        högstaTal = heltal;
                    }

                }
            }

            Console.WriteLine("Ditt högsta tal var " + högstaTal);
        }
    }
}