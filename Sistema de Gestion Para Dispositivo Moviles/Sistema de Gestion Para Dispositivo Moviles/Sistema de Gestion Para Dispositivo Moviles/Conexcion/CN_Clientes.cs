using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.Conexcion
{
    public class CN_Clientes
    {
        private CD_Clientes objetoCD = new CD_Clientes();
        public DataTable MostrarCliente()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public DataTable MostrarCliente(string codigo)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(codigo);
            return tabla;
        }
        public void InsertarCliente(string documento, string nombreCompleto, string correo, string telefono, string idCategoriaCliente, string idDescuento, string estado,string fechaRegistro)
        {
            objetoCD.Insertar(documento, nombreCompleto, correo, telefono, Convert.ToInt32(idCategoriaCliente), Convert.ToInt32(idDescuento), Convert.ToBoolean(estado), Convert.ToDateTime(fechaRegistro));
        }
        public void EditarCliente(string idCliente,string documento, string nombreCompleto, string correo, string telefono, string idCategoriaCliente, string idDescuento, string estado, string fechaRegistro)
        {
            objetoCD.Editar(Convert.ToInt32(idCliente), documento, nombreCompleto, correo, telefono, Convert.ToInt32(idCategoriaCliente), Convert.ToInt32(idDescuento), Convert.ToBoolean(estado), Convert.ToDateTime(fechaRegistro));
        }
        public void EliminarCliente(string idCliente)
        {
            objetoCD.Eliminar(Convert.ToInt32(idCliente));
        }
    }
}
