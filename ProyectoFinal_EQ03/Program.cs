
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
        Console.WriteLine("Grupo: Equipo ## - Nombre del equipo");
        Console.WriteLine("Integrantes:");
        Console.WriteLine("- Nombre1 - Desarrolló X");
        Console.WriteLine("- Nombre2 - Desarrolló Y");
        Console.WriteLine("- Nombre3 - Desarrolló Z");
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

        // Crear instancias de la sucursal y de los empleados y clientes
        Sucursal sucursal = new Sucursal("Av. Siempreviva 742", "(555) 123-4567");
        Empleado empleado1 = new Empleado("Juan Pérez", "juan.perez@example.com", "Calle Falsa 123", "(555) 987-6543", "Cajero", "password1");
        Empleado empleado2 = new Empleado("María Gómez", "maria.gomez@example.com", "Calle Falsa 456", "(555) 555-5555", "Vendedor", "password2");
        Cliente cliente1 = new Cliente("Ana González", "ana.gonzalez@example.com", "Calle Falsa 789", "(555) 111-1111", "contrasena1");
        Cliente cliente2 = new Cliente("Pedro Rodríguez", "pedro.rodriguez@example.com", "Calle Falsa 012", "(555) 222-2222", "contrasena2");
        Gerente gerente = new Gerente("Miguel Hernández", "miguel.hernandez@example.com", "Calle Falsa 345", "(555) 333-3333", "Gerente General", "password3");

        // Agregar los empleados y clientes a la sucursal
        sucursal.AgregarEmpleado(empleado1);
        sucursal.AgregarEmpleado(empleado2);
        sucursal.AgregarCliente(cliente1);
        sucursal.AgregarCliente(cliente2);
        sucursal.AgregarGerente(gerente);    

       Producto producto1 = new Producto("Teclado", Convert.ToByte(Utils.Clamp(Convert.ToDecimal(499.99), 0, 255)), 10, "Teclado inalámbrico para computadora");
Producto producto2 = new Producto("Ratón", Convert.ToByte(Utils.Clamp(Convert.ToDecimal(299.99), 0, 255)), 15, "Mouse inalámbrico para computadora");

        // Agregar los productos a la sucursal
        sucursal.AgregarProducto(producto1);
        sucursal.AgregarProducto(producto2);

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
        Console.WriteLine("Por favor, ingrese un número válido.");
    }
}

// Mostrar información de la tienda seleccionada
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
        Console.WriteLine("Opción inválida.");
        break;
}

