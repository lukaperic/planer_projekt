using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Connection
{
    public class Veza
    {
        string connectionString = "data source = DESKTOP-D01K7H6\\SQLEXPRESS;database = Planer;integrated security = SSPI;";
        SqlConnection connection;
        public Veza()
        {
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
        }

        public SqlDataReader SelectAdministrator(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;

        }

        public SqlDataReader SelectZaposlenici(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;

        }

        public SqlDataReader SelectZaduzio(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;

        }

        public void DodajNovogZaposlenika(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Spremljeno");
                
            }
            catch(Exception e)
            {
                MessageBox.Show("Greska");
            }
            
        }

        public void IzbrisiZaposlenika(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Izbrisano");

            }
            catch (Exception e)
            {
                MessageBox.Show("Greska");
            }

        }

        public void DodajNoviZadatak(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Spremljeno");

            }
            catch (Exception e)
            {
                MessageBox.Show("Greska");
            }

        }

        public void DodajNovoZaduzenje(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Spremljeno");

            }
            catch (Exception e)
            {
                MessageBox.Show("Greska");
            }

        }

        public void Close()
        {
            connection.Close();
        }


    }
}
