using GestionEmpleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CategoriaDepartamento

{
    public abstract class Sucursal : ICustomInterface
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public List<Departamento> ListaDepartamentos { get; set; } = new List<Departamento>();

        public abstract string Ubicacion { get; }

        public string Descripcion { get; set; }

        public abstract double CalcularValor();

        public override string ToString()
        {
            return $"{Codigo} - {Nombre} ({Ubicacion})";
        }

    }
}
