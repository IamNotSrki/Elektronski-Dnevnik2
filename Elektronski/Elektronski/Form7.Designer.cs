namespace Elektronski
{
    partial class Form7
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbOdeljenje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btDodaj = new System.Windows.Forms.Button();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btBrisi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbImePrezime = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Odeljenje";
            // 
            // cbOdeljenje
            // 
            this.cbOdeljenje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdeljenje.FormattingEnabled = true;
            this.cbOdeljenje.Location = new System.Drawing.Point(420, 120);
            this.cbOdeljenje.Margin = new System.Windows.Forms.Padding(2);
            this.cbOdeljenje.Name = "cbOdeljenje";
            this.cbOdeljenje.Size = new System.Drawing.Size(82, 21);
            this.cbOdeljenje.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Ime i prezime ucenika";
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(429, 366);
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
            this.btIzmeni.Location = new System.Drawing.Point(319, 365);
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
            this.btBrisi.Location = new System.Drawing.Point(209, 364);
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
            this.dataGridView1.Location = new System.Drawing.Point(209, 173);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(293, 166);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // cbImePrezime
            // 
            this.cbImePrezime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImePrezime.FormattingEnabled = true;
            this.cbImePrezime.Location = new System.Drawing.Point(209, 120);
            this.cbImePrezime.Margin = new System.Windows.Forms.Padding(2);
            this.cbImePrezime.Name = "cbImePrezime";
            this.cbImePrezime.Size = new System.Drawing.Size(130, 21);
            this.cbImePrezime.TabIndex = 35;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 499);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbOdeljenje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbImePrezime);
            this.Name = "Form7";
            this.Text = "Upisnice";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbOdeljenje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbImePrezime;
    }
}