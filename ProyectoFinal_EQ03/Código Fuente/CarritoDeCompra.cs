using System;
using System.Collections;
using System.Collections.Generic;

public static class ListExtensions
{
    public static void VaciarCarrito(this List<ProductoCarrito> carrito)
    {
        carrito.Clear();
    }
}
public class CarritoDeCompras : IEnumerable<ProductoCarrito>
{
    public List<Producto> ListaDeProductos { get; set; }
    public List<int> Cantidades { get; set; }

    public CarritoDeCompras()
    {
        this.ListaDeProductos = new List<Producto>();
        this.Cantidades = new List<int>();
    }

    public List<ProductoCarrito> Productos()
    {
        List<ProductoCarrito> productos = new List<ProductoCarrito>();
        for (int i = 0; i < this.ListaDeProductos.Count; i++)
        {
            Producto producto = this.ListaDeProductos[i];
            int cantidad = this.Cantidades[i];
            productos.Add(new ProductoCarrito(producto, cantidad));
        }
        return productos;
        
    }
    
   

    public ProductoCarrito BuscarProducto(string nombre)
    {
        int indice = this.ListaDeProductos.FindIndex(p => p.Nombre == nombre);
        if (indice != -1)
        {
            Producto producto = this.ListaDeProductos[indice];
            int cantidad = this.Cantidades[indice];
            return new ProductoCarrito(producto, cantidad);
        }
        else
        {
            return null;
        }
    }

    public void AgregarProducto(Producto producto, int cantidad)
    {
        this.ListaDeProductos.Add(producto);
        this.Cantidades.Add(cantidad);
    }

    public void EliminarProducto(Producto producto)
    {
        int indice = this.ListaDeProductos.IndexOf(producto);
        this.ListaDeProductos.RemoveAt(indice);
        this.Cantidades.RemoveAt(indice);
    }

    public void VaciarCarrito()
    {
        this.ListaDeProductos.Clear();
        this.Cantidades.Clear();
    }

    public decimal ObtenerTotal()
    {
        decimal total = 0;
        for (int i = 0; i < this.ListaDeProductos.Count; i++)
        {
            total += this.ListaDeProductos[i].Precio * this.Cantidades[i];
        }
        return total;
    }

    public void RealizarCompra(Cliente cliente, decimal totalCompra, string rfc, string direccionFiscal, string formaPago)
    {
        // Lógica para realizar la compra con forma de pago
        // ...
    }

    public void RealizarCompra(Cliente cliente, decimal totalCompra, string rfc, string direccionFiscal)
    {
        // Lógica para realizar la compra sin forma de pago
        // ...
    }

    public void RealizarCompra(Cliente cliente, decimal totalCompra)
    {
        // Lógica para realizar la compra sin información fiscal ni forma de pago
        // ...
    }

    public IEnumerator<ProductoCarrito> GetEnumerator()
    {
        foreach (Producto producto in this.ListaDeProductos)
        {
            int cantidad = this.Cantidades[this.ListaDeProductos.IndexOf(producto)];
            yield return new ProductoCarrito(producto, cantidad);
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class ProductoCarrito
{
    public Producto Producto { get; set; }
    public int Cantidad { get; set; }

    public ProductoCarrito(Producto producto, int cantidad)
    {
        this.Producto = producto;
        this.Cantidad = cantidad;
    }
}