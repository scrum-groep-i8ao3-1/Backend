using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //opdracht
            /*
             * •    Eerste getal plus tweede getal 

•    Eerste getal min tweede getal 

•    Tweede getal min eerste getal 

•    Eerste getal maal tweede getal 

•    Eerste getal gedeeld door tweede getal 

•    Tweede getal gedeeld door eerste getal 

•    Restant (modulo) van eerste getal gedeeld door tweede getal 

•    Restant (modulo) van tweede getal gedeeld door eerste getal 

 */
            Console.Write("getal 1 : ");
            double g1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("getal 2 : ");
            double g2 = Convert.ToDouble(Console.ReadLine());
            double a1 = g1 - g2;
            double a2 = g2 - g1;
            double a3 = g1 * g2;
            double a4 = g2 * g1;
            double a5 = g1 / g2;
            double a6 = g2 / g1;
            double a7 = g1 % g2;
            double a8 = g2 % g1;
            Console.Write(a1);
            Console.Read();
            Console.Write(a2);
            Console.Read();
            Console.Write(a3);
            Console.Read();
            Console.Write(a4);
            Console.Read();
            Console.Write(a5);
            Console.Read();
            Console.Write(a6);
            Console.Read();
            Console.Write(a7);
            Console.Read();
            Console.Write(a8);
            Console.Read();
            Console.Write("einde");
            Console.Read();
        }
    }
}