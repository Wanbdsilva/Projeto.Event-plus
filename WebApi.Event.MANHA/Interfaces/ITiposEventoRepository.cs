using WebApi.Event.MANHA.Domains;

namespace WebApi.Event.MANHA.Interfaces
{
    public interface ITiposEventoRepository
    {
        void Cadastrar(TiposUsuario tipoUsuario);

        void Deletar(Guid Id);

        List<TiposUsuario> Listar();

        void Atualizar(Guid Id, TiposUsuario TipoUsuario);
    }
}
