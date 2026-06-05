using Gestion_Donaciones.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Donaciones
{
    public partial class FrmProyectos : Form
    {
        private ProyectoController _proyectoController = new ProyectoController();

        bool editar = false;
        bool cancelar = false;

        int idProyecto = 0;
        public FrmProyectos()
        {
            InitializeComponent();

            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvProyectos.DataSource = _proyectoController.todos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreProyecto.Text == "")
            {
                MessageBox.Show("Ingrese la descripcion");
                return;

            }

            string respuesta = _proyectoController.Nuevo(
                txtNombreProyecto.Text,
                txtDescripcion.Text
                );
            if (respuesta == "OK")
            {
                MessageBox.Show("Proyecto registrado correctamente");
                CargarDatos();
                Limpiar();
            }
            else
            {
                MessageBox.Show(respuesta);
            }
        }

        private void Limpiar()
        {
            txtNombreProyecto.Text = "";
            txtDescripcion.Text = "";

            txtNombreProyecto.Focus();
        }

        private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                DataGridViewRow fila = dgvProyectos.Rows[e.RowIndex];

                idProyecto = Convert.ToInt32(fila.Cells["Id"].Value);

                txtNombreProyecto.Text = fila.Cells["NombreProyecto"].Value.ToString();

                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProyecto == 0) 
            {
                MessageBox.Show("Seleccione un proyecto para eliminar");
                return;
            }

            string respuesta = _proyectoController.Eliminar(idProyecto);

            MessageBox.Show(respuesta);
            CargarDatos();
            Limpiar();
        }

    }
}
