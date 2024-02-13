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
        public List<Disco> listar()
        {
            List<Disco> listaActual = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();
            

            try
            {
                datos.asignarConsulta("SELECT d.Id, d.Titulo, d.FechaLanzamiento, d.CantidadCanciones, d.UrlImagenTapa, e.Descripcion Estilo , te.Descripcion Edicion \r\nFROM DISCOS  d \r\nJOIN GENEROS e ON e.id = d.IdGenero \r\nJOIN FORMATOS te ON te.id = d.IdFormato");
                datos.ejecutarLectura();

                while (datos.Lector.Read()) // Cargo los discos con su info
                {
                    Disco disco = new Disco();
                    disco.Formato = new Formato();
                    disco.Genero = new Genero();

                    disco.Id = (int)datos.Lector["Id"];
                    disco.Titulo = (string)datos.Lector["Titulo"];
                    disco.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    disco.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    disco.UrlImagen = (string)datos.Lector["UrlImagenTapa"];
                    disco.Formato.Nombre = (string)datos.Lector["Edicion"];
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

        public void Agregar(Disco nuevoDisco)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.asignarConsulta("INSERT INTO DISCOS VALUES ( @titulo, @fechaLanzamiento, @cantidadCanciones, @urlImagen, @idGenero, @idFormato)");

                datos.setearParametro("@titulo", nuevoDisco.Titulo);
                datos.setearParametro("@fechaLanzamiento", nuevoDisco.FechaLanzamiento.ToString("yyyy/MM/dd"));
                datos.setearParametro("@cantidadCanciones", nuevoDisco.CantidadCanciones);
                datos.setearParametro("@urlImagen", "Proximamente");
                datos.setearParametro("@idGenero", nuevoDisco.Genero.Id);
                datos.setearParametro("@idFormato", nuevoDisco.Formato.Id);

                datos.ejecutarAccion();
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
