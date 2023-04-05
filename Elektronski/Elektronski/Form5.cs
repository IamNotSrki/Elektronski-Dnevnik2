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
    public partial class Form5 : Form
    {
        int broj;
        SqlConnection veza;
        DataTable dtOcene, dtOceneJoin;

        public Form5()
        {
            InitializeComponent();
        }

        private void ucenikPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, ime+' '+prezime AS 'Naziv ucenika' FROM osoba WHERE uloga = 1", veza);
            DataTable dtUcenik = new DataTable();
            adapter.Fill(dtUcenik);
            cbImePrezime.DataSource = dtUcenik;
            cbImePrezime.ValueMember = "id";
            cbImePrezime.DisplayMember = "Naziv ucenika";
        }

        private void datumPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT datum FROM ocena", veza);
            DataTable dtDatum = new DataTable();
            adapter.Fill(dtDatum);
        }

        private void raspodelaPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT raspodela.id, predmet.naziv + STR(odeljenje.razred) + '-' + Odeljenje.indeks AS 'Raspodela' FROM Raspodela JOIN Predmet on raspodela.predmet_id = predmet.id JOIN Odeljenje ON Raspodela.odeljenje_id = odeljenje.id", veza);
            DataTable dtRaspodela = new DataTable();
            adapter.Fill(dtRaspodela);
            cbRaspodela.DataSource = dtRaspodela;
            cbRaspodela.ValueMember = "id";
            cbRaspodela.DisplayMember = "Raspodela";
        }

        private void gridPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ocena ORDER BY id", veza);
            dtOcene = new DataTable();
            adapter.Fill(dtOcene);

            string tmp = "select ocena.id, osoba.ime + ' ' + osoba.prezime AS 'Ucenik', ocena.datum, predmet.naziv + STR(odeljenje.razred) + '-' + Odeljenje.indeks AS 'Raspodela', ocena.ocena FROM Ocena join osoba ON ocena.ucenik_id = osoba.id JOIN Raspodela ON ocena.raspodela_id = raspodela.id JOIN Predmet on raspodela.predmet_id = predmet.id JOIN Odeljenje ON Raspodela.odeljenje_id = odeljenje.id WHERE osoba.uloga = 1";
            adapter = new SqlDataAdapter(tmp, veza);
            dtOceneJoin = new DataTable();
            adapter.Fill(dtOceneJoin);

            dataGridView1.DataSource = dtOceneJoin;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["id"].Visible = false;
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                broj = dataGridView1.CurrentRow.Index;
                cbImePrezime.SelectedValue = dtOcene.Rows[broj]["ucenik_id"].ToString();
                tbDatum.Text = dtOcene.Rows[broj]["datum"].ToString();
                cbRaspodela.SelectedValue = dtOcene.Rows[broj]["raspodela_id"].ToString();
                tbOcena.Text = dtOcene.Rows[broj]["ocena"].ToString();
            }
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            try
            {
                string naredba = "DELETE FROM ocena WHERE id = " + dtOcene.Rows[broj]["id"].ToString();
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
                if (int.Parse(tbOcena.Text) > 5 || int.Parse(tbOcena.Text) < 1)
                    throw new Exception("Ocena mora biti od 1 do 5.");
                string naredba = "INSERT INTO ocena (ucenik_id, datum, raspodela_id, ocena) VALUES ('";
                naredba = naredba + cbImePrezime.SelectedValue.ToString() + "','";
                naredba = naredba + tbDatum.Text + "','";
                naredba = naredba + cbRaspodela.SelectedValue.ToString() + "',";
                naredba = naredba + tbOcena.Text + ")";

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
                if (int.Parse(tbOcena.Text) > 5 || int.Parse(tbOcena.Text) < 1)
                    throw new Exception("Ocena mora biti od 1 do 5.");
                string naredba = "UPDATE ocena SET ucenik_id='" + cbImePrezime.SelectedValue.ToString();
                naredba = naredba + "', datum='" + tbDatum.Text;
                naredba = naredba + "', ocena='" + tbOcena.Text;
                naredba = naredba + "', raspodela_id='" + cbRaspodela.SelectedValue.ToString() + "'WHERE id='";
                naredba = naredba + dtOcene.Rows[broj]["id"].ToString() + "'";
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

        private void Form5_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["home"].ConnectionString;
            veza = new SqlConnection(CS);
            ucenikPopulate();
            datumPopulate();
            raspodelaPopulate();
            gridPopulate();
        }
    }
}
