namespace Financiera.Dominio
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
        public string Observacion { get; set; }
        public string Foto { get; set; }
    }
}
