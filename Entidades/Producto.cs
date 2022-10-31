using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnCursoNet.Entidades
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public decimal PrecioBruto 
        {
            get
            {
               decimal _PrecioBruto = Convert.ToDecimal(this.PrecioCosto) + Convert.ToDecimal(Margen);
                return _PrecioBruto;
            } 
            
        }
        public decimal PrecioVenta { get
            {
                decimal _PrecioVenta = this.PrecioBruto + Convert.ToDecimal(IVA);
                return _PrecioVenta;
            } }
        public string Proveedor { get; set; }
        public string Categoria    { get; set; }
        public string SubCategoria { get; set; }

    }
}
