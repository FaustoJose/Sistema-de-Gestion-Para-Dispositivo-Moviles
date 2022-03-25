using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema_de_Gestion_Para_Dispositivo_Moviles.Clases;

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.Conexcion
{
    class CN_Ventas
    {

        private CD_Ventas objetoCD = new CD_Ventas();
        public DataTable MostrarProducto(string codigo)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(codigo);
            return tabla;
        }

        public DataTable MostrarVenta()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }



        /*public void InsertarVenta(string idUsuario, string tipoDocumento, string numeroDocumento, string nombrecliente, string montoPago, string montoCambio, string montoTotal, string lst)
        {
            objetoCD.Insertar(Convert.ToInt32(idUsuario), tipoDocumento, numeroDocumento, Convert.ToDouble(montoPago), Convert.ToDouble(montoCambio), Convert.ToDouble(montoTotal), lst.ToList<>);
        }*/
        public void EditarVenta(string idventa, string idUsuario, string tipoDocumento, string numeroDocumento, string documentocliente, string nombrecliente, string montoPago, string montoCambio, string montoTotal, string fechaRegistro)
        {
            objetoCD.Editar(Convert.ToInt32(idventa), Convert.ToInt32(idUsuario), tipoDocumento, numeroDocumento, documentocliente, nombrecliente, Convert.ToDouble(montoPago), Convert.ToDouble(montoCambio), Convert.ToDouble(montoTotal), Convert.ToDateTime(fechaRegistro));
        }
        public void EliminarVenta(string idventa)
        {
            objetoCD.Eliminar(Convert.ToInt32(idventa));
        }

    }
}
