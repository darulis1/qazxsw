namespace AledaShopAdmin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_parametrai = new System.Windows.Forms.Button();
            this.btn_kasininkai = new System.Windows.Forms.Button();
            this.btn_klientai = new System.Windows.Forms.Button();
            this.btn_sandelis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 443);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.btn_parametrai);
            this.flowLayoutPanel1.Controls.Add(this.btn_kasininkai);
            this.flowLayoutPanel1.Controls.Add(this.btn_klientai);
            this.flowLayoutPanel1.Controls.Add(this.btn_sandelis);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(657, 443);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_parametrai
            // 
            this.btn_parametrai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parametrai.Location = new System.Drawing.Point(3, 3);
            this.btn_parametrai.Name = "btn_parametrai";
            this.btn_parametrai.Size = new System.Drawing.Size(100, 100);
            this.btn_parametrai.TabIndex = 3;
            this.btn_parametrai.Text = "Parametrai";
            this.btn_parametrai.UseVisualStyleBackColor = true;
            this.btn_parametrai.Click += new System.EventHandler(this.btn_parametrai_Click);
            // 
            // btn_kasininkai
            // 
            this.btn_kasininkai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kasininkai.Location = new System.Drawing.Point(109, 3);
            this.btn_kasininkai.Name = "btn_kasininkai";
            this.btn_kasininkai.Size = new System.Drawing.Size(100, 100);
            this.btn_kasininkai.TabIndex = 0;
            this.btn_kasininkai.Text = "Kasininkai";
            this.btn_kasininkai.UseVisualStyleBackColor = true;
            this.btn_kasininkai.Click += new System.EventHandler(this.btn_kasininkai_Click);
            // 
            // btn_klientai
            // 
            this.btn_klientai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_klientai.Location = new System.Drawing.Point(215, 3);
            this.btn_klientai.Name = "btn_klientai";
            this.btn_klientai.Size = new System.Drawing.Size(100, 100);
            this.btn_klientai.TabIndex = 1;
            this.btn_klientai.Text = "Klientai";
            this.btn_klientai.UseVisualStyleBackColor = true;
            this.btn_klientai.Click += new System.EventHandler(this.btn_klientai_Click);
            // 
            // btn_sandelis
            // 
            this.btn_sandelis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sandelis.Location = new System.Drawing.Point(321, 3);
            this.btn_sandelis.Name = "btn_sandelis";
            this.btn_sandelis.Size = new System.Drawing.Size(100, 100);
            this.btn_sandelis.TabIndex = 2;
            this.btn_sandelis.Text = "Sandėlis";
            this.btn_sandelis.UseVisualStyleBackColor = true;
            this.btn_sandelis.Click += new System.EventHandler(this.btn_sandelis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 443);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AledaShopAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_kasininkai;
        private System.Windows.Forms.Button btn_klientai;
        private System.Windows.Forms.Button btn_sandelis;
        private System.Windows.Forms.Button btn_parametrai;
    }
}

