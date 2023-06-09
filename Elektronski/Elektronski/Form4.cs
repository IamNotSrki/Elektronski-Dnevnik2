﻿using System;
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
    public partial class Form4 : Form
    {
        DataTable podaci, dtTabela, dtTabelaJoin;
        SqlDataAdapter adapter;
        string imeTabele;
        int broj;
        SqlConnection veza;

        public Form4(string putanja)
        {
            imeTabele = putanja;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string naredba = "UPDATE " + imeTabele + " SET naziv='" + tbNaziv.Text;
                naredba = naredba + "' WHERE id='";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                broj = dataGridView1.CurrentRow.Index;
                tbNaziv.Text = dtTabela.Rows[broj]["naziv"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string naredba = "DELETE FROM " + imeTabele + " WHERE id = " + dtTabela.Rows[broj]["id"].ToString();
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
            string n = "SELECT * FROM " + imeTabele + " ORDER BY id";
            SqlDataAdapter adapter = new SqlDataAdapter(n, veza);
            dtTabela = new DataTable();
            adapter.Fill(dtTabela);

            string tmp = "SELECT * FROM " + imeTabele + " ORDER BY id";
            adapter = new SqlDataAdapter(tmp, veza);
            dtTabelaJoin = new DataTable();
            adapter.Fill(dtTabelaJoin);

            dataGridView1.DataSource = dtTabelaJoin;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["id"].Visible = false;
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                string naredba = "INSERT INTO " + imeTabele + " (naziv) VALUES ('";
                naredba = naredba + tbNaziv.Text + "')";

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
    }
}
