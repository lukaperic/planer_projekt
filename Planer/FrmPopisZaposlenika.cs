using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Connection;

namespace Planer
{
    public partial class FrmPopisZaposlenika : Form
    {
        List<Zaposlenik> listaZaposlenika;
        public Button btnAdministrator;
       
        public FrmPopisZaposlenika(Button btn)
        {
            btnAdministrator = btn;
            btnAdministrator.Enabled = false;
            InitializeComponent();
            listaZaposlenika = new List<Zaposlenik>();
           
        }
        
        private void FrmAdministrator_Load(object sender, EventArgs e)
        {
            
            PrikaziZaposlenike();
            groupBoxDodajNovogZaposlenika.Hide();
            groupBoxZadatak.Hide();
        }

        private void PrikaziZaposlenike()
        {           
            Veza newConnection = new Veza();         
            string query = "select * from Zaposlenici";
            SqlDataReader reader = newConnection.SelectZaposlenici(query);
            while (reader.Read())
            {             
                int id = Convert.ToInt32(reader["ID"].ToString());                
                string ime_zaposlenika = reader["Ime"].ToString();
                string prezime_zaposlenika = reader["Prezime"].ToString();
                Zaposlenik zaposlenik = new Zaposlenik(id, ime_zaposlenika, prezime_zaposlenika);
                listaZaposlenika.Add(zaposlenik);
            }

            dgvZaposlenici.DataSource = "";
            dgvZaposlenici.DataSource = listaZaposlenika;
            newConnection.Close();

        }

        private void btnSpremiZaposlenika_Click(object sender, EventArgs e)
        {
            if(txtImeZaposlenika.Text!="" && txtPrezimeZaposlenika.Text!="" && txtKorisnickaOznaka.Text!="" && txtLozinka.Text!="")
            {
                Veza newConnection = new Veza();
                string query = "Insert into Zaposlenici(ime,prezime,korisnicka_oznaka,lozinka) VALUES ('" + txtImeZaposlenika.Text + "','" + txtPrezimeZaposlenika.Text + "','" + txtKorisnickaOznaka.Text + "','" + txtLozinka.Text + "')";
                newConnection.DodajNovogZaposlenika(query);
                newConnection.Close();
                listaZaposlenika.Clear();
                PrikaziZaposlenike();
                groupBoxDodajNovogZaposlenika.Hide();
            }
            else
            {
                MessageBox.Show("Upisite ime i prezime zaposlenika");
            }        
        }

        

        private void dodajNovogZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxDodajNovogZaposlenika.Show();
        }

        private void izbrisiZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = dgvZaposlenici.CurrentCell.RowIndex;
            if (row != null)
            {
                string id_zaposlenika = dgvZaposlenici.Rows[row].Cells[0].Value.ToString();
                Veza newConnection = new Veza();
                string query = "DELETE FROM Zaposlenici WHERE ID = " + id_zaposlenika;
                newConnection.IzbrisiZaposlenika(query);
                newConnection.Close();
                listaZaposlenika.Clear();
                PrikaziZaposlenike();

            }
            else
            {
                MessageBox.Show("Prvo odaberite zaposlenika kojeg zelite izbrisati");
            }
        }

        private void kreirajNoviZadatakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxZadatak.Show();          
        }

        private void btnDodajNoviZadatak_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            if (txtNazivZadatka.Text!="" && txtOpisZadatka.Text!="" && dateTimePicker1.Value >= today)
            {
                Veza newConnection = new Veza();
                string query = "Insert into Zadatci(naziv,opis_zadatka,rok) VALUES ('" + txtNazivZadatka.Text + "','" + txtOpisZadatka.Text + "','" + dateTimePicker1.Value + "')";
                newConnection.DodajNoviZadatak(query);
                newConnection.Close();
                groupBoxZadatak.Hide();
            }
            else
            {
                MessageBox.Show("Pogresan unos podataka");
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            groupBoxZadatak.Hide();
        }

        private void btnZatvoriNoviZaposlenik_Click(object sender, EventArgs e)
        {
            groupBoxDodajNovogZaposlenika.Hide();
        }

        private void zaduziZadatakOdabranomZaposlenikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = dgvZaposlenici.CurrentCell.RowIndex;
            if (row != null)
            {
                string ime_zaposlenika = dgvZaposlenici.Rows[row].Cells[1].Value.ToString();
                string id_zaposlenika = dgvZaposlenici.Rows[row].Cells[0].Value.ToString();
                FrmPopisSlobodnihZadataka frmPopisSlobodnihZadataka = new FrmPopisSlobodnihZadataka(id_zaposlenika);
                frmPopisSlobodnihZadataka.label1.Text += ime_zaposlenika;
                frmPopisSlobodnihZadataka.Show();
            }
            else
            {
                MessageBox.Show("Prvo odaberite zaposlenika kojem zelite dodijeliti zadatak");
            }
        }

        private void FrmPopisZaposlenika_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnAdministrator.Enabled = true;
        }

        private void pogledajStatistikuZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = dgvZaposlenici.CurrentCell.RowIndex;
            int id_zaposlenika = int.Parse(dgvZaposlenici.Rows[row].Cells[0].Value.ToString());
            FrmStatistikaZaposlenika frm = new FrmStatistikaZaposlenika(id_zaposlenika);
            frm.Show();
        }
    }
}
