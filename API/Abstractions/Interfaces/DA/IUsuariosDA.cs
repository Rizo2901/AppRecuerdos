using Abstractions.Interfaces.Models;


namespace Abstractions.Interfaces.DA
{
    public interface IUsuariosDA
    {
        Task<IEnumerable<UsuariosDetalle>> Obtener();
        Task<UsuariosDetalle> Obtener(Guid Id);
        Task<Guid> Agregar(UsuariosRequest usuario);
        Task<Guid> Editar(Guid Id, UsuariosRequest usuario);
        Task<Guid> Eliminar(Guid Id);
    }
}
