using GS.API.Data.Interfaces;
using GS.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace GS.API.Data.Repositorios
{    
    public class ClienteRep : RepositorioBase<Clientes>, IClienteRep
    {
        public int AddCli(Clientes obj)
        {
            Db.Clientes.Add(obj);
            Db.SaveChanges();

            // Depois do SaveChanges, se sua coluna for Identity, você deve ter o Id assim:
            return obj.ClienteId;
        }

        public List<Clientes> ConsultaClientes(string celular, string nome)
        {
            var cliente = Db.Clientes.AsQueryable();
                        
            if (!string.IsNullOrEmpty(celular))
                cliente = cliente.Where(c => c.ClienteCelular.Contains(celular));

            if (!string.IsNullOrEmpty(nome))
                cliente = cliente.Where(c => c.ClienteNome.Contains(nome));

            return cliente.ToList();
        }

    }
}
