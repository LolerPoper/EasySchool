using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasySchool
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string id , ime, prezime, email;
        int godina_registracije, cbutton;
        double placa, satnica;
        bool osiguranje, stalni;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int Cbutton { get => cbutton; set => cbutton = value; }
        public string Id { get => id; set => id = value; }
        public int Godina_registracije { get => godina_registracije; set => godina_registracije = value; }
        public string Email { get => email; set => email = value; }
        public double Placa { get => placa; set => placa = value; }
        public double Satnica { get => satnica; set => satnica = value; }
        public bool Osiguranje { get => osiguranje; set => osiguranje = value; }
        public bool Stalni { get => stalni; set => stalni = value; }

        private void CheckStalni_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckStalni.Checked == true)
            {
                LblPla.Visible = true;
                LblOsig.Visible = true;
                TxtPla.Visible = true;
                CheckOsig.Visible = true;
                LblSatnica.Visible = false;
                TxtSatnica.Visible = false;
            }
            else
            {
                LblPla.Visible = false;
                LblOsig.Visible = false;
                TxtPla.Visible = false;
                CheckOsig.Visible = false;
                LblSatnica.Visible = true;
                TxtSatnica.Visible = true;
            }
        }

        private void RadioUcenik_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioUcenik.Checked == true)
            {
                GroupUcenik.Visible = true;
            }
            else
            {
                GroupUcenik.Visible = false;
            }
        }
        private void RadioRadnik_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioRadnik.Checked == true)
            {
                GroupRadnik.Visible = true;
                CheckStalni.Visible = true;
            }
            else
            {
                GroupRadnik.Visible = false;
                CheckStalni.Visible = false;
            }
        }

        private void BtnUnos_Click(object sender, EventArgs e)
        {
            if(RadioUcenik.Checked == true)
            {
                id = TxtUID.Text;
                ime = TxtUIme.Text;
                prezime = TxtUPrez.Text;
                godina_registracije = Convert.ToInt16(TxtGodReg.Text);
                email = TxtUEmail.Text;
                cbutton = 0;

                DialogResult upit = MessageBox.Show("Jeste li upisali točne podatke?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (upit)
                {
                    case DialogResult.Yes:
                        DialogResult = DialogResult.OK;
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            if (RadioRadnik.Checked == true)
            {
                id = TxtRID.Text;
                ime = TxtRIme.Text;
                prezime = TxtRPrez.Text;
                email = TxtREmail.Text;
                cbutton = 1;

                if (CheckStalni.Checked == true)
                {
                    placa = Convert.ToDouble(TxtPla.Text);
                    osiguranje = Convert.ToBoolean(CheckOsig.CheckState);
                    stalni = true;
                }
                else
                {
                    satnica = Convert.ToDouble(TxtSatnica.Text);
                    stalni = false;
                }

                DialogResult upit = MessageBox.Show("Jeste li upisali točne podatke?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (upit)
                {
                    case DialogResult.Yes:
                        DialogResult = DialogResult.OK;
                        break;
                    case DialogResult.No:
                        break;
                }

            }
        }
    }
}
