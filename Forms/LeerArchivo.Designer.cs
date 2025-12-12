namespace PizzicattiValentino_GestorAlumos.Forms
{
    partial class LeerArchivo
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
            label1 = new Label();
            txtNombreArchivo = new TextBox();
            btnContinuar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 27);
            label1.Name = "label1";
            label1.Size = new Size(261, 15);
            label1.TabIndex = 0;
            label1.Text = "Escriba el archivo que desea leer (con extensión)";
            // 
            // txtNombreArchivo
            // 
            txtNombreArchivo.Location = new Point(132, 58);
            txtNombreArchivo.Name = "txtNombreArchivo";
            txtNombreArchivo.Size = new Size(149, 23);
            txtNombreArchivo.TabIndex = 1;
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(352, 94);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(75, 23);
            btnContinuar.TabIndex = 2;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // LeerArchivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 120);
            Controls.Add(btnContinuar);
            Controls.Add(txtNombreArchivo);
            Controls.Add(label1);
            Name = "LeerArchivo";
            Text = "LeerArchivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreArchivo;
        private Button btnContinuar;
    }
}