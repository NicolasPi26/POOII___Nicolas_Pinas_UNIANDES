using Gestion_Donaciones.Controllers;


namespace Gestion_Donaciones
{
    public partial class FrmDonaciones : Form
    {
        private DonacionController _donacioncontroller = new DonacionController();

        private DonanteController _donantecontroller = new DonanteController();

        private ProyectoController _proyectocontroller = new ProyectoController();

        bool editar = false;
        bool cancelar = false;

        int idDonacion = 0;
        public FrmDonaciones()
        {
            InitializeComponent();

            CargarDonantes();
            CargarProyectos();
            CargarDonaciones();

            cmbMetodoPago.Items.Add("Efectivo");
            cmbMetodoPago.Items.Add("Transferencia");
            cmbMetodoPago.Items.Add("Tarjeta");
        }

        private void CargarDonantes()
        {
            cmbDonante.DataSource = _donantecontroller.todos();
            cmbDonante.DisplayMember = "Nombre";
            cmbDonante.ValueMember = "IdDonante";
        }

        private void CargarProyectos()
        {
            cmbProyecto.DataSource = _proyectocontroller.todos();
            cmbProyecto.DisplayMember = "NombreProyecto";
            cmbProyecto.ValueMember = "IdProyecto";
        }

        private void CargarDonaciones()
        {
            dgvDonaciones.DataSource = _donacioncontroller.todos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text == "")
            {
                MessageBox.Show("Ingrese un monto");
                return;
            }

            if (cmbMetodoPago.Text == "")
            {
                MessageBox.Show("Seleccione un método de pago");
                return;
            }

            string respuesta = _donacioncontroller.Nuevo(
                Convert.ToInt32(cmbDonante.SelectedValue),
                Convert.ToInt32(cmbProyecto.SelectedValue),
                Convert.ToDecimal(txtMonto.Text),
                dtpFecha.Value,
                cmbMetodoPago.Text);

            if (respuesta == "Ok")
            {
                MessageBox.Show("Donación registrada correctamente");
                Limpiar();
                CargarDonaciones();
            }
            else
            {
                MessageBox.Show(respuesta);
            }
        }

        private void dgvDonaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView fila = dgvDonaciones.Rows[e.RowIndex];

                idDonacion = Convert.ToInt32(fila.Cells["IdDonacion"].Value);

                txtMonto.Text = fila.Cells["Monto"].Value.ToString();
            
                cmbMetodoPago.Text = fila.Cells["MetodoPago"].Value.ToString();
            }
        }
    }
}
