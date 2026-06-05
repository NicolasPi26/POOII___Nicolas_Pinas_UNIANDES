using System;


namespace Gestion_Donaciones.Models
{
    public class DonacionModel
    {
        public int IdDonacion { get; set; }
        public int IdDonante { get; set; }
        public int IdProyecto { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string MetodoPago { get; set; }

    }
}
