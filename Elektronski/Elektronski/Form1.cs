using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elektronski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 osoba = new Form2();
            osoba.ShowDialog();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    Form3 odeljenja = new Form3();
       //     odeljenja.Show();
            
        }

        private void skolskaGodinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 skolske_godine = new Form4("Skolska_godina");
            skolske_godine.Text = "Skolske godine";
            skolske_godine.ShowDialog();
        }

        private void predmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPredmet predmeti = new FormPredmet();
            predmeti.ShowDialog();
        }

        private void smerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 smerovi = new Form4("Smer");
            smerovi.Text = "Smerovi";
            smerovi.ShowDialog();
        }

        private void buttonOdeljenja_Click(object sender, EventArgs e)
        {
            Form3 odeljenja = new Form3();
            odeljenja.ShowDialog(); 
        }

        private void buttonOcene_Click(object sender, EventArgs e)
        {
            Form5 ocene = new Form5();
            ocene.ShowDialog();
        }

        private void buttonUpisnice_Click(object sender, EventArgs e)
        {
            Form7 upisnice = new Form7();
            upisnice.ShowDialog();
        }

        private void buttonRaspodele_Click(object sender, EventArgs e)
        {
            Form8 raspodele = new Form8();
            raspodele.ShowDialog();
        }
    }
}
