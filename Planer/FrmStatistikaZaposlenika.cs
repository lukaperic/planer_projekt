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
    public partial class FrmStatistikaZaposlenika : Form
    {
        int id_zaposlenika;
        List<Zadatak> listaZadatakaKojeTrebaRijesiti;
        List<Zadatak_Rjesen> listaRijesenihZadataka;

        public FrmStatistikaZaposlenika(int zaposlenik_id)
        {
            id_zaposlenika = zaposlenik_id;
            listaZadatakaKojeTrebaRijesiti = new List<Zadatak>();
            listaRijesenihZadataka = new List<Zadatak_Rjesen>();
            InitializeComponent();
        }

        private void FrmStatistikaZaposlenika_Load(object sender, EventArgs e)
        {
            PrikaziStatistikuRijesenihZadataka();
            PrikaziStatistikuZadatakKojeTrebaRijesiti();
            
        }

        private void PrikaziStatistikuZadatakKojeTrebaRijesiti()
        {
            listaZadatakaKojeTrebaRijesiti.Clear();
            Veza newConnection = new Veza();
            string query = "select Zadatci.ID, Zadatci.naziv, Zadatci.opis_zadatka, Zadatci.rok FROM Zadatci JOIN Zaduzio ON Zadatci.ID=Zaduzio.ID_zadatka where Zaduzio.ID_zaposlenika = " + id_zaposlenika + " and  Zaduzio.ID_zadatka not in ( select RijeseniZadatci.id_zadatak from RijeseniZadatci)   ";


            SqlDataReader reader = newConnection.SelectAdministrator(query);
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["ID"].ToString());
                string naziv = reader["naziv"].ToString();
                string opis_zadatka = reader["opis_zadatka"].ToString();
                string rok = reader["rok"].ToString();

                Zadatak zadatak = new Zadatak();
                zadatak.Id = id;
                zadatak.Naziv = naziv;
                zadatak.Opis_zadatka = opis_zadatka;
                zadatak.Rok = rok;

                listaZadatakaKojeTrebaRijesiti.Add(zadatak);

            }
            newConnection.Close();
            dgvZadatkeKojeTrebaRijesiti.DataSource = "";
            dgvZadatkeKojeTrebaRijesiti.DataSource = listaZadatakaKojeTrebaRijesiti;
        }

        private void PrikaziStatistikuRijesenihZadataka()
        {
            Veza newConnection = new Veza();
            string query =  @"SELECT Zadatci.ID, Zadatci.naziv, Zadatci.opis_zadatka,Zadatci.rok, RijeseniZadatci.datum_rjesenja 
            FROM Zaduzio JOIN Zadatci on Zaduzio.ID_zadatka = Zadatci.ID
            JOIN RijeseniZadatci on Zaduzio.ID_zadatka = RijeseniZadatci.id_zadatak
            and Zaduzio.ID_zaposlenika = RijeseniZadatci.id_zaposlenik WHERE Zaduzio.ID_zaposlenika = " + id_zaposlenika;
            SqlDataReader reader = newConnection.SelectAdministrator(query);
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["ID"].ToString());
                string naziv = reader["naziv"].ToString();
                string opis_zadatka = reader["opis_zadatka"].ToString();
                string rok = reader["rok"].ToString();
                string datum_rjesenja = reader["datum_rjesenja"].ToString();
                Zadatak_Rjesen zadatak = new Zadatak_Rjesen();
                zadatak.Id = id;
                zadatak.Naziv = naziv;
                zadatak.Opis_zadatka = opis_zadatka;
                zadatak.Rok = rok;
                zadatak.Datum_rjesenja = datum_rjesenja;
                listaRijesenihZadataka.Add(zadatak);
            }
            newConnection.Close();
            dgvRijeseniZadatci.DataSource = "";
            dgvRijeseniZadatci.DataSource = listaRijesenihZadataka;

        }
    }
}
