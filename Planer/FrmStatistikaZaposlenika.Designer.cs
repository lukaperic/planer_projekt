namespace Planer
{
    partial class FrmStatistikaZaposlenika
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRijeseniZadatci = new System.Windows.Forms.DataGridView();
            this.zadatakRjesenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opiszadatkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrjesenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvZadatkeKojeTrebaRijesiti = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.zadatakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRijeseniZadatci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadatakRjesenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZadatkeKojeTrebaRijesiti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadatakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadatke koje je obavio: ";
            // 
            // dgvRijeseniZadatci
            // 
            this.dgvRijeseniZadatci.AutoGenerateColumns = false;
            this.dgvRijeseniZadatci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRijeseniZadatci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opiszadatkaDataGridViewTextBoxColumn,
            this.rokDataGridViewTextBoxColumn,
            this.datumrjesenjaDataGridViewTextBoxColumn});
            this.dgvRijeseniZadatci.DataSource = this.zadatakRjesenBindingSource;
            this.dgvRijeseniZadatci.Location = new System.Drawing.Point(33, 54);
            this.dgvRijeseniZadatci.Name = "dgvRijeseniZadatci";
            this.dgvRijeseniZadatci.RowTemplate.Height = 24;
            this.dgvRijeseniZadatci.Size = new System.Drawing.Size(614, 188);
            this.dgvRijeseniZadatci.TabIndex = 1;
            // 
            // zadatakRjesenBindingSource
            // 
            this.zadatakRjesenBindingSource.DataSource = typeof(Planer.Zadatak_Rjesen);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // opiszadatkaDataGridViewTextBoxColumn
            // 
            this.opiszadatkaDataGridViewTextBoxColumn.DataPropertyName = "Opis_zadatka";
            this.opiszadatkaDataGridViewTextBoxColumn.HeaderText = "Opis_zadatka";
            this.opiszadatkaDataGridViewTextBoxColumn.Name = "opiszadatkaDataGridViewTextBoxColumn";
            // 
            // rokDataGridViewTextBoxColumn
            // 
            this.rokDataGridViewTextBoxColumn.DataPropertyName = "Rok";
            this.rokDataGridViewTextBoxColumn.HeaderText = "Rok";
            this.rokDataGridViewTextBoxColumn.Name = "rokDataGridViewTextBoxColumn";
            // 
            // datumrjesenjaDataGridViewTextBoxColumn
            // 
            this.datumrjesenjaDataGridViewTextBoxColumn.DataPropertyName = "Datum_rjesenja";
            this.datumrjesenjaDataGridViewTextBoxColumn.HeaderText = "Datum_rjesenja";
            this.datumrjesenjaDataGridViewTextBoxColumn.Name = "datumrjesenjaDataGridViewTextBoxColumn";
            // 
            // dgvZadatkeKojeTrebaRijesiti
            // 
            this.dgvZadatkeKojeTrebaRijesiti.AutoGenerateColumns = false;
            this.dgvZadatkeKojeTrebaRijesiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZadatkeKojeTrebaRijesiti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvZadatkeKojeTrebaRijesiti.DataSource = this.zadatakBindingSource;
            this.dgvZadatkeKojeTrebaRijesiti.Location = new System.Drawing.Point(33, 292);
            this.dgvZadatkeKojeTrebaRijesiti.Name = "dgvZadatkeKojeTrebaRijesiti";
            this.dgvZadatkeKojeTrebaRijesiti.RowTemplate.Height = 24;
            this.dgvZadatkeKojeTrebaRijesiti.Size = new System.Drawing.Size(586, 186);
            this.dgvZadatkeKojeTrebaRijesiti.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zadatke koje treba rijesiti: ";
            // 
            // zadatakBindingSource
            // 
            this.zadatakBindingSource.DataSource = typeof(Planer.Zadatak);
            // 
            // FrmStatistikaZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 530);
            this.Controls.Add(this.dgvZadatkeKojeTrebaRijesiti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRijeseniZadatci);
            this.Controls.Add(this.label1);
            this.Name = "FrmStatistikaZaposlenika";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.FrmStatistikaZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRijeseniZadatci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadatakRjesenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZadatkeKojeTrebaRijesiti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadatakBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRijeseniZadatci;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opiszadatkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrjesenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zadatakRjesenBindingSource;
        private System.Windows.Forms.DataGridView dgvZadatkeKojeTrebaRijesiti;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource zadatakBindingSource;
        private System.Windows.Forms.Label label2;
    }
}