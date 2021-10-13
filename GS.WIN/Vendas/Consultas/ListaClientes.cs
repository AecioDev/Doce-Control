using GS.API.Data.Repositorios;
using GS.API.Models;
using System;
using System.Windows.Forms;

namespace GS.WIN.Vendas
{
    public partial class ListaClientes : Form
    {
        private ClienteRep dbCliente;
        public ListaClientes()
        {
            InitializeComponent();
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {     
            Consulta();
        }

#region Consultas
        private void Consulta()
        {
            int row = 0;
            dbCliente = new ClienteRep();

            var listaClientes = dbCliente.ConsultaClientes(tb_ClienteCell.Text, tb_ClienteNome.Text);
            
            if (listaClientes.Count > 0)
            {
                gridClientes.Rows.Clear();
                foreach (Clientes cli in listaClientes)
                {
                    //Adiciona o PDV na Grid   Codigo, nome, celular, status compras                  
                    gridClientes.Rows.Add();
                    gridClientes.Rows[row].Cells[0].Value = cli.ClienteId;
                    gridClientes.Rows[row].Cells[1].Value = cli.ClienteNome;
                    gridClientes.Rows[row].Cells[2].Value = cli.ClienteCelular;

                    switch (cli.ClienteStatus)
                    {
                        case true:
                            gridClientes.Rows[row].Cells[3].Value = "Ativo";
                            break;
                        case false:
                            gridClientes.Rows[row].Cells[3].Value = "Inativo";
                            break;
                    }

                    gridClientes.Rows[row].Cells[4].Value = cli.ClienteTotalCompras;
                    //var totCompras = (string.IsNullOrEmpty(cli.ClienteTotalCompras))

                    row++;
                }
            }
            else
            {
                gridClientes.Rows.Clear();
            }                       
        }

        private void bt_Atualizar_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        private void tb_ClienteCell_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }

        private void tb_ClienteNome_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }
#endregion

        private void bt_Confirmar_Click(object sender, EventArgs e)
        {

        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadClientes cli = new CadClientes(0);
            cli.ShowDialog();
            this.Show();
            Consulta();
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            if (gridClientes.Rows.Count > 0)
            {
                int ln = gridClientes.CurrentRow.Index;
                int codigo = Convert.ToInt32(gridClientes.Rows[ln].Cells[0].Value.ToString());

                this.Hide();
                CadClientes cli = new CadClientes(codigo);
                cli.ShowDialog();
                this.Show();
                Consulta();
            }
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
