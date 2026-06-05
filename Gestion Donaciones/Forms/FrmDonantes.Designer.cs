namespace Gestion_Donaciones
{
    partial class FrmDonantes
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
            txtNombre = new TextBox();
            txtNumero = new TextBox();
            label2 = new Label();
            txtCorreo = new TextBox();
            label3 = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnConsultar = new Button();
            dgvDonantes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDonantes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(23, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre...";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(168, 39);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numero de telefono";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 21);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(313, 39);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo Electronico";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 21);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Correo";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(23, 109);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 52);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(23, 188);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 53);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(23, 271);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(100, 53);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // dgvDonantes
            // 
            dgvDonantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonantes.Location = new Point(156, 87);
            dgvDonantes.Name = "dgvDonantes";
            dgvDonantes.Size = new Size(388, 280);
            dgvDonantes.TabIndex = 9;
            // 
            // FrmDonantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 450);
            Controls.Add(dgvDonantes);
            Controls.Add(btnConsultar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtCorreo);
            Controls.Add(label3);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FrmDonantes";
            Text = "FrmDonantes";
            ((System.ComponentModel.ISupportInitialize)dgvDonantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtNumero;
        private Label label2;
        private TextBox txtCorreo;
        private Label label3;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnConsultar;
        private DataGridView dgvDonantes;
    }
}