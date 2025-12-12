namespace PizzicattiValentino_GestorAlumos.Forms
{
    partial class FormSolicitarArchiv
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
            btnContinuar = new Button();
            SuspendLayout();
            // 
            // txtNombreArchivo
            // 
            txtNombreArchivo.Location = new Point(145, 58);
            txtNombreArchivo.Name = "txtNombreArchivo";
            txtNombreArchivo.Size = new Size(123, 23);
            txtNombreArchivo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 25);
            label1.Name = "label1";
            label1.Size = new Size(325, 21);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el nombre del archivo (con extension)";
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(334, 72);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(75, 23);
            btnContinuar.TabIndex = 2;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // FormSolicitarArchiv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 107);
            Controls.Add(btnContinuar);
            Controls.Add(label1);
            Controls.Add(txtNombreArchivo);
            Name = "FormSolicitarArchiv";
            Text = "FormSolicitarArchiv";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreArchivo;
        private Label label1;
        private Button btnContinuar;
    }
}