using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.Capa_Presentacion.Administrador
{
    public partial class FormVendedoresAdmin : Form
    {
        public FormVendedoresAdmin()
        {
            InitializeComponent();

            btnVerVentas.Enabled = false;
        }

        private void dataGridVendedores_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridVendedores.SelectedRows.Count > 0)
            {
                btnVerVentas.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreVendedor.Text))
            {
                MessageBox.Show("Complete el campo Nombre");
            }
        }
    }
}
