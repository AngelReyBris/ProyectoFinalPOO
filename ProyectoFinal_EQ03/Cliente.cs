using System;
using System.Collections.Generic;
// Clase Cliente
public class Cliente {
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public ProgramaDeLealtad ProgramaDeLealtad { get; set; }
    public CarritoDeCompras CarritoDeCompras { get; set; }
    public decimal Saldo { get; set; }
    public string Contrasena { get; set; } // se agrega propiedad Contrasena

 public Cliente(string nombre, string correo, string direccion, string telefono, string contrasena) {
    this.Nombre = nombre;
    this.Correo = correo;
    this.Direccion = direccion;
    this.Telefono = telefono;
    this.ProgramaDeLealtad = new ProgramaDeLealtad();
    this.CarritoDeCompras = new CarritoDeCompras();
    this.Saldo = 0;
    this.Contrasena = contrasena;
}
    public void RealizarVenta(Ticket ticket)
    {
        // Agregar el ticket a la lista de tickets del cliente
        this.ProgramaDeLealtad.AñadirPuntos(ticket.Total);
        this.CarritoDeCompras.Vaciar();
    }
    public void DescontarSaldo(decimal cantidad)
    {
    this.Saldo -= cantidad;
    }
}
