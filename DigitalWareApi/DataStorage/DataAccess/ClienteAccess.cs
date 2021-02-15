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

        public static bool EditarCliente(Cliente cliente)
        {
            bool response = false;
            try
            {
                using (var dbContextScope = new DigitalWareEntities())
                {
                    var clienteConsulta = dbContextScope.Cliente.Where(x => x.Id == cliente.Id).FirstOrDefault();
                    if (clienteConsulta != null)
                    {                        
                        FrammeworkTypeUtility.SetProperties(cliente, clienteConsulta);
                        dbContextScope.SaveChanges();
                        response = true;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                response = false;
                throw ex;                
            }

            return response;
        }

        public static bool EliminarCliente(Cliente cliente)
        {
            bool response = false;
            try
            {
                using (var dbContextScope = new DigitalWareEntities())
                {
                    var clienteConsulta = dbContextScope.Cliente.Where(x => x.Id == cliente.Id).FirstOrDefault();
                    if (clienteConsulta != null)
                    {
                        dbContextScope.Cliente.Remove(clienteConsulta);
                        dbContextScope.SaveChanges();
                        response = true;
                    }

                }
            }
            catch (Exception ex)
            {
                response = false;
                throw ex;
            }

            return response;
        }

    }
}
