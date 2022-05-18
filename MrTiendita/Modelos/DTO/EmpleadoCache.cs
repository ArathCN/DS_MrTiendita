using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DTO
{
    /// <summary> Clase que guarda una instancia de <see cref="Empleado"/> para usarla de sesión en el sistema. </summary>
    public class EmpleadoCache
    {
        /// <summary> The empleado </summary>
        private static Empleado empleado;

        /// <summary> Prevents a default instance of the <see cref="EmpleadoCache"/> class from being created.</summary>
        private EmpleadoCache()
        {
        }

        /// <summary> Gets the empleado. </summary>
        /// <param name="empleado">The empleado.</param>
        /// <returns>An <see cref="Empleado"/> instance.</returns>
        public static Empleado GetEmpleado(Empleado empleado = null)
        {
            if (EmpleadoCache.empleado == null)
            {
                EmpleadoCache.empleado = new Empleado();
                if (empleado != null) EmpleadoCache.SetEmpleado(empleado);
            }

            return EmpleadoCache.empleado;
        }

        /// <summary> Sets the empleado. </summary>
        /// <param name="empleado">The empleado.</param>
        public static void SetEmpleado(Empleado empleado)
        {
            if (empleado == null)
            {
                EmpleadoCache.empleado = null;
                return;
            }
            EmpleadoCache.empleado.Id_empleado = empleado.Id_empleado;
            EmpleadoCache.empleado.Clave = empleado.Clave;
            EmpleadoCache.empleado.Nombre = empleado.Nombre;
            EmpleadoCache.empleado.A_paterno = empleado.A_paterno;
            EmpleadoCache.empleado.A_materno = empleado.A_materno;
            EmpleadoCache.empleado.Telefono = empleado.Telefono;
            EmpleadoCache.empleado.Sueldo = empleado.Sueldo;
            EmpleadoCache.empleado.Tipo_empleado = empleado.Tipo_empleado;
            EmpleadoCache.empleado.Usuario = empleado.Usuario;
        }
    }
}
