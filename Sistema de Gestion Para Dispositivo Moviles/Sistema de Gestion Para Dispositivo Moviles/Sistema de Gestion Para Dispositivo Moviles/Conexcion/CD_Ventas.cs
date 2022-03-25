using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sistema_de_Gestion_Para_Dispositivo_Moviles.Clases;

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.Conexcion
{
    class CD_Ventas
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();



        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarVenta";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        /*
           
         */
        public void Insertar(int idUsuario, string tipoDocumento, string numeroDocumento,string nombrecliente, double montoPago, double montoCambio,double montoTotal, List<Detalle_Venta> lst)
        {

            
            //tabla.Columns.Add("IdDetalleventa");
            tabla.Columns.Add("IdProducto");
            tabla.Columns.Add("Precioventa");
            tabla.Columns.Add("Cantidad");
            tabla.Columns.Add("SubTotal");
            tabla.Columns.Add("FechaRegistro");
            int n = 1;
            foreach (var oElement in lst)
            {
               

                tabla.Rows.Add( oElement.IdProducto, oElement.Precioventa, oElement.Cantidad, oElement.SubTotal, oElement.FechaRegistro=DateTime.Now);
                n++;
            }

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarVenta";
            comando.CommandType = CommandType.StoredProcedure;
           
            var parametroLista = new SqlParameter("@lstDetalle", SqlDbType.Structured);
            parametroLista.TypeName = "DETALLESs";
            parametroLista.Value = tabla;
            comando.Parameters.Add(parametroLista);
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            comando.Parameters.AddWithValue("@tipoDocumento", tipoDocumento);
            comando.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);
            comando.Parameters.AddWithValue("@documentocliente","00001" );
            comando.Parameters.AddWithValue("@nombrecliente", nombrecliente);
            comando.Parameters.AddWithValue("@montoPago", montoPago);
            comando.Parameters.AddWithValue("@montoCambio", montoCambio);
            comando.Parameters.AddWithValue("@montoTotal", montoTotal);
            comando.Parameters.AddWithValue("@fechaRegistro", DateTime.Now);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Editar(int idventa, int idUsuario, string tipoDocumento, string numeroDocumento, string documentocliente, string nombrecliente, double montoPago, double montoCambio, double montoTotal, DateTime fechaRegistro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idventa", idventa);
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            comando.Parameters.AddWithValue("@tipoDocumento", tipoDocumento);
            comando.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);
            comando.Parameters.AddWithValue("@documentocliente", documentocliente);
            comando.Parameters.AddWithValue("@nombrecliente", nombrecliente);
            comando.Parameters.AddWithValue("@montoPago", montoPago);
            comando.Parameters.AddWithValue("@montoCambio", montoCambio);
            comando.Parameters.AddWithValue("@montoTotal", montoTotal);
            comando.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar(int idventa)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idventa", idventa);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable Mostrar(string codigo)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProdutoVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigo", codigo);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

    }
        
}
