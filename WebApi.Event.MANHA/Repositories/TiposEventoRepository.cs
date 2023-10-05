using WebApi.Event.MANHA.Contexts;
using WebApi.Event.MANHA.Domains;
using WebApi.Event.MANHA.Interfaces;

namespace WebApi.Event.MANHA.Repositories
{
    public class TiposEventoRepository : ITiposEventoRepository
    {
        private readonly TiposEvento _eventoRepository;

        public TiposEventoRepository()
        {
            _eventoRepository = new TiposEvento();    
        }

        public void Atualizar(Guid Id, TiposUsuario TipoUsuario)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TiposEvento tipoEvento)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TiposUsuario tipoUsuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<TiposUsuario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
