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
    public partial class FormVenta : Form
    {

        private Iform _form;
        public FormVenta(Iform form)
        {
            InitializeComponent();
            _form = form;

            btnRealizarVenta.Enabled = false;
            if(dataGridVenta.Rows.Count > 1)
            {
                btnRealizarVenta.Enabled = true;
            }
        }

        public FormVenta(Iform form, DataGridView dtg)
        {
            InitializeComponent();
            _form = form;

            btnRealizarVenta.Enabled = false;

        }

        

        private void dataGridVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                e.Value = "    X    ";

            }
        }

        private void dataGridVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridVenta.Rows[e.RowIndex];
            DataGridViewCell deleteCell = row.Cells["eliminarCarrito"];
            DataGridViewCell nombreCell = row.Cells["nombreProd"];



            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn columna = dataGridVenta.Columns[e.ColumnIndex];
                if (columna.Name != "eliminarCarrito")
                {

                    //desactivamos el evento click en celdas q no sean del tipo boton
                    dataGridVenta.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;

                }
                else {

                    if (string.IsNullOrEmpty(Convert.ToString(nombreCell.Value)))
                    {
                        deleteCell.ReadOnly = true;
                    }
                    else
                    {
                        //Desactivamos el read only asi podemos usar el boton
                        deleteCell.ReadOnly = false;
                        var msg = MessageBox.Show("Desea eliminar el producto?", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (msg == DialogResult.Yes)
                        {

                            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridVenta.Columns["eliminarCarrito"].Index)
                            {
                                //Eliminamos la fila correspondiente
                                dataGridVenta.Rows.RemoveAt(e.RowIndex);

                            }
                            MessageBox.Show("Producto eliminado del carrito correctamente", "Quitar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }


        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {

        }

        private void dataGridVenta_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridVenta.SelectedRows.Count > 0)
            {
                btnRealizarVenta.Enabled = true;
            }
            else
            {
                btnRealizarVenta.Enabled=false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Desea cancelar esta venta?", "Cancelar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {
                dataGridVenta.Rows.Clear();

            }

            this.Close();
        }
    }
}
