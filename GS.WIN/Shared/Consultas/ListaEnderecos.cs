using GS.API.Data.Repositorios;
using GS.API.Models;
using GS.WIN.Compras;
using GS.WIN.Vendas;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GS.WIN.Shared
{
    public partial class ListaEnderecos : Form
    {
        private EnderecosRep dbDados;
        private int codOrigem = 0;
        private string nomeOrigem = "";
        private string tipoOrigem = "";
        private CadClientes FormCliente;
        private CadFornecedor FormFornecedor;
        //private CadVendedor FormVendedor;

        public ListaEnderecos(CadClientes cliente, string nome)
        {
            FormCliente = cliente;
            tipoOrigem = "C";
            nomeOrigem = nome;
            InitializeComponent();
        }

        public ListaEnderecos(CadFornecedor Fornecedor, string nome)
        {            
            FormFornecedor = Fornecedor;
            tipoOrigem = "F";
            nomeOrigem = nome;
            InitializeComponent();
        }

        //public ListaEnderecos(CadVendedor Vendedor, string nome)
        //{
        //    InitializeComponent();
        //    FormVendedor = Vendedor;
        //    tipoOrigem = "V";
        //    nomeOrigem = nome;
        //}

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            switch (tipoOrigem)
            {
                case "C":
                    codOrigem = FormCliente.CodCli;
                    lb_Origem.Text = "CLIENTE";
                    tb_CodOrigem.Text = codOrigem.ToString();
                    tb_NomeOrigem.Text = nomeOrigem;
                    break;
                case "F":
                    codOrigem = FormFornecedor.CodForn;
                    lb_Origem.Text = "FORNECEDOR";
                    tb_CodOrigem.Text = codOrigem.ToString();
                    tb_NomeOrigem.Text = nomeOrigem;
                    break;
                case "V":
                    //codOrigem = FormVendedor.CodVen;
                    //lb_Origem.Text = "VENDEDOR";
                    //tb_CodOrigem.Text = codOrigem.ToString();
                    //tb_NomeOrigem.Text = nomeOrigem;
                    break;
            }

            Consulta();
        }

#region Consultas
        private void Consulta()
        {
            int row = 0;
            dbDados = new EnderecosRep();

            var listaDados = dbDados.GetAll()
                .Where(e => e.EnderecoTipo == tipoOrigem && e.EnderecoOrigem == codOrigem).ToList();
            
            if (listaDados.Count > 0)
            {
                gridDados.Rows.Clear();
                foreach (Enderecos dados in listaDados)
                {
                    //Adiciona o PDV na Grid   Codigo, Rua, Numero, Bairro, Cidade, UF                  
                    gridDados.Rows.Add();
                    gridDados.Rows[row].Cells[0].Value = dados.EnderecoId;
                    gridDados.Rows[row].Cells[1].Value = dados.EnderecoRua;
                    gridDados.Rows[row].Cells[2].Value = dados.EnderecoNum;
                    gridDados.Rows[row].Cells[3].Value = dados.EnderecoBairro;
                    gridDados.Rows[row].Cells[4].Value = dados.EnderecoCidade;
                    gridDados.Rows[row].Cells[5].Value = dados.EnderecoUF;

                    row++;
                }
            }
            else
            {
                gridDados.Rows.Clear();
            }                       
        }

        private void bt_Atualizar_Click(object sender, EventArgs e)
        {
            Consulta();
        }
                
        private void tb_ClienteNome_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }
#endregion

        private void bt_Confirmar_Click(object sender, EventArgs e)
        {
            int ln = 0;
            int codigo = 0;

            if (gridDados.Rows.Count > 0)
            {
                ln = gridDados.CurrentRow.Index;
                codigo = Convert.ToInt32(gridDados.Rows[ln].Cells[0].Value.ToString());

                switch (tipoOrigem)
                {
                    case "C":
                        FormCliente.tb_CodEndereco.Text = codigo.ToString();
                        break;

                    case "F":
                        FormFornecedor.tb_CodEndereco.Text = codigo.ToString();
                        break;
                    case "V":
                        //FormVendedor.tb_Endereco.Text = codigo.ToString();
                        break;
                }
            }

            this.Close();
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadEndereco ender = new CadEndereco(0, codOrigem, tipoOrigem);
            ender.ShowDialog();
            this.Show();
            Consulta();
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            if (gridDados.Rows.Count > 0)
            {
                int ln = gridDados.CurrentRow.Index;
                int codigo = Convert.ToInt32(gridDados.Rows[ln].Cells[0].Value.ToString());

                this.Hide();
                CadEndereco ender = new CadEndereco(codigo, codOrigem, tipoOrigem);
                ender.ShowDialog();
                this.Show();
                Consulta();
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
