using System;
using System.Collections.Generic;

// Clase Cliente
public class Cliente {
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public ProgramaDeLealtad ProgramaDeLealtad { get; set; }
    public CarritoDeCompras CarritoDeCompras { get; set; }
    public decimal Saldo { get; set; }
    public string Contrasena { get; set; }
    public List<Compra> Compras { get; set; } // Agregar propiedad Compras

    private string _nombreCompleto;
    public string NombreCompleto {
        get { return _nombreCompleto; }
        private set { _nombreCompleto = value; }
    }

    public Cliente(string nombre, string apellido, string correo, string direccion, string telefono, string contrasena) {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Correo = correo;
        this.Direccion = direccion;
        this.Telefono = telefono;
        this.ProgramaDeLealtad = new ProgramaDeLealtad();
        this.CarritoDeCompras = new CarritoDeCompras();
        this.Saldo = 0;
        this.Contrasena = contrasena;
        this.NombreCompleto = nombre + " " + apellido;
        this.Compras = new List<Compra>(); // Inicializar la lista de compras
    }

    public void ActualizarDatosPersonales(string nombreCompleto, string correo, string direccion, string telefono)
    {
        this.Correo = correo;
        this.Direccion = direccion;
        this.Telefono = telefono;
        this.NombreCompleto = nombreCompleto;
        string[] nombreApellido = nombreCompleto.Split(' ');
        if (nombreApellido.Length >= 1)
        {
            this.Nombre = nombreApellido[0];
        }
        if (nombreApellido.Length >= 2)
        {
            this.Apellido = nombreApellido[1];
        }
    }

    public void EliminarProductoDeCarrito(ProductoCarrito producto)
    {
        this.CarritoDeCompras.EliminarProducto(producto.Producto);
    }

    public void RealizarVenta(Ticket ticket)
    {
        // Agregar el ticket a la lista de tickets del cliente
        this.Compras.Add(new Compra(this, ticket));
        this.ProgramaDeLealtad.AñadirPuntos(ticket.Total);
        this.CarritoDeCompras.VaciarCarrito();
    }

    public void DescontarSaldo(decimal cantidad)
    {
        this.Saldo -= cantidad;
    }

    public List<ProductoCarrito> Carrito()
    {
        return this.CarritoDeCompras.Productos();
    }

    public ProductoCarrito BuscarProducto(string nombre)
    {
        return this.CarritoDeCompras.BuscarProducto(nombre);
    }
}

