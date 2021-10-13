namespace GS.WIN.Estoque
{
    partial class CadProduto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label staProdLabel;
            System.Windows.Forms.Label codGrupoLabel;
            System.Windows.Forms.Label valUltCmpLabel;
            System.Windows.Forms.Label precoVendaLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.lb_descricao = new System.Windows.Forms.Label();
            this.tb_Grupo = new System.Windows.Forms.TextBox();
            this.bt_Grupo = new System.Windows.Forms.Button();
            this.lb_unidade = new System.Windows.Forms.Label();
            this.tb_SiglaUni = new System.Windows.Forms.TextBox();
            this.bt_Uni = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_PrecoGrupo = new System.Windows.Forms.ComboBox();
            this.tb_precoVenda = new System.Windows.Forms.TextBox();
            this.tb_cusMed = new System.Windows.Forms.TextBox();
            this.tb_cusRep = new System.Windows.Forms.TextBox();
            this.produtoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoProIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desTabPreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descProgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valAntProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPrecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Status = new System.Windows.Forms.Button();
            this.cb_TipoPro = new System.Windows.Forms.ComboBox();
            this.tb_DescUni = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grid_Estoque = new System.Windows.Forms.DataGridView();
            this.codloc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Dados = new System.Windows.Forms.Panel();
            this.tb_codGrupo = new System.Windows.Forms.TextBox();
            this.tb_codUni = new System.Windows.Forms.TextBox();
            this.bt_AbaDados = new System.Windows.Forms.Button();
            this.bt_abaEstoque = new System.Windows.Forms.Button();
            this.pnl_Estoque = new System.Windows.Forms.Panel();
            this.pnl_Precos = new System.Windows.Forms.Panel();
            this.bt_abaValores = new System.Windows.Forms.Button();
            this.bt_Gravar = new System.Windows.Forms.Button();
            this.lb_MsgInfo = new System.Windows.Forms.Label();
            this.tb_CodProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Relogio = new System.Windows.Forms.Timer(this.components);
            staProdLabel = new System.Windows.Forms.Label();
            codGrupoLabel = new System.Windows.Forms.Label();
            valUltCmpLabel = new System.Windows.Forms.Label();
            precoVendaLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Estoque)).BeginInit();
            this.pnl_Dados.SuspendLayout();
            this.pnl_Estoque.SuspendLayout();
            this.pnl_Precos.SuspendLayout();
            this.SuspendLayout();
            // 
            // staProdLabel
            // 
            staProdLabel.AutoSize = true;
            staProdLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            staProdLabel.ForeColor = System.Drawing.Color.Yellow;
            staProdLabel.Location = new System.Drawing.Point(391, 28);
            staProdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            staProdLabel.Name = "staProdLabel";
            staProdLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            staProdLabel.Size = new System.Drawing.Size(45, 15);
            staProdLabel.TabIndex = 39;
            staProdLabel.Text = "STATUS";
            // 
            // codGrupoLabel
            // 
            codGrupoLabel.AutoSize = true;
            codGrupoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            codGrupoLabel.ForeColor = System.Drawing.Color.Yellow;
            codGrupoLabel.Location = new System.Drawing.Point(33, 138);
            codGrupoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codGrupoLabel.Name = "codGrupoLabel";
            codGrupoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            codGrupoLabel.Size = new System.Drawing.Size(46, 15);
            codGrupoLabel.TabIndex = 48;
            codGrupoLabel.Text = "GRUPO";
            // 
            // valUltCmpLabel
            // 
            valUltCmpLabel.AutoSize = true;
            valUltCmpLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            valUltCmpLabel.ForeColor = System.Drawing.Color.Yellow;
            valUltCmpLabel.Location = new System.Drawing.Point(25, 42);
            valUltCmpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valUltCmpLabel.Name = "valUltCmpLabel";
            valUltCmpLabel.Size = new System.Drawing.Size(96, 15);
            valUltCmpLabel.TabIndex = 37;
            valUltCmpLabel.Text = "CUSTO COMPRA";
            // 
            // precoVendaLabel
            // 
            precoVendaLabel.AutoSize = true;
            precoVendaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            precoVendaLabel.ForeColor = System.Drawing.Color.Yellow;
            precoVendaLabel.Location = new System.Drawing.Point(231, 111);
            precoVendaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            precoVendaLabel.Name = "precoVendaLabel";
            precoVendaLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            precoVendaLabel.Size = new System.Drawing.Size(102, 15);
            precoVendaLabel.TabIndex = 47;
            precoVendaLabel.Text = "PREÇO DE VENDA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Yellow;
            label5.Location = new System.Drawing.Point(231, 43);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(83, 15);
            label5.TabIndex = 37;
            label5.Text = "CUSTO MÉDIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Yellow;
            label1.Location = new System.Drawing.Point(344, 79);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label1.Size = new System.Drawing.Size(32, 15);
            label1.TabIndex = 39;
            label1.Text = "TIPO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Yellow;
            label2.Location = new System.Drawing.Point(25, 111);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label2.Size = new System.Drawing.Size(106, 15);
            label2.TabIndex = 48;
            label2.Text = "PREÇO P/ GRUPO?";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(76)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bt_Fechar);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 60);
            this.panel1.TabIndex = 416;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(4, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 44);
            this.label8.TabIndex = 149;
            this.label8.Text = "Produtos";
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(76)))), ((int)(((byte)(255)))));
            this.bt_Fechar.FlatAppearance.BorderSize = 0;
            this.bt_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Fechar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Fechar.Image = global::GS.WIN.Properties.Resources.Fechar_Ylw_24x24;
            this.bt_Fechar.Location = new System.Drawing.Point(510, 5);
            this.bt_Fechar.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(30, 30);
            this.bt_Fechar.TabIndex = 148;
            this.bt_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Fechar.UseVisualStyleBackColor = false;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // tb_descricao
            // 
            this.tb_descricao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_descricao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_descricao.Location = new System.Drawing.Point(33, 46);
            this.tb_descricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_descricao.Size = new System.Drawing.Size(351, 24);
            this.tb_descricao.TabIndex = 1;
            // 
            // lb_descricao
            // 
            this.lb_descricao.AutoSize = true;
            this.lb_descricao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_descricao.ForeColor = System.Drawing.Color.Yellow;
            this.lb_descricao.Location = new System.Drawing.Point(33, 28);
            this.lb_descricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_descricao.Name = "lb_descricao";
            this.lb_descricao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_descricao.Size = new System.Drawing.Size(70, 15);
            this.lb_descricao.TabIndex = 42;
            this.lb_descricao.Text = "DESCRIÇÃO";
            // 
            // tb_Grupo
            // 
            this.tb_Grupo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Grupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Grupo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Grupo.Location = new System.Drawing.Point(80, 157);
            this.tb_Grupo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Grupo.Name = "tb_Grupo";
            this.tb_Grupo.ReadOnly = true;
            this.tb_Grupo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_Grupo.Size = new System.Drawing.Size(171, 24);
            this.tb_Grupo.TabIndex = 6;
            // 
            // bt_Grupo
            // 
            this.bt_Grupo.FlatAppearance.BorderSize = 0;
            this.bt_Grupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Grupo.Image = global::GS.WIN.Properties.Resources.search_24;
            this.bt_Grupo.Location = new System.Drawing.Point(255, 154);
            this.bt_Grupo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_Grupo.Name = "bt_Grupo";
            this.bt_Grupo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Grupo.Size = new System.Drawing.Size(26, 26);
            this.bt_Grupo.TabIndex = 7;
            this.bt_Grupo.UseVisualStyleBackColor = true;
            this.bt_Grupo.Click += new System.EventHandler(this.bt_Grupo_Click);
            // 
            // lb_unidade
            // 
            this.lb_unidade.AutoSize = true;
            this.lb_unidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_unidade.ForeColor = System.Drawing.Color.Yellow;
            this.lb_unidade.Location = new System.Drawing.Point(33, 79);
            this.lb_unidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_unidade.Name = "lb_unidade";
            this.lb_unidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_unidade.Size = new System.Drawing.Size(57, 15);
            this.lb_unidade.TabIndex = 54;
            this.lb_unidade.Text = "UNIDADE";
            // 
            // tb_SiglaUni
            // 
            this.tb_SiglaUni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_SiglaUni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SiglaUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_SiglaUni.Location = new System.Drawing.Point(80, 97);
            this.tb_SiglaUni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_SiglaUni.Name = "tb_SiglaUni";
            this.tb_SiglaUni.ReadOnly = true;
            this.tb_SiglaUni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_SiglaUni.Size = new System.Drawing.Size(44, 24);
            this.tb_SiglaUni.TabIndex = 2;
            this.tb_SiglaUni.Leave += new System.EventHandler(this.tb_SiglaUni_Leave);
            // 
            // bt_Uni
            // 
            this.bt_Uni.FlatAppearance.BorderSize = 0;
            this.bt_Uni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Uni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Uni.Image = global::GS.WIN.Properties.Resources.search_24;
            this.bt_Uni.Location = new System.Drawing.Point(255, 95);
            this.bt_Uni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_Uni.Name = "bt_Uni";
            this.bt_Uni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Uni.Size = new System.Drawing.Size(26, 26);
            this.bt_Uni.TabIndex = 4;
            this.bt_Uni.UseVisualStyleBackColor = true;
            this.bt_Uni.Click += new System.EventHandler(this.bt_Uni_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_PrecoGrupo);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(precoVendaLabel);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(valUltCmpLabel);
            this.groupBox1.Controls.Add(this.tb_precoVenda);
            this.groupBox1.Controls.Add(this.tb_cusMed);
            this.groupBox1.Controls.Add(this.tb_cusRep);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(50, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(378, 188);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custo/Preço";
            // 
            // cb_PrecoGrupo
            // 
            this.cb_PrecoGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PrecoGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_PrecoGrupo.FormattingEnabled = true;
            this.cb_PrecoGrupo.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.cb_PrecoGrupo.Location = new System.Drawing.Point(25, 129);
            this.cb_PrecoGrupo.Name = "cb_PrecoGrupo";
            this.cb_PrecoGrupo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_PrecoGrupo.Size = new System.Drawing.Size(123, 26);
            this.cb_PrecoGrupo.TabIndex = 11;
            this.cb_PrecoGrupo.SelectedIndexChanged += new System.EventHandler(this.cb_PrecoGrupo_SelectedIndexChanged);
            // 
            // tb_precoVenda
            // 
            this.tb_precoVenda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_precoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_precoVenda.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_precoVenda.Location = new System.Drawing.Point(231, 129);
            this.tb_precoVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_precoVenda.Name = "tb_precoVenda";
            this.tb_precoVenda.Size = new System.Drawing.Size(123, 25);
            this.tb_precoVenda.TabIndex = 12;
            this.tb_precoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_precoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infNum_KeyPress);
            this.tb_precoVenda.Leave += new System.EventHandler(this.Campo_Money);
            // 
            // tb_cusMed
            // 
            this.tb_cusMed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_cusMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cusMed.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_cusMed.Location = new System.Drawing.Point(231, 61);
            this.tb_cusMed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_cusMed.Name = "tb_cusMed";
            this.tb_cusMed.Size = new System.Drawing.Size(123, 25);
            this.tb_cusMed.TabIndex = 10;
            this.tb_cusMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_cusMed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infNum_KeyPress);
            this.tb_cusMed.Leave += new System.EventHandler(this.Campo_Money);
            // 
            // tb_cusRep
            // 
            this.tb_cusRep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_cusRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cusRep.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_cusRep.Location = new System.Drawing.Point(25, 61);
            this.tb_cusRep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_cusRep.Name = "tb_cusRep";
            this.tb_cusRep.Size = new System.Drawing.Size(123, 25);
            this.tb_cusRep.TabIndex = 9;
            this.tb_cusRep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_cusRep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infNum_KeyPress);
            this.tb_cusRep.Leave += new System.EventHandler(this.Campo_Money);
            // 
            // produtoIdDataGridViewTextBoxColumn
            // 
            this.produtoIdDataGridViewTextBoxColumn.DataPropertyName = "ProdutoId";
            this.produtoIdDataGridViewTextBoxColumn.HeaderText = "ProdutoId";
            this.produtoIdDataGridViewTextBoxColumn.Name = "produtoIdDataGridViewTextBoxColumn";
            // 
            // precoProIdDataGridViewTextBoxColumn
            // 
            this.precoProIdDataGridViewTextBoxColumn.DataPropertyName = "PrecoProId";
            this.precoProIdDataGridViewTextBoxColumn.HeaderText = "PrecoProId";
            this.precoProIdDataGridViewTextBoxColumn.Name = "precoProIdDataGridViewTextBoxColumn";
            // 
            // tabPreIdDataGridViewTextBoxColumn
            // 
            this.tabPreIdDataGridViewTextBoxColumn.DataPropertyName = "TabPreId";
            this.tabPreIdDataGridViewTextBoxColumn.HeaderText = "TabPreId";
            this.tabPreIdDataGridViewTextBoxColumn.Name = "tabPreIdDataGridViewTextBoxColumn";
            // 
            // desTabPreDataGridViewTextBoxColumn
            // 
            this.desTabPreDataGridViewTextBoxColumn.DataPropertyName = "DesTabPre";
            this.desTabPreDataGridViewTextBoxColumn.HeaderText = "DesTabPre";
            this.desTabPreDataGridViewTextBoxColumn.Name = "desTabPreDataGridViewTextBoxColumn";
            // 
            // valProdutoDataGridViewTextBoxColumn
            // 
            this.valProdutoDataGridViewTextBoxColumn.DataPropertyName = "ValProduto";
            this.valProdutoDataGridViewTextBoxColumn.HeaderText = "ValProduto";
            this.valProdutoDataGridViewTextBoxColumn.Name = "valProdutoDataGridViewTextBoxColumn";
            // 
            // descProgDataGridViewTextBoxColumn
            // 
            this.descProgDataGridViewTextBoxColumn.DataPropertyName = "DescProg";
            this.descProgDataGridViewTextBoxColumn.HeaderText = "DescProg";
            this.descProgDataGridViewTextBoxColumn.Name = "descProgDataGridViewTextBoxColumn";
            // 
            // valAntProDataGridViewTextBoxColumn
            // 
            this.valAntProDataGridViewTextBoxColumn.DataPropertyName = "ValAntPro";
            this.valAntProDataGridViewTextBoxColumn.HeaderText = "ValAntPro";
            this.valAntProDataGridViewTextBoxColumn.Name = "valAntProDataGridViewTextBoxColumn";
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "Produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            // 
            // tabPrecoDataGridViewTextBoxColumn
            // 
            this.tabPrecoDataGridViewTextBoxColumn.DataPropertyName = "TabPreco";
            this.tabPrecoDataGridViewTextBoxColumn.HeaderText = "TabPreco";
            this.tabPrecoDataGridViewTextBoxColumn.Name = "tabPrecoDataGridViewTextBoxColumn";
            // 
            // bt_Status
            // 
            this.bt_Status.FlatAppearance.BorderSize = 0;
            this.bt_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Status.Image = global::GS.WIN.Properties.Resources.switch_off_icon_48X48;
            this.bt_Status.Location = new System.Drawing.Point(391, 44);
            this.bt_Status.Name = "bt_Status";
            this.bt_Status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Status.Size = new System.Drawing.Size(49, 29);
            this.bt_Status.TabIndex = 56;
            this.bt_Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Status.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Status.UseVisualStyleBackColor = true;
            this.bt_Status.Click += new System.EventHandler(this.bt_Status_Click);
            // 
            // cb_TipoPro
            // 
            this.cb_TipoPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_TipoPro.FormattingEnabled = true;
            this.cb_TipoPro.Items.AddRange(new object[] {
            "Consumo",
            "Final"});
            this.cb_TipoPro.Location = new System.Drawing.Point(344, 97);
            this.cb_TipoPro.Name = "cb_TipoPro";
            this.cb_TipoPro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_TipoPro.Size = new System.Drawing.Size(96, 26);
            this.cb_TipoPro.TabIndex = 5;
            // 
            // tb_DescUni
            // 
            this.tb_DescUni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_DescUni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_DescUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_DescUni.Location = new System.Drawing.Point(127, 97);
            this.tb_DescUni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_DescUni.Name = "tb_DescUni";
            this.tb_DescUni.ReadOnly = true;
            this.tb_DescUni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_DescUni.Size = new System.Drawing.Size(124, 24);
            this.tb_DescUni.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grid_Estoque);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(50, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(378, 188);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estoque";
            // 
            // grid_Estoque
            // 
            this.grid_Estoque.AllowUserToAddRows = false;
            this.grid_Estoque.AllowUserToDeleteRows = false;
            this.grid_Estoque.BackgroundColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Estoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Estoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codloc,
            this.descLocal,
            this.qntest,
            this.unLoc});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Estoque.DefaultCellStyle = dataGridViewCellStyle4;
            this.grid_Estoque.Location = new System.Drawing.Point(8, 23);
            this.grid_Estoque.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_Estoque.Name = "grid_Estoque";
            this.grid_Estoque.ReadOnly = true;
            this.grid_Estoque.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grid_Estoque.RowHeadersVisible = false;
            this.grid_Estoque.Size = new System.Drawing.Size(360, 159);
            this.grid_Estoque.TabIndex = 61;
            // 
            // codloc
            // 
            this.codloc.HeaderText = "Cód";
            this.codloc.Name = "codloc";
            this.codloc.ReadOnly = true;
            this.codloc.Width = 40;
            // 
            // descLocal
            // 
            this.descLocal.HeaderText = "Local";
            this.descLocal.Name = "descLocal";
            this.descLocal.ReadOnly = true;
            this.descLocal.Width = 150;
            // 
            // qntest
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.qntest.DefaultCellStyle = dataGridViewCellStyle2;
            this.qntest.HeaderText = "Quantidade";
            this.qntest.Name = "qntest";
            this.qntest.ReadOnly = true;
            // 
            // unLoc
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.unLoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.unLoc.HeaderText = "UN";
            this.unLoc.Name = "unLoc";
            this.unLoc.ReadOnly = true;
            this.unLoc.Width = 40;
            // 
            // pnl_Dados
            // 
            this.pnl_Dados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(32)))), ((int)(((byte)(117)))));
            this.pnl_Dados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Dados.Controls.Add(this.lb_descricao);
            this.pnl_Dados.Controls.Add(label1);
            this.pnl_Dados.Controls.Add(this.bt_Status);
            this.pnl_Dados.Controls.Add(this.tb_Grupo);
            this.pnl_Dados.Controls.Add(this.tb_codGrupo);
            this.pnl_Dados.Controls.Add(this.tb_codUni);
            this.pnl_Dados.Controls.Add(this.tb_SiglaUni);
            this.pnl_Dados.Controls.Add(this.tb_DescUni);
            this.pnl_Dados.Controls.Add(this.bt_Grupo);
            this.pnl_Dados.Controls.Add(this.cb_TipoPro);
            this.pnl_Dados.Controls.Add(codGrupoLabel);
            this.pnl_Dados.Controls.Add(staProdLabel);
            this.pnl_Dados.Controls.Add(this.lb_unidade);
            this.pnl_Dados.Controls.Add(this.bt_Uni);
            this.pnl_Dados.Controls.Add(this.tb_descricao);
            this.pnl_Dados.ForeColor = System.Drawing.Color.Yellow;
            this.pnl_Dados.Location = new System.Drawing.Point(38, 101);
            this.pnl_Dados.Name = "pnl_Dados";
            this.pnl_Dados.Size = new System.Drawing.Size(480, 213);
            this.pnl_Dados.TabIndex = 0;
            // 
            // tb_codGrupo
            // 
            this.tb_codGrupo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_codGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_codGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_codGrupo.Location = new System.Drawing.Point(33, 156);
            this.tb_codGrupo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_codGrupo.Name = "tb_codGrupo";
            this.tb_codGrupo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_codGrupo.Size = new System.Drawing.Size(44, 24);
            this.tb_codGrupo.TabIndex = 2;
            this.tb_codGrupo.Leave += new System.EventHandler(this.tb_codGrupo_Leave);
            // 
            // tb_codUni
            // 
            this.tb_codUni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_codUni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_codUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_codUni.Location = new System.Drawing.Point(33, 97);
            this.tb_codUni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_codUni.Name = "tb_codUni";
            this.tb_codUni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_codUni.Size = new System.Drawing.Size(44, 24);
            this.tb_codUni.TabIndex = 2;
            this.tb_codUni.Leave += new System.EventHandler(this.tb_SiglaUni_Leave);
            // 
            // bt_AbaDados
            // 
            this.bt_AbaDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(32)))), ((int)(((byte)(117)))));
            this.bt_AbaDados.FlatAppearance.BorderSize = 0;
            this.bt_AbaDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AbaDados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_AbaDados.ForeColor = System.Drawing.Color.Yellow;
            this.bt_AbaDados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_AbaDados.Location = new System.Drawing.Point(254, 74);
            this.bt_AbaDados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_AbaDados.Name = "bt_AbaDados";
            this.bt_AbaDados.Size = new System.Drawing.Size(87, 28);
            this.bt_AbaDados.TabIndex = 14;
            this.bt_AbaDados.Text = "Dados";
            this.bt_AbaDados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_AbaDados.UseVisualStyleBackColor = false;
            this.bt_AbaDados.Click += new System.EventHandler(this.bt_Abas_Click);
            // 
            // bt_abaEstoque
            // 
            this.bt_abaEstoque.BackColor = System.Drawing.Color.MediumPurple;
            this.bt_abaEstoque.FlatAppearance.BorderSize = 0;
            this.bt_abaEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_abaEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_abaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_abaEstoque.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_abaEstoque.ForeColor = System.Drawing.Color.Yellow;
            this.bt_abaEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_abaEstoque.Location = new System.Drawing.Point(430, 74);
            this.bt_abaEstoque.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_abaEstoque.Name = "bt_abaEstoque";
            this.bt_abaEstoque.Size = new System.Drawing.Size(87, 28);
            this.bt_abaEstoque.TabIndex = 16;
            this.bt_abaEstoque.Text = "Estoque";
            this.bt_abaEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_abaEstoque.UseVisualStyleBackColor = false;
            this.bt_abaEstoque.Click += new System.EventHandler(this.bt_Abas_Click);
            // 
            // pnl_Estoque
            // 
            this.pnl_Estoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(32)))), ((int)(((byte)(117)))));
            this.pnl_Estoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Estoque.Controls.Add(this.groupBox2);
            this.pnl_Estoque.ForeColor = System.Drawing.Color.Yellow;
            this.pnl_Estoque.Location = new System.Drawing.Point(38, 101);
            this.pnl_Estoque.Name = "pnl_Estoque";
            this.pnl_Estoque.Size = new System.Drawing.Size(480, 213);
            this.pnl_Estoque.TabIndex = 418;
            // 
            // pnl_Precos
            // 
            this.pnl_Precos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(32)))), ((int)(((byte)(117)))));
            this.pnl_Precos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Precos.Controls.Add(this.groupBox1);
            this.pnl_Precos.ForeColor = System.Drawing.Color.Yellow;
            this.pnl_Precos.Location = new System.Drawing.Point(38, 101);
            this.pnl_Precos.Name = "pnl_Precos";
            this.pnl_Precos.Size = new System.Drawing.Size(480, 213);
            this.pnl_Precos.TabIndex = 8;
            // 
            // bt_abaValores
            // 
            this.bt_abaValores.BackColor = System.Drawing.Color.MediumPurple;
            this.bt_abaValores.FlatAppearance.BorderSize = 0;
            this.bt_abaValores.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_abaValores.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_abaValores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_abaValores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_abaValores.ForeColor = System.Drawing.Color.Yellow;
            this.bt_abaValores.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_abaValores.Location = new System.Drawing.Point(342, 74);
            this.bt_abaValores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_abaValores.Name = "bt_abaValores";
            this.bt_abaValores.Size = new System.Drawing.Size(87, 28);
            this.bt_abaValores.TabIndex = 15;
            this.bt_abaValores.Text = "Valores";
            this.bt_abaValores.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_abaValores.UseVisualStyleBackColor = false;
            this.bt_abaValores.Click += new System.EventHandler(this.bt_Abas_Click);
            // 
            // bt_Gravar
            // 
            this.bt_Gravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(146)))));
            this.bt_Gravar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.bt_Gravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.bt_Gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Gravar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Gravar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(222)))), ((int)(((byte)(23)))));
            this.bt_Gravar.Image = global::GS.WIN.Properties.Resources.ok_32;
            this.bt_Gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Gravar.Location = new System.Drawing.Point(382, 320);
            this.bt_Gravar.Name = "bt_Gravar";
            this.bt_Gravar.Size = new System.Drawing.Size(136, 43);
            this.bt_Gravar.TabIndex = 13;
            this.bt_Gravar.Text = "Confirmar";
            this.bt_Gravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Gravar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Gravar.UseVisualStyleBackColor = false;
            this.bt_Gravar.Click += new System.EventHandler(this.bt_Gravar_Click);
            // 
            // lb_MsgInfo
            // 
            this.lb_MsgInfo.AutoSize = true;
            this.lb_MsgInfo.ForeColor = System.Drawing.Color.Lime;
            this.lb_MsgInfo.Location = new System.Drawing.Point(12, 336);
            this.lb_MsgInfo.Name = "lb_MsgInfo";
            this.lb_MsgInfo.Size = new System.Drawing.Size(232, 15);
            this.lb_MsgInfo.TabIndex = 422;
            this.lb_MsgInfo.Text = "CEP não localizado! Informe Manualmente";
            this.lb_MsgInfo.Visible = false;
            // 
            // tb_CodProduto
            // 
            this.tb_CodProduto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_CodProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CodProduto.Location = new System.Drawing.Point(90, 75);
            this.tb_CodProduto.Name = "tb_CodProduto";
            this.tb_CodProduto.ReadOnly = true;
            this.tb_CodProduto.Size = new System.Drawing.Size(59, 16);
            this.tb_CodProduto.TabIndex = 420;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(38, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 421;
            this.label9.Text = "CÓDIGO";
            // 
            // Relogio
            // 
            this.Relogio.Interval = 1000;
            this.Relogio.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(556, 375);
            this.Controls.Add(this.bt_AbaDados);
            this.Controls.Add(this.bt_abaEstoque);
            this.Controls.Add(this.bt_abaValores);
            this.Controls.Add(this.lb_MsgInfo);
            this.Controls.Add(this.tb_CodProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bt_Gravar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Dados);
            this.Controls.Add(this.pnl_Estoque);
            this.Controls.Add(this.pnl_Precos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadProduto";
            this.Load += new System.EventHandler(this.CadProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Estoque)).EndInit();
            this.pnl_Dados.ResumeLayout(false);
            this.pnl_Dados.PerformLayout();
            this.pnl_Estoque.ResumeLayout(false);
            this.pnl_Precos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label lb_descricao;
        public System.Windows.Forms.TextBox tb_Grupo;
        private System.Windows.Forms.Button bt_Grupo;
        private System.Windows.Forms.Label lb_unidade;
        public System.Windows.Forms.TextBox tb_SiglaUni;
        private System.Windows.Forms.Button bt_Uni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_cusRep;
        private System.Windows.Forms.TextBox tb_precoVenda;
        private System.Windows.Forms.TextBox tb_cusMed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoProIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabPreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desTabPreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descProgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valAntProDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabPrecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bt_Status;
        private System.Windows.Forms.ComboBox cb_TipoPro;
        public System.Windows.Forms.TextBox tb_DescUni;
        private System.Windows.Forms.ComboBox cb_PrecoGrupo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grid_Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn codloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn descLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntest;
        private System.Windows.Forms.DataGridViewTextBoxColumn unLoc;
        private System.Windows.Forms.Panel pnl_Dados;
        private System.Windows.Forms.Button bt_AbaDados;
        private System.Windows.Forms.Button bt_abaEstoque;
        private System.Windows.Forms.Panel pnl_Estoque;
        private System.Windows.Forms.Panel pnl_Precos;
        private System.Windows.Forms.Button bt_abaValores;
        private System.Windows.Forms.Button bt_Gravar;
        private System.Windows.Forms.Label lb_MsgInfo;
        private System.Windows.Forms.TextBox tb_CodProduto;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tb_codGrupo;
        public System.Windows.Forms.TextBox tb_codUni;
        private System.Windows.Forms.Timer Relogio;
    }
}