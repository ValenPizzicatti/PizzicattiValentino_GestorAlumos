namespace PizzicattiValentino_GestorAlumos.Forms
{
    partial class FormModificarAlumno
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnBuscar = new Button();
            txtLegajoBusqueda = new TextBox();
            groupDatos = new GroupBox();
            btnGuardar = new Button();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            txtNombre = new TextBox();
            txtLegajo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupDatos.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtLegajoBusqueda);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 108);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar alumno por legajo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 2;
            label1.Text = "Legajo: ";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(258, 73);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtLegajoBusqueda
            // 
            txtLegajoBusqueda.Location = new Point(88, 41);
            txtLegajoBusqueda.Name = "txtLegajoBusqueda";
            txtLegajoBusqueda.Size = new Size(111, 23);
            txtLegajoBusqueda.TabIndex = 0;
            // 
            // groupDatos
            // 
            groupDatos.Controls.Add(label8);
            groupDatos.Controls.Add(btnGuardar);
            groupDatos.Controls.Add(txtTelefono);
            groupDatos.Controls.Add(txtEmail);
            groupDatos.Controls.Add(txtApellido);
            groupDatos.Controls.Add(txtDocumento);
            groupDatos.Controls.Add(txtNombre);
            groupDatos.Controls.Add(txtLegajo);
            groupDatos.Controls.Add(label7);
            groupDatos.Controls.Add(label6);
            groupDatos.Controls.Add(label5);
            groupDatos.Controls.Add(label4);
            groupDatos.Controls.Add(label3);
            groupDatos.Controls.Add(label2);
            groupDatos.Enabled = false;
            groupDatos.Location = new Point(12, 161);
            groupDatos.Name = "groupDatos";
            groupDatos.Size = new Size(366, 266);
            groupDatos.TabIndex = 1;
            groupDatos.TabStop = false;
            groupDatos.Text = "Datos del alumno";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(236, 132);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(88, 237);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(88, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(88, 93);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 10;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(88, 165);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(100, 23);
            txtDocumento.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(88, 129);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(88, 59);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(100, 23);
            txtLegajo.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 240);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 5;
            label7.Text = "Telefono: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 205);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(42, 15);
            label6.TabIndex = 4;
            label6.Text = "Email: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 168);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 3;
            label5.Text = "Documento: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 132);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 2;
            label4.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 101);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 1;
            label3.Text = "Apellido: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 62);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Legajo: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 28);
            label8.Name = "label8";
            label8.Size = new Size(285, 15);
            label8.TabIndex = 14;
            label8.Text = "Dejar vacio si es que quiere mantener el dato original";
            // 
            // FormModificarAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 425);
            Controls.Add(groupDatos);
            Controls.Add(groupBox1);
            Name = "FormModificarAlumno";
            Text = "FormModificarAlumno";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupDatos.ResumeLayout(false);
            groupDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnBuscar;
        private TextBox txtLegajoBusqueda;
        private GroupBox groupDatos;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private TextBox txtNombre;
        private TextBox txtLegajo;
        private Button btnGuardar;
        private Label label8;
    }
}