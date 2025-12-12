namespace PizzicattiValentino_GestorAlumos.Forms
{
    partial class FormConvertir
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
            txtArchivoOrigen = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            cmbFormatoDestino = new ComboBox();
            label = new Label();
            label3 = new Label();
            txtNuevoNombre = new TextBox();
            label2 = new Label();
            btnConvertir = new Button();
            dgvResumen = new DataGridView();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtArchivoOrigen
            // 
            txtArchivoOrigen.Location = new Point(114, 67);
            txtArchivoOrigen.Name = "txtArchivoOrigen";
            txtArchivoOrigen.Size = new Size(185, 23);
            txtArchivoOrigen.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 28);
            label1.Name = "label1";
            label1.Size = new Size(392, 36);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el nombre del archivo a convertir(con extensión)\r\n\r\n";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(415, 109);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(92, 26);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbFormatoDestino
            // 
            cmbFormatoDestino.FormattingEnabled = true;
            cmbFormatoDestino.Location = new Point(52, 172);
            cmbFormatoDestino.Name = "cmbFormatoDestino";
            cmbFormatoDestino.Size = new Size(298, 23);
            cmbFormatoDestino.TabIndex = 3;
            cmbFormatoDestino.Text = "Formato de archivo";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(52, 124);
            label.Name = "label";
            label.Size = new Size(0, 15);
            label.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 88);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 5;
            label3.Text = "Formato actual";
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Location = new Point(219, 233);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(161, 23);
            txtNuevoNombre.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 241);
            label2.Name = "label2";
            label2.Size = new Size(148, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre del nuevo archivo";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(420, 273);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 8;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // dgvResumen
            // 
            dgvResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumen.Location = new Point(6, 302);
            dgvResumen.Name = "dgvResumen";
            dgvResumen.Size = new Size(562, 150);
            dgvResumen.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dgvResumen);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(btnConvertir);
            groupBox1.Controls.Add(cmbFormatoDestino);
            groupBox1.Controls.Add(txtNuevoNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 468);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // FormConvertir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 691);
            Controls.Add(groupBox1);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(txtArchivoOrigen);
            Name = "FormConvertir";
            Text = "FormConvertir";
            ((System.ComponentModel.ISupportInitialize)dgvResumen).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArchivoOrigen;
        private Label label1;
        private Button btnBuscar;
        private ComboBox cmbFormatoDestino;
        private Label label;
        private Label label3;
        private TextBox txtNuevoNombre;
        private Label label2;
        private Button btnConvertir;
        private DataGridView dgvResumen;
        private GroupBox groupBox1;
    }
}