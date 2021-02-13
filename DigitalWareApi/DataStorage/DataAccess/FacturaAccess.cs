using DataStorage.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage.DataAccess
{
    public static class FacturaAccess
    {
        public static List<Facturas> ObtenerFacturas()
        {
            try
            {
                using (var dbContextScope = new DigitalWareEntities())
                {
                    return dbContextScope.ObtenerFacturas().ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<FacturaProductos> ObtenerFacturaProductos(int clienteId)
        {
            try
            {
                using (var dbContextScope = new DigitalWareEntities())
                {
                    return dbContextScope.ObtenerFacturaProductos(clienteId).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool CrearFactura(Factura factura)
        {
            bool response = false;
            try
            {
                using (var dbContextScope = new DigitalWareEntities())
                {
                    dbContextScope.Factura.Add(factura);
                    dbContextScope.SaveChanges();
                    response = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        public static bool CrearFacturaProducto(FacturaProducto facturaProducto)
        {
            bool response = false;
            try
            {
                using (var dbContextScope = new DigitalWareEntities())
                {
                    dbContextScope.FacturaProducto.Add(facturaProducto);
                    dbContextScope.SaveChanges();
                    response = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        public static bool EliminarFacturaProducto(int facturaProductoId)
        {
            bool response = false;
            try
            {
                using (var dbContextScope = new DigitalWareEntities())
                {
                    var facturaProducto = dbContextScope.FacturaProducto.Where(x => x.Id == facturaProductoId).FirstOrDefault();
                    if (facturaProducto != null)
                    {
                        dbContextScope.FacturaProducto.Remove(facturaProducto);
                        dbContextScope.SaveChanges();
                        response = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

    }
}
