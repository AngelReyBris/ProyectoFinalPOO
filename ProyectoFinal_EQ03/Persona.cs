using System;
using System.Collections.Generic;

public class Sistema 
{
    public List<Cliente> Clientes { get; set; }
    public List<Empleado> Empleados { get; set; }
    public List<Gerente> Gerentes { get; set; }
    public List<Producto> Productos { get; set; }
    public List<Sucursal> Sucursales { get; set; }
    public string Nombre { get; set; }
    public decimal CambioEnCaja { get; set; }

    public void ActualizarStock(Gerente gerente, Producto producto, int cantidad) 
    {
        // validar que el gerente haya enviado la solicitud
        if (true /* validar que el gerente haya enviado la solicitud */) 
        {
            // actualizar el stock del producto en la sucursal correspondiente
            producto.Stock += cantidad;
        }
    }

    public void RetirarEfectivo(Gerente gerente, Sucursal sucursal, decimal cantidad) 
    {
        // retirar la cantidad de la caja y guardar el registro
        CambioEnCaja -= cantidad;
    }

    public void DepositarCambio(Gerente gerente, Sucursal sucursal, decimal cantidad) 
    {
        // depositar la cantidad en la caja y guardar el registro
        CambioEnCaja += cantidad;
    }

    public void AgregarProducto(Gerente gerente, Sucursal sucursal, Producto producto, int cantidad) 
    {
        // agregar el producto a la lista de productos de la sucursal
        sucursal.Productos.Add(producto);
        // enviar la orden de abastecimiento de stock a la sucursal correspondiente
        ActualizarStock(gerente, producto, cantidad);
    }

    public void SolicitarActualizacionStock(Gerente gerente, Sucursal sucursal) 
    {
        // enviar la solicitud de actualización de stock a la sucursal correspondiente
    }

    public void SolicitarRetiroEfectivo(Gerente gerente, Sucursal sucursal, decimal cantidad) 
    {
        // enviar la solicitud de retiro de efectivo a la sucursal correspondiente
        RetirarEfectivo(gerente, sucursal, cantidad);
    }

    public void SolicitarDepositoCambio(Gerente gerente, Sucursal sucursal, decimal cantidad) 
    {
        // enviar la solicitud de depósito de cambio a la sucursal correspondiente
        DepositarCambio(gerente, sucursal, cantidad);
    }

    public void RealizarVenta(Cliente cliente, Sucursal sucursal, Venta venta) 
    {
        // validar que hay suficiente stock de cada producto
        bool haySuficienteStock = true;
        for (int i = 0; i < venta.Productos.Count; i++) 
        {
            if (venta.Cantidades[i] > venta.Productos[i].Stock) 
            {
                haySuficienteStock = false;
                break;
            }
        }
        if (haySuficienteStock) 
        {
            // restar la cantidad vendida del stock de cada producto
            for(int i = 0; i < venta.Productos.Count; i++) 
            {
                venta.Productos[i].Stock -= venta.Cantidades[i];
            }
            // agregar la venta a la lista de ventas de la sucursal y del cliente
            sucursal.Ventas.Add(venta);
            sucursal.Ventas.Add(venta);
        }
    }
}