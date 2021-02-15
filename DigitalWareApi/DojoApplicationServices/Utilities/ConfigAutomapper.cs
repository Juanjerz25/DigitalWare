using AutoMapper;
using DataStorage;
using DigitalWareServices.Models;

namespace DigitalWareServices.Utilities
{
    public static class ConfigAutomapper
    {
        public static IMapper mapper { get; set; }
        public static void Config()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FacturaModel, Factura>().ReverseMap();
                cfg.CreateMap<FacturaModel, Facturas>().ReverseMap();
                cfg.CreateMap<FacturaProductoModel, FacturaProductos>().ReverseMap();
                cfg.CreateMap<ProductoModel, Producto>().ReverseMap();
                cfg.CreateMap<ClienteModel, Cliente>().ReverseMap();
            });
            mapper = config.CreateMapper();
        }
    }
}
