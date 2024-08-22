using AdministracionEmpleados;
using CategoriaDepartamento;
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
    public partial class FrmSucursalDepartamentos : Form
    {

        private List<Sucursal> listaSucursales;
        private List<Empleado> listaEmpleados; // Lista de empleados del FrmEmpleados

        public FrmSucursalDepartamentos(List<Empleado> empleados)
        {
            InitializeComponent();
            listaSucursales = new List<Sucursal>();
            listaEmpleados = empleados;
            btnAsociar.Click += btnAsociar_Click;
        }

        private void CargarCombo()
        {

            // Limpiar y cargar ComboBox de Sucursales
            cmbSucursal.Items.Clear();
            cmbSucursal.Items.AddRange(new string[] { "Osecac", "Osde" });

            // Limpiar y cargar ComboBox de Departamentos
            cmbDepartamento.Items.Clear();
            cmbDepartamento.Items.AddRange(new string[] { "Administración", "Recursos Humanos", "Contabilidad" });

            // Limpiar items anteriores
            cmbEmpleado.Items.Clear();

            // Cargar ComboBox de Empleado con la lista de empleados del FrmEmpleados
            foreach (var empleado in listaEmpleados)
            {
                cmbEmpleado.Items.Add(empleado);
            }
            cmbEmpleado.DisplayMember = "Nombre"; // Mostrar
        }

        private void btnAsociar_Click(object sender, EventArgs e)
        {

            try
            {
                var empleadoSeleccionado = cmbEmpleado.SelectedItem as Empleado;
                var departamentoSeleccionado = cmbDepartamento.SelectedItem as string;
                var direccion = txtDireccion.Text;
                var telefono = txtTelefono.Text;
                var sucursalSeleccionada = cmbSucursal.SelectedItem as string;

                if (empleadoSeleccionado != null && !string.IsNullOrEmpty(departamentoSeleccionado) && !string.IsNullOrEmpty(direccion) && !string.IsNullOrEmpty(telefono) && !string.IsNullOrEmpty(sucursalSeleccionada))
                {
                    var sucursal = listaSucursales.FirstOrDefault(s => s.Nombre == sucursalSeleccionada);
                    if (sucursal == null)
                    {
                        sucursal = new Sucursal
                        {
                            Nombre = sucursalSeleccionada,
                            Direccion = direccion,
                            Telefono = telefono
                        };
                        listaSucursales.Add(sucursal);
                    }

                    var departamento = sucursal.Departamentos.FirstOrDefault(d => d.Nombre == departamentoSeleccionado);
                    if (departamento == null)
                    {
                        departamento = new Departamento { Nombre = departamentoSeleccionado };
                        sucursal.AgregarDepartamento(departamento);
                    }

                    if (!departamento.Empleados.Contains(empleadoSeleccionado))
                    {
                        departamento.AgregarEmpleado(empleadoSeleccionado);
                    }

                    ActualizarDataGridView();
                    MessageBox.Show($"Empleado {empleadoSeleccionado.Nombre} asociado al departamento {departamentoSeleccionado} de la sucursal {sucursalSeleccionada} correctamente.", "Asociar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Complete todos los campos para agregar la asociación correctamente.", "Asociar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asociar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarDataGridView()
        {
            dgvSucursal.DataSource = null;

            var datos = new List<dynamic>();

            foreach (var sucursal in listaSucursales)
            {
                foreach (var departamento in sucursal.Departamentos)
                {
                    foreach (var empleado in departamento.Empleados)
                    {
                        datos.Add(new
                        {
                            NombreEmpleado = $"{empleado.Nombre} {empleado.Apellido}",
                            Sucursal = sucursal.Nombre,
                            Departamento = departamento.Nombre,
                            DireccionSucursal = sucursal.Direccion,
                            TelefonoSucursal = sucursal.Telefono
                        });
                    }
                }
            }

            dgvSucursal.DataSource = datos;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSucursal.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un empleado para modificar.", "Modificar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string nombreEmpleado = dgvSucursal.SelectedRows[0].Cells["NombreEmpleado"].Value.ToString();
                var nombres = nombreEmpleado.Split(' ');
                var nombre = nombres[0];
                var apellido = nombres.Length > 1 ? nombres[1] : "";

                var empleadoSeleccionado = listaEmpleados.FirstOrDefault(emp => emp.Nombre == nombre && emp.Apellido == apellido);

                if (empleadoSeleccionado != null)
                {
                    empleadoSeleccionado.Nombre = cmbEmpleado.SelectedItem.ToString();
                    empleadoSeleccionado.Apellido = "Modificado";
                    ActualizarDataGridView();
                    MessageBox.Show("Empleado modificado correctamente.", "Modificar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSucursal.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un empleado para borrar.", "Eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string nombreEmpleado = dgvSucursal.SelectedRows[0].Cells["NombreEmpleado"].Value.ToString();
                var nombres = nombreEmpleado.Split(' ');
                var nombre = nombres[0];
                var apellido = nombres.Length > 1 ? nombres[1] : "";

                var empleadoSeleccionado = listaEmpleados.FirstOrDefault(emp => emp.Nombre == nombre && emp.Apellido == apellido);

                if (empleadoSeleccionado != null)
                {
                    foreach (var sucursal in listaSucursales)
                    {
                        foreach (var departamento in sucursal.Departamentos)
                        {
                            if (departamento.Empleados.Contains(empleadoSeleccionado))
                            {
                                departamento.Empleados.Remove(empleadoSeleccionado);
                                break;  // Salir del bucle después de encontrar y eliminar el empleado
                            }
                        }
                    }

                    ActualizarDataGridView();
                    MessageBox.Show("Empleado borrado correctamente.", "Eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevaSucursal = txtSucursal.Text;
                if (!string.IsNullOrEmpty(nuevaSucursal))
                {
                    if (!cmbSucursal.Items.Contains(nuevaSucursal))
                    {
                        cmbSucursal.Items.Add(nuevaSucursal);
                        MessageBox.Show($"Sucursal {nuevaSucursal} agregada.");
                        txtSucursal.Clear();
                    }
                    else
                    {
                        MessageBox.Show("La sucursal ya existe.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre de sucursal válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar sucursal: " + ex.Message);
            }
        }

        private void btnAgregarDepartamento_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoDepartamento = txtDepartamento.Text;
                if (!string.IsNullOrEmpty(nuevoDepartamento))
                {
                    if (!cmbDepartamento.Items.Contains(nuevoDepartamento))
                    {
                        cmbDepartamento.Items.Add(nuevoDepartamento);
                        MessageBox.Show($"Departamento {nuevoDepartamento} agregado.");
                        txtDepartamento.Clear();
                    }
                    else
                    {
                        MessageBox.Show("El departamento ya existe.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre de departamento válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar departamento: " + ex.Message);
            }
        }

        private void FrmSucursalDepartamentos_Load(object sender, EventArgs e)
        {
            CargarCombo();
            ActualizarDataGridView();
        }
    }
}
       

    

