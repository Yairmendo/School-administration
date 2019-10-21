using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Evaluaciones
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Nota { get; set; }

        public Evaluaciones() => UniqueId = Guid.NewGuid().ToString();

        internal static void Add(IEnumerable<Evaluaciones> evaluaciones)
        {
            throw new NotImplementedException();
        }
    }
}