using System;
using System.Collections.Generic;

    public class Empleado {
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; } // Permite valores nulos
    public string Telefono { get; set; } 
    public string Funcion { get; set; }
    public string Contrasena { get; set; }
    public bool Activo { get; set; }
    public string Rol { get; set; }

    public Empleado(string nombre, string correo, string direccion, string telefono, string funcion, string contrasena) {
        this.Nombre = nombre;
        this.Correo = correo;
        this.Telefono = telefono;
        this.Funcion = funcion;
        this.Contrasena = contrasena;
        this.Activo = true;
        this.Direccion = direccion; // Puede ser null
    }

    public Empleado(string nombre, string correo, string contrasena) {
        this.Nombre = nombre;
        this.Correo = correo;
        this.Contrasena = contrasena;
        this.Activo = true;
    }

    public Empleado(string nombre, string correo, string direccion, string telefono, string funcion) {
        this.Nombre = nombre;
        this.Correo = correo;
        this.Direccion = direccion; // Puede ser null
        this.Telefono = telefono;
        this.Funcion = funcion;
        this.Activo = true;
    }
}