using GestionEmpleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoriaDepartamento
{
    public class Sucursal 
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        // Relacion 1 a muchos con Departamentos
        public List<Departamento> Departamentos { get; set; }

        // Constructor de la clase Sucursal
        public Sucursal()
        {
            Departamentos = new List<Departamento>();
        }
        public void AgregarDepartamento(Departamento departamento)
        {
            Departamentos.Add(departamento);
        }

    }
}
      