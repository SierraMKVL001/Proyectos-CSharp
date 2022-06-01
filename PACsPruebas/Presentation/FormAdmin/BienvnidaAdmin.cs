using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common.Cache;

namespace Presentation.FormAdmin
{
    public partial class BienvnidaAdmin : Form
    {
        public BienvnidaAdmin()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                
                this.Opacity += 0.01;
                progressBar1.Value += 1;
            }

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();

            }
        }

        private void BienvnidaAdmin_Load(object sender, EventArgs e)
        {
            lblUserN.Text = UserLoginCache.Nombres + " " + UserLoginCache.Apellidos;
            this.Opacity = 0.0;
            timer1.Start();

        }

       

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void lblPuesto_Click(object sender, EventArgs e)
        {

        }

        private void lblUserN_Click(object sender, EventArgs e)
        {

        }
    }
}
