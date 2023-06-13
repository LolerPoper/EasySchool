using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySchool
{
    internal class Ucenik
    {
        string id , ime, prezime, email;
        int godina_registracije;

        public Ucenik(string id , string ime, string prezime, int godina_registracije, string email)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.godina_registracije = godina_registracije;
            this.email = email;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Id { get => id; set => id = value; }
        public int Godina_registracije { get => godina_registracije; set => godina_registracije = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            string ispis = this.id + "\t\t" + this.ime + "\t\t" + this.prezime + "\t\t" + this.godina_registracije + "\t\t\t" + this.email + "\r\n";

            return ispis;
        }
    }
}
