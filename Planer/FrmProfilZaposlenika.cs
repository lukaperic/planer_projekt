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
    public partial class FrmProfilZaposlenika : Form
    {

        //Za datum_rjesenja
        DateTimePicker _datePicker = new DateTimePicker();  //step 1

        int Id_zaposlenika;
        public Button btnZaposlenik;      
        public List<int> listaIdZadatakaKojiSuRijeseni;

        List<Zadatak> listaZadataka;
        List<Zadatak> listaZadatakaKojeTrebaRijesiti;
        List<Zadatak_Rjesen> listaRijesenihZadataka;
       
        public FrmProfilZaposlenika(int id_zaposlenika, Button btn)
        {
           
            InitializeComponent();
            btnZaposlenik = btn;
            btnZaposlenik.Enabled = false;
            listaZadataka = new List<Zadatak>();
            listaZadatakaKojeTrebaRijesiti = new List<Zadatak>();
            listaRijesenihZadataka = new List<Zadatak_Rjesen>();
            listaIdZadatakaKojiSuRijeseni = new List<int>();
            Id_zaposlenika = id_zaposlenika;

           

        }

        private void FrmProfilZaposlenika_Load(object sender, EventArgs e)
        {
            OtvoriVezuIPrikaziPopisSvihZadataka();
            Prikazi_Popis_Rjesenih_Zadataka();
            Prikazi_Popis_Zadataka_Koje_Treba_Rijesiti();
            PostaviPocetnuVrijednostDatuma();

            //datum_rjesenja step 4
            _datePicker.Visible = false;
            _datePicker.CustomFormat = "dd/MM/yyyy";
            _datePicker.ValueChanged += dg1_ValueChanged;

            //dgvPopisZadatakaKojeTrebaRijesiti.Dock = DockStyle.Fill;
            dgvPopisZadatakaKojeTrebaRijesiti.Controls.Add(_datePicker);
            dgvPopisZadatakaKojeTrebaRijesiti.CellClick += dgvPopisZadatakaKojeTrebaRijesiti_CellClick;
        }

        
        public void OtvoriVezuIPrikaziPopisSvihZadataka()
        {
            Veza newConnection = new Veza();
            string query = "select Zadatci.ID, Zadatci.naziv, Zadatci.opis_zadatka, Zadatci.rok FROM Zadatci JOIN Zaduzio ON Zaduzio.ID_zadatka=Zadatci.ID WHERE Zaduzio.ID_zaposlenika = " + Id_zaposlenika + "";
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
                listaZadataka.Add(zadatak);               
            }
            newConnection.Close();
            dgvPopisZadataka.DataSource = "";
            dgvPopisZadataka.DataSource = listaZadataka;
        }

        private void Prikazi_Popis_Rjesenih_Zadataka()
        {
            listaRijesenihZadataka.Clear();
            Veza newConnection = new Veza();
            string query = "SELECT Zadatci.ID, Zadatci.naziv, Zadatci.opis_zadatka, Zadatci.rok, RijeseniZadatci.datum_rjesenja FROM Zaduzio JOIN Zadatci ON Zaduzio.ID_zadatka = Zadatci.ID  JOIN RijeseniZadatci ON Zaduzio.ID_zadatka = RijeseniZadatci.id_zadatak and Zaduzio.ID_zaposlenika = RijeseniZadatci.id_zaposlenik WHERE RijeseniZadatci.id_zaposlenik =  " + Id_zaposlenika +  ""; 


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
            dgvPopisRjesenihZadataka.DataSource = "";
            dgvPopisRjesenihZadataka.DataSource = listaRijesenihZadataka;
        }

        private void Prikazi_Popis_Zadataka_Koje_Treba_Rijesiti()
        {
            listaZadatakaKojeTrebaRijesiti.Clear();
            Veza newConnection = new Veza();
            string query = "select Zadatci.ID, Zadatci.naziv, Zadatci.opis_zadatka, Zadatci.rok FROM Zadatci JOIN Zaduzio ON Zadatci.ID=Zaduzio.ID_zadatka where Zaduzio.ID_zaposlenika = " + Id_zaposlenika +  " and  Zaduzio.ID_zadatka not in ( select RijeseniZadatci.id_zadatak from RijeseniZadatci)   ";


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
            dgvPopisZadatakaKojeTrebaRijesiti.DataSource = "";
            dgvPopisZadatakaKojeTrebaRijesiti.DataSource = listaZadatakaKojeTrebaRijesiti;
            PostaviPocetnuVrijednostDatuma();

        }

        private void FrmProfilZaposlenika_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnZaposlenik.Enabled = true;        
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            listaIdZadatakaKojiSuRijeseni.Clear();
            string tekst="";
            foreach (DataGridViewRow row in dgvPopisZadatakaKojeTrebaRijesiti.Rows)
            { 
                if (((Convert.ToBoolean(row.Cells[5].Value) == true)))
                {
                    int ID_zadatak =  (int)row.Cells[0].Value;
                    listaIdZadatakaKojiSuRijeseni.Add(ID_zadatak);
                }                
            }
            for(int i=0;i<listaIdZadatakaKojiSuRijeseni.Count;i++)
            {
                if (i < listaIdZadatakaKojiSuRijeseni.Count - 1)
                    tekst += listaIdZadatakaKojiSuRijeseni[i].ToString() + ",";
                else
                    tekst += listaIdZadatakaKojiSuRijeseni[i].ToString();
            }
            
            if(listaIdZadatakaKojiSuRijeseni.Count>0)
            {
                DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da zelite oznaciti zadatke sa ID-om: " + tekst + " rjesenim", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Spremi();
                    MessageBox.Show("Spremljeno");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            else
            {
                MessageBox.Show("Niste oznacili rijesenim niti jedan zadatak");
            }
            



        }
        DateTime datum;
        int zadatak;
        private void Spremi()
        {
            foreach (DataGridViewRow row in dgvPopisZadatakaKojeTrebaRijesiti.Rows)
            {
                int ID_zadatak = (int)row.Cells[0].Value;
                if (listaIdZadatakaKojiSuRijeseni.Contains(ID_zadatak) &&  ((Convert.ToBoolean(row.Cells[5].Value) == true)))
                {
                    zadatak = ID_zadatak;
                    datum = Convert.ToDateTime(row.Cells[4].Value);                 
                    Spremi_Promjene(zadatak, datum);
                }            
            }
            Prikazi_Popis_Rjesenih_Zadataka();
            Prikazi_Popis_Zadataka_Koje_Treba_Rijesiti();
        }

        private void Spremi_Promjene(int zadatak_id,DateTime datumRjesenja)
        {
            using (SqlConnection conn = new SqlConnection("data source = DESKTOP-D01K7H6\\SQLEXPRESS;database = Planer;integrated security = SSPI;"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO RijeseniZadatci(id_zaposlenik, id_zadatak, datum_rjesenja)
                            VALUES(@param1, @param2, @param3)";

                    cmd.Parameters.AddWithValue("@param1", Id_zaposlenika);
                    cmd.Parameters.AddWithValue("@param2", zadatak_id);
                    cmd.Parameters.AddWithValue("@param3", datumRjesenja);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Message.ToString(), "Error Message");
                    }

                }
            }


        }

        private void PostaviPocetnuVrijednostDatuma()
        {
            foreach (DataGridViewRow row in dgvPopisZadatakaKojeTrebaRijesiti.Rows)
            {
                string danasnji_datum = DateTime.Now.ToString("M/d/yyyy");
                row.Cells[4].Value = danasnji_datum;

            }
        }

        private void dgvPopisZadatakaKojeTrebaRijesiti_CellClick(object sender, DataGridViewCellEventArgs e) //step 2
        {
            if(e.ColumnIndex==4)
            {
                Rectangle cellRectangle = dgvPopisZadatakaKojeTrebaRijesiti.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex,false);
                _datePicker.Location = cellRectangle.Location;
                _datePicker.Width = cellRectangle.Width;
                try
                {
                    _datePicker.Value = DateTime.Parse(dgvPopisZadatakaKojeTrebaRijesiti.CurrentCell.Value.ToString());
                }
                catch
                {

                }
                _datePicker.Visible = true;
            }
            else
            {
                _datePicker.Visible = false;
            }
        }

        private void dg1_ValueChanged(object sender, EventArgs e) // step 3
        {
            dgvPopisZadatakaKojeTrebaRijesiti.CurrentCell.Value = _datePicker.Value.ToString("MM/dd/yyyy");
            _datePicker.Visible = false;
        }

       
    }
}


