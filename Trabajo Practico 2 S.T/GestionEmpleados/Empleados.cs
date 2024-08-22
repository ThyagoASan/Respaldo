using GestionEmpleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionEmpleados
{

    public enum TipoEmpleado
    {
        Administrativo,
        Tecnico
    }
    public abstract class Empleado : ISalarioCalculable, IComparable<Empleado>
    {
        #region "Propiedades Empleados"
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public TipoEmpleado Tipo { get; set; }
        public DateTime FechaIngreso { get; set; }

        // Método abstracto que debe ser sobrescrito
        public abstract decimal CalcularSalario();
        // Implementación de la interfaz IComparable
        public int CompareTo(Empleado other)
        {
            // Comparación por Nombre y Apellido
            int compare = string.Compare(this.Nombre + this.Apellido, other.Nombre + other.Apellido, StringComparison.Ordinal);
            if (compare == 0)
            {
                // Si los nombres y apellidos son iguales, comparar por Fecha de Ingreso
                compare = DateTime.Compare(this.FechaIngreso, other.FechaIngreso);
            }
            return compare;
        }

    }
    #endregion
}

