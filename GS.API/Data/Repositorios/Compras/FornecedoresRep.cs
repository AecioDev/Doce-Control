using GS.API.Data.Interfaces;
using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GS.API.Data.Repositorios
{
    public class FornecedoresRep : RepositorioBase<Fornecedores>, IFornecedoresRep
    {
        public int AddFor(Fornecedores obj)
        {
            Db.Fornecedores.Add(obj);
            Db.SaveChanges();

            // Depois do SaveChanges, se sua coluna for Identity, você deve ter o Id assim:
            return obj.FornecedorId;
        }

        public List<Fornecedores> ConsultaFor(string doc, string nome)
        {
            var forn = Db.Fornecedores.AsQueryable();
            
            if (!string.IsNullOrEmpty(doc))
                forn = forn.Where(f => f.FornecedorCPF.Contains(doc) || f.FornecedorCNPJ.Contains(doc));

            if (!string.IsNullOrEmpty(nome))
                forn = forn.Where(f => f.FornecedorNome.Contains(nome));

            return forn.ToList();
        }
    }
}
