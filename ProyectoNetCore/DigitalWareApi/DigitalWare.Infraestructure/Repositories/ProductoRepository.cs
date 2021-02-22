using DigitalWare.Core.Entities;
using DigitalWare.Core.Interfaces;
using DigitalWare.Infraestructure.Data;
using DigitalWare.Infraestructure.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWare.Infraestructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly DigitalWareContext _context;
        public ProductoRepository(DigitalWareContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<Producto>> ObtenerProductos()
        {
            var productos = await _context.Producto.ToListAsync();
            return productos;
        }

        public async Task<Producto> ObtenerProductoPorId(int Id)
        {
            var producto = await _context.Producto.FirstOrDefaultAsync(x=> x.Id == Id);
            return producto;
        }

        public async Task CrearProducto(Producto producto)
        {
            _context.Producto.Add(producto);
            await _context.SaveChangesAsync();            
        }

        public async Task ActualizarProducto(Producto producto)
        {
            var productoConsulta = _context.Producto.Where(x => x.Id == producto.Id).FirstOrDefault();
            FrammeworkTypeUtility.SetProperties(producto, productoConsulta);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> EliminarProducto(int id)
        {
            var productoConsulta = _context.Producto.Where(x => x.Id == id).FirstOrDefault();
            if(productoConsulta != null)
            {
                _context.Producto.Remove(productoConsulta);
                _context.SaveChanges();
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
            
        }
    }
}
