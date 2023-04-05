namespace Elektronski
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRazred = new System.Windows.Forms.TextBox();
            this.tbIndeks = new System.Windows.Forms.TextBox();
            this.btDodaj = new System.Windows.Forms.Button();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btBrisi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbImePrezime = new System.Windows.Forms.ComboBox();
            this.cbSmer = new System.Windows.Forms.ComboBox();
            this.cbSkolskaGodina = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Indeks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Razred";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ime i prezime razrednog";
            // 
            // tbRazred
            // 
            this.tbRazred.Location = new System.Drawing.Point(136, 84);
            this.tbRazred.Name = "tbRazred";
            this.tbRazred.Size = new System.Drawing.Size(38, 20);
            this.tbRazred.TabIndex = 27;
            this.tbRazred.TextChanged += new System.EventHandler(this.tbRazred_TextChanged);
            // 
            // tbIndeks
            // 
            this.tbIndeks.Location = new System.Drawing.Point(202, 84);
            this.tbIndeks.Name = "tbIndeks";
            this.tbIndeks.Size = new System.Drawing.Size(36, 20);
            this.tbIndeks.TabIndex = 26;
            this.tbIndeks.TextChanged += new System.EventHandler(this.tbIndeks_TextChanged);
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(576, 331);
            this.btDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(73, 22);
            this.btDodaj.TabIndex = 25;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(356, 330);
            this.btIzmeni.Margin = new System.Windows.Forms.Padding(2);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(73, 23);
            this.btIzmeni.TabIndex = 24;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btBrisi
            // 
            this.btBrisi.Location = new System.Drawing.Point(136, 330);
            this.btBrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(73, 24);
            this.btBrisi.TabIndex = 23;
            this.btBrisi.Text = "Brisi";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(136, 137);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(514, 166);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // cbImePrezime
            // 
            this.cbImePrezime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImePrezime.FormattingEnabled = true;
            this.cbImePrezime.Location = new System.Drawing.Point(390, 84);
            this.cbImePrezime.Margin = new System.Windows.Forms.Padding(2);
            this.cbImePrezime.Name = "cbImePrezime";
            this.cbImePrezime.Size = new System.Drawing.Size(149, 21);
            this.cbImePrezime.TabIndex = 20;
            this.cbImePrezime.SelectedIndexChanged += new System.EventHandler(this.cbImePrezime_SelectedIndexChanged);
            // 
            // cbSmer
            // 
            this.cbSmer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSmer.FormattingEnabled = true;
            this.cbSmer.Location = new System.Drawing.Point(266, 84);
            this.cbSmer.Margin = new System.Windows.Forms.Padding(2);
            this.cbSmer.Name = "cbSmer";
            this.cbSmer.Size = new System.Drawing.Size(96, 21);
            this.cbSmer.TabIndex = 31;
            this.cbSmer.SelectedIndexChanged += new System.EventHandler(this.cbSmer_SelectedIndexChanged);
            // 
            // cbSkolskaGodina
            // 
            this.cbSkolskaGodina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkolskaGodina.FormattingEnabled = true;
            this.cbSkolskaGodina.Location = new System.Drawing.Point(573, 84);
            this.cbSkolskaGodina.Margin = new System.Windows.Forms.Padding(2);
            this.cbSkolskaGodina.Name = "cbSkolskaGodina";
            this.cbSkolskaGodina.Size = new System.Drawing.Size(77, 21);
            this.cbSkolskaGodina.TabIndex = 32;
            this.cbSkolskaGodina.SelectedIndexChanged += new System.EventHandler(this.cbSkolskaGodina_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Skolska godina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Naziv smera";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 420);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSkolskaGodina);
            this.Controls.Add(this.cbSmer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRazred);
            this.Controls.Add(this.tbIndeks);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbImePrezime);
            this.Name = "Form3";
            this.Text = "Odeljenja";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRazred;
        private System.Windows.Forms.TextBox tbIndeks;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbImePrezime;
        private System.Windows.Forms.ComboBox cbSmer;
        private System.Windows.Forms.ComboBox cbSkolskaGodina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}