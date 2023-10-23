using MagicVillaAPI.Modelos;

namespace MagicVillaAPI.Repositorio.IRepositorio
{
    public interface INumeroVillaRepositorio: IRepositorio<NumeroVilla>
    {
        Task<NumeroVilla> Actualizar(NumeroVilla entidad);
    }
}
