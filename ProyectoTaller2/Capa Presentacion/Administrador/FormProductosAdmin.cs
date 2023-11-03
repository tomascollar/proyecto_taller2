using ProyectoTaller2.Capa_Negocio;
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
    public partial class FormProductosAdmin : Form
    {
        public FormProductosAdmin()
        {
            InitializeComponent();
            //Desactivamos los botones del inicio ya que no hay ninguna columna seleccionada
            btnEliminarProd.Enabled = false;
            btnEditarProd.Enabled = false;
        }

        private void dataGridProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridProductos.SelectedRows.Count > 0)
            {
                btnEliminarProd.Enabled = true;
                btnEditarProd.Enabled = true;

            }
            else
            {
                btnEliminarProd.Enabled = false;
                btnEditarProd.Enabled = false;
            }
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreProd.Text) || string.IsNullOrEmpty(txtStockProd.Text) ||
                string.IsNullOrEmpty(txtPrecioProd.Text) || string.IsNullOrEmpty(txtDescripProd.Text) ||
                comboMarca.SelectedItem == null || comboCategoriaProd.SelectedItem == null ) {

                MessageBox.Show("Debe completar todos los campos","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var msg = MessageBox.Show("Esta seguro de añadir este producto?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    MessageBox.Show("El producto se agrego correctamente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string nombre = txtNombreProd.Text;
                    string descripcion = txtDescripProd.Text;
                    int stock = Convert.ToInt32(txtStockProd.Text);
                    double precio = Convert.ToDouble(txtPrecioProd.Text);
                    //falta resolver marca
                    //falta resolver categoria
                    int categoria = Convert.ToInt32(comboCategoriaProd.Text);
                    

                    var nuevoProd = new NegocioProducto();
                    //  nuevoProd.AgregarProducto(nombre, descripcion, stock, precio, marca, categoria);

                    txtDescripProd.Clear();
                    comboMarca.SelectedIndex = -1;
                    txtNombreProd.Clear();
                    txtPrecioProd.Clear();
                    txtStockProd.Clear();
                    comboCategoriaProd.SelectedIndex = -1;

                    dataGridProductos.Refresh();
                    /*
                    var nombre = txtNombreProd.Text;
                    var marca = txtMarcaProd.Text;
                    var stock = txtStockProd.Text;
                    var descrip = txtDescripProd.Text;
                    var precio = Convert.ToInt32(txtPrecioProd.Text);
                    var categoria = comboCategoriaProd.SelectedItem;

                    dataGridProductos.Rows.Add(nombre, marca, stock, precio, descrip, categoria);
                    

                    txtNombreProd.Clear();
                    txtMarcaProd.Clear();
                    txtStockProd.Clear();
                    txtDescripProd.Clear();
                    txtPrecioProd.Clear();
                    comboCategoriaProd.SelectedItem = null;
                    */

                }
                
            }
        }

        ErrorProvider errorP =  new ErrorProvider();


        private void txtStockProd_KeyPress(object sed, KeyPressEventArgs e)
        {
            bool valida = Validar.soloNumeros(e);
            if (!valida)
                errorP.SetError(txtStockProd, "Solo numeros");
            else
                errorP.Clear();
        }

        private void txtPrecioProd_KeyPress(object sed, KeyPressEventArgs e)
        {
            bool valida = Validar.soloNumeros(e);
            if (!valida)
                errorP.SetError(txtPrecioProd, "Solo numeros");
            else
                errorP.Clear();
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            int filaSeleccionada;
            filaSeleccionada = dataGridProductos.CurrentRow.Index;
            
            var msg = MessageBox.Show("Seguro desea eliminar este producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {

                dataGridProductos.Rows.RemoveAt(filaSeleccionada);


                txtNombreProd.Clear();
                comboMarca.SelectedItem = null;
                txtStockProd.Clear();
                txtDescripProd.Clear();
                txtPrecioProd.Clear();
                comboCategoriaProd.SelectedItem = null;

            }
        }

        private void btnEditarProd_Click(object sender, EventArgs e)
        {

            int filaSeleccionada;
            filaSeleccionada = dataGridProductos.CurrentRow.Index;

            if (string.IsNullOrEmpty(txtNombreProd.Text) || string.IsNullOrEmpty(txtStockProd.Text) ||
                string.IsNullOrEmpty(txtPrecioProd.Text) || string.IsNullOrEmpty(txtDescripProd.Text) ||
                comboMarca.SelectedItem == null || comboCategoriaProd.SelectedItem == null)
            {

                MessageBox.Show("Debe completar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var msg = MessageBox.Show("Esta seguro que desea editar este producto con los campos escritos?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    var nombre = txtNombreProd.Text;
                    var marca = comboMarca.SelectedItem;
                    var stock = Convert.ToInt32(txtStockProd.Text);
                    var descrip = txtDescripProd.Text;
                    var precio = Convert.ToInt32(txtPrecioProd.Text);
                    var categoria = comboCategoriaProd.SelectedItem;

                    dataGridProductos[0, filaSeleccionada].Value = nombre;
                    dataGridProductos[1, filaSeleccionada].Value = marca;
                    dataGridProductos[2, filaSeleccionada].Value = stock;
                    dataGridProductos[3, filaSeleccionada].Value = precio;
                    dataGridProductos[4, filaSeleccionada].Value = descrip;
                    dataGridProductos[5, filaSeleccionada].Value = categoria;
 

                    

                    txtNombreProd.Clear();
                    comboMarca.SelectedItem = null;
                    txtStockProd.Clear();
                    txtDescripProd.Clear();
                    txtPrecioProd.Clear();
                    comboCategoriaProd.SelectedItem = null;

                }

            }
        }

        private void dataGridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreProd.Text = dataGridProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboMarca.Text = dataGridProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtStockProd.Text = dataGridProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrecioProd.Text = dataGridProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDescripProd.Text = dataGridProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboCategoriaProd.Text = dataGridProductos.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
