using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using negocio;

namespace filtros
{
    public class FiltroABd
    {

        public List<Disco> filtrar(string campo, string criterio, string condicion)
        {   
            DiscoNegocio negocio = new DiscoNegocio();
            String filtro;

            if (campo == "Título") // "Título"
            {   
                filtro = filtrarPorLetras("Titulo", criterio, condicion);  
            } 
            else if (campo == "Fecha De Lanzamiento")
            {
                filtro = filtrarPorFecha("FechaLanzamiento", criterio, condicion);
            } 
            else
            {
               filtro = filtrarPorNumero("CantidadCanciones", criterio, condicion);
            }

            return negocio.filtrar(filtro);
            
        }

        public string filtrarPorFecha(string campo, string criterio, string condicion)
        {
            switch (criterio)
            {
                case "Mayor a..":
                    return campo + " > '" + condicion + "'";
                case "Menor a..":
                    return campo + " < '" + condicion + "'";
                default:
                    return campo + " = '" + condicion + "'";
            }
        }

        public string filtrarPorNumero(string campo, string criterio, string condicion)
        {
            switch (criterio)
            {
                case "Mayor a..":
                    return campo + " > " + condicion;
                case "Menor a..":
                    return campo + " < " + condicion;
                default:
                    return campo + " = " + condicion;
            }
        }

        public string filtrarPorLetras(string campo, string criterio, string condicion)
        {
            switch (criterio)
            {
                case "Empieza con..":
                    return campo + " like '" + condicion + "%' ";

                case "Termina con..":
                    return campo + " like '%" + condicion + "' ";
                default:
                    return campo + " like '%" + condicion + "%'";

            }
        }


    }
}
