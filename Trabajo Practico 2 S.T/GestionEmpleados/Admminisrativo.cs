using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionEmpleados
{
    public class Administrativo : Empleado
    {
        public decimal SueldoBase { get; set; }
        public decimal Bonificaciones { get; set; }

        public Administrativo(int codigo, string nombre, string apellido, string dni, DateTime fechaIngreso, decimal sueldoBase, decimal bonificaciones)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaIngreso = fechaIngreso;
            SueldoBase = sueldoBase;
            Bonificaciones = bonificaciones;
            Tipo = TipoEmpleado.Administrativo;
        }

        public override decimal CalcularSalario()
        {
            // Implementación específica para calcular salario de administrativo
            return SueldoBase + Bonificaciones;
        }
    }
}

       
