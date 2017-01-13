using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace KolokwiumZadania5i6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 5");
            Student student1 = new Student("Artur", "Jakiś");
            Student student2 = new Student("Stefan", "Unknown");
            Student student3 = new Student("Joanna", "Asdasd");
            Student student4 = new Student("Jan", "Kowalski");
            Student student5 = new Student("Marek", "Zegarek");
            ArrayList aLista = new ArrayList();
            aLista.Add(student1);
            aLista.Add(student2);
            aLista.Add(student3);
            aLista.Add(student4);
            aLista.Add(student5);
            Console.WriteLine("\n\nZadanie 6");
            Punkt punkt = new Punkt();
            Console.Write(punkt.ToString());

            Console.ReadKey();
        }
    }
}
