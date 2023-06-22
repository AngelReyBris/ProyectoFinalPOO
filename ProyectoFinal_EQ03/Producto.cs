using System;
using System.Collections.Generic;

public class Producto 
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public string Descripcion { get; set; }

    public Producto(string nombre, decimal precio, int stock, string descripcion) 
    {
        this.Nombre = nombre;
        this.Precio = precio;
        this.Stock = stock;
        this.Descripcion = descripcion;
    }

    public Producto() 
    {
        // Constructor sin parámetros
    }

    public override string ToString() 
    {
        return this.Nombre;
    }

    // Consultar productos desde una lista
    public static List<Producto> ConsultarProductos(List<Producto> listaProductos) 
    {
        return listaProductos;
    }
}