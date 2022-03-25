using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.Clases
{
    public class Detalle_Venta
    {
        /*
         */
        public int IdDetalleventa { set; get; }
        public int Idventa { set; get; }
        public int IdProducto { set; get; }
        public double Precioventa { set; get; }
        public int Cantidad { set; get; }
        public double SubTotal { set; get; }
        public DateTime FechaRegistro { set; get; }
    }
}
