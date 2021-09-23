namespace Klijent
{
    partial class KasirForma
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelImeKorisnika = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelKorisnickoIme = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewRacuni = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racuniPoDatumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racuniPoRadnikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikliPoOpseguCeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btbDetaljiRacuna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacuni)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewRacuni);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 526);
            this.splitContainer1.SplitterDistance = 874;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelImeKorisnika,
            this.toolStripStatusLabelKorisnickoIme});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(874, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelImeKorisnika
            // 
            this.labelImeKorisnika.Name = "labelImeKorisnika";
            this.labelImeKorisnika.Size = new System.Drawing.Size(60, 20);
            this.labelImeKorisnika.Text = "KASIR : ";
            // 
            // toolStripStatusLabelKorisnickoIme
            // 
            this.toolStripStatusLabelKorisnickoIme.Name = "toolStripStatusLabelKorisnickoIme";
            this.toolStripStatusLabelKorisnickoIme.Size = new System.Drawing.Size(0, 20);
            // 
            // dataGridViewRacuni
            // 
            this.dataGridViewRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRacuni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRacuni.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRacuni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewRacuni.MultiSelect = false;
            this.dataGridViewRacuni.Name = "dataGridViewRacuni";
            this.dataGridViewRacuni.ReadOnly = true;
            this.dataGridViewRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRacuni.Size = new System.Drawing.Size(874, 526);
            this.dataGridViewRacuni.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btbDetaljiRacuna, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(188, 526);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(27, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj racun";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izvestajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.racuniPoDatumuToolStripMenuItem,
            this.racuniPoRadnikuToolStripMenuItem,
            this.artikliPoOpseguCeneToolStripMenuItem});
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.izvestajiToolStripMenuItem.Text = "Izvestaji";
            // 
            // racuniPoDatumuToolStripMenuItem
            // 
            this.racuniPoDatumuToolStripMenuItem.Name = "racuniPoDatumuToolStripMenuItem";
            this.racuniPoDatumuToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.racuniPoDatumuToolStripMenuItem.Text = "Racuni po datumu";
            this.racuniPoDatumuToolStripMenuItem.Click += new System.EventHandler(this.racuniPoDatumuToolStripMenuItem_Click);
            // 
            // racuniPoRadnikuToolStripMenuItem
            // 
            this.racuniPoRadnikuToolStripMenuItem.Name = "racuniPoRadnikuToolStripMenuItem";
            this.racuniPoRadnikuToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.racuniPoRadnikuToolStripMenuItem.Text = "Racuni po radniku";
            this.racuniPoRadnikuToolStripMenuItem.Click += new System.EventHandler(this.racuniPoRadnikuToolStripMenuItem_Click);
            // 
            // artikliPoOpseguCeneToolStripMenuItem
            // 
            this.artikliPoOpseguCeneToolStripMenuItem.Name = "artikliPoOpseguCeneToolStripMenuItem";
            this.artikliPoOpseguCeneToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.artikliPoOpseguCeneToolStripMenuItem.Text = "Artikli po opsegu cene";
            this.artikliPoOpseguCeneToolStripMenuItem.Click += new System.EventHandler(this.artikliPoOpseguCeneToolStripMenuItem_Click);
            // 
            // btbDetaljiRacuna
            // 
            this.btbDetaljiRacuna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btbDetaljiRacuna.Location = new System.Drawing.Point(34, 244);
            this.btbDetaljiRacuna.Name = "btbDetaljiRacuna";
            this.btbDetaljiRacuna.Size = new System.Drawing.Size(120, 37);
            this.btbDetaljiRacuna.TabIndex = 1;
            this.btbDetaljiRacuna.Text = "DetaljiRacuna";
            this.btbDetaljiRacuna.UseVisualStyleBackColor = true;
            this.btbDetaljiRacuna.Click += new System.EventHandler(this.btbDetaljiRacuna_Click);
            // 
            // KasirForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KasirForma";
            this.Text = "KasirForma";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacuni)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewRacuni;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelImeKorisnika;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racuniPoDatumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racuniPoRadnikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artikliPoOpseguCeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelKorisnickoIme;
        private System.Windows.Forms.Button btbDetaljiRacuna;
    }
}