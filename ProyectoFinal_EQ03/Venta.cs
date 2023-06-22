using System;
using System.Collections.Generic;

// Definición de la clase MetodoPago
public class MetodoPago {
    public string Nombre { get; set; }
    public string NumeroTarjeta { get; set; }
    public decimal Saldo { get; set; }
    public bool TarjetaCredito { get; set; }
    public bool TarjetaDebito { get; set; }
    public bool Efectivo { get; set; }

    public MetodoPago() {
        this.Saldo = 0;
    }
}

 public class Venta {
    private static int contadorIdCompra = 0;
    public List<Producto> Productos { get; set; }
    public List<int> Cantidades { get; set; }
    public MetodoPago MetodoPago { get; set; }
    public Cliente Cliente { get; set; }
    public Ticket Ticket { get; set; }
    public Empleado Empleado { get; set; } // Agregar esta propiedad
    public int IdCompra { get; private set; }

    decimal saldo;

    public Venta() {
        this.Productos = new List<Producto>();
        this.Cantidades = new List<int>();
        this.MetodoPago = new MetodoPago();
        this.saldo = this.MetodoPago.Saldo;
    }
    public Venta(List<Producto> productos, List<int> cantidades, Cliente cliente) {
        this.Productos = productos;
        this.Cantidades = cantidades;
        this.Cliente = cliente;
        this.MetodoPago = new MetodoPago();
        this.saldo = this.MetodoPago.Saldo;
        this.IdCompra = ++contadorIdCompra;
    }

    public Venta(List<Producto> productos, List<int> cantidades, MetodoPago metodoPago, Cliente cliente) {
        this.Productos = productos;
        this.Cantidades = cantidades;
        this.MetodoPago = metodoPago;
        this.Cliente = cliente;
        this.saldo = this.MetodoPago.Saldo;
        this.IdCompra = ++contadorIdCompra;
    }

    public decimal ObtenerTotal() {
        decimal total = 0;
        for (int i = 0; i < this.Productos.Count; i++) {
            total += this.Productos[i].Precio * this.Cantidades[i];
        }
        return total;
    }
}