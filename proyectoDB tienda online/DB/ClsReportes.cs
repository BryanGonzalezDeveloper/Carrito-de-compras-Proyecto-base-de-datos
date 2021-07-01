using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace proyectoDB_tienda_online.DB
{
    class ClsReportes
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString);
        SqlCommand instruccion;
        SqlDataReader dr;
        DataTable dt;
        public DataTable top3ProductosCaros()
        {
            try
            {
                dt = new DataTable();
                instruccion = new SqlCommand("sp_top3ProductosCaros", conexion);
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
        public DataTable top3ProductosBaratos()
        {
            try
            {
                dt = new DataTable();
                instruccion = new SqlCommand("sp_top3ProductosBaratos", conexion);
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
        public DataTable ProductoMayorStock()
        {
            try
            {
                dt = new DataTable();
                instruccion = new SqlCommand("sp_mayorStock", conexion);
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
        public DataTable ProductoMenorStock()
        {
            try
            {
                dt = new DataTable();
                instruccion = new SqlCommand("sp_menorStock", conexion);
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
        public DataTable promedioVentas()
        {
            try
            {
                dt = new DataTable();
                instruccion = new SqlCommand("sp_promedioVentas", conexion);
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
        public DataTable categoriaSinArticulo()
        {
            try
            {
                dt = new DataTable();
                instruccion = new SqlCommand("sp_categoriaSinArticulos", conexion);
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
    }
}
