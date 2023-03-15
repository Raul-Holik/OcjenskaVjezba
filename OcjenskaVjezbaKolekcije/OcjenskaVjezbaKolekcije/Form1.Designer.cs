namespace OcjenskaVjezbaKolekcije
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrez = new System.Windows.Forms.TextBox();
            this.txtGod = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnObrada = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.txtBx = new System.Windows.Forms.RichTextBox();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(37, 26);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 0;
            // 
            // txtPrez
            // 
            this.txtPrez.Location = new System.Drawing.Point(37, 68);
            this.txtPrez.Name = "txtPrez";
            this.txtPrez.Size = new System.Drawing.Size(100, 20);
            this.txtPrez.TabIndex = 1;
            // 
            // txtGod
            // 
            this.txtGod.Location = new System.Drawing.Point(37, 107);
            this.txtGod.Name = "txtGod";
            this.txtGod.Size = new System.Drawing.Size(100, 20);
            this.txtGod.TabIndex = 2;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(222, 22);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 4;
            this.btnUnos.Text = "Unesi";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnObrada
            // 
            this.btnObrada.Location = new System.Drawing.Point(360, 21);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(75, 23);
            this.btnObrada.TabIndex = 5;
            this.btnObrada.Text = "Obradi";
            this.btnObrada.UseVisualStyleBackColor = true;
            this.btnObrada.Click += new System.EventHandler(this.btnObrada_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(501, 22);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 6;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(222, 87);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(354, 213);
            this.txtBx.TabIndex = 7;
            this.txtBx.Text = "";
            // 
            // cmbSpol
            // 
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.cmbSpol.Location = new System.Drawing.Point(37, 145);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(121, 21);
            this.cmbSpol.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(612, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SaveFileDialog";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbSpol);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.txtGod);
            this.Controls.Add(this.txtPrez);
            this.Controls.Add(this.txtIme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrez;
        private System.Windows.Forms.TextBox txtGod;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnObrada;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.RichTextBox txtBx;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.Button btnSave;
    }
}

