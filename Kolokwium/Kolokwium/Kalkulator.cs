using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Kalkulator
    {
        protected int Dodawanie(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error:"+e.Message);
                return -1;
            }
            
        }
        protected int Odejmowanie(int a, int b)
        {
            try
            {
                return a - b;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error:"+e.Message);
                return -1;
            }
        }
        protected int Mnozenie(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error:"+e.Message);
                return -1;
            }
        }
        protected int Dzielenie(int a, int b)
        {
            try
            {
                int wynik = a / b;
                return wynik;
            }
            catch (DivideByZeroException eDivide)
            {
                Console.WriteLine("Nie można dzielić przez 0 !\nError:" + eDivide.Message);
                return -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
                return -1;
            }
        }
    }
}
