using AdministracionEmpleados;
using GestionEmpleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoriaDepartamento
{
    public class Departamento
    {
        #region "Detalle Departamento"
        public string Nombre { get; set; }
        //relacion 1 a muchos con Empleados
        public List<Empleado> Empleados { get; set; }

        // Constructor de la clase Departamento
        public Departamento()
        {
            Empleados = new List<Empleado>();
        }
        public void AgregarEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
            OrdenarEmpleados(); // Llama a OrdenarEmpleados() después de agregar un empleado
        }
        public void OrdenarEmpleados()
        {
            Empleados.Sort(); // Ordena usando el método CompareTo de Empleado
        }


        #endregion
    }
}

  