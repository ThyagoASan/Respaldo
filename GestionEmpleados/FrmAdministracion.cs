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
    public partial class FrmAdministracion : Form
    {
        Empleado oEmpleado;
        Departamento oDepartamento;
        Sucursal OBuenosAires;
        Sucursal ORosario;
        Sucursal oSucursal;

        public static List<Empleado> Lempleados;
        public static List<Departamento> Ldepartamentos;
        public static List<Sucursal> Lsucursales;
        public FrmAdministracion()
        {
            InitializeComponent();
            // Inicialización de las variables
            oEmpleado = new Empleado();
            oDepartamento = new Departamento();
            OBuenosAires = new BuenosAires();
            ORosario = new Rosario();

            Lempleados = new List<Empleado>();
            Ldepartamentos = new List<Departamento>();
            Lsucursales = new List<Sucursal>();

            OBuenosAires.ListaDepartamentos = new List<Departamento>();
            ORosario.ListaDepartamentos = new List<Departamento>();
        }

        void CargaDgvEmpleados()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = Lempleados;
        }

        void CargaDgvDepartamentos()
        {
            dgvDepartamentos.DataSource = null;
            dgvDepartamentos.DataSource = Ldepartamentos;
        }

        void CargaDgvSucursales()
        {
            dgvSucursal.DataSource = null;
            dgvSucursal.DataSource = Lsucursales;
        }

        void CargaComboLocalidad()
        {
            cmbLocalidad.DataSource = null;
            cmbLocalidad.DataSource = Enum.GetValues(typeof(CLSEnums.Localidad));
        }

        int GenerarCodigo()
        {
            Random rand = new Random();
            return rand.Next(1, 200);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado oEmpleado = new Empleado();
                oEmpleado.Codigo = GenerarCodigo();
                oEmpleado.Nombre = txtNombre.Text;
                oEmpleado.Apellido = txtApellido.Text;
                oEmpleado.Dni = Convert.ToInt32(txtDni.Text);

                if (Lempleados == null)
                {
                    Lempleados = new List<Empleado>();
                }
                Lempleados.Add(oEmpleado);

                CargaDgvEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el empleado: {ex.Message}");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                oEmpleado = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                foreach (var empleado in Lempleados)
                {
                    if (empleado.Codigo == oEmpleado.Codigo)
                    {
                        empleado.Nombre = txtNombre.Text;
                        empleado.Apellido = txtApellido.Text;
                        empleado.Dni = Convert.ToInt32(txtDni.Text);
                        break;
                    }
                }

                CargaDgvEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el empleado: {ex.Message}");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                oEmpleado = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                Lempleados.Remove(oEmpleado);
                CargaDgvEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregaDep_Click(object sender, EventArgs e)
        {
            try
            {
                Departamento oDepartamento = new Departamento();
                oDepartamento.Codigo = GenerarCodigo();
                oDepartamento.Nombre = txtNombreDepartamento.Text;
                oDepartamento.Estado = CLSEnums.Estado.Libre;

                Ldepartamentos.Add(oDepartamento);
                CargaDgvDepartamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el departamento: {ex.Message}");
            }
        }

        private void btnClonar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el departamento seleccionado del DataGridView
                oDepartamento = (Departamento)dgvDepartamentos.CurrentRow.DataBoundItem;

                // Clonar el departamento y agregarlo a la lista de departamentos
                Ldepartamentos.Add((Departamento)oDepartamento.Clone());

                // Recargar el DataGridView para reflejar el nuevo departamento clonado
                CargaDgvDepartamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al clonar el departamento: {ex.Message}");
            }
        }

        private void AgregarSucursal_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbLocalidad.SelectedItem == null)
                {
                    throw new CLSErrorPersonalizado(CLSErrorPersonalizado.Error.CampoVacio);
                }

                if ((CLSEnums.Localidad)cmbLocalidad.SelectedItem == CLSEnums.Localidad.BuenosAires)
                {
                    OBuenosAires.Codigo = GenerarCodigo();
                    OBuenosAires.Nombre = txtNombreSucursal.Text;
                    Lsucursales.Add(OBuenosAires);
                }
                else if ((CLSEnums.Localidad)cmbLocalidad.SelectedItem == CLSEnums.Localidad.Rosario)
                {
                    ORosario.Codigo = GenerarCodigo();
                    ORosario.Nombre = txtNombreSucursal.Text;
                    Lsucursales.Add(ORosario);
                }

                CargaDgvSucursales();
            }
            catch (CLSErrorPersonalizado ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la sucursal: {ex.Message}");
            }
        }

        private void btnModificarSucursal_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarSucursal_Click(object sender, EventArgs e)
        {

        }

        private void btnAsociar_Click(object sender, EventArgs e)
        {
            try
            {
                oEmpleado = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                oDepartamento = (Departamento)dgvDepartamentos.CurrentRow.DataBoundItem;

                oEmpleado.Departamentoasignado = oDepartamento;
                oDepartamento.Estado = CLSEnums.Estado.Asociado;

                CargaDgvEmpleados();
                CargaDgvDepartamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmAdministracion_Load(object sender, EventArgs e)
        {
            CargaComboLocalidad();
        }

        private void dgvSucursal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener la sucursal seleccionada del DataGridView
            Sucursal oSucursal = (Sucursal)dgvSucursal.CurrentRow.DataBoundItem;

            // Verificar si la sucursal es de Buenos Aires
            if (oSucursal is BuenosAires)
            {
                // Actualizar el DataGridView con los departamentos de Buenos Aires
                dgvInformes.DataSource = null;
                dgvInformes.DataSource = OBuenosAires.ListaDepartamentos;
                dgvInformes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                // Actualizar el nombre de la sucursal en el TextBox correspondiente
                txtNombreSucursal.Text = OBuenosAires.Nombre;
            }
            // Verificar si la sucursal es de Rosario
            else if (oSucursal is Rosario)
            {
                // Actualizar el DataGridView con los departamentos de Rosario
                dgvInformes.DataSource = null;
                dgvInformes.DataSource = ORosario.ListaDepartamentos;
                dgvInformes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                // Actualizar el nombre de la sucursal en el TextBox correspondiente
                txtNombreSucursal.Text = ORosario.Nombre;
            }
        }

        private void btnAsociarDepartamentoSucursal_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el departamento seleccionado del DataGridView
                Departamento oDepartamento = (Departamento)dgvDepartamentos.CurrentRow.DataBoundItem;

                // Obtener la sucursal seleccionada del DataGridView
                Sucursal oSucursal = (Sucursal)dgvSucursal.CurrentRow.DataBoundItem;

                // Verificar si la sucursal es de Buenos Aires o Rosario y asociar el departamento
                if (oSucursal == OBuenosAires)
                {
                    OBuenosAires.ListaDepartamentos.Add(oDepartamento);
                }
                else if (oSucursal == ORosario)
                {
                    ORosario.ListaDepartamentos.Add(oDepartamento);
                }

                // Remover el departamento de la lista general de departamentos
                Ldepartamentos.Remove(oDepartamento);

                // Recargar los DataGridViews para reflejar los cambios
                CargaDgvDepartamentos();
                CargaDgvSucursales();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
