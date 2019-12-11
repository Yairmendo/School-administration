###  Programa para la administración en una escuela.

#### Acerca del proyecto
Nació como un proyecto para ayudar a la familia de un amigo a llevar el control de la administración de su escuela a nivel Preescolar, primaria y secundaria .

#### Objetivo.
Facilitar el control de los alumnos, materias, calificaciones, maestros y reportes para evaluaciones.


Actualmente los datos para probar se encuentran generados aleatoriamente en el archivo **EscuelaEngine.cs** usando listas 

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

En el mismo archivo se encuentra también la generación de grupos, turnos y materias a cada alumno.

Actualmente estoy trabajando en recopilar la información para crear los reportes y son bienvenidas las propuestas para agregar funciones para mejorar el proyecto
