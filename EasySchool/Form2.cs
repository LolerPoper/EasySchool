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

        string ime, prezime, smjer;
        int dob, cbutton;
        double prosjek;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Smjer { get => smjer; set => smjer = value; }
        public int Dob { get => dob; set => dob = value; }
        public double Prosjek { get => prosjek; set => prosjek = value; }
        public int Cbutton { get => cbutton; set => cbutton = value; }

        private void RadioUcenik_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioUcenik.Checked == true) 
            {
                GroupUcenik.Visible= true;
            }

            if (RadioUcenik.Checked == false)
            {
                GroupUcenik.Visible = false;
            }
        }

        private void BtnUnos_Click(object sender, EventArgs e)
        {
            if(RadioUcenik.Checked == true)
            { 
                ime = TxtUIme.Text;
                prezime= TxtUPrez.Text;
                smjer = TxtSmjer.Text;
                dob = Convert.ToInt16(TxtUDob.Text);
                prosjek = Convert.ToDouble(TxtPros.Text);
                cbutton = 1;

                DialogResult upit = MessageBox.Show("Jeste li upisali točne podatke?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (upit)
                {
                    case DialogResult.Yes:
                        Close();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }
    }
}
