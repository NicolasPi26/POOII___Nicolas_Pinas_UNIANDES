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
            button1 = new Button();
            button2 = new Button();
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
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(20, 220);
            button1.Name = "button1";
            button1.Size = new Size(106, 34);
            button1.TabIndex = 3;
            button1.Text = "Inciar sesion";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(149, 220);
            button2.Name = "button2";
            button2.Size = new Size(75, 34);
            button2.TabIndex = 4;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
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
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Gestion de donaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Button button1;
        private Button button2;
        private TextBox txtContrasenia;
        private Label label3;
        private Label lblIntentos;
    }
}
