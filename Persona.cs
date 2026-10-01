using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Persona : IPresentable
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool EstaEmpleado { get; set; }

        public Persona(string nombre, int edad, bool estaEmpleado)
        {
            Nombre = nombre;
            Edad = edad;
            EstaEmpleado = estaEmpleado;
        }

        public virtual string Presentarse()
        {
            string estado = EstaEmpleado ? "tiene trabajo" : "está buscando trabajo";
            return $"{Nombre} tiene {Edad} años y {estado}.";
        }
    }
}
