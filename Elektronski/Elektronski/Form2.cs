using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Elektronski
{
    public partial class Form2 : Form
    {
        DataTable podaci, dtOsobe, dtOsobeJoin;
        SqlDataAdapter adapter;
        string imeTabele;
        SqlConnection veza;
        int broj;

        public Form2()
        {
            imeTabele = "Osoba";
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["home"].ConnectionString;
            veza = new SqlConnection(CS);
            adapter = new SqlDataAdapter("SELECT * FROM " + imeTabele, Konekcija.Connect());
            podaci = new DataTable();
            adapter.Fill(podaci);
            gridPopulate();
            dataGridView1.DataSource = podaci;
            dataGridView1.Columns["id"].ReadOnly = true;
            
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                broj = dataGridView1.CurrentRow.Index;
                tbIme.Text = dtOsobe.Rows[broj]["ime"].ToString();
                tbPrezime.Text = dtOsobe.Rows[broj]["prezime"].ToString();
                tbAdresa.Text = dtOsobe.Rows[broj]["adresa"].ToString();
                tbJmbg.Text = dtOsobe.Rows[broj]["jmbg"].ToString();
                tbEmail.Text = dtOsobe.Rows[broj]["email"].ToString();
                tbPass.Text = dtOsobe.Rows[broj]["pass"].ToString();
                tbUloga.Text = dtOsobe.Rows[broj]["uloga"].ToString();
            }
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            try
            {
                string naredba = "DELETE FROM osoba WHERE id = " + dtOsobe.Rows[broj]["id"].ToString();
                SqlCommand komanda = new SqlCommand(naredba, veza);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                gridPopulate();
            }

            catch (Exception Greska)
            {
                veza.Close();
                MessageBox.Show(Greska.Message);
            }
        }

        private void gridPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM osoba ORDER BY id", veza);
            dtOsobe = new DataTable();
            adapter.Fill(dtOsobe);

            string tmp = "SELECT * FROM osoba ORDER BY id";
            adapter = new SqlDataAdapter(tmp, veza);
            dtOsobeJoin = new DataTable();
            adapter.Fill(dtOsobeJoin);

            dataGridView1.DataSource = dtOsobeJoin;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["id"].Visible = false;
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                string naredba = "INSERT INTO osoba (ime, prezime, adresa, jmbg, email, pass, uloga) VALUES ('";
                naredba = naredba + tbIme.Text + "','";
                naredba = naredba + tbPrezime.Text + "','";
                naredba = naredba + tbAdresa.Text + "','";
                naredba = naredba + tbJmbg.Text + "','";
                naredba = naredba + tbEmail.Text + "','";
                naredba = naredba + tbPass.Text+ "','";
                naredba = naredba + tbUloga.Text + "')";

                SqlCommand komanda = new SqlCommand(naredba, veza);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                gridPopulate();
            }

            catch (Exception Greska)
            {
                veza.Close();
                MessageBox.Show(Greska.Message);
            }
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                string naredba = "UPDATE osoba SET ime='" + tbIme.Text;
                naredba = naredba + "', prezime='" + tbPrezime.Text;
                naredba = naredba + "', adresa='" + tbAdresa.Text;
                naredba = naredba + "', jmbg='" + tbJmbg.Text;
                naredba = naredba + "', email='" + tbEmail.Text;
                naredba = naredba + "', pass='" + tbPass.Text;
                naredba = naredba + "', uloga='" + tbUloga.Text + "'WHERE id='";
                naredba = naredba + dtOsobe.Rows[broj]["id"].ToString() + "'";
                SqlCommand komanda = new SqlCommand(naredba, veza);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                gridPopulate();
            }

            catch (Exception Greska)
            {
                veza.Close();
                MessageBox.Show(Greska.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
      /*      DataTable druga = new DataTable();
            // druga = podaci.GetChanges(DataRowState.Modified); //npr samo jedna od 3 vrste promena
            druga = podaci.GetChanges();
            dataGridView2.DataSource = druga;
            // ============= Ovo je nastavak posto se obrise dataGridView2 nakon pokazanog primera
            DataTable menjano = podaci.GetChanges(); // ovde ce biti sve promene
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            if (menjano != null)
            {
                adapter.Update(menjano);
                this.Close();
            }*/
        }
    }
}
