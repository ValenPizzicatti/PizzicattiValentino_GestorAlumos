namespace PizzicattiValentino_GestorAlumos.Forms
{
    partial class Submenu
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
            btnAgregarAlumno = new Button();
            btnModificarArchivo = new Button();
            btnEliminarAlumno = new Button();
            btnGuardarCambios = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAgregarAlumno
            // 
            btnAgregarAlumno.Location = new Point(78, 105);
            btnAgregarAlumno.Name = "btnAgregarAlumno";
            btnAgregarAlumno.Size = new Size(170, 40);
            btnAgregarAlumno.TabIndex = 0;
            btnAgregarAlumno.Text = "Agregar nuevo alumno";
            btnAgregarAlumno.UseVisualStyleBackColor = true;
            btnAgregarAlumno.Click += btnAgregarAlumno_Click;
            // 
            // btnModificarArchivo
            // 
            btnModificarArchivo.Location = new Point(78, 169);
            btnModificarArchivo.Name = "btnModificarArchivo";
            btnModificarArchivo.Size = new Size(170, 40);
            btnModificarArchivo.TabIndex = 1;
            btnModificarArchivo.Text = "Modificar Archivo";
            btnModificarArchivo.UseVisualStyleBackColor = true;
            btnModificarArchivo.Click += btnModificarArchivo_Click;
            // 
            // btnEliminarAlumno
            // 
            btnEliminarAlumno.Location = new Point(78, 234);
            btnEliminarAlumno.Name = "btnEliminarAlumno";
            btnEliminarAlumno.Size = new Size(170, 40);
            btnEliminarAlumno.TabIndex = 2;
            btnEliminarAlumno.Text = "Eliminar alumno";
            btnEliminarAlumno.UseVisualStyleBackColor = true;
            btnEliminarAlumno.Click += btnEliminarAlumno_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(202, 323);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(110, 28);
            btnGuardarCambios.TabIndex = 3;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 323);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 28);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Descartar Cambios";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 54);
            label1.Name = "label1";
            label1.Size = new Size(245, 25);
            label1.TabIndex = 5;
            label1.Text = "Modificar archivo existente ";
            // 
            // Submenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 396);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarCambios);
            Controls.Add(btnEliminarAlumno);
            Controls.Add(btnModificarArchivo);
            Controls.Add(btnAgregarAlumno);
            Name = "Submenu";
            Text = "Submenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarAlumno;
        private Button btnModificarArchivo;
        private Button btnEliminarAlumno;
        private Button btnGuardarCambios;
        private Button btnCancelar;
        private Label label1;
    }
}