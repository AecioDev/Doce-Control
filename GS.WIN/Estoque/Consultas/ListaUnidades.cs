using GS.API.Data.Repositorios;
using GS.API.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GS.WIN.Estoque
{
    public partial class ListaUnidades : Form
    {
        private UnidadesRep dbDados;
        private int Tela = 0;
        private CadProduto CadPro;

        public ListaUnidades(CadProduto _cadPro)
        {
            InitializeComponent();
            this.CadPro = _cadPro;
            this.Tela = 0;
        }

        public ListaUnidades()
        {
            InitializeComponent();
        }

        private void ConsUnidade_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        #region Consultas
        private void Consulta()
        {
            int row = 0;
            dbDados = new UnidadesRep();

            var listaDados = dbDados.GetAll()
                .Where(g => g.UnidadeNome.Contains(tb_nome.Text)).ToList();

            if (listaDados.Count > 0)
            {
                gridDados.Rows.Clear();
                foreach (Unidades dados in listaDados)
                {
                    //Adiciona o PDV na Grid   Codigo, Rua, Numero, Bairro, Cidade, UF                  
                    gridDados.Rows.Add();
                    gridDados.Rows[row].Cells[0].Value = dados.UnidadeId;
                    gridDados.Rows[row].Cells[1].Value = dados.UnidadeNome;
                    gridDados.Rows[row].Cells[2].Value = dados.UnidadeSigla;

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

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }
        #endregion

        private void bt_Confirmar_Click(object sender, EventArgs e)
        {
            int id_linha = 0;
            string cod = "";
            string desc = "";
            string sigla = "";

            if (gridDados.Rows.Count > 0)
            {
                id_linha = gridDados.CurrentRow.Index; //Pega o índice da linha selecionada            

                cod = gridDados.Rows[id_linha].Cells[0].Value.ToString(); //Pega o valor da linha e coluna selecionda
                desc = gridDados.Rows[id_linha].Cells[1].Value.ToString();
                sigla = gridDados.Rows[id_linha].Cells[2].Value.ToString();

                switch (Tela)
                {                    
                    case 0: //Produto
                        CadPro.CodUni = Convert.ToInt32(cod);
                        CadPro.DescUni = desc;
                        CadPro.SiglaUni = sigla;
                        break;
                }

                this.Close();
            }
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadUnidade cadUni = new CadUnidade(0);
            cadUni.ShowDialog();
            Consulta();
            this.Show();
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            if (gridDados.Rows.Count > 0)
            {
                int ln = gridDados.CurrentRow.Index;
                int codigo = Convert.ToInt32(gridDados.Rows[ln].Cells[0].Value.ToString());

                this.Hide();
                CadUnidade cadUni = new CadUnidade(codigo);
                cadUni.ShowDialog();
                Consulta();
                this.Show();
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Animação Botões
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
