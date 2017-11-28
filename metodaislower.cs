using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Wpisz jakiekolwiek 2znaki: ");
            string wyraz = Console.ReadLine();
            if (wyraz.Length > 2)
            {
                Console.WriteLine("Miałeś wpisać 2znaki");
                Console.ReadKey();
                Main();
            }
            int i;
            for (i = 0; i < wyraz.Length; i++)
            {
                Console.Write(wyraz[i] + " ");
                if (Char.IsLower(wyraz[i]))
                {
                    Console.WriteLine("jest mała");
                }
                if (Char.IsUpper(wyraz[i]))
                {
                    Console.WriteLine("jest wielka");

                }
                else
                {
                    Console.WriteLine("Nie jest literą");
                }
                Console.ReadLine();
            }
        }
    }
}
