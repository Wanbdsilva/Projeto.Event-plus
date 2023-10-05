using WebApi.Event.MANHA.Domains;

namespace WebApi.Event.MANHA.Interfaces
{
    public interface ITiposUsuarioRepository
    {
        void Cadastrar(TiposUsuario tipoUsuario);

        void Deletar(Guid Id);

        List<TiposUsuario> Listar();

        TiposUsuario BuscarPorId(Guid id);

        void Atualizar(Guid Id, TiposUsuario TipoUsuario);
    }
}
