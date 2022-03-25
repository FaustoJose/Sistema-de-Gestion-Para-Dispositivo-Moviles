using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.Conexcion
{
    public class CN_Inventario
    {
        private CD_Inventario objetoCD = new CD_Inventario();
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPRod(string codigo, string nombre, string descriplion, string idCategoria, string stock, string precioCompra, string precioventa, string estado, string fechaRegistro)
        {
            objetoCD.Insertar(codigo, nombre, descriplion, Convert.ToInt32(idCategoria), Convert.ToInt32(stock), Convert.ToDouble(precioCompra), Convert.ToDouble(precioventa), Convert.ToBoolean(estado), Convert.ToDateTime(fechaRegistro));
        }
        public void EditarProd(string idProducto, string codigo, string nombre, string descriplion, string idCategoria, string stock, string precioCompra, string precioventa, string estado, string fechaRegistro)
        {
            objetoCD.Editar(Convert.ToInt32(idProducto), codigo, nombre, descriplion, Convert.ToInt32(idCategoria), Convert.ToInt32(stock), Convert.ToDouble(precioCompra), Convert.ToDouble(precioventa), Convert.ToBoolean(estado), Convert.ToDateTime(fechaRegistro));
        }
        public void EliminarPRod(string idProducto)
        {
            objetoCD.Eliminar(Convert.ToInt32(idProducto));
        }
    }
}
