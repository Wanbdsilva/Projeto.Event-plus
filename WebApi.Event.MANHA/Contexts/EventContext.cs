using Microsoft.EntityFrameworkCore;
using WebApi.Event.MANHA.Domains;
using WebApi.Event.MANHA.Repositories;

namespace WebApi.Event.MANHA.Contexts
{
    public class EventContext : DbContext
    {
        public DbSet<TiposUsuario> TiposUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<TiposEvento> TiposEvento { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<ComentariosEvento> ComentariosEvento { get; set; }
        public DbSet<Instituicao> Instituicao { get; set; }
        public DbSet<PresencaEvento> PresencaEvento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE18-S15; Database=WebApi.Event.MANHA; User id = sa; pwd = Senai@134; TrustServerCertificate=True; ");
            base.OnConfiguring(optionsBuilder);
        }

        public static implicit operator EventContext(TiposEventoRepository v)
        {
            throw new NotImplementedException();
        }
    }
}
