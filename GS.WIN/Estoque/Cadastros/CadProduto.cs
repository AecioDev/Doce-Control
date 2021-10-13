using GS.API.Data.Repositorios;
using GS.API.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GS.WIN.Estoque
{
    public partial class CadProduto : Form
    {
        ProdutosRep cadPro;

        private bool status = true;

        private int TempoMsg = 5;
        private int CodPro = 0;
        private string msgCab = "Doce Control";        
        private decimal cusreppro = 0;
        private decimal cusmedpro = 0;


        //Códigos Consultados
        public int CodGrupo = 0;
        public int CodUni = 0;
        public string DescUni = "";
        public string SiglaUni = "";
        public decimal PrecoGrupo = 0;

        public CadProduto(int _codPro)
        {
            InitializeComponent();
            this.CodPro = _codPro;
        }
               
        private void CadProduto_Load(object sender, EventArgs e)
        {
            if (CodPro > 0) //Modificar o cadastro
            {
                Consulta();
                GetSaldoPro();
                AjustaCampos();                                
            }

            pnl_Dados.Visible = true;            
            pnl_Estoque.Visible = false;
            pnl_Precos.Visible = false;
            bt_AbaDados.BackColor = Color.FromArgb(68, 32, 117);
            VerStatus();
        }

        #region ************** Tratando Valores da Aba Dados ****************
        private void Consulta()
        {
            try
            {
                cadPro = new ProdutosRep();
                var pro = cadPro.GetByCod(CodPro);

                if (pro.ProdutoId > 0)
                {
                    //Aba Dados
                    tb_CodProduto.Text = pro.ProdutoId.ToString();
                    tb_descricao.Text = pro.ProdutoNome;
                    status = (bool)pro.ProdutoAtivo;

                    CodUni = (int)pro.ProCodUni;
                    tb_codUni.Text = CodUni.ToString();
                    tb_DescUni.Text = pro.Unidade.UnidadeNome;
                    tb_SiglaUni.Text = pro.Unidade.UnidadeSigla;

                    switch (pro.ProdutoTipo)
                    {
                        case "C":
                            cb_TipoPro.SelectedIndex = 0; //Consumo
                            break;
                        case "F":
                            cb_TipoPro.SelectedIndex = 1; //Final
                            break;
                    }

                    CodGrupo = (int)pro.ProCodGrupo;
                    tb_codGrupo.Text = CodGrupo.ToString();
                    tb_Grupo.Text = pro.Grupo.GrupoNome;

                    if ((bool)pro.ProPrecoGrupo) //Utiliza Preço por Grupo?
                    {
                        cb_PrecoGrupo.SelectedIndex = 0; //SIM
                        tb_precoVenda.Enabled = false;
                        tb_precoVenda.Text = pro.Grupo.GrupoPreco.ToString();
                    }
                    else
                    {
                        cb_PrecoGrupo.SelectedIndex = 1; //NÃO
                        tb_precoVenda.Enabled = true;
                        tb_precoVenda.Text = pro.ProPrecoAtual.ToString();
                    }

                    //Aba Estoque
                    
                    //Aba Preços
                    cusreppro = (decimal)pro.ProCustoCompra;
                    tb_cusRep.Text = cusreppro.ToString();

                    cusmedpro = (decimal)pro.ProCustoAtual;
                    tb_cusMed.Text = cusmedpro.ToString();                    
                }
                else
                {
                    MessageBox.Show("Produto Não Encontrado!!!", msgCab,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível obter os dados, devido aos erros abaixo\n\n" + ex.Message + "\nException: \n" + 
                    ex.InnerException, msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Grupo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaGrupos grp = new ListaGrupos(this);
            grp.ShowDialog();
            tb_codGrupo.Text = CodGrupo.ToString();
            if (cb_PrecoGrupo.SelectedIndex == 0)
                tb_precoVenda.Text = PrecoGrupo.ToString();

            AjustaCampos();
            this.Show();
        }

        private void tb_codGrupo_Leave(object sender, EventArgs e)
        {
            var codigo = string.IsNullOrEmpty(tb_codGrupo.Text) ? 0 : Convert.ToInt32(tb_codGrupo.Text);
            GruposRep grpDB = new GruposRep();
            var grp = grpDB.GetById(codigo);
            if (grp != null)
            {
                CodGrupo = grp.GrupoId;
                tb_Grupo.Text = grp.GrupoNome;
                if (cb_PrecoGrupo.SelectedIndex == 0)
                    tb_precoVenda.Text = grp.GrupoPreco.ToString();

                AjustaCampos();
            }
            else
            {
                lb_MsgInfo.Text = "Grupo com Código " + tb_codGrupo.Text + ", não encontrado!";
                lb_MsgInfo.Visible = true;
                tb_codGrupo.Text = CodGrupo.ToString();
                Relogio.Enabled = true;
            }
        }

        private void bt_Uni_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaUnidades ConsUniS = new ListaUnidades(this);
            ConsUniS.ShowDialog();
            tb_codUni.Text = CodUni.ToString();
            tb_DescUni.Text = DescUni;
            tb_SiglaUni.Text = SiglaUni;
            this.Show();
        }

        private void tb_SiglaUni_Leave(object sender, EventArgs e)
        {
            var codigo = string.IsNullOrEmpty(tb_codUni.Text) ? 0 : Convert.ToInt32(tb_codUni.Text);
            UnidadesRep uniDB = new UnidadesRep();
            var uni = uniDB.GetById(codigo);
            if (uni != null)
            {
                CodUni = uni.UnidadeId;
                tb_SiglaUni.Text = uni.UnidadeSigla;
                tb_DescUni.Text = uni.UnidadeNome;
            }
            else
            {
                lb_MsgInfo.Text = "Unidade com Código " + tb_codUni.Text + ", não encontrado!";
                lb_MsgInfo.Visible = true;
                tb_codUni.Text = CodUni.ToString();
                Relogio.Enabled = true;
            }
        }

        #endregion

        #region ************** Tratando Valores Informados nos campos ****************
        public void AjustaCampos()
        {
            try
            {
                if (tb_precoVenda.Text != "")
                {
                    if (tb_precoVenda.Text[0] == 'R')
                        tb_precoVenda.Text = tb_precoVenda.Text.Substring(2);

                    tb_precoVenda.Text = Convert.ToDecimal(tb_precoVenda.Text).ToString("C");
                }

                if (tb_cusRep.Text != "")
                {
                    if (tb_cusRep.Text[0] == 'R')
                        tb_cusRep.Text = tb_cusRep.Text.Substring(2);

                    tb_cusRep.Text = Convert.ToDecimal(tb_cusRep.Text).ToString("C");
                }

                if (tb_cusMed.Text != "")
                {
                    if (tb_cusMed.Text[0] == 'R')
                        tb_cusMed.Text = tb_cusMed.Text.Substring(2);

                    tb_cusMed.Text = Convert.ToDecimal(tb_cusMed.Text).ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor informe um valor válido!!!\nMaiores Detalhes:" + ex.Message,
                    msgCab, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void infNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                lb_MsgInfo.Text = "[ATENÇÃO] Este campo aceita somente numero e virgula!";
                lb_MsgInfo.Visible = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                lb_MsgInfo.Text = "[ATENÇÃO] Este campo aceita somente uma virgula!";
                lb_MsgInfo.Visible = true;
            }
        }
        
       private void Campo_Money(object sender, EventArgs e)
        {            
            if (tb_cusRep.Text != "")
            {
                if (tb_cusRep.Text[0] == 'R')
                    tb_cusRep.Text = tb_cusRep.Text.Substring(2);
                         
                tb_cusRep.Text = Convert.ToDecimal(tb_cusRep.Text).ToString("C");
            }

            if (tb_cusMed.Text != "")
            {
                if (tb_cusMed.Text[0] == 'R')
                    tb_cusMed.Text = tb_cusMed.Text.Substring(2);
                                
                tb_cusMed.Text = Convert.ToDecimal(tb_cusMed.Text).ToString("C");
            }

            if (tb_precoVenda.Text != "")
            {
                if (tb_precoVenda.Text[0] == 'R')
                    tb_precoVenda.Text = tb_precoVenda.Text.Substring(2);
                                
                tb_precoVenda.Text = Convert.ToDecimal(tb_precoVenda.Text).ToString("C");
            }
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
        #endregion

        #region ********************* Tratamento do Estoque **************************/
        private void GetSaldoPro()
        {
            //SaldoEstoqueRepositorio consSaldo = new SaldoEstoqueRepositorio();
            //int row = 0;

            //var saldos = consSaldo.GetByPro(CodPro);
                        
            //if (saldos.Count > 0)
            //{
            //    //gridModulos
            //    grid_Estoque.Rows.Clear();
            //    foreach (SaldoEstoque saldo in saldos)
            //    {
            //        //Adiciona o PDV na Grid
            //        grid_Estoque.Rows.Add();
            //        grid_Estoque.Rows[row].Cells[0].Value = saldo.CodLocalEst;
            //        grid_Estoque.Rows[row].Cells[1].Value = saldo.Estoque.DescEstoque;
            //        grid_Estoque.Rows[row].Cells[2].Value = saldo.QntSaldo;
            //        grid_Estoque.Rows[row].Cells[3].Value = tb_SiglaUni.Text;

            //        row++;
            //    }
            //}
            //else
            //{
            //    grid_Estoque.Rows.Clear();
            //}
        }

        #endregion

         private void bt_Gravar_Click(object sender, EventArgs e)
        {
            cadPro = new ProdutosRep();
            Produtos prod = new Produtos();

            bool PrecoGrupo = false;
            bool erro = false;

            string msgErro = "";
            string tipoPro = "";

            //********* Campos Automáticos **********

            //Tipo do Produto
            switch(cb_TipoPro.SelectedIndex)
            {
                case 0: //Consumo
                    tipoPro = "C";
                    break;
                case 1: // Final
                    tipoPro = "F";
                    break;
            }

            //Preço por Grupo?
            if (cb_PrecoGrupo.SelectedIndex == 0) //SIM
                PrecoGrupo = true;
            else
                PrecoGrupo = false;
            
            //************ Verifica campos Obrigatórios (Descrição, Grupo, Unidade) **************

            if (CodUni <= 0) //Unidade de Saída
            {
                msgErro += "Por Favor Informe a Unidade Padrão do Produto!\n";
                erro = true;
            }
                       
            if (CodGrupo <= 0) //Grupo
            {
                msgErro += "Por Favor Informe um Grupo para o Produto!\n";
                erro = true;
            }

            if (string.IsNullOrEmpty(tb_descricao.Text))
            {
                msgErro += "Por Favor Informe a Descrição do Produto!\n";
                erro = true;
            }

            if (tb_precoVenda.Text == "")
            {
                if(PrecoGrupo) //Preço por Grupo?
                    msgErro += "Por Favor Informe o Preço de Venda do Produto no Cadastro do Grupo " + tb_Grupo.Text + "!\n";
                else
                    msgErro += "Por Favor Informe o Preço de Venda do Produto!\n";

                erro = true;
            }
            
            if (erro) //Se deu erro
            {
                MessageBox.Show(msgErro, msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //Aba Dados 
                prod.ProdutoId = CodPro;

                prod.ProdutoNome = tb_descricao.Text;
                prod.ProdutoAtivo = !status;
                prod.ProCodUni = CodUni;
                prod.ProdutoTipo = tipoPro;
                prod.ProCodGrupo = CodGrupo;

                //Aba Preços
                prod.ProPrecoGrupo = PrecoGrupo;

                //Custo Compra
                if (tb_cusRep.Text != "")
                {
                    if (tb_cusRep.Text.Contains("R"))
                        tb_cusRep.Text = tb_cusRep.Text.Replace("R$", "");

                    prod.ProCustoCompra = Convert.ToDecimal(tb_cusRep.Text);
                }
                else
                    prod.ProCustoCompra = 0;

                //Custo Médio
                if (tb_cusMed.Text != "")
                {
                    if (tb_cusMed.Text.Contains("R"))
                        tb_cusMed.Text = tb_cusMed.Text.Replace("R$", "");

                    prod.ProCustoAtual = Convert.ToDecimal(tb_cusMed.Text);
                }
                else
                    prod.ProCustoAtual = 0;

                //Preço Venda
                if (tb_precoVenda.Text != "")
                {
                    if (tb_precoVenda.Text.Contains("R"))
                        tb_precoVenda.Text = tb_precoVenda.Text.Replace("R$", "");

                    prod.ProPrecoAtual = Convert.ToDecimal(tb_precoVenda.Text);
                }
                else
                    prod.ProPrecoAtual = 0;

                if (CodPro > 0) //Modificar
                    cadPro.Update(prod);
                else
                    cadPro.Add(prod);

                MessageBox.Show("Cadastro realizado com Sucesso!!!", "Doce Control",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas ao realizar o cadastro!!!\n\nMais Detalhes Abaixo\n" + ex.Message + "\nException: \n" + ex.InnerException,
                "Doce Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                
        #region ****************** Botões das Abas ******************
        private void bt_Abas_Click(object sender, EventArgs e)
        {
            Button iButton = (Button)sender;
            string btNome = iButton.Name;

            switch (btNome)
            {
                case "bt_AbaDados":
                    pnl_Dados.Visible = true;
                    pnl_Estoque.Visible = false;
                    pnl_Precos.Visible = false;

                    bt_AbaDados.BackColor = Color.FromArgb(68, 32, 117);
                    bt_abaEstoque.BackColor = Color.MediumPurple;
                    bt_abaValores.BackColor = Color.MediumPurple;

                    break;
                case "bt_abaEstoque":
                    pnl_Dados.Visible = false;
                    pnl_Estoque.Visible = true;
                    pnl_Precos.Visible = false;

                    bt_AbaDados.BackColor = Color.MediumPurple;
                    bt_abaEstoque.BackColor = Color.FromArgb(68, 32, 117);
                    bt_abaValores.BackColor = Color.MediumPurple;

                    break;
                case "bt_abaValores":
                    pnl_Dados.Visible = false;
                    pnl_Estoque.Visible = false;
                    pnl_Precos.Visible = true;

                    bt_AbaDados.BackColor = Color.MediumPurple;
                    bt_abaEstoque.BackColor = Color.MediumPurple;
                    bt_abaValores.BackColor = Color.FromArgb(68, 32, 117);

                    break;
            }
        }
        #endregion

        private void cb_PrecoGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_PrecoGrupo.SelectedIndex == 0) //SIM
            {
                tb_precoVenda.Text = PrecoGrupo.ToString();
                tb_precoVenda.Enabled = false;
            }
            else
                tb_precoVenda.Enabled = true;

            AjustaCampos();
        }
       
        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TempoMsg < 0)
            {
                lb_MsgInfo.Visible = false;
                Relogio.Enabled = false;
                TempoMsg = 5;
            }
            else
                TempoMsg--;

        }
    }
}
