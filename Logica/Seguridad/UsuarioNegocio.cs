using Logica.Bibloteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Seguridad
{
    public class UsuarioNegocio
    {

        private List<Usuario> listaUsuarios = new List<Usuario>()
        {
            new Usuario { nombreUsuario = "admin", contrasenaUsuario = "1234", rolUsuario = "Administrador" },
            new Usuario { nombreUsuario = "empleado", contrasenaUsuario = "abcd", rolUsuario = "Empleado" }
            
        };
        public Usuario ValidarLogin(string nombreUsuario, string contrasenaUsuario)
        {
            return listaUsuarios
             .FirstOrDefault(u =>
                 u.nombreUsuario == nombreUsuario &&
                 u.contrasenaUsuario == contrasenaUsuario);
        }

    }
}