bool continuarPrograma = true;
do {
    Console.WriteLine(" ");
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Iniciar sesión como empleado");
    Console.WriteLine("2. Iniciar simulación como cliente");
    Console.WriteLine("3. Salir de APPSOFT");

         // Pedir opción al usuario
    Console.Write("Ingrese el número de opción que desea seleccionar: ");
    int opcion;
    if (!int.TryParse(Console.ReadLine(), out opcion)) {
        Console.WriteLine(" ");
        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
        continue;
    }
        // Verificar la opción elegida y actuar en consecuencia
        switch (opcion) {
            case 1:
                // Pedir datos de autenticación al empleado
                Console.Write("Ingrese su correo electrónico: ");
                string correoEmpleado = Console.ReadLine();
                Console.Write("Ingrese su contaseña personalizada: ");
                string telefonoEmpleado = Console.ReadLine();

                // Autenticar al empleado
                Empleado empleadoAutenticado = sucursal.AutenticarEmpleado(correoEmpleado, telefonoEmpleado);
                if (empleadoAutenticado != null) {
                    // Mostrar menú de opciones para el empleado
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Bienvenido, " + empleadoAutenticado.Nombre + " (" + empleadoAutenticado.Funcion + ")");
                    Console.WriteLine("1. Realizar venta");
                    Console.WriteLine("2. Ver ventas");
                    Console.WriteLine("3. Ver productos");
                    Console.WriteLine("4. Salir");

                    // Pedir opción al empleado
                            Console.Write("Ingrese una opción: ");
                int opcionEmpleado;
                if (!int.TryParse(Console.ReadLine(), out opcionEmpleado)) {
                    Console.WriteLine(" ");
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    continue;
                }
                    // Verificar la opción elegida y actuar en consecuencia
                    switch (opcionEmpleado) {
                        case 1:
                            // Crear instancia de venta
                            List<Producto> productosVenta = new List<Producto>();
                            List<int> cantidadesVenta = new List<int>();
                            Cliente clienteVenta = null;
                            Sucursal sucursalVenta = sucursal;
                            Console.Write("Ingrese el correo electrónico del cliente o presione Enter para continuar como venta anónima: ");
                            string correoCliente = Console.ReadLine();
                            if (correoCliente != "") {
                                // Autenticar alcliente
                                clienteVenta = sucursal.AutenticarCliente(correoCliente, "contrasena");
                                if (clienteVenta == null) {
                                    Console.WriteLine("No se encontró un cliente con ese correo electrónico.");
                                    break;
                                }
                            }
                            bool agregandoProductos = true;
                            while (agregandoProductos) {
                                // Mostrar lista de productos disponibles
                                Console.WriteLine("Productos disponibles:");
                                List<Producto> productosDisponibles = sucursal.ObtenerProductosDisponibles();
                                for (int i = 0; i < productosDisponibles.Count; i++) {
                                    Console.WriteLine((i + 1) + ". " + productosDisponibles[i].Nombre + " ($" + productosDisponibles[i].Precio + ")");
                                }

                                // Pedir al empleado que seleccione un producto o que termine de agregar productos
                                Console.WriteLine("Presione Enter para terminar de agregar productos");
                                Console.Write("Ingrese el número del producto que desea agregar: ");
                                 int indiceProducto;
                            if (!int.TryParse(Console.ReadLine(), out indiceProducto)) { // <-- Modificación de excepción
                                Console.WriteLine(" ");
                                Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                                continue;
                            }

                                // Si el empleado presionó Enter, terminar de agregar productos
                                if (Console.ReadLine() == "") {
                                    agregandoProductos = false;
                                    break;
                                }

                                // Verificar que la opción sea válida
                                
                                bool opcionValida = int.TryParse(Console.ReadLine(), out indiceProducto);
                                if (!opcionValida || indiceProducto < 1 || indiceProducto > productosDisponibles.Count) {
                                    Console.WriteLine("Opción inválida.");
                                    continue;
                                }

                                // Pedir al empleado la cantidad de productos que quiere agregar
                                Console.Write("Ingrese la cantidad de productos que desea agregar: ");
                                int cantidadProducto;
                            if (!int.TryParse(Console.ReadLine(), out cantidadProducto)) { // <-- Modificación de excepción
                                Console.WriteLine(" ");
                                Console.WriteLine("Cantidad no válida.Por favor, ingrese un número entero válido.");
                                continue;
                            }

                                // Verificar que haya suficientes existencias del producto
                                Producto productoSeleccionado = productosDisponibles[indiceProducto - 1];
                                if (cantidadProducto > productoSeleccionado.Stock) {
                                Console.WriteLine("No hay suficientes existencias de ese producto.");
                                continue;
                                }

                                // Agregar el producto y la cantidad a la venta
                                productosVenta.Add(productoSeleccionado);
                                cantidadesVenta.Add(cantidadProducto);
                            }

                            // Verificar que se hayan agregado productos a la venta
                            if (productosVenta.Count == 0) {
                                Console.WriteLine("No se agregaron productos a la venta.");
                                break;
                            }

                            // Pedir al empleado que seleccione al empleado de ventas
                            Console.WriteLine("Seleccione al empleado que realizó la venta:");
                            List<Empleado> empleadosDisponibles = sucursal.ObtenerEmpleadosDisponibles("Vendedor");
                            for (int i = 0; i < empleadosDisponibles.Count; i++) {
                                Console.WriteLine((i + 1) + ". " + empleadosDisponibles[i].Nombre);
                            }
                            Console.Write("Ingrese el número del empleado que realizó la venta: ");
                            int indiceEmpleadoVenta = Convert.ToInt32(Console.ReadLine());

                            // Verificar que la opción sea válida
                            if (indiceEmpleadoVenta < 1 || indiceEmpleadoVenta > empleadosDisponibles.Count) {
                                Console.WriteLine("Opción inválida.");
                                break;
                            }

                            // Obtener al empleado seleccionado y realizar la venta
                            Empleado empleadoVenta = empleadosDisponibles[indiceEmpleadoVenta - 1];
                            Venta venta = new Venta(productosVenta, cantidadesVenta, clienteVenta); // nuevo constructor
                            sucursalVenta.RealizarVenta(venta, empleadoVenta);
                            Console.WriteLine("Venta realizada exitosamente.");
                            break;
                        case 2:
                            // Mostrar lista de ventas realizadas
                            List<Venta> ventas = sucursal.RealizarVentas();
                            Console.WriteLine("Ventas realizadas:");
                            for (int i = 0; i < ventas.Count; i++) {
                                Console.WriteLine((i + 1) + ". " + ventas[i].ToString());
                            }
                            break;
                        case 3:
                            // Mostrar lista de productos disponibles
                            List<Producto> productos = sucursal.ObtenerProductosDisponibles();
                            Console.WriteLine("Productos disponibles:");
                            for (int i = 0; i < productos.Count; i++) {
                                Console.WriteLine((i + 1) + ". " + productos[i].ToString());
                            }
                            break;
                        case 4:
                            // Salir
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                } else {
                    Console.WriteLine("No se encontró un empleado con esa combinación de correo electrónico y número de teléfono.");
                }
                break;

           case 2:
    // Iniciar simulación como cliente
        bool continuarSimulacion = true;
            while (continuarSimulacion) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ingrese su correo electrónico: ");
                string correoClienteSim = Console.ReadLine();
                Console.Write("Ingrese su contaseña personalizada: ");
                string contrasenaClienteSim = Console.ReadLine();
                Cliente clienteSim = sucursal.AutenticarCliente(correoClienteSim, contrasenaClienteSim);
                if (clienteSim == null) {
                    Console.WriteLine("El cliente no está registrado o no tiene un nivel de lealtad suficiente para realizar compras.");
                    Console.WriteLine("Seleccione una opción:");
                    Console.WriteLine("1. Volver al menú anterior");
                    Console.WriteLine("2. Volver a intentar la autenticación");
                    Console.WriteLine("3. Salir de APPSOFT");
                    Console.Write("Ingrese el número de opción que desea seleccionar: ");
                    string opcion1 = Console.ReadLine();
                    switch (opcion1) {
                        case "1":
                            continuarSimulacion = false;
                            break;
                        case "2":
                            continue;
                        case "3":
                            continuarSimulacion = false;
                            continuarPrograma = false;
                            break;
                        default:
                            Console.WriteLine(" ");
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                            continue;
                    }
        } else {
            Console.WriteLine("Bienvenido, " + clienteSim.Nombre + ".");
            Console.Write("Ingrese el nombre del producto que desea comprar o presione Enter para salir: ");
            string nombreProductoSim = Console.ReadLine();
            while (nombreProductoSim != "") {
                Producto productoSim = null;
                foreach (Producto producto in sucursal.Productos) {
                    if (producto.Nombre == nombreProductoSim) {
                        productoSim = producto;
                        break;
                    }
                }
                if (productoSim == null) {
                    Console.WriteLine("El producto no existe.");
                    Console.Write("Ingrese el nombre del producto que desea comprar o presione Enter para salir: ");
                    nombreProductoSim = Console.ReadLine();
                    continue;
                }
                Console.Write("Ingrese la cantidad que desea comprar: ");
                int cantidadProductoSim = Convert.ToInt32(Console.ReadLine());
                if (cantidadProductoSim <= 0 || cantidadProductoSim > productoSim.Stock) {
                    Console.WriteLine("Cantidad no válida.");
                    Console.Write("Ingrese el nombre del producto que desea comprar o presione Enter para salir: ");
                    nombreProductoSim = Console.ReadLine();
                    continue;
                }
                MetodoPago metodoPagoSim;
                if (clienteSim.Saldo >= productoSim.Precio * cantidadProductoSim) {
                    metodoPagoSim = new MetodoPago { Saldo = productoSim.Precio * cantidadProductoSim };
                    clienteSim.DescontarSaldo(productoSim.Precio * cantidadProductoSim);
                } else {
                    Console.Write("Ingrese el método de pago (1. Tarjeta de crédito, 2. Tarjeta de débito, 3. Efectivo): ");
                    int metodoPagoIntSim = Convert.ToInt32(Console.ReadLine());
                    switch (metodoPagoIntSim) {
                        case 1:
                            metodoPagoSim = new MetodoPago { TarjetaCredito = true };
                            break;
                        case 2:
                            metodoPagoSim = new MetodoPago { TarjetaDebito = true };
                            break;
                        case 3:
                            metodoPagoSim = new MetodoPago { Efectivo = true };
                            break;
                        default:
                            Console.WriteLine("Método de pago no válido.");
                            Console.Write("Ingrese el nombre del producto que desea comprar o presione Enter para salir: ");
                            nombreProductoSim = Console.ReadLine();
                            continue;
                    }
                }
                Venta ventaSim = new Venta(new List<Producto> { productoSim }, new List<int> { cantidadProductoSim }, metodoPagoSim, clienteSim);
                Empleado empleadoSim = new Empleado("John", "Doe", "11111111");
                sucursal.RealizarVenta(ventaSim, empleadoSim);
                Console.WriteLine("Compra realizada con éxito.");
                Console.Write("Ingrese el nombre del producto que desea comprar o presione Enter para salir: ");
                nombreProductoSim = Console.ReadLine();
            }
            continuarSimulacion = false;
        }
    }
    break;
        case 3:
            // Salir del programa
            continuarPrograma = false;
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
        } while (continuarPrograma);
    }
}
