using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static void Main()
        {
            int dag = 29;
            int maand = 10;
            int jaar = 2018;
            Console.WriteLine("Op welke dag bent u geboren?: ");
            int dag1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welke maand bent u geboren? (nummer van de maand): ");
            int maand2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is uw geboortejaar?: ");
            int jaar2 = Convert.ToInt32(Console.ReadLine());
            int leeftijd = jaar - jaar2;
            if (dag1 > dag || maand2 > maand)
            {
                leeftijd = leeftijd - 1;
            }
            if (dag1 > 31)
            {
                Console.WriteLine("Voer een geldig dag in ");
                dag1 = Convert.ToInt32(Console.ReadLine());
            }
            if (maand2 > 12)
            {
                Console.WriteLine("Voer een geldige maand in");
                maand2 = Convert.ToInt32(Console.ReadLine());
            }
            if (maand2 == 2 && dag1 > 28)
            {
                Console.WriteLine("Voer een geldige dag in");
                maand2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Uw leeftijd is: " + leeftijd);
            Console.Read();
        }
    }
}
