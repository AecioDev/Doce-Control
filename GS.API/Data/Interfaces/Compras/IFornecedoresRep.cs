using GS.API.Interfaces;
using GS.API.Models;
using System.Collections.Generic;

namespace GS.API.Data.Interfaces
{
    public interface IFornecedoresRep : IRepositorioBase<Fornecedores>
    {
        int AddFor(Fornecedores obj);
        List<Fornecedores> ConsultaFor(string doc, string nome);
    }
}
