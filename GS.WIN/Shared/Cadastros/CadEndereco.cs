using Canducci.Zip;
using GS.API.Data.Repositorios;
using GS.API.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GS.WIN.Shared
{
    public partial class CadEndereco : Form
    {

        private EnderecosRep dbEnd;

        private int CodEnd = 0;
        private int CodOrigem = 0;
        private string TipoOrigem = "";


        public CadEndereco(int _codend, int _codOrig, string _tipoOrigem)
        {
            InitializeComponent();
            CodEnd = _codend;
            CodOrigem = _codOrig;
            TipoOrigem = _tipoOrigem;
        }

        private void Endereco_Load(object sender, EventArgs e)
        {
            if (CodEnd > 0)
                Consulta();
        }

        private void Consulta()
        {            
            dbEnd = new EnderecosRep();

            try
            {
                var dados = dbEnd.GetById(CodEnd);

                if (dados.EnderecoId > 0)
                {
                    tb_CodEnd.Text = dados.EnderecoId.ToString();
                    tb_CepEnd.Text = dados.EnderecoCEP;
                    tb_RuaEnd.Text = dados.EnderecoRua;
                    tb_NumEnd.Text = dados.EnderecoNum;
                    tb_CompEnd.Text = dados.EnderecoComplemento;
                    tb_BaiEnd.Text = dados.EnderecoBairro;
                    tb_CidEnd.Text = dados.EnderecoCidade;
                    tb_UFEnd.Text = dados.EnderecoUF;
                }
                else
                {
                    MessageBox.Show("Endereço não Encontrado!!!", "Doce Control", //Funcoes.msgCab,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível obter os dados, devido aos erros abaixo\n\n" + ex.Message,
                    "Doce Control" /*Funcoes.msgCab*/, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //cliente.Dispose();
            }
        }

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            dbEnd = new EnderecosRep();
            Enderecos mod = new Enderecos();
                        
            //Verifica campos Obrigatórios
            if (tb_RuaEnd.Text == "" || tb_NumEnd.Text == "" || tb_BaiEnd.Text == "" || tb_CidEnd.Text == "" || tb_UFEnd.Text == "")
            {
                AjustaCampos(false);
                MessageBox.Show("Os campos em destaque são Obrigatórios!", "Doce Control",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }

            try
            {
                //Cadastra o Fornecedor                
                mod.EnderecoId = CodEnd;
                mod.EnderecoTipo = TipoOrigem;
                mod.EnderecoOrigem = CodOrigem;
                mod.EnderecoCEP = tb_CepEnd.Text;
                mod.EnderecoRua = tb_RuaEnd.Text;
                mod.EnderecoNum = tb_NumEnd.Text;
                mod.EnderecoComplemento = tb_CompEnd.Text;
                mod.EnderecoBairro = tb_BaiEnd.Text;
                mod.EnderecoCidade = tb_CidEnd.Text;
                mod.EnderecoUF = tb_UFEnd.Text;

                if (CodEnd > 0)   //Modificar
                    dbEnd.Update(mod);
                else
                    dbEnd.Add(mod);

                MessageBox.Show("Cadastro realizado com Sucesso!!!", "Doce Control",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas ao realizar o cadastro!!!\n\nMais Detalhes Abaixo\n" + ex.Message + "\nException: \n" + ex.InnerException,
                "Doce Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AjustaCampos(true);
        }

        private void AjustaCampos(bool ok)
        {
            if (ok)
            {
                tb_RuaEnd.BackColor = Color.White;
                tb_NumEnd.BackColor = Color.White;             
                tb_BaiEnd.BackColor = Color.White;
                tb_CidEnd.BackColor = Color.White;
                tb_UFEnd.BackColor = Color.White;
            }
            else
            {
                tb_RuaEnd.BackColor = Color.Tan;
                tb_NumEnd.BackColor = Color.Tan;
                tb_BaiEnd.BackColor = Color.Tan;
                tb_CidEnd.BackColor = Color.Tan;
                tb_UFEnd.BackColor = Color.Tan;
            }
        }

        private void LocalizarCEP()
        {
            try
            {
                var cep = tb_CepEnd.Text;

                if (cep.Length > 0)
                {
                    //Observação
                    //Formato válido para o CEP: 01414000 ou 01414-000 ou 01.414-000
                    if (cep.Length < 8 || cep.Length > 10)
                    {
                        MessageBox.Show("Formato do CEP não aceito! Favor utilize um dos formatos abaixo:\n79000999\n79000-999\n79.000-999", "Doce Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ZipCodeLoad zipLoad = new ZipCodeLoad();

                    ZipCode zipCode = null;
                    if (ZipCode.TryParse(tb_CepEnd.Text, out zipCode))
                    {
                        ZipCodeInfo zipCodeInfo = zipLoad.Find(zipCode);

                        if (zipCodeInfo != null)
                        {
                            tb_RuaEnd.Text = zipCodeInfo.Address;
                            tb_BaiEnd.Text = zipCodeInfo.District;
                            tb_CidEnd.Text = zipCodeInfo.City;
                            tb_UFEnd.Text = zipCodeInfo.Uf;
                        }
                        else
                        {
                            lb_MsgInfo.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Problemas ao obter o Dados!!!\n\nMais Detalhes Abaixo\n" + ex.Message + "\nException: \n" + ex.InnerException,
                "Doce Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_CepEnd_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }
    }
}
