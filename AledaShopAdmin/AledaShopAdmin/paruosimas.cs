using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AledaShopAdmin
{
    public partial class paruosimas : Form
    {
        private string hostname;
        private string uid;
        private string password;

        public paruosimas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hostname = textBox_hostname.Text;
            

            
            try {
                setHostname(textBox_hostname.Text);
                uid = textBox_uid.Text;
                password = textBox_password.Text;

                configedit cfg = new configedit();
                cfg.AddUpdateAppSettings("aledashopadmin", "Server=" + getHostname() + ";User Id=" + uid + ";Password=" + password + ";");                
                MessageBox.Show("Nustatymų failas sukurtas.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MysqlCommands cmd = new MysqlCommands();
            //cmd.createDB();
            
        }

        public string setHostname(string value)
        {
            if (value != null && value != "")
            {
                return this.hostname = value;
            }
            else
            {
                throw new Exception("Serverio adresas negali būti tuščias");
                //MessageBox.Show("Serverio adresas negali būti tuščias");                
            }
               
            
        }

        public string getHostname()
        {
            return this.hostname;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int max = 500;

            progressBar1.Maximum = max;
            progressBar1.Step = 1;

            for (int i = 0; i <= max; i++){
                progressBar1.PerformStep();
            }
        }
    }
}
