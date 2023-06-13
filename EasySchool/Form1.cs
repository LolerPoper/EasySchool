using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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

        List<Ucenik> listUcenik = new List<Ucenik>();
        List<Stalni> listStalni = new List<Stalni>();
        List<Part> listPart = new List<Part> ();
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if(form2.ShowDialog() == DialogResult.OK) 
            {
                if(form2.Cbutton == 0)
                {

                    Ucenik ucenik = new Ucenik(form2.Id , form2.Ime, form2.Prezime, form2.Godina_registracije, form2.Email);
                    listUcenik.Add(ucenik);
                }
                if (form2.Cbutton == 1 && form2.Stalni == true)
                {

                    Stalni stalni = new Stalni(form2.Placa, form2.Osiguranje, form2.Id, form2.Ime, form2.Prezime, form2.Email);
                    listStalni.Add(stalni);
                }
                if (form2.Cbutton == 1 && form2.Stalni == false)
                {

                    Part part = new Part(form2.Satnica, form2.Id, form2.Ime, form2.Prezime, form2.Email);
                    listPart.Add(part);
                }
            }
        }

        private void BtnIspis_Click(object sender, EventArgs e)
        {
            TxtBox.Clear();

            if (CmbEntitet.SelectedIndex == 0) 
            {
                TxtBox.AppendText("ID:\t\tIme:\t\tPrezime:\t\tGodina Registracije:\t\tEmail:\r\n");

                foreach(Ucenik u in listUcenik)
                {
                    TxtBox.AppendText(u.ToString());
                }
            }

            if (CmbEntitet.SelectedIndex == 1)
            {
                TxtBox.AppendText("ID:\t\tIme:\t\tPrezime:\t\tEmail\t\tPlaća:\t\tOsiguranje:\r\n");

                foreach (Stalni s in listStalni)
                {
                    TxtBox.AppendText(s.ToString());
                }
            }

            if (CmbEntitet.SelectedIndex == 2)
            {
                TxtBox.AppendText("ID:\t\tIme:\t\tPrezime:\t\tEmail\t\tSatnica:\r\n");

                foreach (Part p in listPart)
                {
                    TxtBox.AppendText(p.ToString());
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CmbEntitet.SelectedIndex == 0)
            {
                string filename = "";
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV File (*.csv)|*.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, String.Empty);
                    filename = saveFileDialog.FileName;
                }
                else
                {
                    return;
                }

                using (var writer = new StreamWriter(filename))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(listUcenik);
                }
            }
            if (CmbEntitet.SelectedIndex == 1)
            {
                string filename = "";
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV File (*.csv)|*.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, String.Empty);
                    filename = saveFileDialog.FileName;
                }
                else
                {
                    return;
                }

                using (var writer = new StreamWriter(filename))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(listStalni);
                }
            }
            if (CmbEntitet.SelectedIndex == 2)
            {
                string filename = "";
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV File (*.csv)|*.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, String.Empty);
                    filename = saveFileDialog.FileName;
                }
                else
                {
                    return;
                }

                using (var writer = new StreamWriter(filename))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(listPart);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (CmbEntitet.SelectedIndex == 0)
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV File (*.csv)|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string fileContent = reader.ReadToEnd();
                        string[] content = fileContent.Split(',');
                        int numb = 5;
                        while (content.Length >= numb + 5)
                        {
                            Ucenik LoadUcenik = new Ucenik(
                                content[numb].Substring(0, content[numb].Length),
                                content[numb + 1].Substring(0, content[numb + 1].Length),
                                content[numb + 2].Substring(0, content[numb + 2].Length),
                                Convert.ToInt16(content[numb + 3].Substring(0, content[numb + 3].Length)),
                                content[numb + 4].Substring(0, content[numb + 4].Length));

                            listUcenik.Add(LoadUcenik);
                            numb += 5;
                        }
                    }
                }
            }
            if (CmbEntitet.SelectedIndex == 1)
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV File (*.csv)|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string fileContent = reader.ReadToEnd();
                        string[] content = fileContent.Split(',');
                        int numb = 6;
                        while (content.Length >= numb + 6)
                        {
                            Stalni LoadStalni = new Stalni(
                                Convert.ToDouble(content[numb].Substring(0, content[numb].Length)),
                                Convert.ToBoolean(content[numb + 1].Substring(0, content[numb + 1].Length)),
                                content[numb + 2].Substring(0, content[numb + 2].Length),
                                content[numb + 3].Substring(0, content[numb + 3].Length),
                                content[numb + 4].Substring(0, content[numb + 4].Length),
                                content[numb + 5].Substring(0, content[numb + 5].Length));

                            listStalni.Add(LoadStalni);
                            numb += 6;
                        }
                    }
                }
            }
            if (CmbEntitet.SelectedIndex == 2)
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV File (*.csv)|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string fileContent = reader.ReadToEnd();
                        string[] content = fileContent.Split(',');
                        int numb = 5;
                        while (content.Length >= numb + 6)
                        {
                            Part LoadPart = new Part(
                                Convert.ToDouble(content[numb].Substring(0, content[numb].Length)),
                                content[numb + 1].Substring(0, content[numb + 1].Length),
                                content[numb + 2].Substring(0, content[numb + 2].Length),
                                content[numb + 3].Substring(0, content[numb + 3].Length),
                                content[numb + 4].Substring(0, content[numb + 4].Length));

                            listPart.Add(LoadPart);
                            numb += 5;
                        }
                    }
                }
            }
        }
    }
}
