using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DTO
{
    public class EmpleadoCache
    {
        private static Empleado empleado;

        private EmpleadoCache()
        {
        }

        public static Empleado GetEmpleado(Empleado empleado = null)
        {
            if (EmpleadoCache.empleado == null)
            {
                EmpleadoCache.empleado = new Empleado();
                if(empleado != null )EmpleadoCache.SetEmpleado(empleado);
            }

            return EmpleadoCache.empleado;
        }

        public static void SetEmpleado(Empleado empleado)
        {
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
