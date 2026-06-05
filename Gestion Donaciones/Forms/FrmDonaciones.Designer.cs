namespace Gestion_Donaciones
{
    partial class FrmDonaciones
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
            cmbDonante = new ComboBox();
            label1 = new Label();
            txtMonto = new TextBox();
            dtpFecha = new DateTimePicker();
            btnGuardar = new Button();
            dgvDonaciones = new DataGridView();
            label2 = new Label();
            cmbProyecto = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cmbMetodoPago = new ComboBox();
            label5 = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDonaciones).BeginInit();
            SuspendLayout();
            // 
            // cmbDonante
            // 
            cmbDonante.FormattingEnabled = true;
            cmbDonante.Location = new Point(25, 41);
            cmbDonante.Name = "cmbDonante";
            cmbDonante.Size = new Size(121, 23);
            cmbDonante.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre Donante";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(25, 118);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 2;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(25, 189);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(25, 248);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvDonaciones
            // 
            dgvDonaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonaciones.Location = new Point(25, 288);
            dgvDonaciones.Name = "dgvDonaciones";
            dgvDonaciones.Size = new Size(497, 328);
            dgvDonaciones.TabIndex = 5;
            dgvDonaciones.CellContentClick += dgvDonaciones_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 100);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Monto";
            // 
            // cmbProyecto
            // 
            cmbProyecto.FormattingEnabled = true;
            cmbProyecto.Location = new Point(200, 41);
            cmbProyecto.Name = "cmbProyecto";
            cmbProyecto.Size = new Size(121, 23);
            cmbProyecto.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 23);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombre Proyecto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 171);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "Fecha";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(387, 41);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(121, 23);
            cmbMetodoPago.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 23);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 11;
            label5.Text = "Metodo de Pago";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(229, 248);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(433, 248);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmDonaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 628);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(label5);
            Controls.Add(cmbMetodoPago);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbProyecto);
            Controls.Add(label2);
            Controls.Add(dgvDonaciones);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFecha);
            Controls.Add(txtMonto);
            Controls.Add(label1);
            Controls.Add(cmbDonante);
            Name = "FrmDonaciones";
            Text = "FrmDonaciones";
            ((System.ComponentModel.ISupportInitialize)dgvDonaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDonante;
        private Label label1;
        private TextBox txtMonto;
        private DateTimePicker dtpFecha;
        private Button btnGuardar;
        private DataGridView dgvDonaciones;
        private Label label2;
        private ComboBox cmbProyecto;
        private Label label3;
        private Label label4;
        private ComboBox cmbMetodoPago;
        private Label label5;
        private Button btnEditar;
        private Button btnEliminar;
    }
}