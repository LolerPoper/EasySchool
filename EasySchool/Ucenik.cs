using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySchool
{
    internal class Ucenik
    {
        string ime, prezime, smjer;
        int dob;
        double prosjek;

        public Ucenik(string ime, string prezime, string smjer, int dob, double prosjek)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.smjer = smjer;
            this.dob = dob;
            this.prosjek = prosjek;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Smjer { get => smjer; set => smjer = value; }
        public int Dob { get => dob; set => dob = value; }
        public double Prosjek { get => prosjek; set => prosjek = value; }

        public override string ToString()
        {
            string ispis = "Ime: " + this.ime + "\r\nPrezime: " + this.prezime + "\r\nDob: " + this.dob + "\r\nSmjer: " + this.smjer + "\r\nProsjek: " + this.prosjek;

            return ispis;
        }
    }
}
