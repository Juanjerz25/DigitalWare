using AutoMapper;
using DigitalWare.Core.DTOs;
using DigitalWare.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWare.Infraestructure.Mappings
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Producto, ProductoDto>().ReverseMap();
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Factura, FacturaDto>().ReverseMap();
            CreateMap<FacturaProducto, FacturaProductoDto>().ReverseMap();
        }
    }
}
