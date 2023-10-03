using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Media;
using ProyectoTaller2.CapaPresentacion.Administrador;
using ProyectoTaller2.CapaPresentacion.SuperAdmin;
using ProyectoTaller2;

namespace ProyectoTaller2
{
    public partial class formLogin : Form
    {        


        public formLogin()
        {
            
            this.InitializeComponent();
        }

        //Evento arrastrar el formulario desde el panel de titulo

        //Libreria que permite mover el formulario a travez del evento del MOUSE
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]


        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            //Ponemos este codigo para identificar tipos de usuario que se logean al no
            //tener conexion aun con una db

            /*if (radioButton1.Checked)
            {
                this.Close();
               FormMainMenu menu = new FormMainMenu();
                menu.Show();         
            }

            else if (radioButton2.Checked)
            {
                this.Close();
                Form_Admin admin = new Form_Admin();
                admin.Show();                                  
            }

            else if (radioButton3.Checked)
            {
                this.Close();
                Form_SuperAdmin superadmin = new Form_SuperAdmin();
                superadmin.Show();
            }

            else
            {
                MessageBox.Show("Debe seleccionar un tipo de usuario", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }*/

            string nombreUsuario = txtUser.Text;
            string contraseñaUsuario = txtPassword.Text;

            var usuarioNegocio = new NegocioUsuario();
            int tipoUsuario = usuarioNegocio.ObtenerElTipoDeUsuario(nombreUsuario, contraseñaUsuario);

            if (tipoUsuario != 4)
            {
                if(tipoUsuario == 1)
                {
                    Form_SuperAdmin form_SuperAdmin = new Form_SuperAdmin();
                    form_SuperAdmin.Show();
                }
                else if (tipoUsuario == 2)
                {
                    Form_Admin form_Admin = new Form_Admin();
                    form_Admin.Show();
                }
                else
                {
                    FormMainMenu formMainMenu = new FormMainMenu();
                    formMainMenu.Show();
                }
                        
                

                this.Close();
            }

            else
            {
                MessageBox.Show("Credenciales incorrectas. Intente nuevamente" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }
}
