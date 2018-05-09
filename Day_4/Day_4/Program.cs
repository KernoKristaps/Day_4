using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {

            

            int mainigais2 = 6;
            mainigais2 = Convert.ToInt16("10");
            int a = 5 + mainigais2;
            Console.WriteLine(a);

            string mainigais = "pa labi";

            if (mainigais == "pa labi")
            {
                Console.WriteLine("vienads");
            }
            
            else
            {
                Console.WriteLine("nav vienads");
            }
            



            int mainigais3;
            Console.WriteLine();
            string cipars = Console.ReadLine();

            mainigais3 = Convert.ToInt16(cipars);


            if (mainigais3 < 5)
            {
                Console.WriteLine("#");
            }
            else
            {
                Console.WriteLine("##");
            }
            



            int mainigais4;
            Console.WriteLine();
            string sturis = Console.ReadLine();

            mainigais4 = Convert.ToInt16(sturis);


            if (mainigais4 == 3)
            {
                Console.WriteLine("trijsturis");
            }
            else
            {
                if (mainigais4 == 4)
                {
                    Console.WriteLine("cetrsturis");
                }
                else
                {
                    if (mainigais4 == 5)
                    {
                        Console.WriteLine("piecsturis");
                    }
                    else
                    {
                        Console.WriteLine("nesaprotu");
                    }

                }



            }

            switch (mainigais4)
            {
                case 7:
                    Console.WriteLine("septinsturis");
                    break;
                case 8:
                    Console.WriteLine("astonsturis");
                    break;
                default:
                    Console.WriteLine("ko gribi");
                    break;
            }

            int mainigais5;
            Console.WriteLine();
            string vards = Console.ReadLine();

            mainigais5 = Convert.ToInt16(vards);

            switch (mainigais5)
            {
                case 1:
                    Console.WriteLine("1$ george");
                    break;
                case 2:
                    Console.WriteLine("$2 thomas");
                    break;
                case 5:
                    Console.WriteLine("$5 abraham");
                    break;
                case 10:
                    Console.WriteLine("$10 alexander");
                    break;
                case 20:
                    Console.WriteLine("$20 andrew");
                    break;
                case 50:
                    Console.WriteLine("$50 ulysses");
                    break;
                case 100:
                    Console.WriteLine("$100 benjamin");
                    break;
                default:
                    Console.WriteLine("nesakrit");
                    break;

                    
            }
            Console.ReadLine();
        } 


    }   
    
    
}
