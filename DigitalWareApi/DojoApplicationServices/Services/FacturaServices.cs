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
    public static class FacturaServices
    {
        public static FacturasResponse ObtenerFacturas()
        {
            var mensajes = new List<Mensaje>();
            try
            {
                List<Facturas> facturas = FacturaAccess.ObtenerFacturas();
                List<FacturaModel> facturasModel = ConfigAutomapper.mapper.Map<List<FacturaModel>>(facturas);

                mensajes.Add(new Mensaje("1", "Consulta Realizada Correctamente"));

                return new FacturasResponse(facturasModel, true, mensajes);

            }
            catch (Exception ex)
            {

                //Captura de errores
                mensajes.Add(new Mensaje(null, ex.Message));
                return new FacturasResponse(null, false, mensajes);
            }
        }

        public static FacturasResponse ObtenerFacturaProductos(FacturaModel request)
        {
            var mensajes = new List<Mensaje>();
            try
            {
                List<FacturaProductos> facturaProductos = FacturaAccess.ObtenerFacturaProductos(request.Id);
                List<FacturaModel> facturaProductosModel = ConfigAutomapper.mapper.Map<List<FacturaModel>>(facturaProductos);

                mensajes.Add(new Mensaje("1", "Consulta Realizada Correctamente"));

                return new FacturasResponse(facturaProductosModel, true, mensajes);

            }
            catch (Exception ex)
            {
                //Captura de errores
                mensajes.Add(new Mensaje(null, ex.Message));
                return new FacturasResponse(null, false, mensajes);
            }
        }
    }
}
