using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.Clases
{
    public class Inventario
    {
        private string Codigo;
        private string Categoria;
        private string Marca;
        private string Modelo;
        private string Clasificacion;
        private string Subclasificacion;
        private string Cararteristicas;
        private string Provedor;
        private double Precio;
        private int Strock;

        public void setCodigo(string codigo)
        {
            this.Codigo = codigo;
        }

        public string getCodigo()
        {
            return this.Codigo;
        }


    }
}
