using DigitalWare.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWare.Core.Interfaces
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> ObtenerProductos();

        Task<Producto> ObtenerProductoPorId(int Id);
        Task CrearProducto(Producto producto);
        Task ActualizarProducto(Producto producto);
        Task<bool> EliminarProducto(int id);
    }
}
