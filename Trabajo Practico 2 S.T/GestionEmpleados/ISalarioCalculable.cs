using AdministracionEmpleados;
using CategoriaDepartamento;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleados
{
    public interface ISalarioCalculable
    {
        decimal CalcularSalario();

    }

}

