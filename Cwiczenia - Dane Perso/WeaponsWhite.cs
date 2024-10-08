using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia___Dane_Perso
{
    internal class WeaponsWhite
    {
        public void White()
        {
            Console.WriteLine("Wybierz bron, podaj numer:");
            Console.WriteLine("1. Miecz");
            Console.WriteLine("2. Luk");
            Console.WriteLine("3. Topor");
            Console.WriteLine("4. Kusza");
            Console.WriteLine("5. Bagnet");
            Console.WriteLine("6. Maczuga");
            Console.WriteLine("7. Sztylet");
            Console.WriteLine("8. Katana");
        
            string choice = Console.ReadLine();
            DisplayChoice(choice);
        }
        private void DisplayChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Miecz");
                    break;
                case "2":
                    Console.WriteLine("Luk");
                    break;
                case "3":
                    Console.WriteLine("Topor");
                    break;
                case "4":
                    Console.WriteLine("Kusza");
                    break;
                case "5":
                    Console.WriteLine("Bagnet");
                    break;
                case "6":
                    Console.WriteLine("Maczuga");
                    break;
                case "7":
                    Console.WriteLine("Sztylet");
                    break;
                case "8":
                    Console.WriteLine("Katana");
                    break;
                default:
                    Console.WriteLine("Nie ma takiej broni");
                    break;
            }
        }

    }
}
