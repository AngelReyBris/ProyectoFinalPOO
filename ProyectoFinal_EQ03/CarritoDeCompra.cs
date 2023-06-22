using System.Collections.Generic;


// Clase CarritoDeCompras
public class CarritoDeCompras {
    public List<Producto> Productos { get; set; }
    public List<int> Cantidades { get; set; }

    public CarritoDeCompras() {
        this.Productos = new List<Producto>();
        this.Cantidades = new List<int>();
    }

    public void AgregarProducto(Producto producto, int cantidad) {
        this.Productos.Add(producto);
        this.Cantidades.Add(cantidad);
    }

    public void EliminarProducto(Producto producto) {
        int indice = this.Productos.IndexOf(producto);
        this.Productos.RemoveAt(indice);
        this.Cantidades.RemoveAt(indice);
    }

    public void Vaciar() {
        this.Productos.Clear();
        this.Cantidades.Clear();
    }

    public decimal ObtenerTotal() {
        decimal total = 0;
        for (int i = 0; i < this.Productos.Count; i++) {
            total += this.Productos[i].Precio * this.Cantidades[i];
        }
        return total;
    }
}
