using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class GeneroNegocio
    {
        public List<Genero> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Genero> listaActual = new List<Genero>();

            try
            {
                datos.asignarConsulta("SELECT * FROM GENEROS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Genero genero = new Genero();

                    genero.Id = (int)datos.Lector["id"];
                    genero.Nombre = (string)datos.Lector["Descripcion"];

                    listaActual.Add(genero);
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
