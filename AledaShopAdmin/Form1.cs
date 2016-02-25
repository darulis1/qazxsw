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
    public partial class Form1 : Form
    {
        string lango_pavadinimas = "";

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            lango_pavadinimas = this.Text;     
        }

        private void btn_kasininkai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kasinikai");
        }

        private void btn_klientai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Klientai");
        }

        private void btn_sandelis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sandėlis");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            configedit cfg = new configedit();
            cfg.ReadAllSettings();

            if (cfg.tuscias == true)
            {
                MessageBox.Show("Programos nustatymų failas tuščias. \nReikalingi papildomi nustatymai.");
                paruosimas init = new paruosimas();
                init.ShowDialog();
            }
            else
            {
                prisijungimas login = new prisijungimas();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Text = lango_pavadinimas + " Prisijungęs: " + prisijungimas.naudotojas;
                    if (prisijungimas.naudotojas == "admin")
                    {
                        flowLayoutPanel1.Visible = true;
                    }
                    if (prisijungimas.naudotojas == "user")
                    {
                        flowLayoutPanel1.Visible = true;
                        btn_parametrai.Visible = false;
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.R)
            {
                Text = "";
                prisijungimas.naudotojas = "";
                flowLayoutPanel1.Visible = false;
                prisijungimas login = new prisijungimas();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Text = lango_pavadinimas + " Prisijungęs: " + prisijungimas.naudotojas;
                    if (prisijungimas.naudotojas == "admin")
                    {
                        flowLayoutPanel1.Visible = true;
                        btn_parametrai.Visible = true;
                    }
                    if (prisijungimas.naudotojas == "user")
                    {
                        flowLayoutPanel1.Visible = true;
                        btn_parametrai.Visible = false;
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*DialogResult klausti = MessageBox.Show("Ar tikrai norite uždaryti programą? \nVisi neišsaugoti duomenys pradings!", "Uždaryti", MessageBoxButtons.YesNo);

            if (klausti == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true; 
            }*/
        }

        private void btn_parametrai_Click(object sender, EventArgs e)
        {
            parametrai parametrai = new parametrai();
            parametrai.ShowDialog();
            //nieko gero nekomentuoju
        }
    }
}
