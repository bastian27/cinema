using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema_SCL.Models
{
    class Cartelera
    {
        public string Nombre { get; set; }
        public DateTime Fechaestreno { get; set; }
        public string Genero { get; set; }
        public string Recomendacion { get; set; }
        public int Duracion { get; set; }
        public string Imagen { get; set; }
        public List<Funciones> Funciones { get; set; }
    }
}
