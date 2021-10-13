using GS.API.Data.Repositorios;
using GS.API.Models;
using System;
using System.Windows.Forms;

namespace GS.WIN.Estoque
{
    public partial class ListaProdutos : Form
    {
        
        ProdutosRep consProd;

        public ListaProdutos()
        {
            InitializeComponent();
        }

        private void ConsProduto_Load(object sender, EventArgs e)
        {
            cb_Status.SelectedIndex = 2;
            Consulta();
        }

        #region Consultas
        private void Consulta()
        {
            int row = 0;
            int codgrupo = 0;
            consProd = new ProdutosRep();

            codgrupo = Convert.ToInt32(cb_Grupo.SelectedValue);

            var produtos = consProd.ListaProdutos(tb_nome.Text, cb_TipoPro.SelectedIndex, codgrupo, cb_Status.SelectedIndex);
            if (produtos.Count > 0)
            {
                grd_Dados.Rows.Clear();
                foreach (Produtos prod in produtos)
                {
                    //Adiciona na Grid
                    grd_Dados.Rows.Add();
                    grd_Dados.Rows[row].Cells[0].Value = prod.ProdutoId;
                    grd_Dados.Rows[row].Cells[1].Value = prod.ProdutoNome;
                    grd_Dados.Rows[row].Cells[2].Value = prod.Unidade.UnidadeSigla;
                                        
                    switch (prod.ProdutoTipo)
                    {
                        case "C":   //Consumo
                            grd_Dados.Rows[row].Cells[3].Value = "Consumo";
                            break;
                        case "F":   //Final
                            grd_Dados.Rows[row].Cells[3].Value = "Final";
                            break;
                    }

                    switch (prod.ProdutoAtivo)
                    {
                        case true:
                            grd_Dados.Rows[row].Cells[4].Value = "Ativo";
                            break;
                        case false:
                            grd_Dados.Rows[row].Cells[4].Value = "Inativo";
                            break;
                    }

                    row++;
                }
            }
            else
            {
                grd_Dados.Rows.Clear();
            }

            consProd.Dispose();
                        
        }

        private void bt_Atualizar_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        private void tb_refPro_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }
        #endregion

        private void bt_Selecionar_Click(object sender, EventArgs e)
        {

        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadProduto cadPro = new CadProduto(0);
            cadPro.ShowDialog();
            Consulta();
            this.Show();
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            if (grd_Dados.Rows.Count > 0)
            {
                int ln = grd_Dados.CurrentRow.Index;
                int codigo = Convert.ToInt32(grd_Dados.Rows[ln].Cells[0].Value.ToString());

                this.Hide();
                CadProduto cadPro = new CadProduto(codigo);
                cadPro.ShowDialog();
                Consulta();
                this.Show();
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region ****************** Animação Botões ******************
        private void bt_Enter(object sender, EventArgs e)
        {
            Button iButton = (Button)sender;
            string btNome = iButton.Name;

            switch (btNome)
            {
                case "bt_Confirmar":
                    bt_Selecionar.Size = new System.Drawing.Size(108, 47);
                    break;
                case "bt_Cadastrar":
                    bt_Cadastrar.Size = new System.Drawing.Size(108, 47);
                    break;
                case "bt_Modificar":
                    bt_Modificar.Size = new System.Drawing.Size(108, 47);
                    break;
                case "bt_Atualizar":
                    bt_Atualizar.Size = new System.Drawing.Size(108, 47);
                    break;
            }
        }

        private void bt_Leave(object sender, EventArgs e)
        {
            Button iButton = (Button)sender;
            string btNome = iButton.Name;

            switch (btNome)
            {
                case "bt_Confirmar":
                    bt_Selecionar.Size = new System.Drawing.Size(105, 44);
                    break;
                case "bt_Cadastrar":
                    bt_Cadastrar.Size = new System.Drawing.Size(105, 44);
                    break;
                case "bt_Modificar":
                    bt_Modificar.Size = new System.Drawing.Size(105, 44);
                    break;
                case "bt_Atualizar":
                    bt_Atualizar.Size = new System.Drawing.Size(105, 44);
                    break;
            }
        }




        #endregion        
    }
}
