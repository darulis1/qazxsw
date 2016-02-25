using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AledaShopAdmin
{
    public partial class parametrai : Form
    {
        public parametrai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MysqlCommands cmd = new MysqlCommands();
            cmd.Insert();
        }

        private void button2_Click(object sender, EventArgs e)
        {       
            configedit cfg = new configedit();
            //cfg.AddUpdateAppSettings("Testas", "Rakto \"Testas\" reiksme");
            //cfg.ReadAppSetting("Testas");
            cfg.ReadAllSettings();
        }
    }
}
