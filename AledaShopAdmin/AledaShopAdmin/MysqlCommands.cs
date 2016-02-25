using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;

namespace AledaShopAdmin
{
    class MysqlCommands
    {
        private MySqlConnection connection;
        
        public MysqlCommands()
        {
            Initialize();
        }

        private void Initialize()
        {            
            connection = new MySqlConnection(ConfigurationManager.AppSettings["aledashopadmin"]);
            //createDB();        
        }

        public void createDB()
        {
            string query = "CREATE DATABASE IF NOT EXISTS aledashopadmin DEFAULT CHARACTER SET utf8;";            

            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();            
            connection.Close();
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        //check();
                        MessageBox.Show("Nepavyko prisijungti prie serverio.  Kreipkitės į administratorių");
                        break;

                    case 1042:
                        MessageBox.Show("Neteisingas serverio adresas.");
                        break;

                    case 1045:
                        MessageBox.Show("Neteisingas naudotojo vardas/slaptažodis, patikrinkite prisijungimo duomenis.");
                        break;
                }
                MessageBox.Show(ex.Number.ToString());  // sitas visada rodo klaidos numeri
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public void Insert()
        {
            string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void Update()
        {

        }

        public void Delete()
        {

        }

        public List<string>[] Select()
        {
            List<string>[] list = new List<string>[3];
            return list;
        }

        public int Count()
        {
            return 1;
        }
    }
}
