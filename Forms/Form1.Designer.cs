namespace PizzicattiValentino_GestorAlumos
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnCrearArchivo = new Button();
            btnLeer = new Button();
            button2 = new Button();
            btnEliminarArchivo = new Button();
            txtConvertir = new Button();
            btnReporte = new Button();
            label2 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 36);
            label1.Name = "label1";
            label1.Size = new Size(241, 25);
            label1.TabIndex = 0;
            label1.Text = "Gestor de archivos de texto";
            // 
            // btnCrearArchivo
            // 
            btnCrearArchivo.Location = new Point(91, 94);
            btnCrearArchivo.Name = "btnCrearArchivo";
            btnCrearArchivo.Size = new Size(318, 36);
            btnCrearArchivo.TabIndex = 1;
            btnCrearArchivo.Text = "Crear nuevo archivo";
            btnCrearArchivo.UseVisualStyleBackColor = true;
            btnCrearArchivo.Click += btnCrearArchivo_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(91, 136);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(318, 36);
            btnLeer.TabIndex = 2;
            btnLeer.Text = "Leer archivo existente";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // button2
            // 
            button2.Location = new Point(91, 178);
            button2.Name = "button2";
            button2.Size = new Size(318, 36);
            button2.TabIndex = 3;
            button2.Text = "Modificar Archivo Existente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnEliminarArchivo
            // 
            btnEliminarArchivo.Location = new Point(91, 220);
            btnEliminarArchivo.Name = "btnEliminarArchivo";
            btnEliminarArchivo.Size = new Size(318, 36);
            btnEliminarArchivo.TabIndex = 4;
            btnEliminarArchivo.Text = "Eliminar archivo existente";
            btnEliminarArchivo.UseVisualStyleBackColor = true;
            btnEliminarArchivo.Click += btnEliminarArchivo_Click;
            // 
            // txtConvertir
            // 
            txtConvertir.Location = new Point(91, 262);
            txtConvertir.Name = "txtConvertir";
            txtConvertir.Size = new Size(318, 36);
            txtConvertir.TabIndex = 5;
            txtConvertir.Text = "Convertir entre formatos";
            txtConvertir.UseVisualStyleBackColor = true;
            txtConvertir.Click += txtConvertir_Click;
            // 
            // btnReporte
            // 
            btnReporte.Location = new Point(91, 304);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(318, 36);
            btnReporte.TabIndex = 6;
            btnReporte.Text = "Crear reporte con corte de control";
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Click += btnReporte_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 76);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 7;
            label2.Text = "Seleccione una opcion:";
            // 
            // button6
            // 
            button6.Location = new Point(403, 366);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 8;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 396);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(btnReporte);
            Controls.Add(txtConvertir);
            Controls.Add(btnEliminarArchivo);
            Controls.Add(button2);
            Controls.Add(btnLeer);
            Controls.Add(btnCrearArchivo);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCrearArchivo;
        private Button btnLeer;
        private Button button2;
        private Button btnEliminarArchivo;
        private Button txtConvertir;
        private Button btnReporte;
        private Label label2;
        private Button button6;
    }
}
