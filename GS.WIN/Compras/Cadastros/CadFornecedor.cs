using GS.API.Data.Repositorios;
using GS.API.Models;
using GS.WIN.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GS.WIN.Compras
{
    public partial class CadFornecedor : Form
    {
        public int CodForn = 0;

        private string msgCab = "Doce Control";
        private FornecedoresRep cadFor;
        private EnderecosRep dbEnd;

        public CadFornecedor(int _codForn)
        {
            InitializeComponent();
            CodForn = _codForn;
        }

        private void CadFornecedor_Load(object sender, EventArgs e)
        {
            if (CodForn > 0)
                Consulta();
        }

        private void Consulta()
        {
            cadFor = new FornecedoresRep();
            dbEnd = new EnderecosRep();

            try
            {
                var forn = cadFor.GetById(CodForn);
                                
                if (forn.FornecedorId > 0)
                {
                    tb_FornecedorId.Text = forn.FornecedorId.ToString();
                    tb_Nome.Text = forn.FornecedorNome;
                    tb_Email.Text = forn.FornecedorEmail;
                    tb_CPF.Text = forn.FornecedorCPF;
                    tb_CNPJ.Text = forn.FornecedorCNPJ;
                    tb_Tel1.Text = forn.FornecedorTel1;
                    tb_Tel2.Text = forn.FornecedorTel2;
                    tb_Contato.Text = forn.FornecedorContato;

                    tb_CodEndereco.Text = forn.ForCodEndereco.ToString();

                    CarregaEndereco();
                }
                else
                {
                    MessageBox.Show("Fornecedor não Encontrado!!!", msgCab,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível obter os dados, devido aos erros abaixo\n\n" + ex.Message,
                    msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);                
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

        #region ************** Tratando Valores Informados nos campos ****************
        private void tb_CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aceita apenas numeros no textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tb_CNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aceita apenas numeros no textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        #endregion

        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            cadFor = new FornecedoresRep();
            Fornecedores mod = new Fornecedores();
                                                
            //Verifica campos Obrigatórios
            if (tb_Nome.Text == "")
            {
                MessageBox.Show("Preciso pelo menos do NOME para gravar o Fornecedor!!!", msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Nome.Focus();
                return;
            }
                        
            try
            {
                //Cadastra o Fornecedor                
                mod.FornecedorId = CodForn;
                mod.FornecedorCPF = tb_CPF.Text;
                mod.FornecedorCNPJ = tb_CNPJ.Text;
                mod.FornecedorNome = tb_Nome.Text;
                mod.FornecedorEmail = tb_Email.Text;
                mod.FornecedorTel1 = tb_Tel1.Text;
                mod.FornecedorTel2 = tb_Tel2.Text;
                mod.FornecedorContato = tb_Contato.Text;

                mod.ForCodEndereco = string.IsNullOrEmpty(tb_CodEndereco.Text) ? 0 : Convert.ToInt32(tb_CodEndereco.Text);

                if (CodForn > 0)   //Modificar
                {
                    cadFor.Update(mod);
                    MessageBox.Show("Cadastro alterado com Sucesso!!!", msgCab,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CodForn = cadFor.AddFor(mod);

                    if (MessageBox.Show("Cadastro realizado com Sucesso!!!\n\nDeseja Cadastrar o Endereço agora?", msgCab,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (CodForn > 0)
                        {
                            this.Hide();
                            ListaEnderecos ender = new ListaEnderecos(this, tb_Nome.Text);
                            ender.ShowDialog();
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
            if (CodForn > 0)
            {
                this.Hide();
                ListaEnderecos ender = new ListaEnderecos(this, tb_Nome.Text);
                ender.ShowDialog();
                CarregaEndereco();
                this.Show();
            }
            else
            {
                MessageBox.Show("Para cadastrar o Endereço do Fornecedor Primeiro você deve Cadastrar o Fornecedor!", "Doce Control",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
