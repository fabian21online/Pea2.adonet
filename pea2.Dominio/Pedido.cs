﻿using System;

namespace parcial.Dominio
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public  DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public bool Estado { get; set; }

    }
}
