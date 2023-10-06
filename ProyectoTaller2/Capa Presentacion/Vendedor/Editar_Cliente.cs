using ProyectoTaller2.CapaPresentacion.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.Capa_Presentacion.Vendedor
{
    public partial class Editar_Cliente : Form
    {

        DialogResult ask;
        private Iform _form;
        public Editar_Cliente(Iform form)
        {
            InitializeComponent();
            _form = form;
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validar.soloNumeros(e);
            if (!valida)
                errorP.SetError(txtDni, "Solo numeros");
            else
                errorP.Clear();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validar.soloNumeros(e);
            if (!valida)
                errorP.SetError(txtTelefono, "Solo numeros");
            else
                errorP.Clear();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validar.soloLetras(e);
            if (!valida)
                errorP.SetError(txtNombre, "Solo numeros");
            else
                errorP.Clear();
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validar.soloLetras(e);
            if (!valida)
                errorP.SetError(txtApellido, "Solo numeros");
            else
                errorP.Clear();
        }


        ErrorProvider errorP = new ErrorProvider();
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {

            bool validaDNI = Validar.txtVacios(txtDni);
            if (validaDNI)
                errorP.SetError(txtDni, "Debe completar este campo");
            else
                errorP.Clear();

            bool validaNombre = Validar.txtVacios(txtNombre);
            if (validaNombre)
                errorP.SetError(txtNombre, "Debe completar este campo");
            else
                errorP.Clear();

            bool validaApellido = Validar.txtVacios(txtApellido);
            if (validaApellido)
                errorP.SetError(txtApellido, "Debe completar este campo");
            else
                errorP.Clear();

            bool validaTelefono = Validar.txtVacios(txtTelefono);
            if (validaTelefono)
                errorP.SetError(txtTelefono, "Debe completar este campo");
            else
                errorP.Clear();

            bool validaDireccion = Validar.txtVacios(txtDireccion);
            if (validaDireccion)
                errorP.SetError(txtDireccion, "Debe completar este campo");
            else
                errorP.Clear();

            bool validaEmail = Validar.txtVacios(txtEmail);
            if (validaEmail)
                errorP.SetError(txtEmail, "Debe completar este campo");
            else
                errorP.Clear();

            bool correo = Validar.validarEmail(txtEmail.Text);

            if (!correo)
            {
                MessageBox.Show("Debe ingresar un email valido");
            }
            else
            {

                if (!validaDireccion && !validaApellido && !validaTelefono && !validaDNI && !validaNombre && !validaEmail)
                {

                    ask = MessageBox.Show("Seguro que desea editar este Cliente?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show("El cliente " + txtDni.Text +
                        " se editó correctamente", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                    int DNI = Convert.ToInt32(txtDni.Text);
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string telefono = txtTelefono.Text;
                    string direccion = txtDireccion.Text;

                    this.Close();
                    FormCliente form = new FormCliente(_form);
                    _form.openChildForm(form);
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Seguro desea cancelar la edicion?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
