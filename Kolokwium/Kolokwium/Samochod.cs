using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Samochod
    {
        private float pojemnoscSilnika;
        private string nrVIN;
        public int rocznik;
        public string nazwa;
        public float srednieSpalanie;
        public enum typTrasy {Typ1,Typ2,Typ3} //nie można dodać do enum wartości typu float i double
        public Samochod Create(float pojemnoscSilnika, string nrVIN, int rocznik, string nazwa,float srednieSpalanie)
        {
            Samochod temp = new Samochod(pojemnoscSilnika, nrVIN, rocznik, nazwa,srednieSpalanie);
            return temp;
        }
        public float ObliczSpalanie(float dlugoscTrasy, typTrasy typ)
        {
            if (typ == typTrasy.Typ1)
                return this.srednieSpalanie * dlugoscTrasy * 0.8f;
            else if (typ == typTrasy.Typ2)
                return this.srednieSpalanie * dlugoscTrasy * 1f;
            else
                return this.srednieSpalanie * dlugoscTrasy * 1.3f;
        }
        //konstruktor własny trzeba zmienić z private na public ponieważ nie można utworzyć instancji tej klasy
        //private Samochod(float pojemnoscSilnika, string nrVIN, int rocznik, string nazwa, float srednieSpalanie)
        //{
        //    this.pojemnoscSilnika = pojemnoscSilnika;
        //    this.nrVIN = nrVIN;
        //    this.rocznik = rocznik;
        //    this.nazwa = nazwa;
        //    this.srednieSpalanie = srednieSpalanie;
        //}
        public Samochod(float pojemnoscSilnika, string nrVIN, int rocznik, string nazwa,float srednieSpalanie)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.nrVIN = nrVIN;
            this.rocznik = rocznik;
            this.nazwa = nazwa;
            this.srednieSpalanie = srednieSpalanie;
        }
        public Samochod()
        {

        }
    }
}
