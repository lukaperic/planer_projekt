using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Connection;
using System.Windows.Forms;
 

namespace Planer
{
    public partial class FrmPopisSlobodnihZadataka : Form
    {
        string id_zaposlenika; 

        public FrmPopisSlobodnihZadataka(string id_zaposlenik)
        {
            InitializeComponent();
            id_zaposlenika = id_zaposlenik;
        }

        private void FrmPopisSlobodnihZadataka_Load(object sender, EventArgs e)
        {
           
            PrikaziPopisSlobodnihZadataka();
        }

        private void PrikaziPopisSlobodnihZadataka()
        {
          
            Veza newConnection = new Veza();
            string query = "SELECT * FROM Zadatci WHERE Zadatci.ID NOT IN (Select Zadatci.ID from Zaduzio, Zadatci where Zadatci.ID=Zaduzio.ID_zadatka)";
            SqlDataReader reader = newConnection.SelectZaposlenici(query);
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["ID"].ToString());
                string naziv = reader["naziv"].ToString();
                string opis_zadatka = reader["opis_zadatka"].ToString();
                string rok = reader["rok"].ToString();
                string[] datum = rok.Split(' ');
                lstSlobodniZadaci.Items.Add(id + " " + naziv + " " + opis_zadatka + " " + datum[0]);
            }
            newConnection.Close();
        }

        private void btnZaduziZadatak_Click(object sender, EventArgs e)
        {
            if (lstSlobodniZadaci.SelectedIndex >= 0)
            {
                string id_zadatak = lstSlobodniZadaci.SelectedItem.ToString();
                char zadatak_id = id_zadatak[0];
                Veza newConnection = new Veza();
                string query = "Insert into Zaduzio(ID_zaposlenika,ID_zadatka) VALUES ('" + id_zaposlenika + "','" + zadatak_id + "')";
                newConnection.DodajNovoZaduzenje(query);            
                newConnection.Close();
                lstSlobodniZadaci.Items.Clear();
                PrikaziPopisSlobodnihZadataka();

            }
            else
            {
                MessageBox.Show("Odaberite zadatak koji zelite zaduziti zaposleniku");

            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
