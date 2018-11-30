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
    public partial class FrmZaposlenikLogin : Form
    {
        private Zaposlenik novi;
        public Button btnZaposlenik;

        public FrmZaposlenikLogin(Button btn)
        {
            btnZaposlenik = btn;
            btnZaposlenik.Enabled = false;
            InitializeComponent();
        }

        public void OtvoriVezu()
        {
            Veza newConnection = new Veza();
            string query = "select * from Zaposlenici where korisnicka_oznaka = '" + txtKorisnickaOznaka.Text.Trim() + "' and lozinka = '" + txtLozinka.Text.Trim() + "'";
            SqlDataReader reader = newConnection.SelectAdministrator(query);
            while (reader.Read())
            {
                novi = new Zaposlenik();
                novi.Id = Convert.ToInt32(reader["ID"].ToString());
                novi.KorisnickaOznaka = reader["korisnicka_oznaka"].ToString();
                novi.Lozinka = reader["lozinka"].ToString();
            }
            newConnection.Close();
        }

        private void btnPrijavaZaposlenika_Click(object sender, EventArgs e)
        {
            OtvoriVezu();
            if (novi != null)
            {
                this.Close();
                FrmProfilZaposlenika newFrm = new FrmProfilZaposlenika(novi.Id, btnZaposlenik);
                newFrm.Show();
                
            }
            else
            {
                MessageBox.Show("Pogreska!");
            }
        }

        private void FrmZaposlenikLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnZaposlenik.Enabled = true;
        }
    }
}
