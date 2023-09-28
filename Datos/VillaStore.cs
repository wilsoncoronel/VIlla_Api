using MagicVillaAPI.Modelos.Dto;

namespace MagicVillaAPI.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto{Id=1, Nombre="Lista 1", MetrosCuadrados = 60, Ocupantes = 3},
            new VillaDto{Id=2,Nombre = "Lista 2", MetrosCuadrados = 80, Ocupantes = 4}
        };
    }
}
