using parcial.Dominio;
using System.Collections.Generic;
using System.Data.Sql

namespace Pea2.Data
{
    public class ClienteData
    {
        public List<Cliente>Listar()
        {
            var listado = new List<Cliente>();
            using (var conexion = new sqlConnection())
                return listado;

        }
        public Cliente BuscarPorId(int id)
        {
            var Cliente = new Cliente();
            return Cliente;
        }
        public bool Insertar()
        {
            return true;
        }
        public bool Actualizar(Cliente cliente)
        {
            return true;
        }

        public bool Eliminar(Cliente cliente)
        {
            return true;
        }
    }
}
