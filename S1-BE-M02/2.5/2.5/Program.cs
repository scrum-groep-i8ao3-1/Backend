using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int Prijs, Lak, Bekleding, Automaat, AutoPrijs, BTW;

            Console.WriteLine("Wat is u naam:");
            Console.ReadLine();
            Console.WriteLine("Wat is de de standaard prijs van uw auto");
            Prijs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("De standaard prijs van u auto is: " + Prijs);
            Console.ReadLine();

            Lak = Prijs / 100 * 5;
            Console.WriteLine("+ metallic lak: " + Lak);
            Console.ReadLine();

            Bekleding = Prijs / 100 * 5;
            Console.WriteLine("+ leren bekleding: " + Bekleding);
            Console.ReadLine();

            Automaat = 1000;
            Console.WriteLine("+ automaat: " + Automaat);
            Console.ReadLine();

            AutoPrijs = Prijs + Lak + Bekleding + Automaat;
            Console.WriteLine("De totaal prijs exclusief BTW is: " + AutoPrijs);
            Console.ReadLine();


            BTW = AutoPrijs / 100 * 121;
            Console.WriteLine("De totaal prijs inclusief BTW is: " + BTW);
            Console.ReadLine();
        }
    }
