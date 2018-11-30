namespace Planer
{
    partial class FrmProfilZaposlenika
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
            this.dgvPopisZadataka = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opiszadatkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zadatakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPopisRjesenihZadataka = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opiszadatkaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrjesenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zadatakRjesenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPopisZadatakaKojeTrebaRijesiti = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_rjesenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rijeseno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.zadatakBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zadatakRjesenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZadataka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadatakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisRjesenihZadataka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadatakRjesenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZadatakaKojeTrebaRijesiti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadatakBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadatakRjesenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisZadataka
            // 
            this.dgvPopisZadataka.AutoGenerateColumns = false;
            this.dgvPopisZadataka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisZadataka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opiszadatkaDataGridViewTextBoxColumn,
            this.rokDataGridViewTextBoxColumn});
            this.dgvPopisZadataka.DataSource = this.zadatakBindingSource;
            this.dgvPopisZadataka.Location = new System.Drawing.Point(12, 35);
            this.dgvPopisZadataka.Name = "dgvPopisZadataka";
            this.dgvPopisZadataka.ReadOnly = true;
            this.dgvPopisZadataka.RowTemplate.Height = 24;
            this.dgvPopisZadataka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisZadataka.Size = new System.Drawing.Size(569, 242);
            this.dgvPopisZadataka.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opiszadatkaDataGridViewTextBoxColumn
            // 
            this.opiszadatkaDataGridViewTextBoxColumn.DataPropertyName = "Opis_zadatka";
            this.opiszadatkaDataGridViewTextBoxColumn.HeaderText = "Opis_zadatka";
            this.opiszadatkaDataGridViewTextBoxColumn.Name = "opiszadatkaDataGridViewTextBoxColumn";
            this.opiszadatkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.opiszadatkaDataGridViewTextBoxColumn.Width = 120;
            // 
            // rokDataGridViewTextBoxColumn
            // 
            this.rokDataGridViewTextBoxColumn.DataPropertyName = "Rok";
            this.rokDataGridViewTextBoxColumn.HeaderText = "Rok";
            this.rokDataGridViewTextBoxColumn.Name = "rokDataGridViewTextBoxColumn";
            this.rokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zadatakBindingSource
            // 
            this.zadatakBindingSource.DataSource = typeof(Planer.Zadatak);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis svih zadataka koje sam zaduzen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Popis zadataka koje sam rijesio:";
            // 
            // dgvPopisRjesenihZadataka
            // 
            this.dgvPopisRjesenihZadataka.AutoGenerateColumns = false;
            this.dgvPopisRjesenihZadataka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisRjesenihZadataka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.opiszadatkaDataGridViewTextBoxColumn1,
            this.rokDataGridViewTextBoxColumn1,
            this.datumrjesenjaDataGridViewTextBoxColumn});
            this.dgvPopisRjesenihZadataka.DataSource = this.zadatakRjesenBindingSource1;
            this.dgvPopisRjesenihZadataka.GridColor = System.Drawing.Color.LightGreen;
            this.dgvPopisRjesenihZadataka.Location = new System.Drawing.Point(15, 322);
            this.dgvPopisRjesenihZadataka.Name = "dgvPopisRjesenihZadataka";
            this.dgvPopisRjesenihZadataka.ReadOnly = true;
            this.dgvPopisRjesenihZadataka.RowTemplate.Height = 24;
            this.dgvPopisRjesenihZadataka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisRjesenihZadataka.Size = new System.Drawing.Size(657, 245);
            this.dgvPopisRjesenihZadataka.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            this.nazivDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // opiszadatkaDataGridViewTextBoxColumn1
            // 
            this.opiszadatkaDataGridViewTextBoxColumn1.DataPropertyName = "Opis_zadatka";
            this.opiszadatkaDataGridViewTextBoxColumn1.HeaderText = "Opis_zadatka";
            this.opiszadatkaDataGridViewTextBoxColumn1.Name = "opiszadatkaDataGridViewTextBoxColumn1";
            this.opiszadatkaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rokDataGridViewTextBoxColumn1
            // 
            this.rokDataGridViewTextBoxColumn1.DataPropertyName = "Rok";
            this.rokDataGridViewTextBoxColumn1.HeaderText = "Rok";
            this.rokDataGridViewTextBoxColumn1.Name = "rokDataGridViewTextBoxColumn1";
            this.rokDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // datumrjesenjaDataGridViewTextBoxColumn
            // 
            this.datumrjesenjaDataGridViewTextBoxColumn.DataPropertyName = "Datum_rjesenja";
            this.datumrjesenjaDataGridViewTextBoxColumn.HeaderText = "Datum_rjesenja";
            this.datumrjesenjaDataGridViewTextBoxColumn.Name = "datumrjesenjaDataGridViewTextBoxColumn";
            this.datumrjesenjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zadatakRjesenBindingSource1
            // 
            this.zadatakRjesenBindingSource1.DataSource = typeof(Planer.Zadatak_Rjesen);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Popis zadataka koje trebam rijesiti:";
            // 
            // dgvPopisZadatakaKojeTrebaRijesiti
            // 
            this.dgvPopisZadatakaKojeTrebaRijesiti.AutoGenerateColumns = false;
            this.dgvPopisZadatakaKojeTrebaRijesiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisZadatakaKojeTrebaRijesiti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.datum_rjesenja,
            this.Rijeseno});
            this.dgvPopisZadatakaKojeTrebaRijesiti.DataSource = this.zadatakBindingSource;
            this.dgvPopisZadatakaKojeTrebaRijesiti.GridColor = System.Drawing.Color.Red;
            this.dgvPopisZadatakaKojeTrebaRijesiti.Location = new System.Drawing.Point(590, 35);
            this.dgvPopisZadatakaKojeTrebaRijesiti.Name = "dgvPopisZadatakaKojeTrebaRijesiti";
            this.dgvPopisZadatakaKojeTrebaRijesiti.RowTemplate.Height = 24;
            this.dgvPopisZadatakaKojeTrebaRijesiti.Size = new System.Drawing.Size(657, 245);
            this.dgvPopisZadatakaKojeTrebaRijesiti.TabIndex = 4;
            this.dgvPopisZadatakaKojeTrebaRijesiti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPopisZadatakaKojeTrebaRijesiti_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Opis_zadatka";
            this.dataGridViewTextBoxColumn3.HeaderText = "Opis_zadatka";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Rok";
            this.dataGridViewTextBoxColumn4.HeaderText = "Rok";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // datum_rjesenja
            // 
            this.datum_rjesenja.HeaderText = "datum_rjesenja";
            this.datum_rjesenja.Name = "datum_rjesenja";
            // 
            // Rijeseno
            // 
            this.Rijeseno.HeaderText = "Rijeseno";
            this.Rijeseno.Name = "Rijeseno";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(1157, 296);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(90, 30);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // zadatakBindingSource1
            // 
            this.zadatakBindingSource1.DataSource = typeof(Planer.Zadatak);
            // 
            // zadatakRjesenBindingSource
            // 
            this.zadatakRjesenBindingSource.DataSource = typeof(Planer.Zadatak_Rjesen);
            // 
            // FrmProfilZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 746);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPopisZadatakaKojeTrebaRijesiti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPopisRjesenihZadataka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPopisZadataka);
            this.Name = "FrmProfilZaposlenika";
            this.Text = "Moj profil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProfilZaposlenika_FormClosed);
            this.Load += new System.EventHandler(this.FrmProfilZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZadataka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadatakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisRjesenihZadataka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadatakRjesenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZadatakaKojeTrebaRijesiti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadatakBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadatakRjesenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisZadataka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opiszadatkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zadatakBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPopisRjesenihZadataka;
        private System.Windows.Forms.BindingSource zadatakBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn opiszadatkaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrjesenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zadatakRjesenBindingSource1;
        private System.Windows.Forms.BindingSource zadatakRjesenBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPopisZadatakaKojeTrebaRijesiti;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_rjesenja;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Rijeseno;
    }
}