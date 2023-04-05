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
    public partial class FormPredmet : Form
    {
        DataTable podaci, dtTabela, dtTabelaJoin;
        SqlDataAdapter adapter;
        string imeTabele;
        int broj;
        SqlConnection veza;

        public FormPredmet()
        {
            InitializeComponent();
        }

        private void FormPredmet_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["home"].ConnectionString;
            veza = new SqlConnection(CS);
            adapter = new SqlDataAdapter("SELECT * FROM Predmet", Konekcija.Connect());
            podaci = new DataTable();
            adapter.Fill(podaci);
            gridPopulate();
            dataGridView1.DataSource = podaci;
            dataGridView1.Columns["id"].ReadOnly = true;
        }

        private void gridPopulate()
        {
            string n = "SELECT * FROM Predmet ORDER BY id";
            SqlDataAdapter adapter = new SqlDataAdapter(n, veza);
            dtTabela = new DataTable();
            adapter.Fill(dtTabela);

            string tmp = "SELECT * FROM Predmet ORDER BY id";
            adapter = new SqlDataAdapter(tmp, veza);
            dtTabelaJoin = new DataTable();
            adapter.Fill(dtTabelaJoin);

            dataGridView1.DataSource = dtTabelaJoin;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["id"].Visible = false;
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            try
            {
                string naredba = "DELETE FROM Predmet WHERE id = " + dtTabela.Rows[broj]["id"].ToString();
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
                string naredba = "UPDATE Predmet SET naziv='" + tbNaziv.Text;
                naredba = naredba + "', razred='" +  tbRazred.Text + "' WHERE id='";
                naredba = naredba + dtTabela.Rows[broj]["id"].ToString() + "'";
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

        private void btDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                string naredba = "INSERT INTO Predmet (naziv, razred) VALUES ('";
                naredba = naredba + tbNaziv.Text + "','";
                naredba = naredba + tbRazred.Text + "')";

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

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                broj = dataGridView1.CurrentRow.Index;
                tbNaziv.Text = dtTabela.Rows[broj]["naziv"].ToString();
                tbRazred.Text = dtTabela.Rows[broj]["razred"].ToString();
            }
        }
    }
}
