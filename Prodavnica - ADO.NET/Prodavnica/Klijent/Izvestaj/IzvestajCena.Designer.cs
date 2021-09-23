namespace Klijent
{
    partial class IzvestajCena
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCenaOd = new System.Windows.Forms.TextBox();
            this.txtCenaDo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cena :   OD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCenaOd
            // 
            this.txtCenaOd.Location = new System.Drawing.Point(82, 10);
            this.txtCenaOd.Name = "txtCenaOd";
            this.txtCenaOd.Size = new System.Drawing.Size(64, 20);
            this.txtCenaOd.TabIndex = 1;
            // 
            // txtCenaDo
            // 
            this.txtCenaDo.Location = new System.Drawing.Point(181, 10);
            this.txtCenaDo.Name = "txtCenaDo";
            this.txtCenaDo.Size = new System.Drawing.Size(73, 20);
            this.txtCenaDo.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generisi izvestaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DO";
            // 
            // IzvestajCena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCenaDo);
            this.Controls.Add(this.txtCenaOd);
            this.Controls.Add(this.label1);
            this.Name = "IzvestajCena";
            this.Size = new System.Drawing.Size(469, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCenaOd;
        private System.Windows.Forms.TextBox txtCenaDo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}
