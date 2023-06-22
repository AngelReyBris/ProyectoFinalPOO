using System;
using System.Collections.Generic;

// Clase Pedido
class Pedido : CarritoDeCompras {
    public Cliente Cliente { get; set; }
    public DateTime Fecha { get; set; }

    public Pedido(Cliente cliente) {
        this.Cliente = cliente;
        this.Fecha = DateTime.Now;
    }
}
