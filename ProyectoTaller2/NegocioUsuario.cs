using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;
using System.Windows.Navigation;

namespace ProyectoTaller2
{
    internal class NegocioUsuario
    {


        private CapaDatos datos = new CapaDatos();

        public bool AgregarUsuario(string nombre, string apellido, string telefono, string usuario, string contraseña, int tipo_usuario)
        {
            var obj = new usuario
            {
                nombre_usuario = nombre,
                apellido_usuario = apellido,
                telefono_usuario = telefono,
                usuario1 = usuario,
                contraseña = contraseña,
                id_tipo_usuario = tipo_usuario
            };

            datos.InsertarUsuario(obj);

            return true;
        }

        public bool EditarUsuario(string nombre, string apellido, string telefono, string usuario, string contraseña, int tipo_usuario)
        {
            return true;
        }


        public List<usuario> ListarUsuario()
        {
            var lst = datos.ObtenerUsuarios();
            return lst;
        }



        public int ObtenerElTipoDeUsuario(string nombreUsuario, string contraseñaUsuario)
        {
            int idTipoUsuario = datos.ObtenerTipoUsuario(nombreUsuario, contraseñaUsuario);

            switch(idTipoUsuario)
            {
                case 1:
                    return 1;
                case 2:
                    return 2;

                case 3:
                    return 3;

                default:
                    return 4;//otra manera de manejar usuarios desconocidos
            }
        }
    }

}
