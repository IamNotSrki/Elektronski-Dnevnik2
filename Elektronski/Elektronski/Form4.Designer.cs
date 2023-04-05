
namespace Elektronski
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btBrisi = new System.Windows.Forms.Button();
            this.btDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(156, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(267, 216);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(252, 347);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btIzmeni.TabIndex = 1;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.button1_Click);
            // 
            // btBrisi
            // 
            this.btBrisi.Location = new System.Drawing.Point(156, 347);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(75, 23);
            this.btBrisi.TabIndex = 2;
            this.btBrisi.Text = "Brisi";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.button2_Click);
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(348, 347);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(75, 23);
            this.btDodaj.TabIndex = 3;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(273, 43);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(100, 20);
            this.tbNaziv.TabIndex = 5;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 454);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNaziv;
    }
}