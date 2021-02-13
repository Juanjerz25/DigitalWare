using DataStorage.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage.DataAccess
{
    public static class ProductoAccess
    {
        public static List<Producto> ObtenerProductos()
        {
            try
            {
                using (var dbContextScope = new DigitalWareEntities())
                {
                    return dbContextScope.Producto.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  

        public static bool CrearProducto(Producto producto)
        {
            bool response = false;
            try
            {
                using (var dbContextScope = new DigitalWareEntities())
                {
                    dbContextScope.Producto.Add(producto);
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

    }
}
