using DataStorage.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage.DataAccess
{
    public static class ClienteAccess
    {
        public static List<Cliente> ObtenerClientes()
        {
            try
            {
                using (var dbContextScope = new DigitalWareEntities())
                {
                    return dbContextScope.Cliente.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  

        public static bool CrearCliente(Cliente cliente)
        {
            bool response = false;
            try
            {
                using (var dbContextScope = new DigitalWareEntities())
                {
                    dbContextScope.Cliente.Add(cliente);
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
