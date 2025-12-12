namespace PizzicattiValentino_GestorAlumos.Forms
{
    partial class EliminarArchivoSolicitarArchivo
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
            txtRuta = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            btnCancelar = new Button();
            btnContinuar = new Button();
            dgvInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInfo).BeginInit();
            SuspendLayout();
            // 
            // txtRuta
            // 
            txtRuta.Location = new Point(93, 56);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(209, 23);
            txtRuta.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(460, 21);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el nombre (con extension) del archivo que desea eliminar";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(344, 56);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(93, 305);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(358, 305);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(75, 23);
            btnContinuar.TabIndex = 4;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // dgvInfo
            // 
            dgvInfo.AllowUserToAddRows = false;
            dgvInfo.AllowUserToDeleteRows = false;
            dgvInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfo.Location = new Point(23, 113);
            dgvInfo.MultiSelect = false;
            dgvInfo.Name = "dgvInfo";
            dgvInfo.ReadOnly = true;
            dgvInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfo.Size = new Size(460, 150);
            dgvInfo.TabIndex = 5;
            // 
            // EliminarArchivoSolicitarArchivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 356);
            Controls.Add(dgvInfo);
            Controls.Add(btnContinuar);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(txtRuta);
            Name = "EliminarArchivoSolicitarArchivo";
            Text = "EliminarArchivoSolicitarArchivo";
            ((System.ComponentModel.ISupportInitialize)dgvInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRuta;
        private Label label1;
        private Button btnBuscar;
        private Button btnCancelar;
        private Button btnContinuar;
        private DataGridView dgvInfo;
    }
}