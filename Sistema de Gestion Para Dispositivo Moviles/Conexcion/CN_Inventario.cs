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
        public void InsertarPRod(string codigo, string categoria, string marca, string modelo, string clasificacion, string subclasificacion, string caracteristicas, string provedor, string precio, string stock)
        {
            objetoCD.Insertar(codigo, categoria, marca, modelo, clasificacion, subclasificacion, caracteristicas, provedor,Convert.ToDouble(precio), Convert.ToInt32(stock));
        }
        public void EditarProd(string codigo, string categoria, string marca, string modelo, string clasificacion, string subclasificacion, string caracteristicas, string provedor, string precio, string stock)
        {
            objetoCD.Editar(codigo, categoria, marca, modelo, clasificacion, subclasificacion, caracteristicas, provedor, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }
        public void EliminarPRod(string codigo)
        {
            objetoCD.Eliminar(codigo);
        }
    }
}
