﻿using DataStorage;
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

        public static FacturaProductosResponse ObtenerFacturaProductos(FacturaModel request)
        {
            var mensajes = new List<Mensaje>();
            try
            {
                List<FacturaProductos> facturaProductos = FacturaAccess.ObtenerFacturaProductos((int)request.Id);
                List<FacturaProductoModel> facturaProductosModel = ConfigAutomapper.mapper.Map<List<FacturaProductoModel>>(facturaProductos);

                mensajes.Add(new Mensaje("1", "Consulta Realizada Correctamente"));

                return new FacturaProductosResponse(facturaProductosModel, true, mensajes);
            }
            catch (Exception ex)
            {
                //Captura de errores
                mensajes.Add(new Mensaje(null, ex.Message));
                return new FacturaProductosResponse(null, false, mensajes);
            }
        }

        public static FacturaResponse CrearFactura(FacturaModel request)
        {
            var mensajes = new List<Mensaje>();

            try
            {  
                // No tiene errores
                if (mensajes.Count == 0)
                {
                    Factura factura = ConfigAutomapper.mapper.Map<Factura>(request);
                    FacturaAccess.CrearFactura(factura);
                    FacturaModel facturaModel = ConfigAutomapper.mapper.Map<FacturaModel>(factura);

                    mensajes.Add(new Mensaje("1", "Registro Creado Correctamente"));
                    return new FacturaResponse(facturaModel, true, mensajes);
                }
                else
                {
                    return new FacturaResponse(null, false, mensajes);
                }
            }
            catch (Exception ex)
            {
                //Captura de errores
                mensajes.Add(new Mensaje("Error", ex.Message));

                return new FacturaResponse(null, false, mensajes);
            }
        }

        public static FacturaResponse EditarFactura(FacturaModel request)
        {
            var mensajes = new List<Mensaje>();

            try
            {
                // No tiene errores
                if (mensajes.Count == 0)
                {
                    Factura factura = ConfigAutomapper.mapper.Map<Factura>(request);
                    FacturaAccess.EditarFactura(factura);
                    FacturaModel facturaModel = ConfigAutomapper.mapper.Map<FacturaModel>(factura);

                    mensajes.Add(new Mensaje("1", "Registro Modificado Correctamente"));
                    return new FacturaResponse(facturaModel, true, mensajes);
                }
                else
                {
                    return new FacturaResponse(null, false, mensajes);
                }
            }
            catch (Exception ex)
            {
                //Captura de errores
                mensajes.Add(new Mensaje("Error", ex.Message));

                return new FacturaResponse(null, false, mensajes);
            }
        }

        public static FacturaResponse EliminarFactura(FacturaModel request)
        {
            var mensajes = new List<Mensaje>();

            try
            {
                // No tiene errores
                if (mensajes.Count == 0)
                {
                    Factura factura = ConfigAutomapper.mapper.Map<Factura>(request);
                    FacturaAccess.EliminarFactura(factura);
                    FacturaModel facturaModel = ConfigAutomapper.mapper.Map<FacturaModel>(factura);

                    mensajes.Add(new Mensaje("1", "Registro Modificado Correctamente"));
                    return new FacturaResponse(facturaModel, true, mensajes);
                }
                else
                {
                    return new FacturaResponse(null, false, mensajes);
                }
            }
            catch (Exception ex)
            {
                //Captura de errores
                mensajes.Add(new Mensaje("Error", ex.Message));

                return new FacturaResponse(null, false, mensajes);
            }
        }

        public static FacturaProductoResponse CrearFacturaProducto(FacturaModel request)
        {
            var mensajes = new List<Mensaje>();

            try
            {
                // No tiene errores
                if (mensajes.Count == 0)
                {
                    FacturaProducto facturaProducto = ConfigAutomapper.mapper.Map<FacturaProducto>(request);
                    FacturaAccess.CrearFacturaProducto(facturaProducto);
                    FacturaProductoModel facturaProductoModel = ConfigAutomapper.mapper.Map<FacturaProductoModel>(facturaProducto);

                    mensajes.Add(new Mensaje("1", "Registro Creado Correctamente"));
                    return new FacturaProductoResponse(facturaProductoModel, true, mensajes);
                }
                else
                {
                    return new FacturaProductoResponse(null, false, mensajes);
                }
            }
            catch (Exception ex)
            {
                //Captura de errores
                mensajes.Add(new Mensaje("Error", ex.Message));

                return new FacturaProductoResponse(null, false, mensajes);
            }
        }

        public static FacturaProductoResponse EditarFacturaProducto(FacturaModel request)
        {
            var mensajes = new List<Mensaje>();

            try
            {
                // No tiene errores
                if (mensajes.Count == 0)
                {
                    FacturaProducto facturaProducto = ConfigAutomapper.mapper.Map<FacturaProducto>(request);
                    FacturaAccess.EditarFacturaProducto(facturaProducto);
                    FacturaProductoModel facturaProductoModel = ConfigAutomapper.mapper.Map<FacturaProductoModel>(facturaProducto);

                    mensajes.Add(new Mensaje("1", "Registro Creado Correctamente"));
                    return new FacturaProductoResponse(facturaProductoModel, true, mensajes);
                }
                else
                {
                    return new FacturaProductoResponse(null, false, mensajes);
                }
            }
            catch (Exception ex)
            {
                //Captura de errores
                mensajes.Add(new Mensaje("Error", ex.Message));

                return new FacturaProductoResponse(null, false, mensajes);
            }
        }

        public static FacturaProductoResponse EliminarFacturaProducto(FacturaModel request)
        {
            var mensajes = new List<Mensaje>();

            try
            {
                // No tiene errores
                if (mensajes.Count == 0)
                {
                    FacturaProducto facturaProducto = ConfigAutomapper.mapper.Map<FacturaProducto>(request);
                    FacturaAccess.EliminarFacturaProducto(facturaProducto.Id);
                    FacturaProductoModel facturaProductoModel = ConfigAutomapper.mapper.Map<FacturaProductoModel>(facturaProducto);

                    mensajes.Add(new Mensaje("1", "Registro Creado Correctamente"));
                    return new FacturaProductoResponse(facturaProductoModel, true, mensajes);
                }
                else
                {
                    return new FacturaProductoResponse(null, false, mensajes);
                }
            }
            catch (Exception ex)
            {
                //Captura de errores
                mensajes.Add(new Mensaje("Error", ex.Message));

                return new FacturaProductoResponse(null, false, mensajes);
            }
        }
    }
}
