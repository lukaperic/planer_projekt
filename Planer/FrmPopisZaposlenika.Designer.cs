namespace Planer
{
    partial class FrmPopisZaposlenika
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
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.groupBoxDodajNovogZaposlenika = new System.Windows.Forms.GroupBox();
            this.btnZatvoriNoviZaposlenik = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickaOznaka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSpremiZaposlenika = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezimeZaposlenika = new System.Windows.Forms.TextBox();
            this.txtImeZaposlenika = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovogZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbrisiZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaduziZadatakOdabranomZaposlenikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pogledajStatistikuZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadatakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajNoviZadatakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxZadatak = new System.Windows.Forms.GroupBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodajNoviZadatak = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOpisZadatka = new System.Windows.Forms.TextBox();
            this.txtNazivZadatka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.groupBoxDodajNovogZaposlenika.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxZadatak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AutoGenerateColumns = false;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn});
            this.dgvZaposlenici.DataSource = this.zaposlenikBindingSource;
            this.dgvZaposlenici.Location = new System.Drawing.Point(66, 43);
            this.dgvZaposlenici.MultiSelect = false;
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.RowTemplate.Height = 24;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(633, 304);
            this.dgvZaposlenici.TabIndex = 0;
            // 
            // groupBoxDodajNovogZaposlenika
            // 
            this.groupBoxDodajNovogZaposlenika.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDodajNovogZaposlenika.Controls.Add(this.btnZatvoriNoviZaposlenik);
            this.groupBoxDodajNovogZaposlenika.Controls.Add(this.label3);
            this.groupBoxDodajNovogZaposlenika.Controls.Add(this.txtLozinka);
            this.groupBoxDodajNovogZaposlenika.Controls.Add(this.txtKorisnickaOznaka);
            this.groupBoxDodajNovogZaposlenika.Controls.Add(this.label4);
            this.groupBoxDodajNovogZaposlenika.Controls.Add(this.btnSpremiZaposlenika);
            this.groupBoxDodajNovogZaposlenika.Controls.Add(this.label2);
            this.groupBoxDodajNovogZaposlenika.Controls.Add(this.txtPrezimeZaposlenika);
            this.groupBoxDodajNovogZaposlenika.Controls.Add(this.txtImeZaposlenika);
            this.groupBoxDodajNovogZaposlenika.Controls.Add(this.label1);
            this.groupBoxDodajNovogZaposlenika.Location = new System.Drawing.Point(66, 353);
            this.groupBoxDodajNovogZaposlenika.Name = "groupBoxDodajNovogZaposlenika";
            this.groupBoxDodajNovogZaposlenika.Size = new System.Drawing.Size(423, 248);
            this.groupBoxDodajNovogZaposlenika.TabIndex = 4;
            this.groupBoxDodajNovogZaposlenika.TabStop = false;
            this.groupBoxDodajNovogZaposlenika.Text = "Novi zaposlenik";
            // 
            // btnZatvoriNoviZaposlenik
            // 
            this.btnZatvoriNoviZaposlenik.Location = new System.Drawing.Point(323, 211);
            this.btnZatvoriNoviZaposlenik.Name = "btnZatvoriNoviZaposlenik";
            this.btnZatvoriNoviZaposlenik.Size = new System.Drawing.Size(94, 27);
            this.btnZatvoriNoviZaposlenik.TabIndex = 10;
            this.btnZatvoriNoviZaposlenik.Text = "Zatvori";
            this.btnZatvoriNoviZaposlenik.UseVisualStyleBackColor = true;
            this.btnZatvoriNoviZaposlenik.Click += new System.EventHandler(this.btnZatvoriNoviZaposlenik_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Unesi lozinku: ";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(197, 158);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(137, 22);
            this.txtLozinka.TabIndex = 8;
            // 
            // txtKorisnickaOznaka
            // 
            this.txtKorisnickaOznaka.Location = new System.Drawing.Point(197, 124);
            this.txtKorisnickaOznaka.Name = "txtKorisnickaOznaka";
            this.txtKorisnickaOznaka.Size = new System.Drawing.Size(137, 22);
            this.txtKorisnickaOznaka.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unesi korisnicku oznaku: ";
            // 
            // btnSpremiZaposlenika
            // 
            this.btnSpremiZaposlenika.Location = new System.Drawing.Point(25, 206);
            this.btnSpremiZaposlenika.Name = "btnSpremiZaposlenika";
            this.btnSpremiZaposlenika.Size = new System.Drawing.Size(125, 36);
            this.btnSpremiZaposlenika.TabIndex = 5;
            this.btnSpremiZaposlenika.Text = "Dodaj";
            this.btnSpremiZaposlenika.UseVisualStyleBackColor = true;
            this.btnSpremiZaposlenika.Click += new System.EventHandler(this.btnSpremiZaposlenika_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unesi prezime:";
            // 
            // txtPrezimeZaposlenika
            // 
            this.txtPrezimeZaposlenika.Location = new System.Drawing.Point(197, 87);
            this.txtPrezimeZaposlenika.Name = "txtPrezimeZaposlenika";
            this.txtPrezimeZaposlenika.Size = new System.Drawing.Size(137, 22);
            this.txtPrezimeZaposlenika.TabIndex = 2;
            // 
            // txtImeZaposlenika
            // 
            this.txtImeZaposlenika.Location = new System.Drawing.Point(197, 53);
            this.txtImeZaposlenika.Name = "txtImeZaposlenika";
            this.txtImeZaposlenika.Size = new System.Drawing.Size(137, 22);
            this.txtImeZaposlenika.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesi ime: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposleniciToolStripMenuItem,
            this.zadatakToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1204, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovogZaposlenikaToolStripMenuItem,
            this.izbrisiZaposlenikaToolStripMenuItem,
            this.zaduziZadatakOdabranomZaposlenikuToolStripMenuItem,
            this.pogledajStatistikuZaposlenikaToolStripMenuItem});
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            // 
            // dodajNovogZaposlenikaToolStripMenuItem
            // 
            this.dodajNovogZaposlenikaToolStripMenuItem.Name = "dodajNovogZaposlenikaToolStripMenuItem";
            this.dodajNovogZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.dodajNovogZaposlenikaToolStripMenuItem.Text = "Dodaj novog zaposlenika";
            this.dodajNovogZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.dodajNovogZaposlenikaToolStripMenuItem_Click);
            // 
            // izbrisiZaposlenikaToolStripMenuItem
            // 
            this.izbrisiZaposlenikaToolStripMenuItem.Name = "izbrisiZaposlenikaToolStripMenuItem";
            this.izbrisiZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.izbrisiZaposlenikaToolStripMenuItem.Text = "Izbrisi zaposlenika";
            this.izbrisiZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.izbrisiZaposlenikaToolStripMenuItem_Click);
            // 
            // zaduziZadatakOdabranomZaposlenikuToolStripMenuItem
            // 
            this.zaduziZadatakOdabranomZaposlenikuToolStripMenuItem.Name = "zaduziZadatakOdabranomZaposlenikuToolStripMenuItem";
            this.zaduziZadatakOdabranomZaposlenikuToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.zaduziZadatakOdabranomZaposlenikuToolStripMenuItem.Text = "Zaduzi zadatak odabranom zaposleniku";
            this.zaduziZadatakOdabranomZaposlenikuToolStripMenuItem.Click += new System.EventHandler(this.zaduziZadatakOdabranomZaposlenikuToolStripMenuItem_Click);
            // 
            // pogledajStatistikuZaposlenikaToolStripMenuItem
            // 
            this.pogledajStatistikuZaposlenikaToolStripMenuItem.Name = "pogledajStatistikuZaposlenikaToolStripMenuItem";
            this.pogledajStatistikuZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.pogledajStatistikuZaposlenikaToolStripMenuItem.Text = "Pogledaj statistiku zaposlenika";
            this.pogledajStatistikuZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.pogledajStatistikuZaposlenikaToolStripMenuItem_Click);
            // 
            // zadatakToolStripMenuItem
            // 
            this.zadatakToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajNoviZadatakToolStripMenuItem});
            this.zadatakToolStripMenuItem.Name = "zadatakToolStripMenuItem";
            this.zadatakToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.zadatakToolStripMenuItem.Text = "Zadatak";
            // 
            // kreirajNoviZadatakToolStripMenuItem
            // 
            this.kreirajNoviZadatakToolStripMenuItem.Name = "kreirajNoviZadatakToolStripMenuItem";
            this.kreirajNoviZadatakToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.kreirajNoviZadatakToolStripMenuItem.Text = "Kreiraj novi zadatak";
            this.kreirajNoviZadatakToolStripMenuItem.Click += new System.EventHandler(this.kreirajNoviZadatakToolStripMenuItem_Click);
            // 
            // groupBoxZadatak
            // 
            this.groupBoxZadatak.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxZadatak.Controls.Add(this.btnZatvori);
            this.groupBoxZadatak.Controls.Add(this.dateTimePicker1);
            this.groupBoxZadatak.Controls.Add(this.label6);
            this.groupBoxZadatak.Controls.Add(this.btnDodajNoviZadatak);
            this.groupBoxZadatak.Controls.Add(this.label7);
            this.groupBoxZadatak.Controls.Add(this.txtOpisZadatka);
            this.groupBoxZadatak.Controls.Add(this.txtNazivZadatka);
            this.groupBoxZadatak.Controls.Add(this.label8);
            this.groupBoxZadatak.Location = new System.Drawing.Point(718, 43);
            this.groupBoxZadatak.Name = "groupBoxZadatak";
            this.groupBoxZadatak.Size = new System.Drawing.Size(423, 248);
            this.groupBoxZadatak.TabIndex = 10;
            this.groupBoxZadatak.TabStop = false;
            this.groupBoxZadatak.Text = "Novi zadatak:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(277, 212);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(94, 27);
            this.btnZatvori.TabIndex = 9;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Unesi rok: ";
            // 
            // btnDodajNoviZadatak
            // 
            this.btnDodajNoviZadatak.Location = new System.Drawing.Point(19, 206);
            this.btnDodajNoviZadatak.Name = "btnDodajNoviZadatak";
            this.btnDodajNoviZadatak.Size = new System.Drawing.Size(172, 36);
            this.btnDodajNoviZadatak.TabIndex = 5;
            this.btnDodajNoviZadatak.Text = "Dodaj novi zadatak";
            this.btnDodajNoviZadatak.UseVisualStyleBackColor = true;
            this.btnDodajNoviZadatak.Click += new System.EventHandler(this.btnDodajNoviZadatak_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Unesi opis zadatka:";
            // 
            // txtOpisZadatka
            // 
            this.txtOpisZadatka.Location = new System.Drawing.Point(197, 87);
            this.txtOpisZadatka.Multiline = true;
            this.txtOpisZadatka.Name = "txtOpisZadatka";
            this.txtOpisZadatka.Size = new System.Drawing.Size(162, 76);
            this.txtOpisZadatka.TabIndex = 2;
            // 
            // txtNazivZadatka
            // 
            this.txtNazivZadatka.Location = new System.Drawing.Point(197, 53);
            this.txtNazivZadatka.Name = "txtNazivZadatka";
            this.txtNazivZadatka.Size = new System.Drawing.Size(137, 22);
            this.txtNazivZadatka.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Unesi naziv zadatka: ";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(Planer.Zaposlenik);
            // 
            // FrmPopisZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Planer.Properties.Resources.Untitled4;
            this.ClientSize = new System.Drawing.Size(1204, 666);
            this.Controls.Add(this.groupBoxZadatak);
            this.Controls.Add(this.groupBoxDodajNovogZaposlenika);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPopisZaposlenika";
            this.Text = "FrmZaposlenici";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPopisZaposlenika_FormClosed);
            this.Load += new System.EventHandler(this.FrmAdministrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.groupBoxDodajNovogZaposlenika.ResumeLayout(false);
            this.groupBoxDodajNovogZaposlenika.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxZadatak.ResumeLayout(false);
            this.groupBoxZadatak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxDodajNovogZaposlenika;
        private System.Windows.Forms.Button btnSpremiZaposlenika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezimeZaposlenika;
        private System.Windows.Forms.TextBox txtImeZaposlenika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovogZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izbrisiZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnickaOznaka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem zadatakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajNoviZadatakToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxZadatak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDodajNoviZadatak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOpisZadatka;
        private System.Windows.Forms.TextBox txtNazivZadatka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnZatvoriNoviZaposlenik;
        private System.Windows.Forms.ToolStripMenuItem zaduziZadatakOdabranomZaposlenikuToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.ToolStripMenuItem pogledajStatistikuZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
    }
}