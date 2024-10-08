using Cwiczenia_Dane_Perso;
using System;
namespace Cwiczenia_Dane_Perso
{ 
    class Program
    { 
        static void Main(string[] args)
        {
            WeaponsProch prochowaBron = new WeaponsProch();
            WeaponsWhite bialaBron = new WeaponsWhite();

            Console.WriteLine("Witaj w bazie zarzadzania danymi");
        
            Console.WriteLine("Podaj swoje imie");
            string imie = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Podaj swoje nazwisko");
            string nazwisko = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Podaj swoj pseudonim");
            string pseudonim = Console.ReadLine() ?? string.Empty;



            double czas;

            while (true)

            {
                Console.WriteLine("Jaki masz czas na 100-tke? Podaj liczbe z przecinkiem a nie z kropka.");

                if (double.TryParse(Console.ReadLine(), out czas))
                {
                    Console.WriteLine("Twoj czas na 100-tke to: " + czas);
                    break;
                }
                else
                {
                    Console.WriteLine("Podales zly czas. Sprobuj ponownie.");
                }
            }

            Console.WriteLine("Ile wyciskasz na lawce?");
            int waga = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jaki masz rozmiar buta?");
            double rozmiar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Jakie sztuki walki potrafisz?");
            string sztuki = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Jakiego rodzaju broni uzywasz? Wybierz \"B\" dla Biala lub \"P\" dla Prochowa");
            string bron = Console.ReadLine() ?? string.Empty;
                        
            if (bron == "B")
            {
                bialaBron.DisplayWeapons();
            
            }

            else if (bron == "P")
            {
                prochowaBron.DisplayWeapons();
            }
            else
            {
                Console.WriteLine("Nie podales rodzaju broni");
            }

            Console.WriteLine("Dziękujemy za dostarczanie informacji dla tajnej organizacji kontrolującej świat. ;)");
        }
    }
}