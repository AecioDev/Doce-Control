using GS.API.Data.Repositorios;
using GS.API.Models;
using System;
using System.Windows.Forms;

namespace GS.WIN.Estoque
{
    public partial class CadUnidade : Form
    {
        UnidadesRep cadUni;
        private int CodUni = 0;

        public CadUnidade(int _coduni)
        {
            InitializeComponent();
            this.CodUni = _coduni;
        }

        private void CadUnidade_Load(object sender, EventArgs e)
        {
            if (CodUni > 0)
                Consulta();
        }

        private void Consulta()
        {
            cadUni = new UnidadesRep();

            var uni = cadUni.GetById(CodUni);

            tb_Nome.Text = uni.UnidadeNome;
            tb_sigUni.Text = uni.UnidadeSigla;

            cadUni.Dispose();
        }

        private void bt_Gravar_Click(object sender, EventArgs e)
        {            
            cadUni = new UnidadesRep();
            Unidades uni = new Unidades();

            //Verifica campos Obrigatórios
            if (tb_Nome.Text == "")
            {
                MessageBox.Show("É necessário informar a descrição da Unidade!!!", "Doce Control",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Nome.Focus();
                return;
            }

            if (tb_sigUni.Text == "")
            {
                MessageBox.Show("É necessário informar a Sigla da Unidade!!!", "Doce Control",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Nome.Focus();
                return;
            }

            try
            {
                uni.UnidadeId = CodUni;
                uni.UnidadeNome = tb_Nome.Text;
                uni.UnidadeSigla = tb_sigUni.Text;
                
                if (CodUni > 0)   //Modificar
                   cadUni.Update(uni);
                else
                   cadUni.Add(uni);

                MessageBox.Show("Cadastro realizado com Sucesso!!!", "Doce Control",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível gravar os dados, devido aos erros abaixo\n\n" + ex.Message + "\n Exception: \n" + ex.InnerException.Message,
                    "Doce Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
