namespace GS.WIN.Estoque
{
    partial class ListaProdutos
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
            System.Windows.Forms.Label staProdLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProdutos));
            this.grd_Dados = new System.Windows.Forms.DataGridView();
            this.col00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col03 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col04 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.cb_TipoPro = new System.Windows.Forms.ComboBox();
            this.cb_Grupo = new System.Windows.Forms.ComboBox();
            this.bt_Modificar = new System.Windows.Forms.Button();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Atualizar = new System.Windows.Forms.Button();
            this.bt_Selecionar = new System.Windows.Forms.Button();
            staProdLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Dados)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // staProdLabel
            // 
            staProdLabel.AutoSize = true;
            staProdLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            staProdLabel.ForeColor = System.Drawing.Color.Yellow;
            staProdLabel.Location = new System.Drawing.Point(428, 78);
            staProdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            staProdLabel.Name = "staProdLabel";
            staProdLabel.Size = new System.Drawing.Size(45, 15);
            staProdLabel.TabIndex = 207;
            staProdLabel.Text = "STATUS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Yellow;
            label5.Location = new System.Drawing.Point(428, 128);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(32, 15);
            label5.TabIndex = 207;
            label5.Text = "TIPO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Yellow;
            label6.Location = new System.Drawing.Point(27, 128);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(46, 15);
            label6.TabIndex = 207;
            label6.Text = "GRUPO";
            // 
            // grd_Dados
            // 
            this.grd_Dados.AllowUserToAddRows = false;
            this.grd_Dados.AllowUserToDeleteRows = false;
            this.grd_Dados.AllowUserToResizeRows = false;
            this.grd_Dados.BackgroundColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Dados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col00,
            this.col01,
            this.col02,
            this.col03,
            this.col04});
            this.grd_Dados.Location = new System.Drawing.Point(12, 185);
            this.grd_Dados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grd_Dados.Name = "grd_Dados";
            this.grd_Dados.ReadOnly = true;
            this.grd_Dados.RowHeadersVisible = false;
            this.grd_Dados.RowHeadersWidth = 30;
            this.grd_Dados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_Dados.Size = new System.Drawing.Size(532, 237);
            this.grd_Dados.TabIndex = 197;
            // 
            // col00
            // 
            this.col00.HeaderText = "CÓD";
            this.col00.Name = "col00";
            this.col00.ReadOnly = true;
            this.col00.Width = 50;
            // 
            // col01
            // 
            this.col01.HeaderText = "DESCRIÇÃO";
            this.col01.Name = "col01";
            this.col01.ReadOnly = true;
            this.col01.Width = 250;
            // 
            // col02
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col02.DefaultCellStyle = dataGridViewCellStyle2;
            this.col02.HeaderText = "UN";
            this.col02.Name = "col02";
            this.col02.ReadOnly = true;
            this.col02.Width = 50;
            // 
            // col03
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.col03.DefaultCellStyle = dataGridViewCellStyle3;
            this.col03.HeaderText = "TIPO";
            this.col03.Name = "col03";
            this.col03.ReadOnly = true;
            this.col03.Width = 80;
            // 
            // col04
            // 
            this.col04.HeaderText = "STATUS";
            this.col04.Name = "col04";
            this.col04.ReadOnly = true;
            this.col04.Width = 80;
            // 
            // cb_Status
            // 
            this.cb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO",
            "TODOS"});
            this.cb_Status.Location = new System.Drawing.Point(428, 96);
            this.cb_Status.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(93, 24);
            this.cb_Status.TabIndex = 204;
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_nome.Location = new System.Drawing.Point(30, 96);
            this.tb_nome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(390, 22);
            this.tb_nome.TabIndex = 199;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(29, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 206;
            this.label4.Text = "DESCRIÇÃO";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(76)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bt_Fechar);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 60);
            this.panel2.TabIndex = 218;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 44);
            this.label1.TabIndex = 149;
            this.label1.Text = "Lista Produtos";
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(76)))), ((int)(((byte)(255)))));
            this.bt_Fechar.FlatAppearance.BorderSize = 0;
            this.bt_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Fechar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Fechar.Image = global::GS.WIN.Properties.Resources.Fechar_Ylw_24x24;
            this.bt_Fechar.Location = new System.Drawing.Point(630, 8);
            this.bt_Fechar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(30, 30);
            this.bt_Fechar.TabIndex = 10;
            this.bt_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Fechar.UseVisualStyleBackColor = false;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // cb_TipoPro
            // 
            this.cb_TipoPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_TipoPro.FormattingEnabled = true;
            this.cb_TipoPro.Items.AddRange(new object[] {
            "Consumo",
            "Final",
            "Todos"});
            this.cb_TipoPro.Location = new System.Drawing.Point(428, 146);
            this.cb_TipoPro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_TipoPro.Name = "cb_TipoPro";
            this.cb_TipoPro.Size = new System.Drawing.Size(93, 24);
            this.cb_TipoPro.TabIndex = 204;
            // 
            // cb_Grupo
            // 
            this.cb_Grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_Grupo.FormattingEnabled = true;
            this.cb_Grupo.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO",
            "TODOS"});
            this.cb_Grupo.Location = new System.Drawing.Point(30, 146);
            this.cb_Grupo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_Grupo.Name = "cb_Grupo";
            this.cb_Grupo.Size = new System.Drawing.Size(294, 24);
            this.cb_Grupo.TabIndex = 204;
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
            this.bt_Modificar.Location = new System.Drawing.Point(549, 389);
            this.bt_Modificar.Name = "bt_Modificar";
            this.bt_Modificar.Size = new System.Drawing.Size(118, 33);
            this.bt_Modificar.TabIndex = 219;
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
            this.bt_Cadastrar.Location = new System.Drawing.Point(549, 350);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(118, 33);
            this.bt_Cadastrar.TabIndex = 220;
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
            this.bt_Atualizar.Location = new System.Drawing.Point(549, 224);
            this.bt_Atualizar.Name = "bt_Atualizar";
            this.bt_Atualizar.Size = new System.Drawing.Size(118, 33);
            this.bt_Atualizar.TabIndex = 221;
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
            this.bt_Selecionar.Location = new System.Drawing.Point(549, 185);
            this.bt_Selecionar.Name = "bt_Selecionar";
            this.bt_Selecionar.Size = new System.Drawing.Size(118, 33);
            this.bt_Selecionar.TabIndex = 222;
            this.bt_Selecionar.Text = "Selecionar";
            this.bt_Selecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Selecionar.UseVisualStyleBackColor = false;
            this.bt_Selecionar.Click += new System.EventHandler(this.bt_Selecionar_Click);
            // 
            // ListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(677, 435);
            this.Controls.Add(this.bt_Modificar);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.bt_Atualizar);
            this.Controls.Add(this.bt_Selecionar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grd_Dados);
            this.Controls.Add(this.cb_Grupo);
            this.Controls.Add(label6);
            this.Controls.Add(this.cb_TipoPro);
            this.Controls.Add(label5);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(staProdLabel);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ListaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsProduto";
            this.Load += new System.EventHandler(this.ConsProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Dados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grd_Dados;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.ComboBox cb_TipoPro;
        private System.Windows.Forms.ComboBox cb_Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col00;
        private System.Windows.Forms.DataGridViewTextBoxColumn col01;
        private System.Windows.Forms.DataGridViewTextBoxColumn col02;
        private System.Windows.Forms.DataGridViewTextBoxColumn col03;
        private System.Windows.Forms.DataGridViewTextBoxColumn col04;
        private System.Windows.Forms.Button bt_Modificar;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Atualizar;
        private System.Windows.Forms.Button bt_Selecionar;
    }
}