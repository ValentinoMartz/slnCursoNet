using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Producto
    {
        /*  public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Matricula { get; set; } */
        
        public string Nombre { get; set; }
        public string Descricion { get; set;}
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }

        //get PrecioBruto y PrecioVenta decimales
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }

        public decimal PrecioBruto
        {
            get
            {
                decimal _precioBruto = Convert.ToDecimal(1 + this.Margen) * PrecioCosto;
                return _precioBruto;
            }
        }

        public decimal PrecioVenta
        {
            get
            {
                decimal _precioVenta = Convert.ToDecimal(1 + this.IVA) * PrecioBruto;
                return _precioVenta;
            }
        }
    }
}
