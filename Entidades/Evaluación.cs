using System;
using System.Collections.Generic;


namespace CoreEscuela.Entidades
{
    public class Evaluación: ObjetoEscuelaBase
    {

        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota},{Alumno},{Asignatura}";
        }

    }
}