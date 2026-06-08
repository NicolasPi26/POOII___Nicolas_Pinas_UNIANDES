namespace Tarea4_Semana4_POOII
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtNumero = new TextBox();
            PanelImagen = new Panel();
            pictureBox1 = new PictureBox();
            btnIniciar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblEstado = new Label();
            PanelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 38);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Subir su Imagen";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(23, 70);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(142, 23);
            txtNumero.TabIndex = 1;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // PanelImagen
            // 
            PanelImagen.AllowDrop = true;
            PanelImagen.Controls.Add(pictureBox1);
            PanelImagen.Location = new Point(23, 113);
            PanelImagen.Name = "PanelImagen";
            PanelImagen.Size = new Size(227, 130);
            PanelImagen.TabIndex = 2;
            PanelImagen.DragDrop += PanelImagen_DragDrop;
            PanelImagen.DragEnter += PanelImagen_DragEnter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 130);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(171, 70);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(88, 23);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar Timer";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.FromArgb(255, 128, 128);
            lblEstado.Location = new Point(23, 258);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(128, 20);
            lblEstado.TabIndex = 5;
            lblEstado.Text = "Estado: Detenido";
            lblEstado.Click += lblEstado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 313);
            Controls.Add(lblEstado);
            Controls.Add(btnIniciar);
            Controls.Add(PanelImagen);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            PanelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Panel PanelImagen;
        private Button btnIniciar;
        private System.Windows.Forms.Timer timer1;
        private Label lblEstado;
        private PictureBox pictureBox1;
    }
}
