using GS.API.Data.Repositorios;
using GS.API.Models;
using GS.WIN.Shared;
using System;
using System.Windows.Forms;

namespace GS.WIN.Vendas
{
    public partial class CadClientes : Form
    {

        private bool status = true;
        private ClienteRep dbCliente;
        private EnderecosRep dbEnd;
        private DateTime DataCadastro;

        public int CodCli = 0;

        public CadClientes(int _codcli)
        {
            InitializeComponent();
            CodCli = _codcli;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

            if (CodCli > 0)
                Consulta();

            VerStatus();
        }

        private void Consulta()
        {
            dbCliente = new ClienteRep();
            dbEnd = new EnderecosRep();

            try
            {
                var cliente = dbCliente.GetById(CodCli);
                
                if (cliente.ClienteId > 0)
                {
                    tb_ClienteId.Text = cliente.ClienteId.ToString();
                    status = (bool)cliente.ClienteStatus;
                    DataCadastro = cliente.ClienteDataCad.Value;
                    tb_DataCadastro.Text = DataCadastro.ToShortDateString();
                    tb_ClienteNome.Text = cliente.ClienteNome;
                    tb_ClienteCell.Text = cliente.ClienteCelular;
                    dt_Nascimento.Value = cliente.ClienteDataNasc.Value;

                    if (cliente.ClienteTotalCompras != null)
                    {
                        var valor = cliente.ClienteTotalCompras;
                        tb_TotalCompras.Text = valor.ToString();
                    }

                    tb_CodEndereco.Text = cliente.CliCodEndereco.ToString();

                    CarregaEndereco();

                }
                else
                {
                    MessageBox.Show("Cliente não Encontrado!!!", "Doce Control", //Funcoes.msgCab,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível obter os dados, devido aos erros abaixo\n\n" + ex.Message,
                    "Doce Control" /*Funcoes.msgCab*/, MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void CarregaEndereco()
        {
            int CodEnd = string.IsNullOrEmpty(tb_CodEndereco.Text) ? 0 : Convert.ToInt32(tb_CodEndereco.Text);

            var endereco = dbEnd.GetById(CodEnd);
            if (endereco != null)
            {
                tb_DadosEndereco.Text = endereco.EnderecoRua + ", n. " + endereco.EnderecoNum +
                    " - " + endereco.EnderecoBairro + ", " + endereco.EnderecoCidade +
                    " " + endereco.EnderecoUF + " - " + endereco.EnderecoCEP;
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Status_Click(object sender, EventArgs e)
        {
            VerStatus();
        }

        private void VerStatus()
        {
            if (status) //true
            {
                bt_Status.Image = Properties.Resources.switch_on_icon_48X48;
                status = false;
            }
            else
            {
                bt_Status.Image = Properties.Resources.switch_off_icon_48X48;
                status = true;
            }
                
        }

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            dbCliente = new ClienteRep();
            Clientes mod = new Clientes();                        
                        
            //Verifica campos Obrigatórios
            if (tb_ClienteNome.Text == "" )
            {                
                MessageBox.Show("Preciso pelo menos do NOME para gravar o Cliente!", "Doce Control",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_ClienteNome.Focus();
                return;
            }

            try
            {
                //Cadastra
                mod.ClienteId = CodCli;
                mod.ClienteNome = tb_ClienteNome.Text;
                mod.ClienteCelular = tb_ClienteCell.Text;
                mod.ClienteDataNasc = dt_Nascimento.Value;

                if (!string.IsNullOrEmpty(tb_TotalCompras.Text))
                {
                    if (tb_TotalCompras.Text.Contains("R"))
                        tb_TotalCompras.Text = tb_TotalCompras.Text.Replace("R$", "");

                    mod.ClienteTotalCompras = Convert.ToDecimal(tb_TotalCompras.Text);
                }
                else
                    mod.ClienteTotalCompras = 0;

                mod.ClienteStatus = !status;
                mod.CliCodEndereco = string.IsNullOrEmpty(tb_CodEndereco.Text) ? 0 : Convert.ToInt32(tb_CodEndereco.Text);

                if (CodCli > 0) //Modificar
                {   
                    mod.ClienteDataCad = DataCadastro;
                    dbCliente.Update(mod);

                    MessageBox.Show("Cadastro alterado com Sucesso!!!", "Doce Control",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    mod.ClienteDataCad = DateTime.Now;
                    CodCli = dbCliente.AddCli(mod);

                    if (MessageBox.Show("Cadastro realizado com Sucesso!!!\n\nDeseja Cadastrar o Endereço agora?", "Doce Control",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (CodCli > 0)
                        {
                            this.Hide();
                            ListaEnderecos ender = new ListaEnderecos(this, tb_ClienteNome.Text);
                            ender.ShowDialog();
                            this.Close();
                        }
                    }
                }
                
                this.Close();

            }
            catch (Exception ex)
            {                
                MessageBox.Show("Problemas ao realizar o cadastro!!!\n\nMais Detalhes Abaixo\n" + ex.Message + "\nException: \n" + ex.InnerException,
                "Doce Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void bt_Endereco_Click(object sender, EventArgs e)
        {
            if (CodCli > 0)
            {
                this.Hide();
                ListaEnderecos ender = new ListaEnderecos(this, tb_ClienteNome.Text);
                ender.ShowDialog();
                CarregaEndereco();
                this.Show();
            }
            else
            {
                MessageBox.Show("Para cadastrar o Endereço do Cliente Primeiro você deve Cadastrar o Cliente!", "Doce Control",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
