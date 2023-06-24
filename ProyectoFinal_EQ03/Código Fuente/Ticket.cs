using System;
using System.Collections.Generic;


public class Ticket {
    public DateTime Fecha { get;set; }
    public Venta Venta { get; set; }
    public Sucursal Sucursal { get; set; }
    public decimal Total { get; set; }
    public string IdCompra { get; set; }

    public Ticket()
    {
        // initialize the properties
        Fecha = DateTime.Now;
        Venta = new Venta(); // or initialize with an existing instance of Venta
        Sucursal = new Sucursal(); // or initialize with an existing instance of Sucursal
        Total = 0;
        IdCompra = "";
    }

    public Ticket(Venta venta, Sucursal sucursal)
    {
        // initialize the properties
        Fecha = DateTime.Now;
        Venta = venta;
        Sucursal = sucursal;
        Total = venta.ObtenerTotal();
        IdCompra = Guid.NewGuid().ToString();
    }
}