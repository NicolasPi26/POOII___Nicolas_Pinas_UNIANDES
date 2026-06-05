using Microsoft.Data.SqlClient;
using System.Data;

namespace Gestion_Donaciones.data
{
    public static class ConexionSql
    {
        public static string Cadena =
            "Server=@\"Server=DESKTOP-M209H8F\\Nicop;\r\n              Database=ONG_Donaciones;\r\n              Trusted_Connection= True\r\n              TrustServerCertificate=True\";";
    }
}

