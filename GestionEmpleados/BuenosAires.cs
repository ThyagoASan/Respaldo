using CategoriaDepartamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleados
{
    public class BuenosAires : Sucursal
    {
        public override string Ubicacion => "Buenos Aires";

        public override double CalcularValor()
        {
            return ListaDepartamentos.Count * 10000; // Ejemplo simple de cálculo
        }
    }
}
