using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionEmpleados
{
    public class Tecnico : Empleado
    {
        public decimal SueldoBase { get; set; }
        public decimal HorasExtras { get; set; }
        public decimal TarifaHorasExtras { get; set; }

        public Tecnico(int codigo, string nombre, string apellido, string dni, DateTime fechaIngreso, decimal sueldoBase, decimal horasExtras, decimal tarifaHorasExtras)
        {
            Codigo=codigo;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaIngreso = fechaIngreso;
            SueldoBase = sueldoBase;
            HorasExtras = horasExtras;
            TarifaHorasExtras = tarifaHorasExtras;
            Tipo=TipoEmpleado.Tecnico;
        }
        public override decimal CalcularSalario()
        {
            // Implementación específica para calcular salario de técnico
            return SueldoBase + (HorasExtras * TarifaHorasExtras);
        }
    }
}

       