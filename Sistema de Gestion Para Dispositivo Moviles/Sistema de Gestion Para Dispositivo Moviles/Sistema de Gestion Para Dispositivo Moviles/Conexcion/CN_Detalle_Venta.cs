using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.Conexcion
{
    public class CN_Detalle_Venta
    {
        CD_Detalle_Venta objetoCD = new CD_Detalle_Venta();
        public DataTable MostrarVenta(string idventa)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(Convert.ToInt32(idventa));
            return tabla;
        }



        /*public void InsertarDetalle_Venta(string idventa, string idProducto, string precioventa, string cantidad, string subTotal, string fechaRegistro)
        {
            objetoCD.Insertar(Convert.ToInt32(idventa), Convert.ToInt32(idProducto), Convert.ToDouble(precioventa), Convert.ToInt32(cantidad), Convert.ToDouble(subTotal), Convert.ToDateTime(fechaRegistro));
        }*/
        public void EditarDetalle_Venta(string idDetalleventa , string idventa, string idProducto, string precioventa, string cantidad, string subTotal, string fechaRegistro)
        {
            objetoCD.Editar(Convert.ToInt32(idDetalleventa), Convert.ToInt32(idventa), Convert.ToInt32(idProducto), Convert.ToDouble(precioventa), Convert.ToInt32(cantidad), Convert.ToDouble(subTotal), Convert.ToDateTime(fechaRegistro));
        }
        public void EliminarDetalle_Venta(string idDetalleventa)
        {
            objetoCD.Eliminar(Convert.ToInt32(idDetalleventa));
        }
    }
}
