using System;
using System.Collections.Generic;

public enum TipoTrabajador {
    Gerente,
    Asistente,
    Tecnico
}

public class Empleado {
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Funcion { get; set; }
    public string Contrasena { get; set; }
    public bool Activo { get; set; }
    public string Rol { get; set; }
    public TipoTrabajador Tipo { get; set; }
    public string NumTrabajador { get; set; } // Agregar propiedad NumTrabajador

    public Empleado(string nombre, string correo, string direccion, string telefono, string funcion, string contrasena, TipoTrabajador tipo, string numTrabajador) {
        this.Nombre = nombre;
        this.Correo = correo;
        this.Telefono = telefono;
        this.Funcion = funcion;
        this.Contrasena = contrasena;
        this.Activo = true;
        this.Direccion = direccion; // Puede ser null
        this.Tipo = tipo;
        this.NumTrabajador = numTrabajador; // Asignar valor a NumTrabajador
    }

    public Empleado(string nombre, string correo, string contrasena, TipoTrabajador tipo, string numTrabajador) {
        this.Nombre = nombre;
        this.Correo = correo;
        this.Contrasena = contrasena;
        this.Activo = true;
        this.Tipo = tipo;
        this.NumTrabajador = numTrabajador; // Asignar valor a NumTrabajador
    }

    public Empleado(string nombre, string correo, string direccion, string telefono, string funcion, TipoTrabajador tipo, string numTrabajador) {
        this.Nombre = nombre;
        this.Correo = correo;
        this.Direccion = direccion; // Puede ser null
        this.Telefono = telefono;
        this.Funcion = funcion;
        this.Activo = true;
        this.Tipo = tipo;
        this.NumTrabajador = numTrabajador; // Asignar valor a NumTrabajador
    }

    public string NombreCompleto {
        get {
            return string.Format("{0}", this.Nombre); // Return the full name as a string
        }
    }
}