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
    public partial class Pago : Form
    {
        public Pago()
        {
            InitializeComponent();

            lvRegistro.View = View.Details;
            lvRegistro.Columns.Add("Nombre");
            lvRegistro.Columns.Add("Monto");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            ListViewItem lvi1 = new ListViewItem();
            double infraccion = 0;
            infraccion = empleado.infraccionTotal(cmbCategoria.SelectedItem.ToString(), Convert.ToInt32(txtMinutosTardanza.Text), Convert.ToInt32(txtLLamadasAtencion.Text));

            lvi1.Text = txtNombre.Text.Trim();
            lvi1.SubItems.Add(infraccion.ToString());
            lvRegistro.Items.Add(lvi1);

            lblCantidad.Text = lvRegistro.Items.Count.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtLLamadasAtencion.Clear();
            txtNombre.Clear();
            txtMinutosTardanza.Clear();
            cmbCategoria.SelectedIndex = -1;
        }

        private void txtMinutosTardanza_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_numero(e);
        }

        private void txtLLamadasAtencion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_numero(e);
        }

        private void validar_numero(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
