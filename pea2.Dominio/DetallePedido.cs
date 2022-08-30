using System;

namespace Financiera.Dominio
{
    public class DetallePedido
    {
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public int cantidad { get; set; }
        public decimal Precio { get; set; }

    }
}
