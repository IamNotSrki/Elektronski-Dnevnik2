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
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "Profesor" && textBox2.Text == "prof")
                {
                    Form1 elektronskiDnevnik = new Form1();
                    elektronskiDnevnik.ShowDialog();
                }
                else
                    throw new Exception("Pogresno ime ili lozinka.");
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
        }
    }
}
