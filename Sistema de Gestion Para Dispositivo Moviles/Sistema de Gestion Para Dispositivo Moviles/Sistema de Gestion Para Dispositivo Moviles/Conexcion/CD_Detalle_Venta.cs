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
    public class CD_Detalle_Venta
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar(int Idventa)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarDetalle_Venta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idventa", Idventa);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
       

        /*
          private int IdDetelle_Venta { set; get; }
        private int Idventa { set; get; }
        private double Precioventa { set; get; }
        private int Cantidad { set; get; }
        private double SubTotal { set; get; }
        private DateTime FechaRegistro { set; get; } 
         */

        /*public void Insertar(List<Detalle_Venta> lst)
        {
               


                 tabla.Columns.Add("Idventa");
                 tabla.Columns.Add("Precioventa");
                 tabla.Columns.Add("Cantidad");
                 tabla.Columns.Add("SubTotal");
                 tabla.Columns.Add("FechaRegistro");
            foreach (var oElement in lst)
            {
                tabla.Rows.Add( oElement.Idventa, oElement.Precioventa, oElement.Cantidad, oElement.SubTotal, oElement.FechaRegistro);
               
            }

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "InsetarDetalle_Venta";
                comando.CommandType = CommandType.StoredProcedure;
                var parametroLista = new SqlParameter("@lstConceptos", SqlDbType.Structured);
                parametroLista.TypeName = "DESCUENTO_CLIENTE";
                parametroLista.Value = tabla;


                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            
        }*/
        public void Editar(int idDetalleventa, int idventa, int idProducto, double precioventa, int cantidad, double subTotal, DateTime fechaRegistro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarDetalle_Venta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idDetalleventa", idDetalleventa);
            comando.Parameters.AddWithValue("@idventa", idventa);
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.Parameters.AddWithValue("@precioventa", precioventa);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@subTotal", subTotal);
            comando.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar(int idDetalleventa)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarDetalle_Venta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idDetalleventa", idDetalleventa);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
