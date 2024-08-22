using AdministracionEmpleados;
using GestionEmpleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CategoriaDepartamento
{
    public class Departamento : ICloneable
    {
        #region "Detalle Departamento"
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public CLSEnums.Estado Estado { get; set; }

        #endregion

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return $"{Codigo} - {Nombre}";
        }


    }
}

