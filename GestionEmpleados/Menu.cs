﻿using AdministracionEmpleados;
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
       

        public Menu()
        {
            InitializeComponent();
          
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdministracion frm  = new FrmAdministracion();
            frm.MdiParent = this;
            frm.Show();
        }

    }
}
