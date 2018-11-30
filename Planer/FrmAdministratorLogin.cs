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
    public partial class FrmAdministratorLogin : Form
    {
        private Administrator novi;
        public Button btnAdministrator;

        public FrmAdministratorLogin(Button btn)
        {
            btnAdministrator = btn;
            btnAdministrator.Enabled = false;
            InitializeComponent();           
        }        

        public void OtvoriVezu()
        {
            Veza newConnection = new Veza();
            string query = "select * from Administrator where korisnicka_oznaka = '" + txtKorisnickaOznaka.Text.Trim() + "' and lozinka = '" + txtLozinka.Text.Trim() + "'";
            SqlDataReader reader = newConnection.SelectAdministrator(query);
            while (reader.Read())
            {
                novi = new Administrator();
                novi.Id = Convert.ToInt32(reader["ID"].ToString());
                novi.Korisnicka_Oznaka = reader["korisnicka_oznaka"].ToString();
                novi.Lozinka = reader["lozinka"].ToString();
            }
            newConnection.Close();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            OtvoriVezu();
            if(novi!=null)
            {
                this.Close();
                FrmPopisZaposlenika forma = new FrmPopisZaposlenika(btnAdministrator);
                forma.Show();
            }
            else
            {
                MessageBox.Show("Pogreska!");
            }
        }

        private void FrmAdministratorLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnAdministrator.Enabled = true;       
        }
    }
}
