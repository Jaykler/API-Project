using HildaVilla.Api.Models.Dto;

namespace HildaVilla.Api.Data
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList =
        [
            new() {Id = 1, Nombre= "vista al mar"},
            new() {Id = 2, Nombre= "vista a la piscina"},
        ];
    }
}
