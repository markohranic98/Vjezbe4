namespace Osobe
{
    partial class uiOsobe
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
            this.uiOutputOsobe = new System.Windows.Forms.ListBox();
            this.uiInputIme = new System.Windows.Forms.TextBox();
            this.uiInputPrezime = new System.Windows.Forms.TextBox();
            this.uiInputDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.uiActionSvi = new System.Windows.Forms.Button();
            this.uiActionPoDatumu = new System.Windows.Forms.Button();
            this.uiInputFilter = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // uiOutputOsobe
            // 
            this.uiOutputOsobe.FormattingEnabled = true;
            this.uiOutputOsobe.Location = new System.Drawing.Point(12, 12);
            this.uiOutputOsobe.Name = "uiOutputOsobe";
            this.uiOutputOsobe.Size = new System.Drawing.Size(281, 277);
            this.uiOutputOsobe.TabIndex = 7;
            // 
            // uiInputIme
            // 
            this.uiInputIme.Location = new System.Drawing.Point(129, 312);
            this.uiInputIme.Name = "uiInputIme";
            this.uiInputIme.Size = new System.Drawing.Size(164, 20);
            this.uiInputIme.TabIndex = 0;
            // 
            // uiInputPrezime
            // 
            this.uiInputPrezime.Location = new System.Drawing.Point(129, 350);
            this.uiInputPrezime.Name = "uiInputPrezime";
            this.uiInputPrezime.Size = new System.Drawing.Size(164, 20);
            this.uiInputPrezime.TabIndex = 1;
            // 
            // uiInputDatumRodenja
            // 
            this.uiInputDatumRodenja.Location = new System.Drawing.Point(129, 397);
            this.uiInputDatumRodenja.Name = "uiInputDatumRodenja";
            this.uiInputDatumRodenja.Size = new System.Drawing.Size(164, 20);
            this.uiInputDatumRodenja.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Datum rođenja";
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.Enabled = false;
            this.uiActionDodaj.Location = new System.Drawing.Point(218, 438);
            this.uiActionDodaj.Name = "uiActionDodaj";
            this.uiActionDodaj.Size = new System.Drawing.Size(75, 23);
            this.uiActionDodaj.TabIndex = 3;
            this.uiActionDodaj.Text = "Dodaj osobu";
            this.uiActionDodaj.UseVisualStyleBackColor = true;
            this.uiActionDodaj.Click += new System.EventHandler(this.uiActionDodaj_Click);
            // 
            // uiActionSvi
            // 
            this.uiActionSvi.Location = new System.Drawing.Point(309, 12);
            this.uiActionSvi.Name = "uiActionSvi";
            this.uiActionSvi.Size = new System.Drawing.Size(75, 23);
            this.uiActionSvi.TabIndex = 6;
            this.uiActionSvi.Text = "Sve osobe";
            this.uiActionSvi.UseVisualStyleBackColor = true;
            this.uiActionSvi.Click += new System.EventHandler(this.uiActionSvi_Click);
            // 
            // uiActionPoDatumu
            // 
            this.uiActionPoDatumu.Location = new System.Drawing.Point(459, 63);
            this.uiActionPoDatumu.Name = "uiActionPoDatumu";
            this.uiActionPoDatumu.Size = new System.Drawing.Size(75, 23);
            this.uiActionPoDatumu.TabIndex = 5;
            this.uiActionPoDatumu.Text = "Po datumu";
            this.uiActionPoDatumu.UseVisualStyleBackColor = true;
            this.uiActionPoDatumu.Click += new System.EventHandler(this.uiActionPoDatumu_Click);
            // 
            // uiInputFilter
            // 
            this.uiInputFilter.Location = new System.Drawing.Point(309, 63);
            this.uiInputFilter.Name = "uiInputFilter";
            this.uiInputFilter.Size = new System.Drawing.Size(130, 20);
            this.uiInputFilter.TabIndex = 4;
            // 
            // uiOsobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 490);
            this.Controls.Add(this.uiActionPoDatumu);
            this.Controls.Add(this.uiActionSvi);
            this.Controls.Add(this.uiActionDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiInputFilter);
            this.Controls.Add(this.uiInputDatumRodenja);
            this.Controls.Add(this.uiInputPrezime);
            this.Controls.Add(this.uiInputIme);
            this.Controls.Add(this.uiOutputOsobe);
            this.Name = "uiOsobe";
            this.Text = "Osobe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uiOutputOsobe;
        private System.Windows.Forms.TextBox uiInputIme;
        private System.Windows.Forms.TextBox uiInputPrezime;
        private System.Windows.Forms.DateTimePicker uiInputDatumRodenja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.Button uiActionSvi;
        private System.Windows.Forms.Button uiActionPoDatumu;
        private System.Windows.Forms.DateTimePicker uiInputFilter;
    }
}

