using Cwiczenia___Dane_Perso;
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
            string imie = Console.ReadLine();

            Console.WriteLine("Podaj swoje nazwisko");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj swoj pseudonim");
            string pseudonim = Console.ReadLine();

            Console.WriteLine("Jaki masz czas na 100-tke?");
    
            if (double.TryParse(Console.ReadLine(), out double czas))

            {
                Console.WriteLine("Twoj czas na 100-tke to: " + czas);
            }
            else
            {
                Console.WriteLine("Podales zly czas");
            }

            Console.WriteLine("Ile wyciskasz na lawce?");
            int waga = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jaki masz rozmiar buta?");
            double rozmiar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Jakie sztuki walki potrafisz?");
            string sztuki = Console.ReadLine();

            Console.WriteLine("Jakiego rodzaju broni uzywasz? Biala czy Prochowa");
            string bron = Console.ReadLine() ?? string.Empty;
                        
            if (bron == "Biala")
            {
                Console.WriteLine("Jakiej broni bialej uzywasz?");
                string bronBiala = Console.ReadLine() ?? string.Empty;
            }

            else if (bron == "Prochowa")
            {
                Console.WriteLine("Jakiej broni prochowej uzywasz?");
                string bronProchowa = Console.ReadLine() ?? string.Empty;
            }
            else
            {
                Console.WriteLine("Nie podales rodzaju broni");
            }
        }
    }
}