using System.Collections.Generic;

namespace GS.API.Models
{
    public class Fornecedores
    {
        public int FornecedorId { get; set; }
        public string FornecedorNome { get; set; }
        public string FornecedorCNPJ { get; set; }
        public string FornecedorCPF { get; set; }
        public string FornecedorContato { get; set; }
        public string FornecedorTel1 { get; set; }
        public string FornecedorTel2 { get; set; }
        public string FornecedorEmail { get; set; }
        public int? ForCodEndereco { get; set; }

        public List<Compras> Compra { get; set; }
    }
}
