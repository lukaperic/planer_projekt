namespace Planer
{
    partial class FrmPopisSlobodnihZadataka
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
            this.lstSlobodniZadaci = new System.Windows.Forms.ListBox();
            this.btnZaduziZadatak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSlobodniZadaci
            // 
            this.lstSlobodniZadaci.FormattingEnabled = true;
            this.lstSlobodniZadaci.ItemHeight = 16;
            this.lstSlobodniZadaci.Location = new System.Drawing.Point(12, 12);
            this.lstSlobodniZadaci.Name = "lstSlobodniZadaci";
            this.lstSlobodniZadaci.Size = new System.Drawing.Size(980, 404);
            this.lstSlobodniZadaci.TabIndex = 0;
            // 
            // btnZaduziZadatak
            // 
            this.btnZaduziZadatak.Location = new System.Drawing.Point(711, 474);
            this.btnZaduziZadatak.Name = "btnZaduziZadatak";
            this.btnZaduziZadatak.Size = new System.Drawing.Size(133, 35);
            this.btnZaduziZadatak.TabIndex = 1;
            this.btnZaduziZadatak.Text = "Zaduži";
            this.btnZaduziZadatak.UseVisualStyleBackColor = true;
            this.btnZaduziZadatak.Click += new System.EventHandler(this.btnZaduziZadatak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zadužite zadatak zaposleniku:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(850, 474);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(133, 35);
            this.btnOdustani.TabIndex = 3;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmPopisSlobodnihZadataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 558);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZaduziZadatak);
            this.Controls.Add(this.lstSlobodniZadaci);
            this.Name = "FrmPopisSlobodnihZadataka";
            this.Text = "Popis Slobodnih Zadataka";
            this.Load += new System.EventHandler(this.FrmPopisSlobodnihZadataka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSlobodniZadaci;
        private System.Windows.Forms.Button btnZaduziZadatak;
        private System.Windows.Forms.Button btnOdustani;
        public System.Windows.Forms.Label label1;
    }
}