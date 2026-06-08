namespace Tarea4_Semana4_POOII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblEstado.Click += lblEstado_Click;

            txtNumero.KeyPress += txtNumero_KeyPress;

            PanelImagen.DragEnter += PanelImagen_DragEnter;
            PanelImagen.DragDrop += PanelImagen_DragDrop;

            btnIniciar.Click += (s, e) =>
            {
                timer1.Start();
                lblEstado.Text = "Estado: Timer iniciando";
            };

            timer1.Tick += timer1_Tick;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Estado: Click detectado";
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PanelImagen_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void PanelImagen_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (archivos.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(archivos[0]);
            }
        }
        private int Contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Contador++;
            lblEstado.Text = $"Tiempo: {Contador} segundos";
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Estado: Click detectado";
        }
    }
}
