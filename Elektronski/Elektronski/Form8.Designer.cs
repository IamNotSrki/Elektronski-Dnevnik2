namespace Elektronski
{
    partial class Form8
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSkolskaGodina = new System.Windows.Forms.ComboBox();
            this.cbPredmet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btDodaj = new System.Windows.Forms.Button();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btBrisi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbImePrezime = new System.Windows.Forms.ComboBox();
            this.cbOdeljenje = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Predmet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Skolska godina";
            // 
            // cbSkolskaGodina
            // 
            this.cbSkolskaGodina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkolskaGodina.FormattingEnabled = true;
            this.cbSkolskaGodina.Location = new System.Drawing.Point(306, 94);
            this.cbSkolskaGodina.Margin = new System.Windows.Forms.Padding(2);
            this.cbSkolskaGodina.Name = "cbSkolskaGodina";
            this.cbSkolskaGodina.Size = new System.Drawing.Size(77, 21);
            this.cbSkolskaGodina.TabIndex = 46;
            // 
            // cbPredmet
            // 
            this.cbPredmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPredmet.FormattingEnabled = true;
            this.cbPredmet.Location = new System.Drawing.Point(417, 94);
            this.cbPredmet.Margin = new System.Windows.Forms.Padding(2);
            this.cbPredmet.Name = "cbPredmet";
            this.cbPredmet.Size = new System.Drawing.Size(119, 21);
            this.cbPredmet.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Ime i prezime nastavnika";
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(583, 341);
            this.btDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(73, 22);
            this.btDodaj.TabIndex = 39;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(352, 340);
            this.btIzmeni.Margin = new System.Windows.Forms.Padding(2);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(73, 23);
            this.btIzmeni.TabIndex = 38;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btBrisi
            // 
            this.btBrisi.Location = new System.Drawing.Point(121, 340);
            this.btBrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(73, 24);
            this.btBrisi.TabIndex = 37;
            this.btBrisi.Text = "Brisi";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 147);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(536, 166);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // cbImePrezime
            // 
            this.cbImePrezime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImePrezime.FormattingEnabled = true;
            this.cbImePrezime.Location = new System.Drawing.Point(121, 94);
            this.cbImePrezime.Margin = new System.Windows.Forms.Padding(2);
            this.cbImePrezime.Name = "cbImePrezime";
            this.cbImePrezime.Size = new System.Drawing.Size(151, 21);
            this.cbImePrezime.TabIndex = 35;
            // 
            // cbOdeljenje
            // 
            this.cbOdeljenje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdeljenje.FormattingEnabled = true;
            this.cbOdeljenje.Location = new System.Drawing.Point(570, 94);
            this.cbOdeljenje.Margin = new System.Windows.Forms.Padding(2);
            this.cbOdeljenje.Name = "cbOdeljenje";
            this.cbOdeljenje.Size = new System.Drawing.Size(87, 21);
            this.cbOdeljenje.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Odeljenje";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOdeljenje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSkolskaGodina);
            this.Controls.Add(this.cbPredmet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbImePrezime);
            this.Name = "Form8";
            this.Text = "Raspodele";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSkolskaGodina;
        private System.Windows.Forms.ComboBox cbPredmet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbImePrezime;
        private System.Windows.Forms.ComboBox cbOdeljenje;
        private System.Windows.Forms.Label label2;
    }
}