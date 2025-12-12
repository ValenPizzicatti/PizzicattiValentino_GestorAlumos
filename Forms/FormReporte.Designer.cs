namespace PizzicattiValentino_GestorAlumos.Forms
{
    partial class FormReporte
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
            cmbFormato = new ComboBox();
            btnCargar = new Button();
            txtReporte = new TextBox();
            btnGuardarTXT = new Button();
            lblEstado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 27);
            label1.Name = "label1";
            label1.Size = new Size(322, 21);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el nombre del archivo (Sin extensión)";
            // 
            // txtNombreArchivo
            // 
            txtNombreArchivo.Location = new Point(387, 29);
            txtNombreArchivo.Name = "txtNombreArchivo";
            txtNombreArchivo.Size = new Size(100, 23);
            txtNombreArchivo.TabIndex = 1;
            // 
            // cmbFormato
            // 
            cmbFormato.FormattingEnabled = true;
            cmbFormato.Location = new Point(556, 29);
            cmbFormato.Name = "cmbFormato";
            cmbFormato.Size = new Size(121, 23);
            cmbFormato.TabIndex = 2;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(626, 89);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(88, 23);
            btnCargar.TabIndex = 3;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // txtReporte
            // 
            txtReporte.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReporte.Location = new Point(12, 131);
            txtReporte.Multiline = true;
            txtReporte.Name = "txtReporte";
            txtReporte.ReadOnly = true;
            txtReporte.ScrollBars = ScrollBars.Vertical;
            txtReporte.Size = new Size(754, 225);
            txtReporte.TabIndex = 4;
            // 
            // btnGuardarTXT
            // 
            btnGuardarTXT.Location = new Point(286, 389);
            btnGuardarTXT.Name = "btnGuardarTXT";
            btnGuardarTXT.Size = new Size(113, 35);
            btnGuardarTXT.TabIndex = 5;
            btnGuardarTXT.Text = "Guardar TXT";
            btnGuardarTXT.UseVisualStyleBackColor = true;
            btnGuardarTXT.Click += btnGuardarTXT_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(556, 399);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 15);
            lblEstado.TabIndex = 6;
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEstado);
            Controls.Add(btnGuardarTXT);
            Controls.Add(txtReporte);
            Controls.Add(btnCargar);
            Controls.Add(cmbFormato);
            Controls.Add(txtNombreArchivo);
            Controls.Add(label1);
            Name = "FormReporte";
            Text = "FormReporte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreArchivo;
        private ComboBox cmbFormato;
        private Button btnCargar;
        private TextBox txtReporte;
        private Button btnGuardarTXT;
        private Label lblEstado;
    }
}