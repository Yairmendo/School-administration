using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{

    public class Escuela
    {
        public string UniqueId {get; private set; } = Guid.NewGuid().ToString();
        string nombre;
        public string Nombre
        {
            get { return "Copia:" + nombre; }
            set {nombre = value.ToUpper();}
        }

        public int AñodeCreacion{get; set;}

        public string Pais { get; set; }
        public string Ciudad { get; set; }
        
/*         public Escuela(string nombre, int año)
        {
            this.nombre = nombre;
            AñodeCreacion = año;
        } */  //Este es el constructor largo
        public TiposEscuela TipoEscuela{get; set;}

        public List<Curso> Cursos { get; set; }

        public Escuela(string nombre, int año) => (Nombre, AñodeCreacion) = (nombre, año);//Este es el constructor corto

        public Escuela(string nombre, int año, TiposEscuela tipo, string pais = "", string ciudad = "")
        {
            (Nombre, AñodeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }

}
