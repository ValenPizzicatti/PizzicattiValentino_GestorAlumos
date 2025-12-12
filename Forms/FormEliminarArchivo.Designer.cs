namespace PizzicattiValentino_GestorAlumos.Forms
{
    partial class FormEliminarArchivo
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
            lblRuta = new Label();
            btnEliminar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRuta.Location = new Point(145, 9);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(61, 22);
            lblRuta.TabIndex = 0;
            lblRuta.Text = "label1";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(316, 78);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(93, 78);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormEliminarArchivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 126);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(lblRuta);
            Name = "FormEliminarArchivo";
            Text = "FormEliminarArchivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRuta;
        private Button btnEliminar;
        private Button btnCancelar;
    }
}