namespace Elektronski
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.šifarniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skolskaGodinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOdeljenja = new System.Windows.Forms.Button();
            this.buttonOcene = new System.Windows.Forms.Button();
            this.buttonUpisnice = new System.Windows.Forms.Button();
            this.buttonRaspodele = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.šifarniciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Šifarnici";
            // 
            // šifarniciToolStripMenuItem
            // 
            this.šifarniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobaToolStripMenuItem,
            this.skolskaGodinaToolStripMenuItem,
            this.smerToolStripMenuItem,
            this.predmetToolStripMenuItem});
            this.šifarniciToolStripMenuItem.Name = "šifarniciToolStripMenuItem";
            this.šifarniciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.šifarniciToolStripMenuItem.Text = "Šifarnici";
            // 
            // osobaToolStripMenuItem
            // 
            this.osobaToolStripMenuItem.Name = "osobaToolStripMenuItem";
            this.osobaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.osobaToolStripMenuItem.Text = "Osoba";
            this.osobaToolStripMenuItem.Click += new System.EventHandler(this.osobaToolStripMenuItem_Click);
            // 
            // skolskaGodinaToolStripMenuItem
            // 
            this.skolskaGodinaToolStripMenuItem.Name = "skolskaGodinaToolStripMenuItem";
            this.skolskaGodinaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.skolskaGodinaToolStripMenuItem.Text = "Školska godina";
            this.skolskaGodinaToolStripMenuItem.Click += new System.EventHandler(this.skolskaGodinaToolStripMenuItem_Click);
            // 
            // smerToolStripMenuItem
            // 
            this.smerToolStripMenuItem.Name = "smerToolStripMenuItem";
            this.smerToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.smerToolStripMenuItem.Text = "Smer";
            this.smerToolStripMenuItem.Click += new System.EventHandler(this.smerToolStripMenuItem_Click);
            // 
            // predmetToolStripMenuItem
            // 
            this.predmetToolStripMenuItem.Name = "predmetToolStripMenuItem";
            this.predmetToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.predmetToolStripMenuItem.Text = "Predmet";
            this.predmetToolStripMenuItem.Click += new System.EventHandler(this.predmetToolStripMenuItem_Click);
            // 
            // buttonOdeljenja
            // 
            this.buttonOdeljenja.Location = new System.Drawing.Point(210, 115);
            this.buttonOdeljenja.Name = "buttonOdeljenja";
            this.buttonOdeljenja.Size = new System.Drawing.Size(163, 80);
            this.buttonOdeljenja.TabIndex = 2;
            this.buttonOdeljenja.Text = "Pregled odeljenja";
            this.buttonOdeljenja.UseVisualStyleBackColor = true;
            this.buttonOdeljenja.Click += new System.EventHandler(this.buttonOdeljenja_Click);
            // 
            // buttonOcene
            // 
            this.buttonOcene.Location = new System.Drawing.Point(463, 115);
            this.buttonOcene.Name = "buttonOcene";
            this.buttonOcene.Size = new System.Drawing.Size(163, 80);
            this.buttonOcene.TabIndex = 3;
            this.buttonOcene.Text = "Pregled ocena";
            this.buttonOcene.UseVisualStyleBackColor = true;
            this.buttonOcene.Click += new System.EventHandler(this.buttonOcene_Click);
            // 
            // buttonUpisnice
            // 
            this.buttonUpisnice.Location = new System.Drawing.Point(210, 251);
            this.buttonUpisnice.Name = "buttonUpisnice";
            this.buttonUpisnice.Size = new System.Drawing.Size(163, 80);
            this.buttonUpisnice.TabIndex = 4;
            this.buttonUpisnice.Text = "Pregled upisnica";
            this.buttonUpisnice.UseVisualStyleBackColor = true;
            this.buttonUpisnice.Click += new System.EventHandler(this.buttonUpisnice_Click);
            // 
            // buttonRaspodele
            // 
            this.buttonRaspodele.Location = new System.Drawing.Point(463, 251);
            this.buttonRaspodele.Name = "buttonRaspodele";
            this.buttonRaspodele.Size = new System.Drawing.Size(163, 80);
            this.buttonRaspodele.TabIndex = 5;
            this.buttonRaspodele.Text = "Pregled raspodela";
            this.buttonRaspodele.UseVisualStyleBackColor = true;
            this.buttonRaspodele.Click += new System.EventHandler(this.buttonRaspodele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 487);
            this.Controls.Add(this.buttonRaspodele);
            this.Controls.Add(this.buttonUpisnice);
            this.Controls.Add(this.buttonOcene);
            this.Controls.Add(this.buttonOdeljenja);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EsDnevnik";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem šifarniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skolskaGodinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetToolStripMenuItem;
        private System.Windows.Forms.Button buttonOdeljenja;
        private System.Windows.Forms.Button buttonOcene;
        private System.Windows.Forms.Button buttonUpisnice;
        private System.Windows.Forms.Button buttonRaspodele;
    }
}

