
using System;
using System.Collections.Generic;

public class Sucursal {
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public bool SolicitudStockPendiente { get; set; }
    public List<Empleado> empleados;
    public List<Cliente> clientes;
    public List<Producto> productos;
    public List<Venta> ventas;
    public List<Ticket> tickets;
    private List<Gerente> gerentes = new List<Gerente>();
    public List<Producto> ProductosSolicitados { get; set; }
    public List<Producto> Inventario
{
    get { return this.productos; }
}
    public Sucursal()
    {
        this.empleados = new List<Empleado>();
        this.clientes = new List<Cliente>();
        this.productos = new List<Producto>();
        this.ventas = new List<Venta>();
        this.tickets = new List<Ticket>();
        this.ProductosSolicitados = new List<Producto>(); 
    }

    public Sucursal(string direccion, string telefono)
    {
        this.Direccion = direccion;
        this.Telefono = telefono;
        this.empleados = new List<Empleado>();
        this.clientes = new List<Cliente>();
        this.productos = new List<Producto>();
        this.ventas = new List<Venta>();
        this.tickets = new List<Ticket>();
    }

    public List<Empleado> Empleados
    {
        get { return this.empleados; }
    }

    public List<Cliente> Clientes
    {
        get { return this.clientes; }
    }

    public List<Producto> Productos
    {
        get { return this.productos; }
    }

    public List<Venta> Ventas
    {
        get { return this.ventas; }
    }

    public List<Ticket> Tickets
    {
        get { return this.tickets; }
    }

    public void AgregarEmpleado(Empleado empleado)
    {
        this.empleados.Add(empleado);
    }

    public void AgregarGerente(Gerente gerente)
    {
        this.gerentes.Add(gerente);
    }

    public void AgregarCliente(Cliente cliente)
    {
        this.clientes.Add(cliente);
    }


public void AgregarProductoNuevo(Producto producto)
{
    if (producto != null) {
        Producto productoExistente = this.BuscarProducto(producto.Nombre);
        if (productoExistente != null) {
            productoExistente.Stock++;
        } else {
            producto.Stock = 1;
            this.productos.Add(producto);
        }
    }
}
   public void AgregarProducto(Producto producto, int cantidad)
{
    if (producto != null) {
        Producto productoExistente = this.BuscarProducto(producto.Nombre);
        if (productoExistente != null) {
            productoExistente.Stock += cantidad;
        } else {
            producto.Stock = cantidad;
            this.productos.Add(producto);
        }
    }
}

    public Producto BuscarProducto(string nombre)
{
    foreach (Producto producto in this.productos) {
        if (producto.Nombre == nombre) {
            return producto;
        }
    }
    return null;
}
    public Empleado AutenticarEmpleado(string usuario, string contrasena)
    {
        foreach (Empleado empleado in this.empleados) {
            if (empleado.Correo == usuario && empleado.Contrasena == contrasena) {
                return empleado;
            }
        }
        return null;
    }

    public Cliente AutenticarCliente(string correo, string contrasena)
    {
        foreach (Cliente cliente in this.clientes) {
            if (cliente.Correo == correo && cliente.Contrasena == contrasena) {
                return cliente;
            }
        }
        return null;
    }

    public void RealizarVenta(Venta venta, Empleado empleado)
    {
        this.ventas.Add(venta);
        venta.Ticket = new Ticket(venta, this);
        this.tickets.Add(venta.Ticket);
        for (int i = 0; i < venta.Productos.Count; i++) {
            venta.Productos[i].Stock -= venta.Cantidades[i];
        }
        if (venta.Cliente != null && venta.MetodoPago != null && venta.MetodoPago.Saldo > 0) {
            venta.Cliente.Saldo -= venta.ObtenerTotal();
        }
        venta.Empleado = empleado;
    }

    // Método para obtener la lista de productos disponibles
    public List<Producto> ObtenerProductosDisponibles()
    {
        List<Producto> disponibles = new List<Producto>();
        foreach (Producto producto in this.productos) {
            if (producto.Stock > 0) {
                disponibles.Add(producto);
            }
        }
        return disponibles;
    }

    // Método para obtener la lista de empleados disponibles
    public List<Empleado> ObtenerEmpleadosDisponibles(string rol)
    {
        List<Empleado> disponibles = new List<Empleado>();
        foreach (Empleado empleado in this.empleados) {
            if (empleado.Activo) {
                disponibles.Add(empleado);
            }
        }
        return disponibles;
    }
    public List<Empleado> ObtenerEmpleadosDisponiblesPorRol(string rol)
{
    List<Empleado> disponibles = new List<Empleado>();
    foreach (Empleado empleado in this.empleados) {
        if (empleado.Activo && empleado.Rol.Equals(rol)) {
            disponibles.Add(empleado);
        }
    }
    return disponibles;
}
public List<Venta> RealizarVentas()
{
    return this.ventas;
}

public Empleado BuscarEmpleado(string numTrabajador, string password)
{
    foreach (Empleado empleado in this.empleados) {
        if (empleado.NumTrabajador == numTrabajador && empleado.Contrasena == password) {
            return empleado;
        }
    }
    return null;
}
public Cliente BuscarCliente(string correo, string contrasena)
{
    foreach (Cliente cliente in this.clientes) {
        if (cliente.Correo == correo && cliente.Contrasena == contrasena) {
            return cliente;
        }
    }
    return null;
}
}