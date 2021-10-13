using GS.WIN.Compras;
using GS.WIN.Estoque;
using GS.WIN.Vendas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GS.WIN.Shared
{
    public partial class Home : Form
    {
        private bool mostrarMenu = false;
        private Color btAtivo = Color.FromArgb(68, 32, 117);
        private Color btNormal = Color.FromArgb(65, 39, 145);
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //Ajusta o Local das Panels
            pnl_Vendas.Location = new Point(182, 86);
            pnl_Estoque.Location = new Point(182, 86);
            pnl_Compras.Location = new Point(182, 86);
            pnl_Financeiro.Location = new Point(182, 86);
            
        }

        #region **************** Botões de Compras ****************
        private void bt_Fornecedores_Click(object sender, EventArgs e)
        {
            EsconderMenu();
            ListaFornecedores forn = new ListaFornecedores();
            forn.ShowDialog();
        }

        #endregion

        #region **************** Botões de Vendas ****************
        private void bt_Clientes_Click(object sender, EventArgs e)
        {
            EsconderMenu();
            ListaClientes cli = new ListaClientes();
            cli.ShowDialog();
        }

        #endregion

        #region **************** Botões de Estoque ****************
        private void bt_Produtos_Click(object sender, EventArgs e)
        {
            EsconderMenu();
            ListaProdutos pro = new ListaProdutos();
            pro.ShowDialog();
        }

        private void bt_Grupos_Click(object sender, EventArgs e)
        {
            EsconderMenu();
            ListaGrupos grupos = new ListaGrupos();
            grupos.ShowDialog();
        }

        private void bt_Unidades_Click(object sender, EventArgs e)
        {
            EsconderMenu();
            ListaUnidades unidade = new ListaUnidades();
            unidade.ShowDialog();
        }

        #endregion

        #region ****************** Botões das Abas ******************
        private void bt_Menu_Click(object sender, EventArgs e)
        {
            Button iButton = (Button)sender;
            string btNome = iButton.Name;
            mostrarMenu = !mostrarMenu;

            pnl_Vendas.Visible = false;
            pnl_Estoque.Visible = false;
            pnl_Compras.Visible = false;
            pnl_Financeiro.Visible = false;

            MostraMenu(btNome);
        }

        private void MostraMenu(string botao)
        {
            switch (botao)
            {
                case "bt_Vendas":
                    
                    pnl_Vendas.Visible = mostrarMenu;

                    bt_Vendas.BackColor = btAtivo;
                    bt_Estoque.BackColor = btNormal;
                    bt_Compras.BackColor = btNormal;
                    bt_Financeiro.BackColor = btNormal;

                    break;

                case "bt_Estoque":

                    pnl_Estoque.Visible = mostrarMenu;

                    bt_Vendas.BackColor = btNormal;
                    bt_Estoque.BackColor = btAtivo;
                    bt_Compras.BackColor = btNormal;
                    bt_Financeiro.BackColor = btNormal;

                    break;

                case "bt_Compras":

                    pnl_Compras.Visible = mostrarMenu;

                    bt_Vendas.BackColor = btNormal;
                    bt_Estoque.BackColor = btNormal;
                    bt_Compras.BackColor = btAtivo;
                    bt_Financeiro.BackColor = btNormal;

                    break;

                case "bt_Financeiro":
                                        
                    pnl_Financeiro.Visible = mostrarMenu;

                    bt_Vendas.BackColor = btNormal;
                    bt_Estoque.BackColor = btNormal;
                    bt_Compras.BackColor = btNormal;
                    bt_Financeiro.BackColor = btAtivo;

                    break;
            }            
        }
        
        private void bt_Compras_MouseEnter(object sender, EventArgs e)
        {
            pnl_Compras.Visible = true;

            pnl_Vendas.Visible = false;
            pnl_Estoque.Visible = false;
            pnl_Financeiro.Visible = false;

            bt_Compras.BackColor = btAtivo;

            bt_Estoque.BackColor = btNormal;
            bt_Vendas.BackColor = btNormal;
            bt_Financeiro.BackColor = btNormal;

            mostrarMenu = true;
        }

        private void bt_Vendas_MouseEnter(object sender, EventArgs e)
        {
            pnl_Vendas.Visible = true;

            pnl_Compras.Visible = false;
            pnl_Estoque.Visible = false;
            pnl_Financeiro.Visible = false;

            bt_Vendas.BackColor = btAtivo;

            bt_Estoque.BackColor = btNormal;
            bt_Compras.BackColor = btNormal;
            bt_Financeiro.BackColor = btNormal;

            mostrarMenu = true;
        }

        private void bt_Estoque_MouseEnter(object sender, EventArgs e)
        {
            pnl_Estoque.Visible = true;

            pnl_Vendas.Visible = false;
            pnl_Compras.Visible = false;
            pnl_Financeiro.Visible = false;

            bt_Estoque.BackColor = btAtivo;

            bt_Vendas.BackColor = btNormal;
            bt_Compras.BackColor = btNormal;
            bt_Financeiro.BackColor = btNormal;

            mostrarMenu = true;
        }

        private void bt_Financeiro_MouseEnter(object sender, EventArgs e)
        {
            pnl_Financeiro.Visible = true;

            pnl_Vendas.Visible = false;
            pnl_Estoque.Visible = false;
            pnl_Compras.Visible = false;

            bt_Financeiro.BackColor = btAtivo;

            bt_Estoque.BackColor = btNormal;
            bt_Compras.BackColor = btNormal;
            bt_Vendas.BackColor = btNormal;


            mostrarMenu = true;
        }

        private void Home_MouseEnter(object sender, EventArgs e)
        {
            EsconderMenu();
        }

        private void EsconderMenu()
        {
            pnl_Vendas.Visible = false;
            pnl_Estoque.Visible = false;
            pnl_Compras.Visible = false;
            pnl_Financeiro.Visible = false;

            bt_Vendas.BackColor = btNormal;
            bt_Estoque.BackColor = btNormal;
            bt_Compras.BackColor = btNormal;
            bt_Financeiro.BackColor = btNormal;
        }


        #endregion

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
