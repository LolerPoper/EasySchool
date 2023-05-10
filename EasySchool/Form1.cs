﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasySchool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if(form2.ShowDialog() == DialogResult.OK) 
            {
                if(form2.Cbutton == 1)
                {
                    List<Ucenik> list = new List<Ucenik>();

                    Ucenik ucenik = new Ucenik(form2.Ime, form2.Prezime, form2.Smjer, form2.Dob, form2.Prosjek);

                    foreach (Ucenik u in list) 
                    {
                        TxtBox.AppendText(u.ToString());
                    }
                }
            }
        }
    }
}
