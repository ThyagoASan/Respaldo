using CategoriaDepartamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleados
{
    public class Rosario : Sucursal
    {
        public override string Ubicacion => "Rosario";

        public override double CalcularValor()
        {
            return ListaDepartamentos.Count * 8000; // Ejemplo simple de cálculo
        }
    }
}
