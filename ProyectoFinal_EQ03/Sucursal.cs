using System.Collections.Generic;

public class Sucursal {
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public List<Empleado> empleados;
    public List<Cliente> clientes;
    public List<Producto> productos;
    public List<Venta> ventas;
    public List<Ticket> tickets;
    private List<Gerente> gerentes = new List<Gerente>();
    public Sucursal()
    {
        this.empleados = new List<Empleado>();
        this.clientes = new List<Cliente>();
        this.productos = new List<Producto>();
        this.ventas = new List<Venta>();
        this.tickets = new List<Ticket>();
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

    public void AgregarProducto(Producto producto)
    {
        this.productos.Add(producto);
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
}