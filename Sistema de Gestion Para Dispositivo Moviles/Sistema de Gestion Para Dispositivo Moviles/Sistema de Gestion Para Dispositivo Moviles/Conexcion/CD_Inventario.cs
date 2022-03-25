using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.Conexcion
{
    public class CD_Inventario
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        /*
         @codigo varchar (50), 
@nombre varchar (50), 
@descriplion varchar (50), 
@idCategoria int, 
@stock int, 
@precioCompra decimal(10,2), 
@precioventa decimal (10,2), 
@estado bit, 
@fechaRegistro datetime 
         */
        public void Insertar(string codigo, string nombre, string descriplion, int idCategoria, int stock, double precioCompra, double precioventa, bool estado,DateTime fechaRegistro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descriplion", descriplion);
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@precioCompra", precioCompra);
            comando.Parameters.AddWithValue("@precioventa", precioventa);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Editar(int idProducto,string codigo, string nombre, string descriplion, int idCategoria, int stock, double precioCompra, double precioventa, bool estado, DateTime fechaRegistro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descriplion", descriplion);
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@precioCompra", precioCompra);
            comando.Parameters.AddWithValue("@precioventa", precioventa);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar(int idProducto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
