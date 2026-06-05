namespace Gestion_Donaciones
{
    partial class Form1
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
            label2 = new Label();
            txtUsuario = new TextBox();
            btn_ingresar = new Button();
            btn_Salir = new Button();
            txtContrasenia = new TextBox();
            label3 = new Label();
            lblIntentos = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 23);
            label1.Name = "label1";
            label1.Size = new Size(78, 19);
            label1.TabIndex = 0;
            label1.Text = "ONG Piñas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(20, 84);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingresar usuario...";
            txtUsuario.Size = new Size(219, 25);
            txtUsuario.TabIndex = 2;
            // 
            // btn_ingresar
            // 
            btn_ingresar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ingresar.Location = new Point(20, 220);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(106, 34);
            btn_ingresar.TabIndex = 3;
            btn_ingresar.Text = "Inciar sesion";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Salir.Location = new Point(149, 220);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(75, 34);
            btn_Salir.TabIndex = 4;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContrasenia.Location = new Point(20, 141);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PlaceholderText = "Ingresar contraseña...";
            txtContrasenia.Size = new Size(219, 25);
            txtContrasenia.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 117);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // lblIntentos
            // 
            lblIntentos.AutoSize = true;
            lblIntentos.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIntentos.ForeColor = Color.Red;
            lblIntentos.Location = new Point(20, 182);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(47, 19);
            lblIntentos.TabIndex = 7;
            lblIntentos.Text = "label4";
            lblIntentos.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 272);
            ControlBox = false;
            Controls.Add(lblIntentos);
            Controls.Add(txtContrasenia);
            Controls.Add(label3);
            Controls.Add(btn_Salir);
            Controls.Add(btn_ingresar);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Gestion de donaciones";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Button btn_ingresar;
        private Button btn_Salir;
        private TextBox txtContrasenia;
        private Label label3;
        private Label lblIntentos;
    }
}
