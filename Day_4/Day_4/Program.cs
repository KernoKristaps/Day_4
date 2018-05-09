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
            Console.ReadLine();
        } 
    }   
    
    
}
