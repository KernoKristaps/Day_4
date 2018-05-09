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
                            if (mainigais4 == 6)
                            {
                             Console.WriteLine("sesturis");
                            }
                            
                                
                                
                         }



                    }

                

            
               
               
                  
            }
            Console.ReadLine();
        } 


    }   
    
    
}
