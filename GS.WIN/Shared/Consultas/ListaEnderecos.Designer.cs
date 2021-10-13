
namespace GS.WIN.Shared
{
    partial class ListaEnderecos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaEnderecos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NomeOrigem = new System.Windows.Forms.TextBox();
            this.lb_Origem = new System.Windows.Forms.Label();
            this.gridDados = new System.Windows.Forms.DataGridView();
            this.col00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col03 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col04 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col05 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_CodOrigem = new System.Windows.Forms.TextBox();
            this.bt_Modificar = new System.Windows.Forms.Button();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Atualizar = new System.Windows.Forms.Button();
            this.bt_Selecionar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(662, 64);
            this.panel1.TabIndex = 12;
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Fechar.FlatAppearance.BorderSize = 0;
            this.bt_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Fechar.Image = global::GS.WIN.Properties.Resources.Fechar_Ylw_24x24;
            this.bt_Fechar.Location = new System.Drawing.Point(619, 3);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(40, 33);
            this.bt_Fechar.TabIndex = 1;
            this.bt_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Fechar.UseVisualStyleBackColor = true;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista Enderecos";
            // 
            // tb_NomeOrigem
            // 
            this.tb_NomeOrigem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_NomeOrigem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_NomeOrigem.Location = new System.Drawing.Point(106, 98);
            this.tb_NomeOrigem.Name = "tb_NomeOrigem";
            this.tb_NomeOrigem.ReadOnly = true;
            this.tb_NomeOrigem.Size = new System.Drawing.Size(433, 22);
            this.tb_NomeOrigem.TabIndex = 13;
            // 
            // lb_Origem
            // 
            this.lb_Origem.AutoSize = true;
            this.lb_Origem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Origem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lb_Origem.Location = new System.Drawing.Point(18, 80);
            this.lb_Origem.Name = "lb_Origem";
            this.lb_Origem.Size = new System.Drawing.Size(82, 15);
            this.lb_Origem.TabIndex = 14;
            this.lb_Origem.Text = "FORNECEDOR";
            // 
            // gridDados
            // 
            this.gridDados.AllowUserToAddRows = false;
            this.gridDados.AllowUserToDeleteRows = false;
            this.gridDados.BackgroundColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col00,
            this.col01,
            this.col02,
            this.col03,
            this.col04,
            this.col05});
            this.gridDados.Location = new System.Drawing.Point(18, 131);
            this.gridDados.Name = "gridDados";
            this.gridDados.ReadOnly = true;
            this.gridDados.RowHeadersVisible = false;
            this.gridDados.RowTemplate.Height = 25;
            this.gridDados.Size = new System.Drawing.Size(521, 207);
            this.gridDados.TabIndex = 17;
            // 
            // col00
            // 
            this.col00.HeaderText = "CÓDIGO";
            this.col00.Name = "col00";
            this.col00.ReadOnly = true;
            this.col00.Width = 60;
            // 
            // col01
            // 
            this.col01.HeaderText = "LOGRADOURO";
            this.col01.Name = "col01";
            this.col01.ReadOnly = true;
            this.col01.Width = 250;
            // 
            // col02
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col02.DefaultCellStyle = dataGridViewCellStyle2;
            this.col02.HeaderText = "NÚMERO";
            this.col02.Name = "col02";
            this.col02.ReadOnly = true;
            this.col02.Width = 70;
            // 
            // col03
            // 
            this.col03.HeaderText = "BAIRRO";
            this.col03.Name = "col03";
            this.col03.ReadOnly = true;
            this.col03.Width = 250;
            // 
            // col04
            // 
            dataGridViewCellStyle3.Format = "C";
            this.col04.DefaultCellStyle = dataGridViewCellStyle3;
            this.col04.HeaderText = "CIDADE";
            this.col04.Name = "col04";
            this.col04.ReadOnly = true;
            this.col04.Width = 150;
            // 
            // col05
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col05.DefaultCellStyle = dataGridViewCellStyle4;
            this.col05.HeaderText = "UF";
            this.col05.Name = "col05";
            this.col05.ReadOnly = true;
            this.col05.Width = 30;
            // 
            // tb_CodOrigem
            // 
            this.tb_CodOrigem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CodOrigem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_CodOrigem.Location = new System.Drawing.Point(18, 98);
            this.tb_CodOrigem.Name = "tb_CodOrigem";
            this.tb_CodOrigem.ReadOnly = true;
            this.tb_CodOrigem.Size = new System.Drawing.Size(82, 22);
            this.tb_CodOrigem.TabIndex = 13;
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
            this.bt_Modificar.Location = new System.Drawing.Point(545, 305);
            this.bt_Modificar.Name = "bt_Modificar";
            this.bt_Modificar.Size = new System.Drawing.Size(118, 33);
            this.bt_Modificar.TabIndex = 193;
            this.bt_Modificar.Text = "Modificar";
            this.bt_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Modificar.UseVisualStyleBackColor = true;
            this.bt_Modificar.Click += new System.EventHandler(this.bt_Modificar_Click);
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
            this.bt_Cadastrar.Location = new System.Drawing.Point(545, 266);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(118, 33);
            this.bt_Cadastrar.TabIndex = 194;
            this.bt_Cadastrar.Text = "Cadastrar";
            this.bt_Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Cadastrar.UseVisualStyleBackColor = true;
            this.bt_Cadastrar.Click += new System.EventHandler(this.bt_Cadastrar_Click);
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
            this.bt_Atualizar.Location = new System.Drawing.Point(545, 170);
            this.bt_Atualizar.Name = "bt_Atualizar";
            this.bt_Atualizar.Size = new System.Drawing.Size(118, 33);
            this.bt_Atualizar.TabIndex = 195;
            this.bt_Atualizar.Text = "Atualizar";
            this.bt_Atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Atualizar.UseVisualStyleBackColor = true;
            this.bt_Atualizar.Click += new System.EventHandler(this.bt_Atualizar_Click);
            // 
            // bt_Selecionar
            // 
            this.bt_Selecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Selecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(146)))));
            this.bt_Selecionar.FlatAppearance.BorderSize = 0;
            this.bt_Selecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Selecionar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Selecionar.ForeColor = System.Drawing.Color.Yellow;
            this.bt_Selecionar.Image = global::GS.WIN.Properties.Resources.BDConfirm32px;
            this.bt_Selecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Selecionar.Location = new System.Drawing.Point(545, 131);
            this.bt_Selecionar.Name = "bt_Selecionar";
            this.bt_Selecionar.Size = new System.Drawing.Size(118, 33);
            this.bt_Selecionar.TabIndex = 196;
            this.bt_Selecionar.Text = "Selecionar";
            this.bt_Selecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Selecionar.UseVisualStyleBackColor = false;
            this.bt_Selecionar.Click += new System.EventHandler(this.bt_Confirmar_Click);
            // 
            // ListaEnderecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(670, 350);
            this.Controls.Add(this.bt_Modificar);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.bt_Atualizar);
            this.Controls.Add(this.bt_Selecionar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridDados);
            this.Controls.Add(this.tb_CodOrigem);
            this.Controls.Add(this.tb_NomeOrigem);
            this.Controls.Add(this.lb_Origem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaEnderecos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Clientes";
            this.Load += new System.EventHandler(this.ListaClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NomeOrigem;
        private System.Windows.Forms.Label lb_Origem;
        private System.Windows.Forms.DataGridView gridDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn col00;
        private System.Windows.Forms.DataGridViewTextBoxColumn col01;
        private System.Windows.Forms.DataGridViewTextBoxColumn col02;
        private System.Windows.Forms.DataGridViewTextBoxColumn col03;
        private System.Windows.Forms.DataGridViewTextBoxColumn col04;
        private System.Windows.Forms.DataGridViewTextBoxColumn col05;
        private System.Windows.Forms.TextBox tb_CodOrigem;
        private System.Windows.Forms.Button bt_Modificar;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Atualizar;
        private System.Windows.Forms.Button bt_Selecionar;
    }
}