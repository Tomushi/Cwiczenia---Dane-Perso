using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia___Dane_Perso
{
    internal class WeaponsProch
    {
        public void Proch()
        {
            Console.WriteLine("Wybierz bron, podaj numer:");
            Console.WriteLine("1. Muszkiet");
            Console.WriteLine("2. Karabin");
            Console.WriteLine("3. Pistolet");
            Console.WriteLine("4. Rewolwer");
            Console.WriteLine("5. Strzelba");
            Console.WriteLine("6. Granatnik");
            Console.WriteLine("7. Minigun");
            Console.WriteLine("8. Bazooka");
            Console.WriteLine("9. Karabin snajperski");

            string choice = Console.ReadLine();
            DisplayChoice(choice);
        }

        private void DisplayChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Muszkiet");
                    break;
                case "2":
                    Console.WriteLine("Karabin");
                    break;
                case "3":
                    Console.WriteLine("Pistolet");
                    break;
                case "4":
                    Console.WriteLine("Rewolwer");
                    break;
                case "5":
                    Console.WriteLine("Strzelba");
                    break;
                case "6":
                    Console.WriteLine("Granatnik");
                    break;
                case "7":
                    Console.WriteLine("Minigun");
                    break;
                case "8":
                    Console.WriteLine("Bazooka");
                    break;
                case "9":
                    Console.WriteLine("Karabin snajperski");
                    break;
                default:
                    Console.WriteLine("Nie ma takiej broni");
                    break;
            }
        }
    }
}
