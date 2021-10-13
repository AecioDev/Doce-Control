using GS.API.Data.Repositorios;
using GS.API.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace GS.WIN.Compras
{
    public partial class ListaFornecedores : Form
    {
        public ListaFornecedores()
        {
            InitializeComponent();
        }

        private void ConsFornecedor_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        #region Consultas
        private void Consulta()
        {
            int row = 0;
            FornecedoresRep consFor = new FornecedoresRep();
            
            var fornecedor = consFor.ConsultaFor(tb_Doc.Text, tb_nome.Text);

            if (fornecedor.Count > 0)
            {
                grd_Dados.Rows.Clear();
                foreach (Fornecedores forn in fornecedor)
                {
                    //Adiciona o PDV na Grid                   
                    grd_Dados.Rows.Add();
                    grd_Dados.Rows[row].Cells[0].Value = forn.FornecedorId;
                    
                    if (forn.FornecedorCNPJ.Length > 0)
                    {
                        grd_Dados.Rows[row].Cells[1].Value = forn.FornecedorCNPJ;                                            }

                    if (forn.FornecedorCPF.Length > 0)
                    {
                        grd_Dados.Rows[row].Cells[1].Value = forn.FornecedorCPF;
                    }

                    grd_Dados.Rows[row].Cells[2].Value = forn.FornecedorNome;

                    grd_Dados.Rows[row].Cells[3].Value = forn.FornecedorTel1;
                    grd_Dados.Rows[row].Cells[4].Value = forn.FornecedorTel2;
                    grd_Dados.Rows[row].Cells[5].Value = forn.FornecedorContato;

                    row++;
                }
            }
            else
            {
                grd_Dados.Rows.Clear();
            }

            consFor.Dispose();
        }

        private void bt_Atualizar_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        private void tb_Doc_TextChanged(object sender, EventArgs e)
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

        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadFornecedor cadFor = new CadFornecedor(0);
            cadFor.ShowDialog();
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
                CadFornecedor cadFor = new CadFornecedor(codigo);
                cadFor.ShowDialog();
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
