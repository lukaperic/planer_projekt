using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planer
{
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
            korisnickaPodrska.SetShowHelp(this, true);     
            korisnickaPodrska.HelpNamespace = " https://github.com/foivz/r18047/wiki/3.-Korisni%C4%8Dka-dokumentacija";

        }

        public Button BtnAdministrator
        {
            get
            {
                return btnAdministrator;
            }
        }

        public Button BtnZaposlenik
        {
            get
            {
                return btnZaposlenik;
            }
        }



        private void btnAdministrator_Click_1(object sender, EventArgs e)
        {
            
            FrmAdministratorLogin novaForma = new FrmAdministratorLogin(BtnAdministrator);
            novaForma.Show();
           
        }

        private void btnZaposlenik_Click(object sender, EventArgs e)
        {
            FrmZaposlenikLogin novaForma = new FrmZaposlenikLogin(BtnZaposlenik);
            novaForma.Show();
        }
    }
}
