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
    public static class ClienteServices
    {
        public static ClientesResponse ObtenerClientes()
        {
            var mensajes = new List<Mensaje>();
            try
            {
                List<Cliente> productos = ClienteAccess.ObtenerClientes();
                List<ClienteModel> productosModel = ConfigAutomapper.mapper.Map<List<ClienteModel>>(productos);

                mensajes.Add(new Mensaje("1", "Consulta Realizada Correctamente"));

                return new ClientesResponse(productosModel, true, mensajes);

            }
            catch (Exception ex)
            {

                //Captura de errores
                mensajes.Add(new Mensaje(null, ex.Message));
                return new ClientesResponse(null, false, mensajes);
            }
        }
    }
}
