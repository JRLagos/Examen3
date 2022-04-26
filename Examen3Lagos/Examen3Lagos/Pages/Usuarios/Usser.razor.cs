using Examen3Lagos.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Examen3Lagos.Pages.Usuarios;

partial class Usser
{
    [Inject] private IUsuarioServicio _usuarioServicio { get; set; }

    private IEnumerable<Usuario> usuariosLista { get; set; }

    protected override async Task OnInitializedAsync()
    {
        usuariosLista = (IEnumerable<Usuario>)await _usuarioServicio.GetLista();
    }
}
