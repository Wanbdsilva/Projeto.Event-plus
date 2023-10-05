using Microsoft.EntityFrameworkCore;
using WebApi.Event.MANHA.Contexts;
using WebApi.Event.MANHA.Domains;
using WebApi.Event.MANHA.Interfaces;
using WebApi.Event.MANHA.Utils;

namespace WebApi.Event.MANHA.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EventContext _eventContext;

        public UsuarioRepository()
        {
            _eventContext = new EventContext();
        }
        
        public Usuario BuscarPorEmailESenha(string email, string Senha)
        {
            try
            {
                Usuario usuarioBuscado = _eventContext.Usuario
                    .Select(u => new Usuario
                    {
                        IdUsuario = u.IdUsuario,
                        Nome = u.Nome,
                        Email = u.Email,

                        TiposUsuario = new TiposUsuario
                        {
                            Titulo = u.TiposUsuario!.Titulo
                        }
                    }).FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado != null) 
                {
                    bool confere = Criptografia.CompararHash(Senha, usuarioBuscado.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }
                return null!;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public Usuario BuscarPorId(Guid Id)
        {
            try
            {
                Usuario usuarioBuscado = _eventContext.Usuario
                    .Select(u => new Usuario
                    {
                        IdUsuario = u.IdUsuario,
                        Nome= u.Nome,
                        Email= u.Email,

                        TiposUsuario= new TiposUsuario
                        {
                            Titulo = u.TiposUsuario.Titulo
                        }
                    }).FirstOrDefault(u => u.IdUsuario == Id)!;

                if (usuarioBuscado != null)
                {
                    return usuarioBuscado;
                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha);

                _eventContext.Add(usuario);

                _eventContext.SaveChanges();
            }
            catch (Exception) 
            {
                throw;
            }
        }
    }
}
