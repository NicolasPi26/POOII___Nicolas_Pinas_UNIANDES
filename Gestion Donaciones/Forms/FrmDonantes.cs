using Gestion_Donaciones.Controllers;
using Gestion_Donaciones.Models;
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
    public partial class FrmDonantes : Form
    {
       
        
        private DonanteController _donanteController = new DonanteController();

        bool editar = false;
        bool cancelar = false;


        
        public FrmDonantes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del donante.");
                return;
            }

            if (txtNumero.Text == "")
            {
                MessageBox.Show("Ingrese el número de contacto del donante.");
                return;
            }

            if (txtCorreo.Text == "") 
            {
                MessageBox.Show("Ingrese el correo electrónico del donante.");
                return;

            }

            // Guardado del donante

            string respuesta = _donanteController.Nuevo(
                txtNombre.Text,
                txtNumero.Text,
                txtCorreo.Text
                );

            if ( respuesta == "ok")
            {
                MessageBox.Show("Donante registrado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al registrar el donante: " + respuesta);
            }
        }
    }
}
