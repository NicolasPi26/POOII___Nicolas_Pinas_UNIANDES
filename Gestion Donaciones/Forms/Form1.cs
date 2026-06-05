namespace Gestion_Donaciones
{
    public partial class Form1 : Form
    {
        int intentos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContrasenia.Text;

            if (usuario == "admin" && contraseña == "1234")
            {
                var dashboard = new FrmMenu();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                intentos++;
                lblIntentos.Text = "intentos restantes:" + (3 - intentos);
                lblIntentos.Visible = true;

                if (intentos >= 3)
                {
                    MessageBox.Show("Has alcanzado el número máximo de intentos.");
                    Application.Exit();
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblIntentos.Text = "intentos restantes: 3";
            lblIntentos.Visible = true;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
