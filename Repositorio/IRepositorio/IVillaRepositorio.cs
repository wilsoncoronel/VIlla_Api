using MagicVillaAPI.Modelos;

namespace MagicVillaAPI.Repositorio.IRepositorio
{
    public interface IVillaRepositorio: IRepositorio<Villa>
    {
        Task<Villa> Actualizar(Villa entidad);
    }
}
