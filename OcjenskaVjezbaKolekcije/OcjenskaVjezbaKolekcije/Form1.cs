using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OcjenskaVjezbaKolekcije
{
    public partial class Form1 : Form
    {
        class Podaci
        {
            string ime, prezime, godine, spol;
            string brada;

            public Podaci(string ime, string prezime, string godine, string spol)
            {
                this.ime = ime;
                this.prezime = prezime;
                this.godine = godine;
                this.spol = spol;
            }

            public string Ime { get => ime; set => ime = value; }
            public string Prezime { get => prezime; set => prezime = value; }
            public string Godine { get => godine; set => godine = value; }
            public string Spol { get => spol; set => spol = value; }
            public string Brada { get => brada; set => brada = value; }

            public override string ToString()
            {
                string ispis = "Ime: " + ime + " prezime: " + prezime + " god: " + godine + " spol: " + spol;
                return ispis;
            }


        }

        List<Podaci> PodaciList = new List<Podaci>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            foreach (Podaci p in PodaciList)
            {
                txtBx.AppendText(p.ToString());
            }
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            Podaci podaci = new Podaci(txtIme.Text, txtPrez.Text, txtGod.Text, cmbSpol.SelectedText);

            try
            {
                if (txtIme.Text =="" || txtPrez.Text =="" || txtGod.Text =="" || cmbSpol.Text=="")
                {
                    MessageBox.Show("Pogrešan unos", "Pokušajte ponovo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIme.Clear();
                    txtPrez.Clear();
                    txtGod.Clear();
                    
                }
                else
                {
                    PodaciList.Add(podaci);
                    txtIme.Clear();
                    txtPrez.Clear();
                    txtGod.Clear();
                }

            }
            catch 
            {
                txtIme.Clear();
                txtPrez.Clear();
                txtGod.Clear();
                
            }
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            foreach (Podaci p in PodaciList)
            {
                if(p.Spol=="M")
                {
                    p.Brada = "Ima bradu";
                }
                else
                {
                    p.Brada = "Nema bradu";
                }
            }

            string file = @"C:\Users\ucenik\Documents\Raul Dominik Holik\OcjenskaVjezbaKolekcije";
            string separator = ",";
            StringBuilder output = new StringBuilder();
            String[] headings = { "Ime", "Prezime", "Godina rođenja", "Spol" };
            output.AppendLine(string.Join(separator, headings));

            foreach (Podaci p in PodaciList)
            {
                String[] newLine = { p.Ime, p.Prezime, p.Godine, p.Spol };
                output.AppendLine(string.Join(separator, headings));
                string Line = string.Format("{0}, {1}, {2}, {3}",p.Ime,p.Prezime,p.Godine,p.Spol);
                output.AppendLine(string.Join(separator, newLine));
            }

            try
            {
                File.AppendAllText(file, output.ToString());
            }
            catch 
            {
                Console.WriteLine("Podaci se nisu mogli upisati u datoteku");
                return;
            }
        }
    }
}
