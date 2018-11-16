using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Wat is uw gewicht?: ");
            float gewicht = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wat is uw lengte?: ");
            float lengte = Convert.ToInt32(Console.ReadLine());
            float BMI = gewicht / (lengte * lengte) * 10000;
            Console.Write("Uw BMI is " + BMI);
            Console.Read();
        }
    }
}