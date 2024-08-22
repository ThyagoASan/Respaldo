using CategoriaDepartamento;
using GestionEmpleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionEmpleados
{
    public class Empleado
    {
        #region "Propiedades Empleados"
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        //Relacacion 1 a 1 con Departamento
        public Departamento Departamentoasignado { get; set; }
        #endregion

        public override string ToString()
        {
            return $"{Codigo} - {Nombre} {Apellido}";
        }

    }
}

