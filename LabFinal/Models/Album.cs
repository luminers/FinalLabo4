using System;

namespace LabFinal.Models
{
    public class Album
    {
        public int Id { get; set; }

        public string nombre { get; set; }

        public string resumen { get; set; }

        public DateTime fechaCreacion { get; set; }

        public string imagenTapa { get; set; }

        public int? categoriaId { get; set; }

        public Categoria categoria { get; set; }

    }
}
