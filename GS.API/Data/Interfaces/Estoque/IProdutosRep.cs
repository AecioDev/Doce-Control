using GS.API.Interfaces;
using GS.API.Models;
using System.Collections.Generic;

namespace GS.API.Data.Interfaces
{
    interface IProdutosRep : IRepositorioBase<Produtos>
    {
        Produtos GetByCod(int cod);
        List<Produtos> ListaProdutos(string desc, int tipo, int grupo, int status);
    }
}
