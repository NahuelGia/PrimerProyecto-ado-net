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
                datos.asignarConsulta("SELECT d.Id, d.Titulo, d.FechaLanzamiento, d.CantidadCanciones, d.UrlImagenTapa, g.Descripcion Estilo, g.id IdEstilo , f.id IdFormato ,f.Descripcion Edicion FROM DISCOS  d JOIN GENEROS g ON g.id = d.IdGenero JOIN FORMATOS f ON f.id = d.IdFormato WHERE d.Activo = 1 ");
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
                    disco.Formato.Id = (int)datos.Lector["IdFormato"];
                    disco.Genero.Nombre = (string)datos.Lector["Estilo"];
                    disco.Genero.Id = (int)datos.Lector["IdEstilo"];

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

        public void agregar(Disco nuevoDisco)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.asignarConsulta("INSERT INTO DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdGenero, IdFormato) VALUES ( @titulo, @fechaLanzamiento, @cantidadCanciones, @urlImagen, @idGenero, @idFormato)");

                datos.setearParametro("@titulo", nuevoDisco.Titulo);
                datos.setearParametro("@fechaLanzamiento", nuevoDisco.FechaLanzamiento.ToString("yyyy/MM/dd"));
                datos.setearParametro("@cantidadCanciones", nuevoDisco.CantidadCanciones);
                datos.setearParametro("@urlImagen", nuevoDisco.UrlImagen);
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

        public void modificar(Disco discoModificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.asignarConsulta("UPDATE DISCOS SET Titulo = @titulo, FechaLanzamiento = @fechaLanzamiento, CantidadCanciones = @cantCanciones, UrlImagenTapa = @urlImagen, IdGenero = @idGenero, IdFormato= @idFormato WHERE Id = @idDisco");

                datos.setearParametro("@titulo", discoModificado.Titulo);
                datos.setearParametro("@fechaLanzamiento", discoModificado.FechaLanzamiento.ToString("yyyy/MM/dd"));
                datos.setearParametro("@cantCanciones", discoModificado.CantidadCanciones);
                datos.setearParametro("@urlImagen", discoModificado.UrlImagen);
                datos.setearParametro("@idGenero", discoModificado.Genero.Id);
                datos.setearParametro("@idFormato", discoModificado.Formato.Id);
                datos.setearParametro("@idDisco", discoModificado.Id);

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

        public void eliminar(Disco seleccionado)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();

                datos.asignarConsulta("UPDATE DISCOS SET Activo = 0 WHERE Id = @idDisco");
                datos.setearParametro("@idDisco", seleccionado.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
