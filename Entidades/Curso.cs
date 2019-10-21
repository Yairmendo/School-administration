using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public TiposJornadas Jornada { get; set; }

        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }

        public Curso() => UniqueId = Guid.NewGuid().ToString();
        
    }
}