namespace PizzicattiValentino_GestorAlumos.src
{
    partial class CrearArchivo
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
            txtNombreArchivo = new TextBox();
            label1 = new Label();
            rdbTxt = new RadioButton();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtCantidadAlumnos = new TextBox();
            label2 = new Label();
            rdbCsv = new RadioButton();
            rdbJson = new RadioButton();
            rdbXml = new RadioButton();
            btnSiguiente = new Button();
            btnVolver = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreArchivo
            // 
            txtNombreArchivo.Location = new Point(116, 71);
            txtNombreArchivo.Name = "txtNombreArchivo";
            txtNombreArchivo.Size = new Size(100, 23);
            txtNombreArchivo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 32);
            label1.Name = "label1";
            label1.Size = new Size(328, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el nombre del archivo que desea crear (sin extension)";
            // 
            // rdbTxt
            // 
            rdbTxt.AutoSize = true;
            rdbTxt.Location = new Point(97, 131);
            rdbTxt.Name = "rdbTxt";
            rdbTxt.Size = new Size(42, 19);
            rdbTxt.TabIndex = 2;
            rdbTxt.TabStop = true;
            rdbTxt.Text = ".txt";
            rdbTxt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCantidadAlumnos);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rdbCsv);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rdbJson);
            groupBox1.Controls.Add(txtNombreArchivo);
            groupBox1.Controls.Add(rdbXml);
            groupBox1.Controls.Add(rdbTxt);
            groupBox1.Location = new Point(33, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 306);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "CrearArchivo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 265);
            label3.Name = "label3";
            label3.Size = new Size(188, 15);
            label3.TabIndex = 7;
            label3.Text = "¿Cuantos alumnos desea ingresar?";
            // 
            // txtCantidadAlumnos
            // 
            txtCantidadAlumnos.Location = new Point(206, 262);
            txtCantidadAlumnos.Name = "txtCantidadAlumnos";
            txtCantidadAlumnos.Size = new Size(100, 23);
            txtCantidadAlumnos.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 110);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "Extension";
            // 
            // rdbCsv
            // 
            rdbCsv.AutoSize = true;
            rdbCsv.Location = new Point(171, 131);
            rdbCsv.Name = "rdbCsv";
            rdbCsv.Size = new Size(45, 19);
            rdbCsv.TabIndex = 3;
            rdbCsv.TabStop = true;
            rdbCsv.Text = ".csv";
            rdbCsv.UseVisualStyleBackColor = true;
            // 
            // rdbJson
            // 
            rdbJson.AutoSize = true;
            rdbJson.Location = new Point(97, 183);
            rdbJson.Name = "rdbJson";
            rdbJson.Size = new Size(50, 19);
            rdbJson.TabIndex = 4;
            rdbJson.TabStop = true;
            rdbJson.Text = ".json";
            rdbJson.UseVisualStyleBackColor = true;
            // 
            // rdbXml
            // 
            rdbXml.AutoSize = true;
            rdbXml.Location = new Point(171, 183);
            rdbXml.Name = "rdbXml";
            rdbXml.Size = new Size(48, 19);
            rdbXml.TabIndex = 5;
            rdbXml.TabStop = true;
            rdbXml.Text = ".xml";
            rdbXml.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(249, 350);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 4;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(63, 350);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // CrearArchivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 440);
            Controls.Add(btnVolver);
            Controls.Add(btnSiguiente);
            Controls.Add(groupBox1);
            Name = "CrearArchivo";
            Text = "CrearArchivo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombreArchivo;
        private Label label1;
        private RadioButton rdbTxt;
        private GroupBox groupBox1;
        private RadioButton rdbCsv;
        private RadioButton rdbJson;
        private RadioButton rdbXml;
        private Label label2;
        private Button btnSiguiente;
        private Button btnVolver;
        private Label label3;
        private TextBox txtCantidadAlumnos;
    }
}