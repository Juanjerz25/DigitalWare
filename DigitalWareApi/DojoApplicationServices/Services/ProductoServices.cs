using DataStorage;
using DataStorage.DataAccess;
using DigitalWareServices.Models;
using DigitalWareServices.Response;
using DigitalWareServices.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWareServices.Services
{
    public static class ProductoServices
    {
        public static ProductosResponse ObtenerProductos()
        {
            var mensajes = new List<Mensaje>();
            try
            {
                List<Producto> productos = ProductoAccess.ObtenerProductos();
                List<ProductoModel> productosModel = ConfigAutomapper.mapper.Map<List<ProductoModel>>(productos);

                mensajes.Add(new Mensaje("1", "Consulta Realizada Correctamente"));

                return new ProductosResponse(productosModel, true, mensajes);

            }
            catch (Exception ex)
            {
                //Captura de errores
                mensajes.Add(new Mensaje(null, ex.Message));
                return new ProductosResponse(null, false, mensajes);
            }
        }
    }
}
