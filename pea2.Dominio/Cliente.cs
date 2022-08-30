namespace parcial.Dominio
{
    public class Cliente
    {
        // GET => Leer
        // SET => Escribir
        public int IdCliente { get; set; }
        public string NroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Observacion { get; set; }
        public string Nombres { get; set; }

        public string NombreCompleto
        {
            get
            {
                return this.Nombre;
            }
        }
    }
}
