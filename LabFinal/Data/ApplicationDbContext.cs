using LabFinal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabFinal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Album> albums{ get; set; }
        public DbSet<Categoria> categorias { get; set; }

        public DbSet<Integrante> integrantes{ get; set; }

        public DbSet<IntegranteAlbum> integrantesAlbums { get; set; }



    }
}
