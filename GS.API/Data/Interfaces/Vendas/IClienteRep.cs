using GS.API.Interfaces;
using GS.API.Models;
using System.Collections.Generic;

namespace GS.API.Data.Interfaces
{
    public interface IClienteRep : IRepositorioBase<Clientes>
    {
        int AddCli(Clientes obj);
        List<Clientes> ConsultaClientes(string celular, string nome);

    }
}
