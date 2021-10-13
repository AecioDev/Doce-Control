using GS.API.Data.Repositorios;
using GS.API.Models;
using System;
using System.Windows.Forms;

namespace GS.WIN.Estoque
{
    public partial class CadGrupo : Form
    {
        private int CodGrupo = 0;
        private string msgCab = "Doce Control";
        GruposRep cadGrupo;

        public CadGrupo(int _codGrupo)
        {
            this.CodGrupo = _codGrupo;
            InitializeComponent();
        }

        private void CadGrupo_Load(object sender, EventArgs e)
        {            
            if (CodGrupo > 0)
                Consulta();
        }

        private void Consulta()
        {
            cadGrupo = new GruposRep();
            try
            {
                var grupos = cadGrupo.GetById(CodGrupo);

                if (grupos.GrupoId > 0)
                {
                    tb_Nome.Text = grupos.GrupoNome;
                    
                    if (grupos.GrupoPreco != null)
                    {
                        var valor = grupos.GrupoPreco;
                        tb_Preco.Text = valor.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Cadastro não Encontrado!!!", msgCab,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível gravar os dados, devido aos erros abaixo\n\n" + ex.Message + "\n Exception: \n" + ex.InnerException.Message,
                    msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                
        private void bt_Gravar_Click(object sender, EventArgs e)
        {
            cadGrupo = new GruposRep();
            Grupos grp = new Grupos();

            //Verifica campos Obrigatórios
            if (tb_Nome.Text == "")
            {
                MessageBox.Show("É necessário informar a Descrição do Grupo!!!", msgCab,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Nome.Focus();
                return;
            }

            try
            {
                grp.GrupoId = CodGrupo;
                grp.GrupoNome = tb_Nome.Text;

                if (!string.IsNullOrEmpty(tb_Preco.Text))
                {
                    var valor = tb_Preco.Text.Replace("R$", "");
                    grp.GrupoPreco = Convert.ToDecimal(valor);
                }

                if (CodGrupo > 0)   //Modificar
                    cadGrupo.Update(grp);
                else
                    cadGrupo.Add(grp);
                MessageBox.Show("Cadastro realizado com Sucesso!!!", msgCab,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas ao realizar o cadastro!!!\n\nMais Detalhes Abaixo\n" + ex.Message + "\nException: \n" + ex.InnerException,
                msgCab, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Preco_Leave(object sender, EventArgs e)
        {
            if (tb_Preco.Text != "")
            {
                if (tb_Preco.Text[0] == 'R')
                    tb_Preco.Text = tb_Preco.Text.Substring(2);

                tb_Preco.Text = Convert.ToDecimal(tb_Preco.Text).ToString("C");
            }
        }
    }
}
