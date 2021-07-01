using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;

namespace proyectoDB_tienda_online.DB
{
    class MetodosDB
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString);
        SqlCommand instruccion;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        //Metodo para encriptar contraseña:
        public static string Get_SHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++)
            {
                sb.AppendFormat("{0:x2}", stream[i]);
            }
            return sb.ToString();
        }
        public bool insertarUsuario(string nombre,string apellido, string email, string contrasenia)
        {
            try
            {
                contrasenia = Get_SHA256(contrasenia);
                instruccion = new SqlCommand("sp_registrarUsuario", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                instruccion.Parameters.AddWithValue("@Nombres", nombre);
                instruccion.Parameters.AddWithValue("@Apellidos", apellido);
                instruccion.Parameters.AddWithValue("@Correo", email);
                instruccion.Parameters.AddWithValue("@Contrasena", contrasenia);
                instruccion.Parameters.AddWithValue("@EsAdministrador", false);
                instruccion.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                conexion.Open();
                instruccion.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        public delegate void imprimir(string texto);
        public imprimir DelAsignarNombre;
        public bool obtenerUsuario(string correo,string contrasena)
        {
            bool flag = false;
            try
            {
                contrasena = Get_SHA256(contrasena);
                instruccion = new SqlCommand("sp_obtenerUsuario", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                instruccion.Parameters.AddWithValue("@Correo", correo);
                instruccion.Parameters.AddWithValue("@Contrasena", contrasena);
                conexion.Open();
                dr = instruccion.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[3].ToString().Equals(correo) && dr[4].ToString().Equals(contrasena))
                    {
                        miDelegado(Convert.ToBoolean(dr[5]));
                        DelAsignarNombre(dr[1].ToString());
                        flag = true;
                        break;
                    }
                }
                return flag;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        public int obtenerIDusuario(string contrasena,string correo)
        {
            int id = -1;
            try
            {
                contrasena = Get_SHA256(contrasena);
                instruccion = new SqlCommand("sp_obtenerIdUsuario", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                instruccion.Parameters.AddWithValue("@contrasena", contrasena);
                instruccion.Parameters.AddWithValue("@correo", correo);
                conexion.Open();
               dr= instruccion.ExecuteReader();
                while (dr.Read())
                {
                    id = Int32.Parse(dr[0].ToString());
                    break;
                }
                return id;
            }
            catch (Exception)
            {

                return -1; 
            }
            finally
            {
                conexion.Close();
            }
        }
       public delegate void delegadopermisos(bool permiso);
       public delegadopermisos miDelegado;
      
        #region Categorias
        public DataTable listadoCategorias()
        {

            return obtenerCategorias();
        }
        DataTable obtenerCategorias()
        {
            try
            {
                instruccion = new SqlCommand("sp_obtenerCategoria", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                dr = instruccion.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                conexion.Close();
            }
        }

        public bool editarCategoria(int id, string descripcion, bool activa)
        {
            bool flag = false;
            try
            {
                instruccion = new SqlCommand("sp_ModificarCategoria", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                instruccion.Parameters.AddWithValue("@IdCategoria", id);
                instruccion.Parameters.AddWithValue("@Descripcion", descripcion);
                instruccion.Parameters.AddWithValue("@Activo", activa);
                instruccion.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                conexion.Open();
                instruccion.ExecuteNonQuery();
                flag = Convert.ToBoolean(instruccion.Parameters["@Resultado"].Value);
                return flag;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        bool aux = false;
        public bool agregarCategoria(string descripcionCategoria)
        {
            aux = false;
            try
            {
                instruccion = new SqlCommand("sp_RegistrarCategoria", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                instruccion.Parameters.AddWithValue("@Descripcion", descripcionCategoria);
                instruccion.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                conexion.Open();
                instruccion.ExecuteNonQuery();
                aux = Convert.ToBoolean(instruccion.Parameters["@Resultado"].Value);
                return aux;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        #endregion


        #region Marcas
        public DataTable listadoMarcas()
        {

            return obtenerMarcas();
        }
        DataTable obtenerMarcas()
        {
            try
            {
                instruccion = new SqlCommand("sp_obtenerMarca", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                dr = instruccion.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                conexion.Close();
            }
        }

        public bool editarMarca(int id, string descripcion, bool activa)
        {
            bool flag = false;
            try
            {
                instruccion = new SqlCommand("sp_ModificarMarca", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                instruccion.Parameters.AddWithValue("@IdMarca", id);
                instruccion.Parameters.AddWithValue("@Descripcion", descripcion);
                instruccion.Parameters.AddWithValue("@Activo", activa);
                instruccion.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                conexion.Open();
                instruccion.ExecuteNonQuery();
                flag = Convert.ToBoolean(instruccion.Parameters["@Resultado"].Value);
                return flag;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
      
        public bool agregarMarca(string descripcionMarca)
        {
            aux = false;
            try
            {
                instruccion = new SqlCommand("sp_RegistrarMarca", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                instruccion.Parameters.AddWithValue("@Descripcion", descripcionMarca);
                instruccion.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                conexion.Open();
                instruccion.ExecuteNonQuery();
                aux = Convert.ToBoolean(instruccion.Parameters["@Resultado"].Value);
                return aux;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        #endregion


        #region  Productos
        int idMarca(string marca)
        {
            int id = -1;
            try
            {
                instruccion = new SqlCommand("sp_idMarca", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                instruccion.Parameters.AddWithValue("@DescripcionMarca", marca);
                instruccion.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                conexion.Open();
                instruccion.ExecuteNonQuery();
                id = Convert.ToInt32(instruccion.Parameters["@id"].Value);
                return id;
            }
            catch
            {
                return -1;
            }
            finally
            {
                conexion.Close();
            }
        }
        int idCategoria(string categoria)
        {
            int id = -1;
            try
            {
                instruccion = new SqlCommand("sp_idCategoria", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                instruccion.Parameters.AddWithValue("@DescripcionCategoria", categoria);
                instruccion.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                conexion.Open();
                instruccion.ExecuteNonQuery();
                id = Convert.ToInt32(instruccion.Parameters["@id"].Value);
                return id;
            }
            catch
            {
                return -1;
            }
            finally
            {
                conexion.Close();
            }
        }
        public DataTable listadoProductos()
        {
            try
            {
                dt = new DataTable();
                instruccion = new SqlCommand("sp_obtenerProducto", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                conexion.Open();
               dr= instruccion.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                conexion.Close();
            }
        }
        public bool agregarProducto(string nombre,string descripcion,string marca,string categoria,double precio,int stock,string rutaImagen)
        {
            aux = false;
            try
            {
                int id_categoria = idCategoria(categoria);
                int id_marca = idMarca(marca);
                instruccion = new SqlCommand("sp_registrarProducto", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                instruccion.Parameters.AddWithValue("@Nombre", nombre);
                instruccion.Parameters.AddWithValue("@Descripcion", descripcion);
                instruccion.Parameters.AddWithValue("@IdMarca", id_marca);
                instruccion.Parameters.AddWithValue("@IdCategoria", id_categoria);
                instruccion.Parameters.AddWithValue("@Precio", precio);
                instruccion.Parameters.AddWithValue("@Stock", stock);
                instruccion.Parameters.AddWithValue("@RutaImagen", rutaImagen);
                instruccion.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                conexion.Open();
                instruccion.ExecuteNonQuery();
                aux = true;
                return aux;
            }
            catch (Exception ex)
            {
                string msj = ex.Message;

                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        public bool editarProducto(int idProducto,string nombre,string descripcion,string marca,string categoria,double precio,int stock,bool activo)
        {
            aux = false;
            try
            {
                int id_categoria = idCategoria(categoria);
                int id_marca = idMarca(marca);
                instruccion = new SqlCommand("sp_editarProducto", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                instruccion.Parameters.AddWithValue("@IdProducto", idProducto);
                instruccion.Parameters.AddWithValue("@Nombre", nombre);
                instruccion.Parameters.AddWithValue("@Descripcion", descripcion);
                instruccion.Parameters.AddWithValue("@IdMarca", id_marca);
                instruccion.Parameters.AddWithValue("@IdCategoria", id_categoria);
                instruccion.Parameters.AddWithValue("@Precio", precio);
                instruccion.Parameters.AddWithValue("@Stock", stock);
                instruccion.Parameters.AddWithValue("@Activo", activo);
                instruccion.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                conexion.Open();
                instruccion.ExecuteNonQuery();
                aux = Convert.ToBoolean(instruccion.Parameters["@Resultado"].Value);
                return
                    aux;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        #endregion

        #region Vista para usuarios
        public DataTable listaMarcasUsuarios()
        {
            try
            {
                dt = new DataTable();
                instruccion = new SqlCommand("sp_obtenerMarcaUsuario", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                dr = instruccion.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                conexion.Close();
            }
        }
        public DataTable listaCategoriaUsuarios()
        {
            try
            {
                dt = new DataTable();
                instruccion = new SqlCommand("sp_obtenerCategoriaUsuario", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                dr = instruccion.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                conexion.Close();
            }
        }
        public DataTable listaProductoUsuarios()
        {
            try
            {
                dt = new DataTable();
                instruccion = new SqlCommand("sp_obtenerProductoUsuario", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                dr = instruccion.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                conexion.Close();
            }
        }
        public bool agregarAlCarrito(int idUsuario, int idProducto)
        {
            try
            {
                dt = new DataTable();
                instruccion = new SqlCommand("sp_InsertarCarrito", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                instruccion.Parameters.AddWithValue("@IdUsuario", idUsuario);
                instruccion.Parameters.AddWithValue("@IdProducto", idProducto);
                instruccion.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                conexion.Open();
                instruccion.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        public DataTable verCarrito(int idUsuario)
        {
            try
            {
                dt = new DataTable();
                instruccion = new SqlCommand("sp_ObtenerCarrito", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                instruccion.Parameters.AddWithValue("@IdUsuario", idUsuario);
                conexion.Open();
                dr = instruccion.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }

        public bool realizarCompra(int idUsuario,int TotalArticulos,double TotalPagar,string contacto,string telefono,string direccion)
        {
            aux = false;
            try
            {
                instruccion = new SqlCommand("sp_registrarCompra", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                instruccion.Parameters.AddWithValue("@IdUsuario",idUsuario);
                instruccion.Parameters.AddWithValue("@TotalProducto", TotalArticulos);
                instruccion.Parameters.AddWithValue("@Total", TotalPagar);
                instruccion.Parameters.AddWithValue("@Contacto", contacto);
                instruccion.Parameters.AddWithValue("@Telefono", telefono);
                instruccion.Parameters.AddWithValue("@Direccion", direccion);
                instruccion.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                conexion.Open();
                instruccion.ExecuteNonQuery();
                aux = Convert.ToBoolean(instruccion.Parameters["@Resultado"].Value);
               

                return aux;
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        public bool detalleCompra(int idUsuario, int idProducto,int cantidad,double total)
        {
            try
            {
                dt = new DataTable();
                instruccion = new SqlCommand("sp_detalleCompra", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                instruccion.Parameters.AddWithValue("@idUsuario", idUsuario);
                instruccion.Parameters.AddWithValue("@idProducto", idProducto);
                instruccion.Parameters.AddWithValue("@cantidad", cantidad);
                instruccion.Parameters.AddWithValue("@total", total);
                conexion.Open();
                instruccion.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        public bool eliminarCarrito(int idUsuario)
        {
            try
            {
                instruccion = new SqlCommand("sp_eliminarCarrito", conexion);
                instruccion.CommandType = CommandType.StoredProcedure;
                instruccion.Parameters.AddWithValue("@idUsuario", idUsuario);
                conexion.Open();
                instruccion.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        #endregion
    }
}
