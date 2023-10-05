using Microsoft.EntityFrameworkCore;
using WebApi.Event.MANHA.Contexts;
using WebApi.Event.MANHA.Domains;
using WebApi.Event.MANHA.Interfaces;

namespace WebApi.Event.MANHA.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {

        private readonly EventContext _eventContext;

        public TiposUsuarioRepository() 
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid Id, TiposUsuario tiposUsuario)
        {
            TiposUsuario tiposUsuario1 = _eventContext.TiposUsuario.Find(Id)!;

            if (tiposUsuario1 != null)
            {
                tiposUsuario1.Titulo = tiposUsuario1.Titulo;
            }

            _eventContext.TiposUsuario.Update(tiposUsuario1!);

            _eventContext.SaveChanges();
        }

        public TiposUsuario BuscarPorId(Guid id)
        {
           return _eventContext.TiposUsuario.FirstOrDefault(e => e.IdTipoUsuario == id)!;
        }

        public void Cadastrar(TiposUsuario tipoUsuario)
        {
            _eventContext.TiposUsuario.Add(tipoUsuario);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid Id)
        {
            TiposUsuario tiposUsuario = _eventContext.TiposUsuario.Find(Id)!;

            _eventContext.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {
            return _eventContext.TiposUsuario.Include(e => e.Titulo).ToList();
        }
    }
}
