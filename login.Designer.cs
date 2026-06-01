namespace TareaN3_Semana3_Nicolas_Piñas
{
    partial class login
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Inicio de sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 53);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(38, 223);
            button1.Name = "button1";
            button1.Size = new Size(95, 33);
            button1.TabIndex = 3;
            button1.Text = "Iniciar sesion";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(145, 223);
            button2.Name = "button2";
            button2.Size = new Size(95, 33);
            button2.TabIndex = 4;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 23);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 125);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 128, 128);
            label4.Location = new Point(33, 176);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 7;
            label4.Text = "Label4";
            label4.Visible = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 299);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            Text = "Consultas Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
    }
}
