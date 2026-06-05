using Gestion_Donaciones.Models;
using Gestion_Donaciones.data;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Gestion_Donaciones.Controllers
{
    public class DonanteController
    {
        public List<DonanteModel> todos() 
        {
            return DonanteSqlData.todos();
        }

        public string Nuevo( string Nombre,
            string Telefono,
            string Correo
            )
        {
            DonanteModel model = new DonanteModel
            {
                Nombre = Nombre,
                Telefono = Telefono,        
                Correo = Correo

            };

            return DonanteSqlData.Nuevo(model);
        }
    }
}
