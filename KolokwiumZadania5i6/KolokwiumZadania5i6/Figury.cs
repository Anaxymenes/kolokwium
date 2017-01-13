using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumZadania5i6
{
    class Figury:IFigurable,ICloneable
    {
        protected string name;
        public string Name { get { return this.name; } set { this.name = value; } }

        public Object Clone()
        {
            return MemberwiseClone();
        }

        virtual public void LiczObwod()
        {
            throw new NotImplementedException();
        }

        virtual public void PobierzDaneZKlawiatury()
        {
            throw new NotImplementedException();
        }

        virtual public string Wyswietl()
        {
            return "";
        }
        public override string ToString()
        {
            Console.Clear();
            return Wyswietl();
        }
    }
}
