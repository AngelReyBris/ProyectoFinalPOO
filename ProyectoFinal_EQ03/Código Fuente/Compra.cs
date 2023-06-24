using System;
using System.Collections.Generic;

// Clase Compra
public class Compra {
    public Cliente Cliente { get; set; }
    public Ticket Ticket { get; set; }

    public Compra(Cliente cliente, Ticket ticket)
    {
        this.Cliente = cliente;
        this.Ticket = ticket;
    }

    public override string ToString()
    {
        return "Fecha: " + this.Ticket.Fecha + ", Total: " + this.Ticket.Total;
    }
}