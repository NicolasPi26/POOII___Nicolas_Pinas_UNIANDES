namespace Gestion_Donaciones
{
    partial class FrmProyectos
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
            btnGuardar = new Button();
            txtNombreProyecto = new TextBox();
            txtDescripcion = new TextBox();
            label2 = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            dgvProyectos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 31);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del proyecto";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(57, 283);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 40);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombreProyecto
            // 
            txtNombreProyecto.Location = new Point(23, 49);
            txtNombreProyecto.Name = "txtNombreProyecto";
            txtNombreProyecto.PlaceholderText = "Coloque el nombre del proyecto";
            txtNombreProyecto.Size = new Size(137, 23);
            txtNombreProyecto.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(23, 126);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Colocar la descripcion";
            txtDescripcion.Size = new Size(589, 134);
            txtDescripcion.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 108);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 3;
            label2.Text = "Descripcion del proyecto";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(254, 283);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(101, 40);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(465, 283);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 40);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvProyectos
            // 
            dgvProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProyectos.Location = new Point(26, 347);
            dgvProyectos.Name = "dgvProyectos";
            dgvProyectos.Size = new Size(586, 284);
            dgvProyectos.TabIndex = 7;
            dgvProyectos.CellContentClick += dgvProyectos_CellContentClick;
            // 
            // FrmProyectos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 643);
            Controls.Add(dgvProyectos);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(txtNombreProyecto);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Name = "FrmProyectos";
            Text = "FrmProyectos";
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGuardar;
        private TextBox txtNombreProyecto;
        private TextBox txtDescripcion;
        private Label label2;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgvProyectos;
    }
}