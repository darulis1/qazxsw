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
    public partial class prisijungimas: Form
    {
        public prisijungimas()
        {
            InitializeComponent();            
        }
        public static string naudotojas = "";

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            naudotojas = "";
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                naudotojas = textBox1.Text;
                this.DialogResult = DialogResult.OK;
            }
            else if (textBox1.Text == "user" && textBox2.Text == "user")
            {
                naudotojas = textBox1.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Neteisingi prisijungimo duomenys!");
            }
        }

        private void prisijungimas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
