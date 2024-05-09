using Microsoft.EntityFrameworkCore;

namespace iCompass.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<TipoUsuario> TipoUsuario { get; set; }

        public DbSet<TipoSexo> TipoSexo { get; set; }

        public DbSet<TipoRedeSocial> TipoRedeSocial { get; set; }

        public DbSet<TipoConteudo> TipoConteudo { get; set; }

        public DbSet<Postagem> Postagem { get; set; }

        public DbSet<Plano> Plano { get; set; }

        public DbSet<DadosInfluencer> DadosInfluencer { get; set; }

    }
}
