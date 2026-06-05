namespace Gestion_Donaciones
{
    partial class FrmMenu
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
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            donantesToolStripMenuItem = new ToolStripMenuItem();
            proyectosToolStripMenuItem = new ToolStripMenuItem();
            donacionesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(273, 192);
            button1.Name = "button1";
            button1.Size = new Size(87, 71);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { donantesToolStripMenuItem, proyectosToolStripMenuItem, donacionesToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "&Salir";
            // 
            // donantesToolStripMenuItem
            // 
            donantesToolStripMenuItem.Name = "donantesToolStripMenuItem";
            donantesToolStripMenuItem.Size = new Size(180, 22);
            donantesToolStripMenuItem.Text = "Donantes";
            // 
            // proyectosToolStripMenuItem
            // 
            proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            proyectosToolStripMenuItem.Size = new Size(180, 22);
            proyectosToolStripMenuItem.Text = "Proyectos";
            // 
            // donacionesToolStripMenuItem
            // 
            donacionesToolStripMenuItem.Name = "donacionesToolStripMenuItem";
            donacionesToolStripMenuItem.Size = new Size(180, 22);
            donacionesToolStripMenuItem.Text = "Donaciones";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "FrmMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem donantesToolStripMenuItem;
        private ToolStripMenuItem donacionesToolStripMenuItem;
        private ToolStripMenuItem proyectosToolStripMenuItem;
    }
}