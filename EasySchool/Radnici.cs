using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySchool
{
    internal class Radnici
    {
        public string id, ime, prezime, email;

        public string Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }

    }

    internal class Stalni : Radnici
    {
        double placa;
        bool osiguranje;

        public double Placa{ get => placa; set => placa = value; }
        public bool Osiguranje { get => osiguranje; set => osiguranje = value; }

        public Stalni(double placa, bool osiguranje, string id, string ime, string prezime, string email)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.placa = placa;
            this.osiguranje = osiguranje;
        }

        public override string ToString()
        {
            string ispis = this.id + "\t\t" + this.ime + "\t\t" + this.prezime + "\t\t" + this.email + "\t\t" + this.placa + " €" + "\t\t" + this.osiguranje + "\r\n";

            return ispis;
        }
    }

    internal class Part : Radnici
    {
        double satnica;

        public double Satnica { get => satnica; set => satnica = value; }

        public Part(double satnica, string id, string ime, string prezime, string email)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.satnica = satnica;
        }

        public override string ToString()
        {
            string ispis = this.id + "\t\t" + this.ime + "\t\t" + this.prezime + "\t\t" + this.email + "\t\t" + this.satnica + " €" + "\r\n";

            return ispis;
        }

    }
}
