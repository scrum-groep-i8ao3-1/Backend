using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("welke datum ben je geboren : ");
            string xe = Console.ReadLine();
            DateTime myVALUE = DateTime.Now;
            DateTime myBirthdate = DateTime.Parse(xe);
            TimeSpan myAGE = DateTime.Now.Subtract(myBirthdate);
            Double xee = Convert.ToDouble(myAGE.TotalHours.ToString());
            Double xeee = xee / 24;
            Double xeeee = xeee / 365;
            double xeeeee = Math.Truncate(xeeee);
            Console.Write(xeeeee);
            Console.ReadKey();
        }
    }
}
