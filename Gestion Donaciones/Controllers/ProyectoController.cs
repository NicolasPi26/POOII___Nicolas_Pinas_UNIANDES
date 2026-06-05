using Gestion_Donaciones.data;
using Gestion_Donaciones.Models;
using System.Collections.Generic;

namespace Gestion_Donaciones.Controllers
{
    public class ProyectoController
    {
        public List<ProyectoModel> todos()
        {
            return ProyectoSqlData.todos();
        }

        public ProyectoSqlData uno(int id)
        {
            return ProyectoSqlData.uno(id);
        }

        public string Nuevo(string nombreProyecto, string descripcion)
        {
            ProyectoModel proyecto = new ProyectoModel
            {
                NombreProyecto = nombreProyecto,
                Descripcion = descripcion
            };
            return ProyectoSqlData.Nuevo(proyecto);
        }

        public string Editar(int id, string nombreProyecto, string descripcion)
        {
            ProyectoModel model = new ProyectoModel
            {
                IdProyecto = id,
                NombreProyecto = nombreProyecto,
                Descripcion = descripcion
            };
            return ProyectoSqlData.Editar(model);
        }

        public string Eliminar(int id)
        {
            return ProyectoSqlData.Eliminar(id);
        }
    }
}
