using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class FormatoNegocio
    {
        public List<Formato> listar()
        {
			AccesoDatos datos = new AccesoDatos();
			List<Formato> listaActual = new List<Formato>();

			try
			{
				datos.asignarConsulta("SELECT * FROM FORMATOS");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Formato formato = new Formato();

					formato.Id = (int)datos.Lector["id"];
					formato.Nombre = (string)datos.Lector["Descripcion"];

					listaActual.Add(formato);
				}
				return listaActual;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally 
			{
				datos.cerrarConexion();
			}
        }
    }
}
