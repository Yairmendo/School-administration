using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
            ciudad: "CDMX", pais: "Mexico"
            );

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            var lista = new List<Evaluación>();
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);

                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluación
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{i + 1}",
                                Nota = (float)(5 * rnd.NextDouble())
                            };
                            lista.Add(ev);
                        }
                    }
                }
            }
        }
        private float NoteSimulator()
        {
            var rand = new Random();
            float result = (float)Math.Round(rand.NextDouble() * 5, 2);
            return result;
        }


        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listasAsignaturas = new List<Asignatura>(){
                        new Asignatura{Nombre = "Matemáticas"},
                        new Asignatura{Nombre = "Educación Física"},
                        new Asignatura{Nombre = "Castellano"},
                        new Asignatura{Nombre = "Ciencias Naturales"}
                };

                curso.Asignaturas = listasAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos =  from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno{Nombre = $"{n1} {n2} {a1}" };
            
            return listaAlumnos.OrderBy((al)=> al.UniqueId ).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>()
            {
                new Curso(){Nombre = "101", Jornada = TiposJornadas.Mañana },
                new Curso(){Nombre = "201", Jornada = TiposJornadas.Mañana },
                new Curso{Nombre = "301", Jornada = TiposJornadas.Mañana },
                new Curso(){Nombre = "401", Jornada = TiposJornadas.Tarde },
                new Curso(){Nombre = "501", Jornada = TiposJornadas.Tarde },
            };

            Random rnd = new Random();
            foreach(var c in Escuela.Cursos)
            {
                int cantRandom =rnd.Next(5, 20);
                c.Alumnos = GenerarAlumnosAlAzar(cantRandom);
            }
            
        }

    }
}