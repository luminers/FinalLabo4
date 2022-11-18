namespace LabFinal.Models
{
    public class IntegranteAlbum
    {
        public int Id { get; set; }

        public int IdAlbum { get; set; }

        public int IdIntegrante { get; set; }

        public Album album { get; set; }

        public Integrante integrante { get; set; }


    }
}
