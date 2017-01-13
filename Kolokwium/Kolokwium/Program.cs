using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Program
    {
        static public string GetType(int a)
        { return "Pobrany został typ int"; }
        static public string GetType(string a)
        { return "Pobrany został typ string"; }
        static public string GetType(int a, string b)
        { return "Pobrany został: parametru pierwszego typ int, zaś parametru drugiego typ string "; }
        static public string GetType(bool a)
        { return "Pobrany został typ bool"; }
        static public string GetType(int a, int b, bool c)
        { return "Pobrany zostały typy: parametr pierwszy i drugi typu int, zaś trzeci typu bool"; }
        static void Main(string[] args)
        {
            //1a)
            Console.WriteLine("Zadanie 1");
            Samochod samochod1 = new Samochod();

            Console.WriteLine("Zadanie 2");
            Console.WriteLine(GetType(2));
            Console.WriteLine(GetType("Ala ma kota"));
            Console.WriteLine(GetType(242,"Kot ma Alę"));
            Console.WriteLine(GetType(true));
            Console.WriteLine(GetType(2,6,false));

            Console.WriteLine("Zadanie 4");
            List<Pracownik> listaPracownikow = new List<Pracownik>();
            listaPracownikow.Add(new Ksiegowa("Aneta", "Unknown", 3700));
            listaPracownikow.Add(new Pracownik("Jan", "Kowalski", 2800.85));
            listaPracownikow.Add(new Skrzypek("Franek", "Dolas", 1699.99));
            listaPracownikow.Add(new Sprzedawca("Monika", "Zdun", 2100));

            foreach (var c in listaPracownikow)
            { 
                Console.WriteLine("Imię: " + c.Imie + " Nazwisko: " + c.Nazwisko);
                c.Pracuj();
            }
            Console.ReadKey();
        }
    }
}
