
namespace GS.WIN.Vendas
{
    partial class ListaClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ClienteNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ClienteCell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.codCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CelCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totCompras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Selecionar = new System.Windows.Forms.Button();
            this.bt_Atualizar = new System.Windows.Forms.Button();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Modificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(76)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.bt_Fechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 60);
            this.panel1.TabIndex = 12;
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Fechar.FlatAppearance.BorderSize = 0;
            this.bt_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Fechar.Image = global::GS.WIN.Properties.Resources.Fechar_Ylw_24x24;
            this.bt_Fechar.Location = new System.Drawing.Point(621, 8);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(30, 30);
            this.bt_Fechar.TabIndex = 1;
            this.bt_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Fechar.UseVisualStyleBackColor = true;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista Clientes";
            // 
            // tb_ClienteNome
            // 
            this.tb_ClienteNome.Location = new System.Drawing.Point(12, 97);
            this.tb_ClienteNome.Name = "tb_ClienteNome";
            this.tb_ClienteNome.Size = new System.Drawing.Size(370, 23);
            this.tb_ClienteNome.TabIndex = 13;
            this.tb_ClienteNome.TextChanged += new System.EventHandler(this.tb_ClienteNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "NOME";
            // 
            // tb_ClienteCell
            // 
            this.tb_ClienteCell.Location = new System.Drawing.Point(388, 97);
            this.tb_ClienteCell.Name = "tb_ClienteCell";
            this.tb_ClienteCell.Size = new System.Drawing.Size(145, 23);
            this.tb_ClienteCell.TabIndex = 16;
            this.tb_ClienteCell.TextChanged += new System.EventHandler(this.tb_ClienteCell_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(388, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "CELULAR";
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.BackgroundColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCli,
            this.nomeCli,
            this.CelCli,
            this.statusCli,
            this.totCompras});
            this.gridClientes.Location = new System.Drawing.Point(12, 134);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.RowHeadersVisible = false;
            this.gridClientes.RowTemplate.Height = 25;
            this.gridClientes.Size = new System.Drawing.Size(521, 245);
            this.gridClientes.TabIndex = 17;
            // 
            // codCli
            // 
            this.codCli.HeaderText = "CÓDIGO";
            this.codCli.Name = "codCli";
            this.codCli.ReadOnly = true;
            this.codCli.Width = 80;
            // 
            // nomeCli
            // 
            this.nomeCli.HeaderText = "NOME";
            this.nomeCli.Name = "nomeCli";
            this.nomeCli.ReadOnly = true;
            this.nomeCli.Width = 200;
            // 
            // CelCli
            // 
            this.CelCli.HeaderText = "CELULAR";
            this.CelCli.Name = "CelCli";
            this.CelCli.ReadOnly = true;
            // 
            // statusCli
            // 
            this.statusCli.HeaderText = "STATUS";
            this.statusCli.Name = "statusCli";
            this.statusCli.ReadOnly = true;
            this.statusCli.Width = 60;
            // 
            // totCompras
            // 
            dataGridViewCellStyle2.Format = "C";
            this.totCompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.totCompras.HeaderText = "COMPRAS R$";
            this.totCompras.Name = "totCompras";
            this.totCompras.ReadOnly = true;
            this.totCompras.Width = 150;
            // 
            // bt_Selecionar
            // 
            this.bt_Selecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Selecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(146)))));
            this.bt_Selecionar.FlatAppearance.BorderSize = 0;
            this.bt_Selecionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(201)))));
            this.bt_Selecionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(201)))));
            this.bt_Selecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Selecionar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Selecionar.ForeColor = System.Drawing.Color.Yellow;
            this.bt_Selecionar.Image = global::GS.WIN.Properties.Resources.BDConfirm32px;
            this.bt_Selecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Selecionar.Location = new System.Drawing.Point(537, 134);
            this.bt_Selecionar.Name = "bt_Selecionar";
            this.bt_Selecionar.Size = new System.Drawing.Size(118, 33);
            this.bt_Selecionar.TabIndex = 18;
            this.bt_Selecionar.Text = "Selecionar";
            this.bt_Selecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Selecionar.UseVisualStyleBackColor = false;
            this.bt_Selecionar.Click += new System.EventHandler(this.bt_Confirmar_Click);
            // 
            // bt_Atualizar
            // 
            this.bt_Atualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Atualizar.FlatAppearance.BorderSize = 0;
            this.bt_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Atualizar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Atualizar.ForeColor = System.Drawing.Color.Yellow;
            this.bt_Atualizar.Image = global::GS.WIN.Properties.Resources.BDRefresh32px1;
            this.bt_Atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Atualizar.Location = new System.Drawing.Point(537, 173);
            this.bt_Atualizar.Name = "bt_Atualizar";
            this.bt_Atualizar.Size = new System.Drawing.Size(118, 33);
            this.bt_Atualizar.TabIndex = 18;
            this.bt_Atualizar.Text = "Atualizar";
            this.bt_Atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Atualizar.UseVisualStyleBackColor = true;
            this.bt_Atualizar.Click += new System.EventHandler(this.bt_Atualizar_Click);
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Cadastrar.FlatAppearance.BorderSize = 0;
            this.bt_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cadastrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Cadastrar.ForeColor = System.Drawing.Color.Yellow;
            this.bt_Cadastrar.Image = global::GS.WIN.Properties.Resources.BDCadastrar32px;
            this.bt_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Cadastrar.Location = new System.Drawing.Point(537, 307);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(118, 33);
            this.bt_Cadastrar.TabIndex = 18;
            this.bt_Cadastrar.Text = "Cadastrar";
            this.bt_Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Cadastrar.UseVisualStyleBackColor = true;
            this.bt_Cadastrar.Click += new System.EventHandler(this.bt_Cadastrar_Click);
            // 
            // bt_Modificar
            // 
            this.bt_Modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Modificar.FlatAppearance.BorderSize = 0;
            this.bt_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Modificar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Modificar.ForeColor = System.Drawing.Color.Yellow;
            this.bt_Modificar.Image = global::GS.WIN.Properties.Resources.BDEdit32px;
            this.bt_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Modificar.Location = new System.Drawing.Point(537, 346);
            this.bt_Modificar.Name = "bt_Modificar";
            this.bt_Modificar.Size = new System.Drawing.Size(118, 33);
            this.bt_Modificar.TabIndex = 18;
            this.bt_Modificar.Text = "Modificar";
            this.bt_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Modificar.UseVisualStyleBackColor = true;
            this.bt_Modificar.Click += new System.EventHandler(this.bt_Modificar_Click);
            // 
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(667, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Modificar);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.bt_Atualizar);
            this.Controls.Add(this.bt_Selecionar);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.tb_ClienteNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_ClienteCell);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Clientes";
            this.Load += new System.EventHandler(this.ListaClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ClienteNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ClienteCell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn CelCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn totCompras;
        private System.Windows.Forms.Button bt_Selecionar;
        private System.Windows.Forms.Button bt_Atualizar;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Modificar;
    }
}