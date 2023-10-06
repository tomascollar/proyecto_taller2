using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2
{
    public partial class FormProducto : Form
    {

        private Iform _form;
        public FormProducto(Iform form)
        {
            InitializeComponent();
            _form = form;

            btnAgregarCarrito.Visible = false;

        }

        private struct RGBColors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(172, 126, 241);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(249, 118, 176);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253, 138, 114);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(95, 77, 221);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249, 88, 155);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(24, 161, 251);
        }


        ErrorProvider errorP = new ErrorProvider(); 
       

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //verifica si al menos una fila esta seleccionada
            if(dataGridView1.SelectedRows.Count > 0)
            {
                //habilita los botones si hay al menos una fila selected
                btnAgregarCarrito.Visible = true;

            }
            else
            {
                btnAgregarCarrito.Visible=false;
            }
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            _form.ActivateButton(sender, RGBColors.color1);
            _form.openChildForm(new FormVenta(_form, dataGridView1));
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            bool valida = Validar.txtVacios(txtBuscar);
            if (valida)
                errorP.SetError(txtBuscar, "Debe completar este campo");
            else
                errorP.Clear();
        }
    }
}
