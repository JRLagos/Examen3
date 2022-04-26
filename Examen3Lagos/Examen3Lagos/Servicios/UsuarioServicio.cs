using Datos.Interfaces;
using Datos.Repositorios;
using Examen3Lagos.Data;
using Examen3Lagos.Interfaces;
using Modelos;

namespace Examen3Lagos.Servicios;

public class UsuarioServicio : IUsuarioServicio
{
    private readonly MysqlConfiguration _configuration;
    private IUsuarioRepositorio usuarioRepositorio;

    public UsuarioServicio(MysqlConfiguration configuration)
    {
        _configuration = configuration;
        usuarioRepositorio = new UsuarioRepositorio(configuration.CadenaConexion);
    }

    public async Task<bool> Actualizar(Usuario usuario)
    {
        return await usuarioRepositorio.Actualizar(usuario);
    }

    public async  Task<bool> Eliminar(Usuario usuario)
    {
        return await usuarioRepositorio.Eliminar(usuario);
    }

    public async Task<IEnumerable<Usuario>> GetLista()
    {
        return await usuarioRepositorio.GetLista();
    }

    public async Task<Usuario> GetPorcodigo(string codigo)
    {
        return await usuarioRepositorio.GetPorcodigo(codigo);
    }

    public async Task<bool> Nuevo(Usuario usuario)
    {
        return await usuarioRepositorio.Nuevo(usuario);
    }
}
