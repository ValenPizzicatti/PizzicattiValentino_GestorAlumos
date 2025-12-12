namespace PizzicattiValentino_GestorAlumos.Forms
{
    partial class FormEliminarAlumno
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
            txtLegajo = new TextBox();
            dgvAlumno = new DataGridView();
            btnCancelar = new Button();
            btnEliminar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumno).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtLegajo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 130);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese un numero de legajo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 48);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Legajo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(203, 91);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(84, 45);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(100, 23);
            txtLegajo.TabIndex = 1;
            // 
            // dgvAlumno
            // 
            dgvAlumno.AllowUserToAddRows = false;
            dgvAlumno.AllowUserToDeleteRows = false;
            dgvAlumno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumno.Location = new Point(12, 175);
            dgvAlumno.Name = "dgvAlumno";
            dgvAlumno.ReadOnly = true;
            dgvAlumno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumno.Size = new Size(421, 180);
            dgvAlumno.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(37, 417);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 42);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(294, 417);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 42);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormEliminarAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 500);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(dgvAlumno);
            Controls.Add(groupBox1);
            Name = "FormEliminarAlumno";
            Text = "FormEliminarAlumno";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumno).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnBuscar;
        private TextBox txtLegajo;
        private DataGridView dgvAlumno;
        private Button btnCancelar;
        private Button btnEliminar;
    }
}