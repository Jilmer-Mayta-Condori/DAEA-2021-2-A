
namespace Lab06
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEnrollmentDate = new System.Windows.Forms.DateTimePicker();
            this.txtHireDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrdenApellido = new System.Windows.Forms.Button();
            this.btnBuscarXCodigo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpSearchDateContrato = new System.Windows.Forms.DateTimePicker();
            this.dtpSearchDateInscripcion = new System.Windows.Forms.DateTimePicker();
            this.btnSearchFacturacion = new System.Windows.Forms.Button();
            this.btnSearchContrato = new System.Windows.Forms.Button();
            this.btnSearchLastname = new System.Windows.Forms.Button();
            this.btnSearchNombre = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToOrderColumns = true;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(12, 247);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowHeadersVisible = false;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(670, 188);
            this.dgvListado.TabIndex = 26;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            this.dgvListado.SelectionChanged += new System.EventHandler(this.dgvListado_SelectionChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(377, 129);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(377, 100);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(377, 70);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 23;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(377, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(377, 12);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 21;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Persona";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtEnrollmentDate);
            this.panel1.Controls.Add(this.txtHireDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPersonID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 219);
            this.panel1.TabIndex = 19;
            // 
            // txtEnrollmentDate
            // 
            this.txtEnrollmentDate.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.txtEnrollmentDate.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEnrollmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtEnrollmentDate.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.txtEnrollmentDate.Location = new System.Drawing.Point(179, 185);
            this.txtEnrollmentDate.Name = "txtEnrollmentDate";
            this.txtEnrollmentDate.ShowCheckBox = true;
            this.txtEnrollmentDate.Size = new System.Drawing.Size(129, 20);
            this.txtEnrollmentDate.TabIndex = 11;
            // 
            // txtHireDate
            // 
            this.txtHireDate.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.txtHireDate.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtHireDate.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.txtHireDate.Location = new System.Drawing.Point(22, 185);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.ShowCheckBox = true;
            this.txtHireDate.Size = new System.Drawing.Size(127, 20);
            this.txtHireDate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Inscripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contrato";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(179, 117);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(129, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(22, 118);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(127, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(22, 46);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(79, 20);
            this.txtPersonID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // btnOrdenApellido
            // 
            this.btnOrdenApellido.Location = new System.Drawing.Point(377, 158);
            this.btnOrdenApellido.Name = "btnOrdenApellido";
            this.btnOrdenApellido.Size = new System.Drawing.Size(75, 34);
            this.btnOrdenApellido.TabIndex = 27;
            this.btnOrdenApellido.Text = "Ordenar por Apellido";
            this.btnOrdenApellido.UseVisualStyleBackColor = true;
            this.btnOrdenApellido.Click += new System.EventHandler(this.btnOrdenApellido_Click);
            // 
            // btnBuscarXCodigo
            // 
            this.btnBuscarXCodigo.Location = new System.Drawing.Point(377, 198);
            this.btnBuscarXCodigo.Name = "btnBuscarXCodigo";
            this.btnBuscarXCodigo.Size = new System.Drawing.Size(75, 34);
            this.btnBuscarXCodigo.TabIndex = 28;
            this.btnBuscarXCodigo.Text = "Buscar por Codigo";
            this.btnBuscarXCodigo.UseVisualStyleBackColor = true;
            this.btnBuscarXCodigo.Click += new System.EventHandler(this.btnBuscarXCodigo_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpSearchDateContrato);
            this.panel2.Controls.Add(this.dtpSearchDateInscripcion);
            this.panel2.Controls.Add(this.btnSearchFacturacion);
            this.panel2.Controls.Add(this.btnSearchContrato);
            this.panel2.Controls.Add(this.btnSearchLastname);
            this.panel2.Controls.Add(this.btnSearchNombre);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSearchLastName);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtSearchName);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(471, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 219);
            this.panel2.TabIndex = 20;
            // 
            // dtpSearchDateContrato
            // 
            this.dtpSearchDateContrato.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.dtpSearchDateContrato.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpSearchDateContrato.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchDateContrato.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.dtpSearchDateContrato.Location = new System.Drawing.Point(15, 137);
            this.dtpSearchDateContrato.Name = "dtpSearchDateContrato";
            this.dtpSearchDateContrato.Size = new System.Drawing.Size(79, 20);
            this.dtpSearchDateContrato.TabIndex = 33;
            this.dtpSearchDateContrato.ValueChanged += new System.EventHandler(this.dtpSearchDateContrato_ValueChanged);
            // 
            // dtpSearchDateInscripcion
            // 
            this.dtpSearchDateInscripcion.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.dtpSearchDateInscripcion.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpSearchDateInscripcion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchDateInscripcion.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.dtpSearchDateInscripcion.Location = new System.Drawing.Point(15, 185);
            this.dtpSearchDateInscripcion.Name = "dtpSearchDateInscripcion";
            this.dtpSearchDateInscripcion.Size = new System.Drawing.Size(79, 20);
            this.dtpSearchDateInscripcion.TabIndex = 12;
            this.dtpSearchDateInscripcion.ValueChanged += new System.EventHandler(this.dtpSearchDateInscripcion_ValueChanged);
            // 
            // btnSearchFacturacion
            // 
            this.btnSearchFacturacion.Location = new System.Drawing.Point(116, 171);
            this.btnSearchFacturacion.Name = "btnSearchFacturacion";
            this.btnSearchFacturacion.Size = new System.Drawing.Size(90, 34);
            this.btnSearchFacturacion.TabIndex = 32;
            this.btnSearchFacturacion.Text = "Buscar x Fecha Inscripcion";
            this.btnSearchFacturacion.UseVisualStyleBackColor = true;
            this.btnSearchFacturacion.Click += new System.EventHandler(this.btnSearchFacturacion_Click);
            // 
            // btnSearchContrato
            // 
            this.btnSearchContrato.Location = new System.Drawing.Point(116, 123);
            this.btnSearchContrato.Name = "btnSearchContrato";
            this.btnSearchContrato.Size = new System.Drawing.Size(90, 34);
            this.btnSearchContrato.TabIndex = 31;
            this.btnSearchContrato.Text = "Buscar x Fecha Contrato";
            this.btnSearchContrato.UseVisualStyleBackColor = true;
            this.btnSearchContrato.Click += new System.EventHandler(this.btnSearchContrato_Click);
            // 
            // btnSearchLastname
            // 
            this.btnSearchLastname.Location = new System.Drawing.Point(116, 70);
            this.btnSearchLastname.Name = "btnSearchLastname";
            this.btnSearchLastname.Size = new System.Drawing.Size(90, 34);
            this.btnSearchLastname.TabIndex = 30;
            this.btnSearchLastname.Text = "Buscar Apellido";
            this.btnSearchLastname.UseVisualStyleBackColor = true;
            this.btnSearchLastname.Click += new System.EventHandler(this.btnSearchLastname_Click);
            // 
            // btnSearchNombre
            // 
            this.btnSearchNombre.Location = new System.Drawing.Point(116, 20);
            this.btnSearchNombre.Name = "btnSearchNombre";
            this.btnSearchNombre.Size = new System.Drawing.Size(90, 34);
            this.btnSearchNombre.TabIndex = 29;
            this.btnSearchNombre.Text = "Buscar por Nombre";
            this.btnSearchNombre.UseVisualStyleBackColor = true;
            this.btnSearchNombre.Click += new System.EventHandler(this.btnSearchNombre_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Inscripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Contrato";
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(15, 84);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(79, 20);
            this.txtSearchLastName.TabIndex = 3;
            this.txtSearchLastName.TextChanged += new System.EventHandler(this.txtSearchLastName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Apellido";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(15, 36);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(79, 20);
            this.txtSearchName.TabIndex = 1;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nombre";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBuscarXCodigo);
            this.Controls.Add(this.btnOrdenApellido);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrdenApellido;
        private System.Windows.Forms.Button btnBuscarXCodigo;
        private System.Windows.Forms.DateTimePicker txtEnrollmentDate;
        private System.Windows.Forms.DateTimePicker txtHireDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpSearchDateContrato;
        private System.Windows.Forms.DateTimePicker dtpSearchDateInscripcion;
        private System.Windows.Forms.Button btnSearchFacturacion;
        private System.Windows.Forms.Button btnSearchContrato;
        private System.Windows.Forms.Button btnSearchLastname;
        private System.Windows.Forms.Button btnSearchNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label11;
    }
}

