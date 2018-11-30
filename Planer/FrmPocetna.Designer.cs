namespace Planer
{
    partial class FrmPocetna
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.btnZaposlenik = new System.Windows.Forms.Button();
            this.korisnickaPodrska = new System.Windows.Forms.HelpProvider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prijavi se kao: ";
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.BackgroundImage = global::Planer.Properties.Resources.Untitled5;
            this.btnAdministrator.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrator.Location = new System.Drawing.Point(97, 118);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(198, 60);
            this.btnAdministrator.TabIndex = 1;
            this.btnAdministrator.Text = "Administrator";
            this.btnAdministrator.UseVisualStyleBackColor = true;
            this.btnAdministrator.Click += new System.EventHandler(this.btnAdministrator_Click_1);
            // 
            // btnZaposlenik
            // 
            this.btnZaposlenik.BackgroundImage = global::Planer.Properties.Resources.Untitled5;
            this.btnZaposlenik.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaposlenik.Location = new System.Drawing.Point(316, 118);
            this.btnZaposlenik.Name = "btnZaposlenik";
            this.btnZaposlenik.Size = new System.Drawing.Size(198, 60);
            this.btnZaposlenik.TabIndex = 2;
            this.btnZaposlenik.Text = "Zaposlenik";
            this.btnZaposlenik.UseVisualStyleBackColor = true;
            this.btnZaposlenik.Click += new System.EventHandler(this.btnZaposlenik_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Planer.Properties.Resources.bar_chart__2_;
            this.pictureBox1.Location = new System.Drawing.Point(316, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 106);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Planer.Properties.Resources.Untitled4;
            this.ClientSize = new System.Drawing.Size(606, 323);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnZaposlenik);
            this.Controls.Add(this.btnAdministrator);
            this.Controls.Add(this.label1);
            this.Name = "FrmPocetna";
            this.Text = "FrmPocetna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdministrator;
        private System.Windows.Forms.Button btnZaposlenik;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HelpProvider korisnickaPodrska;
    }
}