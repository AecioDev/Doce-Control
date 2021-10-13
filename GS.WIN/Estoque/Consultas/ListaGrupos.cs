using GS.API.Data.Repositorios;
using GS.API.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GS.WIN.Estoque
{
    public partial class ListaGrupos : Form
    {
        private GruposRep dbDados;
        private int Tela = 0;
        private CadProduto CadPro;

        public ListaGrupos(CadProduto _cadPro)
        {
            InitializeComponent();
            this.CadPro = _cadPro;
            this.Tela = 0;
        }

        public ListaGrupos()
        {
            InitializeComponent();
        }

        private void ConsGrupo_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        #region Consultas
        private void Consulta()
        {
            int row = 0;
            dbDados = new GruposRep();

            var listaDados = dbDados.GetAll()
                .Where(g => g.GrupoNome.Contains(tb_nome.Text)).ToList();

            if (listaDados.Count > 0)
            {
                gridDados.Rows.Clear();
                foreach (Grupos dados in listaDados)
                {
                    //Adiciona o PDV na Grid   Codigo, Rua, Numero, Bairro, Cidade, UF                  
                    gridDados.Rows.Add();
                    gridDados.Rows[row].Cells[0].Value = dados.GrupoId;
                    gridDados.Rows[row].Cells[1].Value = dados.GrupoNome;
                    gridDados.Rows[row].Cells[2].Value = dados.GrupoPreco;

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
            string preco = "";

            if (gridDados.Rows.Count > 0)
            {
                id_linha = gridDados.CurrentRow.Index; //Pega o índice da linha selecionada            

                cod = gridDados.Rows[id_linha].Cells[0].Value.ToString(); //Pega o valor da linha e coluna selecionda
                desc = gridDados.Rows[id_linha].Cells[1].Value.ToString();
                preco = gridDados.Rows[id_linha].Cells[2].Value.ToString();

                switch (Tela)
                {
                    case 0: //Produto
                        CadPro.tb_Grupo.Text = desc;
                        CadPro.CodGrupo = (string.IsNullOrEmpty(cod)) ? 0 : Convert.ToInt32(cod);
                        CadPro.PrecoGrupo = (string.IsNullOrEmpty(preco)) ? 0 : Convert.ToDecimal(preco);
                        break;
                }

                this.Close();
            }
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadGrupo cadGrp = new CadGrupo(0);
            cadGrp.ShowDialog();
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
                CadGrupo cadGrp = new CadGrupo(codigo);
                cadGrp.ShowDialog();
                Consulta();
                this.Show();
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
