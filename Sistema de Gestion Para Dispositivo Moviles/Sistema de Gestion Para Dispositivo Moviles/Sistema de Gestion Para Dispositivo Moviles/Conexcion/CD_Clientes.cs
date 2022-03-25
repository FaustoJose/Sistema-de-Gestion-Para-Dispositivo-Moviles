using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.Conexcion
{
    public class CD_Clientes
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable Mostrar(string codigo)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarClienteVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigo", codigo);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        /*
         @idCliente int,
@documento varchar(50), 
@nombreCompleto varchar (50), 
@correo varchar (50), 
@telefono varchar (50), 
@idCategoriaCliente  int,
@idDescuento int,
@estado bit, 
@fechaRegistro datetime
         */

        public void Insertar(string documento, string nombreCompleto, string correo, string telefono, int idCategoriaCliente, int idDescuento, bool estado, DateTime fechaRegistro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@idCategoriaCliente", idCategoriaCliente);
            comando.Parameters.AddWithValue("@idDescuento", idDescuento);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Editar(int idCliente, string documento, string nombreCompleto, string correo, string telefono, int idCategoriaCliente, int idDescuento, bool estado, DateTime fechaRegistro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@idCategoriaCliente", idCategoriaCliente);
            comando.Parameters.AddWithValue("@idDescuento", idDescuento);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar(int idCliente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
