



using System;
using System.Collections.Generic;


class Program {
public static class Utils
{
    public static T Clamp<T>(T value, T min, T max) where T : IComparable<T>
    {
        if (value.CompareTo(min) < 0) return min;
        else if (value.CompareTo(max) > 0) return max;
        else return value;
    }
}

static void Main(string[] args) {
    // Información del equipo que desarrolló el proyecto
    Console.WriteLine("Proyecto Final");
    Console.WriteLine("Programación Orientada a Objetos");
    Console.WriteLine("Grupo: Equipo 03 - APPSOFT");
    Console.WriteLine("Integrantes:");
    Console.WriteLine("- Antonio Martínez Rodrigo. - Desarrolló la creacion de clases para empleados y diagramas UML.");
    Console.WriteLine("- Nishimura Guerrero Christian Jesús. - Desarrolló la creacion de clases para clientes y seleccion del flujo del programa.");
    Console.WriteLine("- Briseño Vázquez Angel Geovany - Desarrolló La creacion del resto de las clases tanto para empleado y cliente, su implementaciín en el programa final y el intento de conectar a base de datos Sqlite, mas control y manejo de exepciones.");
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();
    Console.Clear();

    // Crear instancias de la sucursal y de los empleados y clientes
    Sucursal sucursal = new Sucursal("Av. Siempreviva 742", "(555) 123-4567");
    Empleado empleado1 = new Empleado("Juan Pérez", "juan.perez@example.com", "Calle Falsa 123", "(555) 987-6543", "Cajero", "password1", TipoTrabajador.Asistente, "001");
    Empleado empleado2 = new Empleado("María Gómez", "maria.gomez@example.com", "Calle Falsa 456", "(555) 555-5555", "Vendedor", "password2", TipoTrabajador.Gerente, "002");
    Cliente cliente1 = new Cliente("Ana", "González", "ana.gonzalez@example.com", "Calle Falsa 789", "(555) 111-1111", "contrasena1");
    Cliente cliente2 = new Cliente("Pedro", "Rodríguez", "pedro.rodriguez@example.com", "Calle Falsa 012", "(555) 222-2222", "contrasena2");
    Gerente gerente = new Gerente("Miguel Hernández", "miguel.hernandez@example.com", "Calle Falsa 345", "(555) 333-3333", "Gerente General", "password3");

// Crear instancias de la sucursal y de los empleados y clientes


    // Agregar los empleados y clientes a la sucursal
    sucursal.AgregarEmpleado(empleado1);
    sucursal.AgregarEmpleado(empleado2);
    sucursal.AgregarCliente(cliente1);
    sucursal.AgregarCliente(cliente2);
    sucursal.AgregarGerente(gerente);    

    Producto producto1 = new Producto("Monitor ASUS MXLZ27", 255, 1, "Monitor de 24” HDMI, VGA");
Producto producto2 = new Producto("Monitor HP LS2001", 10, 1, "Monitor 21” VGA");
Producto producto3 = new Producto("Monitor Dell DS247", 255, 3, "Monitor 21” DP");
Producto producto4 = new Producto("Laptop Dell 1135G7", 255, 6, "1 TB DD, 8 GB RAM, Intel Core i5");
Producto producto5 = new Producto("iPad MPQ03LZ/A", 255, 6, "64 GB, 10.9 Pulgadas");
Producto producto6 = new Producto("Combo Teclado Mouse Logitech K200", 255, 22, "Negro, USB");
Producto producto7 = new Producto("Laptop HP B09BMGCVZH", 255, 6, "1 TB DD, 8 GB RAM, AMD Ryzen 5");
Producto producto8 = new Producto("Laptop Alienware M15 R7", 255, 1, "512 SSD, 1 TB DD, 16 GB RAM, Intel Core i7, Nvidia RTX 3060");
Producto producto9 = new Producto("Bocinas Logitech Z207", 255, 7, "Bocinas Bluetooth para PC, Sonido Estéreo, 10W, Entrada Audio 3.5 mm");
Producto producto10 = new Producto("Monitor ASUS MXLZ27", 255, 12, "Monitor de 24” HDMI, VGA");
Producto producto11 = new Producto("Monitor HP LS2001", 255, 4, "Monitor 21” VGA");
Producto producto12 = new Producto("Monitor Dell DS247", 255, 15, "Monitor 21” DP");
Producto producto13 = new Producto("Laptop Dell 1135G7", 255, 6, "1 TB DD, 8 GB RAM, Intel Core i5");
Producto producto14 = new Producto("iPad MPQ03LZ/A", 255, 18, "64 GB, 10.9 Pulgadas");
Producto producto15 = new Producto("Combo Teclado Mouse Logitech K200", 255, 13, "Negro, USB");
Producto producto16 = new Producto("Laptop HP B09BMGCVZH", 255, 12, "1 TB DD, 8 GB RAM, AMD Ryzen 5");
Producto producto17 = new Producto("Laptop Alienware M15 R7", 255, 3, "512 SSD, 1 TB DD, 16 GB RAM, Intel Core i7, Nvidia RTX 3050");
Producto producto18 = new Producto("Bocinas Logitech Z207", 255, 2, "Bocinas Bluetooth para PC, Sonido Estéreo, 10W, Entrada Audio 3.5 mm");
    // Agregar los productos a la sucursal
    sucursal.AgregarProductoNuevo(producto1);
    sucursal.AgregarProductoNuevo(producto2);
     sucursal.AgregarProductoNuevo(producto3);
    sucursal.AgregarProductoNuevo(producto4);
     sucursal.AgregarProductoNuevo(producto5);
    sucursal.AgregarProductoNuevo(producto6);
     sucursal.AgregarProductoNuevo(producto7);
    sucursal.AgregarProductoNuevo(producto8);
     sucursal.AgregarProductoNuevo(producto9);
    sucursal.AgregarProductoNuevo(producto10);
     sucursal.AgregarProductoNuevo(producto11);
    sucursal.AgregarProductoNuevo(producto12);
     sucursal.AgregarProductoNuevo(producto13);
    sucursal.AgregarProductoNuevo(producto14);
     sucursal.AgregarProductoNuevo(producto15);
    sucursal.AgregarProductoNuevo(producto16);
     sucursal.AgregarProductoNuevo(producto17);
    sucursal.AgregarProductoNuevo(producto18);

    // Mostrar el menú principal
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("=======================================================");
    Console.WriteLine("||               BIENVENIDO A                        ||");
    Console.WriteLine("||                    APPSOFT                        ||");
    Console.WriteLine("||                                                   ||");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("||   La mejor tienda en línea de electrodomésticos   ||");
    Console.WriteLine("||   Estamos comprometidos en brindarte la mejor     ||");
    Console.WriteLine("||   experiencia de compra.                          ||");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("=======================================================");
    Console.WriteLine("||                                                   ||");
    Console.WriteLine("||   Si necesitas ayuda en cualquier momento,        ||");
    Console.WriteLine("||   no dudes en contactarnos.                       ||");
    Console.WriteLine("||                                                   ||");
    Console.WriteLine("||   ¡Que tengas un excelente día!                   ||");
    Console.WriteLine("||                                                   ||");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("=======================================================");

    // Menú para seleccionar la tienda
    Console.WriteLine("Seleccione la tienda de su agrado:");
    Console.WriteLine("1. Sucursal Coyoacán");
    Console.WriteLine("2. Sucursal Centro");
    Console.WriteLine("3. Sucursal de la FI");

    // Obtener la selección del usuario
    int seleccionTienda;

    while(true)
    {
        try
        {
            seleccionTienda = int.Parse(Console.ReadLine());
            break;
        }
        catch (FormatException)
       {
            Console.WriteLine("Selección invalida. Por favor ingrese un número válido.");
            
        }
    }

    // Seleccionar la tienda
    switch (seleccionTienda)
    {
            case 1:
                Console.WriteLine(" ");
                Console.WriteLine("Ha seleccionado la Sucursal Coyoacán.");
                Console.WriteLine("Información de la tienda:");
                Console.WriteLine("Nombre: Tienda Coyoacán");
                Console.WriteLine("Dirección: Calle 1, Coyoacán");
                Console.WriteLine("Teléfono: 55-1234-5678");
                break;
            case 2:
                Console.WriteLine(" ");
                Console.WriteLine("Ha seleccionado la Sucursal Centro.");
                Console.WriteLine("Información de la tienda:");
                Console.WriteLine("Nombre: Tienda Centro");
                Console.WriteLine("Dirección: Av. Juárez 123, Centro");
                Console.WriteLine("Teléfono: 55-2345-6789");
                break;
            case 3:
                Console.WriteLine(" ");
                Console.WriteLine("Ha seleccionado la Sucursal de la FI.");
                Console.WriteLine("Información de la tienda:");
                Console.WriteLine("Nombre: Tienda FI");
                Console.WriteLine("Dirección: Av. Universidad 3000, Coyoacán");
                Console.WriteLine("Teléfono: 55-3456-7890");
                break;
            default:
                Console.WriteLine(" ");
                Console.WriteLine("Opción inválida Será dirigido a la Sucursal de La FI.");
                break;
    }
 
    int seleccion=0;
    do{
    // Mostrar el menú principal de la tienda seleccionada
    Console.WriteLine(" ");
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Iniciar sesión como empleado");
    Console.WriteLine("2. Iniciar simulación como cliente");
    Console.WriteLine("3. Salir de APPSOFT");

    Console.Write("Ingrese el número de opción que desea seleccionar: ");
    
    if (!int.TryParse(Console.ReadLine(), out seleccion)) {
        Console.WriteLine(" ");
        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
        continue;
    }
        // Verificar la opción elegida y actuar en consecuencia

    // Ejecutar la acción seleccionada por el usuario
    switch (seleccion)
    {
        case 1:
            //Simulación empleado
        Console.ForegroundColor = ConsoleColor.Magenta;   
        Console.WriteLine("Iniciar Sesión Empleado");
        Console.WriteLine("-----------------------");
        Console.Write("Ingrese su número de trabajador: ");
        string numTrabajador = Console.ReadLine();
        Console.Write("Ingrese su contraseña: ");
        string password = Console.ReadLine();
    Sucursal sucursalNueva = new Sucursal();
    // Buscar empleado por número de trabajador y contraseña
    Empleado empleado = sucursal.BuscarEmpleado(numTrabajador, password);

    if (empleado != null)
    {
        Console.WriteLine("Bienvenido, " + empleado.NombreCompleto);
        Console.WriteLine("-----------------------");

        // Menú de opciones para el empleado
        int opcionEmpleado = 0;
        do
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Actualizar Stock");
            Console.WriteLine("2. Retiro de Efectivo (ganancias)");
            Console.WriteLine("3. Depósito de cambio");
            Console.WriteLine("4. Ver inventario");
            Console.WriteLine("5. Ver lista de clientes de la sucursal");
            Console.WriteLine("6. Actualizar Información personal");
            Console.WriteLine("7. Cerrar sesión");
            Console.Write("Seleccione una opción: ");
            if (int.TryParse(Console.ReadLine(), out opcionEmpleado))
            {
                switch (opcionEmpleado)
                {
                    case 1:
                        // Actualizar Stock
                       if (empleado.Tipo == TipoTrabajador.Gerente)
                        {
                            Console.WriteLine("No tiene permisos para realizar esta acción.");
                        }
                        else
                        {
                            // Se debe validar que el gerente haya enviado la solicitud
                            if (sucursal.SolicitudStockPendiente)
                            {
                                Console.WriteLine("Listado de productos a recibir:");
                                foreach (Producto producto in sucursal.ProductosSolicitados)
                                {
                                    Console.WriteLine(producto.ToString());
                                }

                                // Se debe permitir regresar productos que no se solicitaron o de los cuales tienen suficientes
                                Console.WriteLine("¿Desea regresar algún producto?");
                                // ...
                            }
                            else
                            {
                                Console.WriteLine("No hay solicitudes de stock pendientes.");
                            }
                        }
                        break;
                    case 2:
                        // Retiro de Efectivo (ganancias)
                        if (empleado.Tipo == TipoTrabajador.Gerente)
                        {
                            Console.WriteLine("No tiene permisos para realizar esta acción.");
                        }
                        else
                        {
                            // Se debe llevar un registro sobre los depósitos y retiros con el ID del Gerente que lo autorizó y el empleado que lo llevó a cabo.
                            Console.WriteLine("Ingrese la cantidad a retirar:");
                            double cantidad = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el ID del Gerente que autoriza la operación:");
                            string idGerente = Console.ReadLine();
                            // ...
                        }
                        break;
                    case 3:
                        // Depósito de cambio
                        // ...
                        break;
                    case 4:
                        // Ver inventario
                        Console.WriteLine("Inventario:");
                        foreach (Producto producto in sucursal.Inventario)
                        {
                            Console.WriteLine(producto.ToString());
                        }
                        break;
                    case 5:
                        // Ver lista de clientes de la sucursal
                        Console.WriteLine("Lista de clientes:");
                        foreach (Cliente cliente in sucursal.Clientes)
                        {
                            Console.WriteLine(cliente.ToString());
                        }
                        break;
                    case 6:
                        // Actualizar Información personal
                        // ...
                        break;
                    case 7:
                        // Cerrar sesión
                        Console.WriteLine("Sesión cerrada.");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingrese un número válido.");
            }

        } while (opcionEmpleado != 7);
    }
    else
    {
        Console.WriteLine("Número de trabajador o contraseña incorrectos.");
    }
    break;

            case 2:
    //simulación cliente
    Console.ForegroundColor = ConsoleColor.Green;       
    Console.WriteLine("Inicio de sesión Cliente");
    Console.WriteLine("-----------------------");
    Console.Write("Ingrese su correo electrónico: ");
    string correo = Console.ReadLine();
    Console.Write("Ingrese su contraseña: ");
    string contrasena = Console.ReadLine();

   
    // Buscar cliente por correo electrónico y contraseña
    Cliente clienteExistente = sucursal.BuscarCliente(correo, contrasena);


    if (clienteExistente != null)
    {
        Console.WriteLine("Bienvenido, " + clienteExistente.NombreCompleto);
        Console.WriteLine("-----------------------");

        // Menú de opciones para el cliente
        int opcionCliente = 0;
        do
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Buscar producto");
            Console.WriteLine("2. Ver Carrito");
            Console.WriteLine("3. Editar carrito");
            Console.WriteLine("4. Comprar");
            Console.WriteLine("5. Actualizar Datos Personales");
            Console.WriteLine("6. Ver Mis Compras");
            Console.WriteLine("7. Cerrar sesión");
            Console.Write("Seleccione una opción: ");
            if (int.TryParse(Console.ReadLine(), out opcionCliente))
            {
                switch (opcionCliente)
                {
                    case 1:
                        // Buscar producto
                        Console.Write("Ingrese el nombre del producto: ");
                        string nombreProducto = Console.ReadLine();
                        Producto producto = sucursal.BuscarProducto(nombreProducto);
                        if (producto != null)
                        {
                            Console.WriteLine(producto.ToString());
                            Console.Write("¿Desea agregar el producto a su carrito? (S/N): ");
                            string respuesta = Console.ReadLine();
                            if (respuesta.ToUpper() == "S")
                            {
                                Console.Write("Ingrese la cantidad: ");
                                int cantidad = int.Parse(Console.ReadLine());
                                sucursal.AgregarProducto(producto, cantidad);
                                Console.WriteLine("Producto agregado al carrito.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Producto no encontrado.");
                        }
                        break;
                    case 2:
                        // Ver carrito
                        Console.WriteLine("Carrito de compras:");
                        foreach (ProductoCarrito productoCarrito in clienteExistente.CarritoDeCompras)
                        {
                            Console.WriteLine(productoCarrito.Producto.ToString() + " Cantidad: " + productoCarrito.Cantidad);
                        }
                        break;
                    case 3:
                        // Editar carrito
                        Console.WriteLine("Carrito de compras:");
                        foreach (ProductoCarrito productoCarrito in clienteExistente.Carrito())
                        {
                        Console.WriteLine(productoCarrito.Producto.ToString() + " Cantidad: " + productoCarrito.Cantidad);
                        }
                        Console.Write("Ingrese el nombre del producto que desea eliminar o modificar la cantidad: ");
                        string nombreProductoEditar = Console.ReadLine();
                        ProductoCarrito productoCarritoEditar = clienteExistente.BuscarProducto(nombreProductoEditar);
                        if (productoCarritoEditar != null)
                        {
                            Console.Write("Ingrese la nueva cantidad o 0 para eliminar el producto: ");
                            int nuevaCantidad = int.Parse(Console.ReadLine());
                            if (nuevaCantidad == 0)
                            {
                                clienteExistente.EliminarProductoDeCarrito(productoCarritoEditar);
                                Console.WriteLine("Producto eliminado del carrito.");
                            }
                            else
                            {
                                productoCarritoEditar.Cantidad = nuevaCantidad;
                                Console.WriteLine("Cantidad modificada.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Producto no encontrado en el carrito.");
                        }
                        break;
                    case 4:
                        // Comprar
                        decimal totalCompraProducto = 0;
                        decimal totalCompra = 0;
                        bool hayProductosSinExistencia = false;

                        foreach (ProductoCarrito productoCarrito in clienteExistente.Carrito())
                        {
                            if (productoCarrito.Producto.Existencia >= productoCarrito.Cantidad)
                            {
                                productoCarrito.Producto.Existencia -= productoCarrito.Cantidad;
                                totalCompraProducto = productoCarrito.Producto.Precio * productoCarrito.Cantidad;
                            }
                            else
                            {
                                Console.WriteLine("No hay suficiente existencia de " + productoCarrito.Producto.Nombre + ".");
                                hayProductosSinExistencia = true;
                            }

                            totalCompra += totalCompraProducto;
                        }

                        if (!hayProductosSinExistencia)
                        {
                            Console.Write("¿Desea factura? (S/N): ");
                            string respuestaFactura = Console.ReadLine();

                            if (respuestaFactura.ToUpper() == "S")
                            {
                                Console.Write("Ingrese su RFC: ");
                                string rfc = Console.ReadLine();
                                Console.Write("Ingrese su dirección fiscal: ");
                                string direccionFiscal = Console.ReadLine();
                                Console.Write("¿Es correcta la forma de pago? (Tarjeta de Crédito) (S/N): ");
                                string respuestaFormaPago = Console.ReadLine();

                                CarritoDeCompras carrito = null;

                                if (respuestaFormaPago.ToUpper() == "N")
                                {
                                    Console.Write("Ingrese la forma de pago: ");
                                    string formaPago = Console.ReadLine();
                                    carrito = new CarritoDeCompras();
                                    carrito.RealizarCompra(clienteExistente, totalCompra, rfc, direccionFiscal, formaPago);
                                }
                                else
                                {
                                    carrito = new CarritoDeCompras();
                                    carrito.RealizarCompra(clienteExistente, totalCompra, rfc, direccionFiscal);
                                }
                            }
                            else
                            {
                                CarritoDeCompras carrito = new CarritoDeCompras();
                                carrito.RealizarCompra(clienteExistente, totalCompra);
                            }

                            Console.WriteLine("Compra realizada con éxito.");

                            // Vaciar carrito
                            clienteExistente.Carrito().VaciarCarrito();
                        }
                        break;
                    case 5:
                        // Actualizar datos personales
                        Console.WriteLine("Actualización de Datos Personales");
                        Console.WriteLine("---------------------------------");
                        Console.Write("Ingrese su nombre completo: ");
                        string nombreCompleto = Console.ReadLine();
                        Console.Write("Ingrese su nuevo correo electrónico: ");
                        string nuevoCorreo = Console.ReadLine();
                        Console.Write("Ingrese su dirección: ");
                        string direccion = Console.ReadLine();
                        Console.Write("Ingrese su teléfono: ");
                        string telefono = Console.ReadLine();
                        clienteExistente.ActualizarDatosPersonales(nombreCompleto, nuevoCorreo, direccion, telefono);
                        Console.WriteLine("Datos actualizados con éxito.");
                        break;
                    case 6:
                        // Ver mis compras
                        Console.WriteLine("Mis Compras:");
                        foreach (Compra compra in clienteExistente.Compras)
                        {
                            Console.WriteLine(compra.ToString());
                        }
                        break;
                    case 7:
                        // Cerrar sesión
                        Console.WriteLine("Sesión cerrada.");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
            Console.WriteLine();
        } while (opcionCliente != 7);
    }
    else
    {
        Console.WriteLine("Correo electrónico o contraseña incorrectos.");
    }
    break;
        case 3:
    Console.WriteLine("Saliendo del programa...");
    Environment.Exit(0);
    break;
    
    }

    Console.ReadKey();
} while (seleccion != 3);
}
}