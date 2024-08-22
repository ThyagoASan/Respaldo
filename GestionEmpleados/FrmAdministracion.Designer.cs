namespace GestionEmpleados
{
    partial class FrmAdministracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModificarSucursal = new System.Windows.Forms.Button();
            this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.btnAsociarDepartamentoSucursal = new System.Windows.Forms.Button();
            this.btnAsociar = new System.Windows.Forms.Button();
            this.AgregarSucursal = new System.Windows.Forms.Button();
            this.dgvInformes = new System.Windows.Forms.DataGridView();
            this.dgvSucursal = new System.Windows.Forms.DataGridView();
            this.btnBorrarSucursal = new System.Windows.Forms.Button();
            this.btnClonar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregaDep = new System.Windows.Forms.Button();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarSucursal
            // 
            this.btnModificarSucursal.Location = new System.Drawing.Point(968, 168);
            this.btnModificarSucursal.Name = "btnModificarSucursal";
            this.btnModificarSucursal.Size = new System.Drawing.Size(75, 23);
            this.btnModificarSucursal.TabIndex = 152;
            this.btnModificarSucursal.Text = "Modificar";
            this.btnModificarSucursal.UseVisualStyleBackColor = true;
            this.btnModificarSucursal.Click += new System.EventHandler(this.btnModificarSucursal_Click);
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.Location = new System.Drawing.Point(598, 301);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDepartamento.TabIndex = 151;
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Location = new System.Drawing.Point(767, 57);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(100, 20);
            this.txtNombreSucursal.TabIndex = 150;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(767, 19);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(100, 21);
            this.cmbLocalidad.TabIndex = 149;
            // 
            // btnAsociarDepartamentoSucursal
            // 
            this.btnAsociarDepartamentoSucursal.Location = new System.Drawing.Point(892, 461);
            this.btnAsociarDepartamentoSucursal.Name = "btnAsociarDepartamentoSucursal";
            this.btnAsociarDepartamentoSucursal.Size = new System.Drawing.Size(75, 23);
            this.btnAsociarDepartamentoSucursal.TabIndex = 148;
            this.btnAsociarDepartamentoSucursal.Text = "AgregarDepartamento";
            this.btnAsociarDepartamentoSucursal.UseVisualStyleBackColor = true;
            this.btnAsociarDepartamentoSucursal.Click += new System.EventHandler(this.btnAsociarDepartamentoSucursal_Click);
            // 
            // btnAsociar
            // 
            this.btnAsociar.Location = new System.Drawing.Point(780, 461);
            this.btnAsociar.Name = "btnAsociar";
            this.btnAsociar.Size = new System.Drawing.Size(75, 23);
            this.btnAsociar.TabIndex = 147;
            this.btnAsociar.Text = "Asociar Departamento";
            this.btnAsociar.UseVisualStyleBackColor = true;
            this.btnAsociar.Click += new System.EventHandler(this.btnAsociar_Click);
            // 
            // AgregarSucursal
            // 
            this.AgregarSucursal.Location = new System.Drawing.Point(872, 168);
            this.AgregarSucursal.Name = "AgregarSucursal";
            this.AgregarSucursal.Size = new System.Drawing.Size(75, 23);
            this.AgregarSucursal.TabIndex = 146;
            this.AgregarSucursal.Text = "Agregar";
            this.AgregarSucursal.UseVisualStyleBackColor = true;
            this.AgregarSucursal.Click += new System.EventHandler(this.AgregarSucursal_Click);
            // 
            // dgvInformes
            // 
            this.dgvInformes.Location = new System.Drawing.Point(780, 284);
            this.dgvInformes.Name = "dgvInformes";
            this.dgvInformes.Size = new System.Drawing.Size(472, 150);
            this.dgvInformes.TabIndex = 145;
            // 
            // dgvSucursal
            // 
            this.dgvSucursal.Location = new System.Drawing.Point(873, 12);
            this.dgvSucursal.Name = "dgvSucursal";
            this.dgvSucursal.Size = new System.Drawing.Size(472, 150);
            this.dgvSucursal.TabIndex = 144;
            this.dgvSucursal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSucursal_CellContentClick);
            // 
            // btnBorrarSucursal
            // 
            this.btnBorrarSucursal.Location = new System.Drawing.Point(1062, 168);
            this.btnBorrarSucursal.Name = "btnBorrarSucursal";
            this.btnBorrarSucursal.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarSucursal.TabIndex = 143;
            this.btnBorrarSucursal.Text = "Borrar";
            this.btnBorrarSucursal.UseVisualStyleBackColor = true;
            this.btnBorrarSucursal.Click += new System.EventHandler(this.btnBorrarSucursal_Click);
            // 
            // btnClonar
            // 
            this.btnClonar.Location = new System.Drawing.Point(149, 440);
            this.btnClonar.Name = "btnClonar";
            this.btnClonar.Size = new System.Drawing.Size(75, 23);
            this.btnClonar.TabIndex = 142;
            this.btnClonar.Text = "Clonar";
            this.btnClonar.UseVisualStyleBackColor = true;
            this.btnClonar.Click += new System.EventHandler(this.btnClonar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 141;
            this.label6.Text = "NombreDepartamento";
            // 
            // btnAgregaDep
            // 
            this.btnAgregaDep.Location = new System.Drawing.Point(23, 440);
            this.btnAgregaDep.Name = "btnAgregaDep";
            this.btnAgregaDep.Size = new System.Drawing.Size(75, 23);
            this.btnAgregaDep.TabIndex = 140;
            this.btnAgregaDep.Text = "AgreDeparta";
            this.btnAgregaDep.UseVisualStyleBackColor = true;
            this.btnAgregaDep.Click += new System.EventHandler(this.btnAgregaDep_Click);
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.Location = new System.Drawing.Point(12, 284);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.Size = new System.Drawing.Size(461, 150);
            this.dgvDepartamentos.TabIndex = 139;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 12);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(472, 150);
            this.dgvEmpleados.TabIndex = 138;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(122, 184);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 137;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(597, 53);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 136;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(597, 86);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 135;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(597, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 134;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 133;
            this.label3.Text = "Dni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 132;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 131;
            this.label1.Text = "Nombre";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(263, 184);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 130;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 184);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 129;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 674);
            this.Controls.Add(this.btnModificarSucursal);
            this.Controls.Add(this.txtNombreDepartamento);
            this.Controls.Add(this.txtNombreSucursal);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.btnAsociarDepartamentoSucursal);
            this.Controls.Add(this.btnAsociar);
            this.Controls.Add(this.AgregarSucursal);
            this.Controls.Add(this.dgvInformes);
            this.Controls.Add(this.dgvSucursal);
            this.Controls.Add(this.btnBorrarSucursal);
            this.Controls.Add(this.btnClonar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregaDep);
            this.Controls.Add(this.dgvDepartamentos);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmAdministracion";
            this.Text = "FrmAdministracion";
            this.Load += new System.EventHandler(this.FrmAdministracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarSucursal;
        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Button btnAsociarDepartamentoSucursal;
        private System.Windows.Forms.Button btnAsociar;
        private System.Windows.Forms.Button AgregarSucursal;
        private System.Windows.Forms.DataGridView dgvInformes;
        private System.Windows.Forms.DataGridView dgvSucursal;
        private System.Windows.Forms.Button btnBorrarSucursal;
        private System.Windows.Forms.Button btnClonar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregaDep;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
    }
}