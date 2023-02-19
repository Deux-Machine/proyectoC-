using System;
using CoreEscuela.Entidades;

namespace Etapa1{

    class Program{

        static void Main(string[] args){

            var escuela = new Escuela("El verguero", 2012);
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Medellin";
            Console.WriteLine(escuela.Nombre);
        }
    }
}
