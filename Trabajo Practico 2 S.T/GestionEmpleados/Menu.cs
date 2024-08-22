using AdministracionEmpleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmpleados
{
    public partial class Menu : Form
    {
        private List<Empleado> empleados;

        public Menu()
        {
            InitializeComponent();
            empleados = new List<Empleado>();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados(empleados);
            frmEmpleados.MdiParent = this;
            frmEmpleados.Show();
        }

        private void sucursalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmSucursalDepartamentos frmSucursalDepartamentos = new FrmSucursalDepartamentos(empleados);
            frmSucursalDepartamentos.MdiParent = this;
            frmSucursalDepartamentos.Show();

        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
