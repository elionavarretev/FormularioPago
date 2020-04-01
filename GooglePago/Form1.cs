using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GooglePago
{
    public partial class frmPago : Form
    {
        public frmPago()
        {
            InitializeComponent();
            panelLateralIzquierdo.Width = 1;
            panelIzquiero.Width = 2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pbBotonesAndroid_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelIzquiero.Width == 2)
            {
                panelIzquiero.Width = 40;
            }
            else
                panelIzquiero.Width = 2;
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Pago());
            panelIzquiero.Width = 2;
        }
    }
}
