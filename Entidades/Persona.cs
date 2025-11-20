using System.ComponentModel.DataAnnotations;

namespace EjemploRailwayNube.Entidades
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ci { get; set; }
    }
}
