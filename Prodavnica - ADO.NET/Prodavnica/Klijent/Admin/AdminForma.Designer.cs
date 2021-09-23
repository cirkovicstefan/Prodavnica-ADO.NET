namespace Klijent
{
    partial class AdminForma
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racuniPoRadnikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racuniPoDatumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikliPoOpseguCeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxTabela = new System.Windows.Forms.ToolStripComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izvestajiToolStripMenuItem,
            this.comboBoxTabela});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.racuniPoRadnikuToolStripMenuItem,
            this.racuniPoDatumuToolStripMenuItem,
            this.artikliPoOpseguCeneToolStripMenuItem});
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.izvestajiToolStripMenuItem.Text = "Izvestaji";
            // 
            // racuniPoRadnikuToolStripMenuItem
            // 
            this.racuniPoRadnikuToolStripMenuItem.Name = "racuniPoRadnikuToolStripMenuItem";
            this.racuniPoRadnikuToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.racuniPoRadnikuToolStripMenuItem.Text = "Racuni po radniku";
            this.racuniPoRadnikuToolStripMenuItem.Click += new System.EventHandler(this.racuniPoRadnikuToolStripMenuItem_Click);
            // 
            // racuniPoDatumuToolStripMenuItem
            // 
            this.racuniPoDatumuToolStripMenuItem.Name = "racuniPoDatumuToolStripMenuItem";
            this.racuniPoDatumuToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.racuniPoDatumuToolStripMenuItem.Text = "Racuni po datumu";
            this.racuniPoDatumuToolStripMenuItem.Click += new System.EventHandler(this.racuniPoDatumuToolStripMenuItem_Click);
            // 
            // artikliPoOpseguCeneToolStripMenuItem
            // 
            this.artikliPoOpseguCeneToolStripMenuItem.Name = "artikliPoOpseguCeneToolStripMenuItem";
            this.artikliPoOpseguCeneToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.artikliPoOpseguCeneToolStripMenuItem.Text = "Artikli po opsegu cene";
            this.artikliPoOpseguCeneToolStripMenuItem.Click += new System.EventHandler(this.artikliPoOpseguCeneToolStripMenuItem_Click);
            // 
            // comboBoxTabela
            // 
            this.comboBoxTabela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTabela.Items.AddRange(new object[] {
            "Korisnici",
            "Artikli"});
            this.comboBoxTabela.Name = "comboBoxTabela";
            this.comboBoxTabela.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTabela.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(726, 397);
            this.panel.TabIndex = 3;
            // 
            // AdminForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 424);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForma";
            this.Text = "AdminForma";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racuniPoRadnikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racuniPoDatumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artikliPoOpseguCeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox comboBoxTabela;
        private System.Windows.Forms.Panel panel;
    }
}