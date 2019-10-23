using System;
using System.Collections.Generic;
using CoreEscuela.Util;
using Etapa1.Entidades;

namespace CoreEscuela.Entidades
{
    public class Curso: ObjetoEscuelaBase, ILugar
    {

        public TiposJornadas Jornada { get; set; }

        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }

        public string Dirección { get; set; }

        public void LimpiarLugar()
        {
            Printer.DrawLine();
            Console.WriteLine("Limpiando establecimiento...");
            Console.WriteLine($"Curso {Nombre} Limpio");
        }
    }
}