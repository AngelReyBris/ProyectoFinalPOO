
using System;
using System.Collections.Generic;

// Clase ProgramaDeLealtad
// Clase ProgramaDeLealtad
public class ProgramaDeLealtad {
    public int Puntos { get; set; }
    public int Nivel { get; set; }

    public void AñadirPuntos(decimal puntos) {
        int puntosEnteros = (int) puntos;
        this.Puntos += puntosEnteros;
    }
}