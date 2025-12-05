using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoMetodologia
{
    internal class SesionUsuario
    {
        // Propiedades para almacenar los datos del usuario logeado
        public static int ID { get; set; }
        public static string NombreUsuario { get; set; }
        public static decimal Dinero { get; set; }

        // Método para limpiar los datos al cerrar sesión
        public static void CerrarSesion()
        {
            ID = 0;
            NombreUsuario = null;
            Dinero = 0.0M;
        }
    }
}
