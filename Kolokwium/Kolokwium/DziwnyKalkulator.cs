using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class DziwnyKalkulator:Kalkulator
    {
        protected int DodawanieModulo26(int a)
        {
            try
            {
                return a % 26;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error:"+e.Message);
                return -1;
            }
        }
        protected int PotrojneDodawanie(int a, int b, int c)
        {
            try
            {
                return Dodawanie(Dodawanie(a, b), c);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error:"+e.Message);
                return -1;
            }
        }
        protected double Pierwiastkowanie(int a)
        {
            try
            {
                return Math.Sqrt(a);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error:"+e.Message);
                return -1;
            }
        }
    }
}
