using AutoMapper;
using DigitalWare.Core.DTOs;
using DigitalWare.Core.Entities;
using DigitalWare.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigitalWare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IMapper _mapper;
        public ProductoController(IProductoRepository productoRepository, IMapper mapper)
        {
            _productoRepository = productoRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerProductos()
        {
            var productos = await _productoRepository.ObtenerProductos();
            var productosDto = _mapper.Map<IEnumerable<ProductoDto>>(productos);
            return Ok(productosDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerProductoPorId(int id)
        {
            var producto = await _productoRepository.ObtenerProductoPorId(id);
            var productoDto = _mapper.Map<ProductoDto>(producto);
            return Ok(productoDto);
        }
        [HttpPost]
        public async Task<IActionResult> CrearProducto(ProductoDto productoDto)
        {
            var producto = _mapper.Map<Producto>(productoDto);
            await _productoRepository.CrearProducto(producto);
            return Ok(productoDto);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarProducto(ProductoDto productoDto)
        {
            var producto = _mapper.Map<Producto>(productoDto);
            await _productoRepository.ActualizarProducto(producto);
            return Ok(productoDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarProducto(int id)
        {
            var estadoProducto = await _productoRepository.EliminarProducto(id);
            if (estadoProducto)
                return Ok(null);
            return NotFound();
        }
    }
}
