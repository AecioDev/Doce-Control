using GS.API.Data.Interfaces;
using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GS.API.Data.Repositorios
{
    public class ProdutosRep : RepositorioBase<Produtos>, IProdutosRep
    {
        public Produtos GetByCod(int cod)
        {
            return Db.Produtos.AsQueryable()
                .Where(p => p.ProdutoId == cod)
                .Include(p => p.Unidade)
                .Include(p => p.Grupo)
                .FirstOrDefault();
        }

        public List<Produtos> ListaProdutos(string desc, int tipo, int grupo, int status)
        {
            var pro = Db.Produtos.AsQueryable();

            //Descrição
            if (!string.IsNullOrEmpty(desc))
                pro = pro.Where(p => p.ProdutoNome.Contains(desc));

            //Tipo
            if (tipo < 2) //2 = Todos
            {
                var fTipo = (tipo == 0) ? "C" : "F"; //Consumo ou Final
                pro = pro.Where(p => p.ProdutoTipo == fTipo);
            }

            //Grupo
            if (grupo > 0)
                pro = pro.Where(p => p.ProCodGrupo == grupo);

            //Status
            if (status < 2) //2 = Todos
            {
                var fStatus = (status == 0) ? false : true;
                pro = pro.Where(p => p.ProdutoAtivo == fStatus);
            }
            
            return pro
                .Include(p => p.Unidade)
                .Include(p => p.Grupo)
                .ToList();
        }
    }
}
