using System;
using System.Collections.Generic;

public class Producto 
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Existencia { get; set; } // Cambiar el nombre de la propiedad a Existencia
    public string Descripcion { get; set; }
    public int Stock { get; set; }
    public Producto(string nombre, decimal precio, int existencia, string descripcion) 
    {
        this.Nombre = nombre;
        this.Precio = precio;
        this.Existencia = existencia;
        this.Descripcion = descripcion;
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