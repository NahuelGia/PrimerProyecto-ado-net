using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class DiscoNegocio
    {
        public List<Disco> listarDisco()
        {
            List<Disco> listaActual = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();
            

            try
            {
                datos.asignarConsulta("SELECT d.Id, d.Titulo, d.FechaLanzamiento, d.CantidadCanciones, d.UrlImagenTapa, e.Descripcion Estilo , te.Descripcion Edicion \r\nFROM DISCOS  d \r\nJOIN ESTILOS e ON e.id = d.IdEstilo \r\nJOIN TIPOSEDICION te ON te.id = d.IdTipoEdicion");
                datos.ejecutarLectura();

                while (datos.Lector.Read()) // Cargo los discos con su info
                {
                    Disco disco = new Disco();
                    disco.TipoEdicion = new Tipo();
                    disco.Genero = new Estilo();

                    disco.Id = (int)datos.Lector["Id"];
                    disco.Titulo = (string)datos.Lector["Titulo"];
                    disco.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    disco.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    disco.UrlImagen = (string)datos.Lector["UrlImagenTapa"];
                    disco.TipoEdicion.Nombre = (string)datos.Lector["Edicion"];
                    disco.Genero.Nombre = (string)datos.Lector["Estilo"];

                    listaActual.Add(disco);

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
