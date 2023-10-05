using WebApi.Event.MANHA.Domains;

namespace WebApi.Event.MANHA.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);

        Usuario BuscarPorId(Guid Id);

        Usuario BuscarPorEmailESenha(string email, string Senha);
    }
}
