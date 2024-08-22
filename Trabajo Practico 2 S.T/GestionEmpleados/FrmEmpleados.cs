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
    public partial class FrmEmpleados : Form
    {
        private List<Empleado> empleados;
       
        public FrmEmpleados(List<Empleado> empleados)
        {
            InitializeComponent();
            this.empleados = empleados;
            cmbTipoEmpleado.SelectedIndexChanged += CmbTipoEmpleado_SelectedIndexChanged;
        }
        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            cmbTipoEmpleado.Items.AddRange(new string[] { "Administrativo", "Técnico" });
            ActualizarDataGridView();
        }
          
        private void CmbTipoEmpleado_SelectedIndexChanged(object sender,EventArgs e)
        {
            // Mostrar u ocultar controles según el tipo de empleado seleccionado
            if (cmbTipoEmpleado.SelectedItem?.ToString() == "Administrativo")
            {
                lblBonificacion.Visible = true;
                txtBonificacion.Visible = true;
                lblHoras.Visible = false;
                txtHora.Visible = false;
                lblTarifa.Visible = false;
                txtTarifa.Visible = false;
            }
            else if (cmbTipoEmpleado.SelectedItem?.ToString() == "Técnico")
            {
                lblBonificacion.Visible = false;
                txtBonificacion.Visible = false;
                lblHoras.Visible = true;
                txtHora.Visible = true;
                lblTarifa.Visible = true;
                txtTarifa.Visible = true;
            }
        }

        private void ActualizarDataGridView()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleados.Select(emp => new
            {
                emp.Codigo,
                emp.Nombre,
                emp.Apellido,
                emp.Dni,
                emp.FechaIngreso,
                Tipo = emp.Tipo.ToString(),
                Salario = emp.CalcularSalario()
            }).ToList();

        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            cmbTipoEmpleado.SelectedIndex = -1;
            dtpFechaIngreso.Value = DateTime.Now;
            txtSueldo.Text = "";
            txtHora.Text = "";
            txtTarifa.Text = "";
            txtBonificacion.Text = "";

            // Ajustar visibilidad de controles
            CmbTipoEmpleado_SelectedIndexChanged(null, null);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleado;

                if (cmbTipoEmpleado.SelectedItem == null)
                    throw new ArgumentException("Seleccione un tipo de empleado.");

                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                    throw new ArgumentException("Ingrese un código válido.");

                int codigo = Convert.ToInt32(txtCodigo.Text);
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string dni = txtDni.Text;
                DateTime fechaIngreso = dtpFechaIngreso.Value;

                if (cmbTipoEmpleado.SelectedItem.ToString() == "Administrativo")
                {
                    if (string.IsNullOrWhiteSpace(txtSueldo.Text) || string.IsNullOrWhiteSpace(txtBonificacion.Text))
                        throw new ArgumentException("Ingrese sueldo base y bonificación para el empleado administrativo.");

                    decimal sueldoBase = Convert.ToDecimal(txtSueldo.Text);
                    decimal bonificacion = Convert.ToDecimal(txtBonificacion.Text);

                    empleado = new Administrativo(codigo, nombre, apellido, dni, fechaIngreso, sueldoBase, bonificacion);
                }
                else if (cmbTipoEmpleado.SelectedItem.ToString() == "Técnico")
                {
                    if (string.IsNullOrWhiteSpace(txtSueldo.Text) || string.IsNullOrWhiteSpace(txtHora.Text) || string.IsNullOrWhiteSpace(txtTarifa.Text))
                        throw new ArgumentException("Ingrese sueldo base, horas extras y tarifa para el empleado técnico.");

                    decimal sueldoBase = Convert.ToDecimal(txtSueldo.Text);
                    decimal horasExtras = Convert.ToDecimal(txtHora.Text);
                    decimal tarifaHorasExtras = Convert.ToDecimal(txtTarifa.Text);

                    empleado = new Tecnico(codigo, nombre, apellido, dni, fechaIngreso, sueldoBase, horasExtras, tarifaHorasExtras);
                }
                else
                {
                    throw new ArgumentException("Tipo de empleado no seleccionado.");
                }

                empleados.Add(empleado);
                ActualizarDataGridView();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un empleado para modificar.");
                    return;
                }

                int codigo = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["Codigo"].Value);
                Empleado empleado = empleados.FirstOrDefault(emp => emp.Codigo == codigo);

                if (empleado != null)
                {
                    empleado.Nombre = txtNombre.Text;
                    empleado.Apellido = txtApellido.Text;
                    empleado.Dni = txtDni.Text;
                    empleado.FechaIngreso = dtpFechaIngreso.Value;

                    if (empleado is Administrativo admin)
                    {
                        admin.SueldoBase = Convert.ToDecimal(txtSueldo.Text);
                        admin.Bonificaciones = Convert.ToDecimal(txtBonificacion.Text);
                    }
                    else if (empleado is Tecnico tecnico)
                    {
                        tecnico.SueldoBase = Convert.ToDecimal(txtSueldo.Text);
                        tecnico.HorasExtras = Convert.ToDecimal(txtHora.Text);
                        tecnico.TarifaHorasExtras = Convert.ToDecimal(txtTarifa.Text);
                    }

                    ActualizarDataGridView();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar empleado: " + ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un empleado para eliminar.");
                    return;
                }

                int codigo = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["Codigo"].Value);
                Empleado empleado = empleados.FirstOrDefault(emp => emp.Codigo == codigo);

                if (empleado != null)
                {
                    empleados.Remove(empleado);
                    ActualizarDataGridView();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar empleado: " + ex.Message);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                if (empleados.Count > 0)
                {
                    empleados.Sort();
                    ActualizarDataGridView();
                }
                else
                {
                    MessageBox.Show("No hay empleados para ordenar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ordenar empleados: " + ex.Message);
            }
        }
    }
}
