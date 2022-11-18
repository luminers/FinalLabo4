using System;

namespace LabFinal.Models
{
    public class Integrante
    {

        public int Id { get; set; }
        public string nombre { get; set; }

        public string apellido { get; set; }

        public string biografia { get; set; }

       

        public string foto { get; set; }

        public int IdAlbum { get; set; }

        public Album album { get; set; }





    }
}
