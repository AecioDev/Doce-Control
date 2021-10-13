namespace GS.WIN.Estoque
{
    partial class ListaGrupos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaGrupos));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.gridDados = new System.Windows.Forms.DataGridView();
            this.col00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Modificar = new System.Windows.Forms.Button();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Atualizar = new System.Windows.Forms.Button();
            this.bt_Selecionar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(76)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bt_Fechar);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 60);
            this.panel2.TabIndex = 217;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(4, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 44);
            this.label3.TabIndex = 149;
            this.label3.Text = "Lista Grupos";
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(76)))), ((int)(((byte)(255)))));
            this.bt_Fechar.FlatAppearance.BorderSize = 0;
            this.bt_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Fechar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Fechar.Image = global::GS.WIN.Properties.Resources.Fechar_Ylw_24x24;
            this.bt_Fechar.Location = new System.Drawing.Point(415, 8);
            this.bt_Fechar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(30, 30);
            this.bt_Fechar.TabIndex = 10;
            this.bt_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Fechar.UseVisualStyleBackColor = false;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // gridDados
            // 
            this.gridDados.AllowUserToAddRows = false;
            this.gridDados.AllowUserToDeleteRows = false;
            this.gridDados.BackgroundColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
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
            this.col02});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDados.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridDados.Location = new System.Drawing.Point(15, 130);
            this.gridDados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridDados.Name = "gridDados";
            this.gridDados.ReadOnly = true;
            this.gridDados.RowHeadersVisible = false;
            this.gridDados.RowHeadersWidth = 21;
            this.gridDados.Size = new System.Drawing.Size(306, 162);
            this.gridDados.TabIndex = 214;
            // 
            // col00
            // 
            this.col00.HeaderText = "CÓD";
            this.col00.Name = "col00";
            this.col00.ReadOnly = true;
            this.col00.Width = 40;
            // 
            // col01
            // 
            this.col01.HeaderText = "NOME";
            this.col01.Name = "col01";
            this.col01.ReadOnly = true;
            this.col01.Width = 200;
            // 
            // col02
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Format = "C";
            this.col02.DefaultCellStyle = dataGridViewCellStyle2;
            this.col02.HeaderText = "PREÇO";
            this.col02.Name = "col02";
            this.col02.ReadOnly = true;
            this.col02.Width = 80;
            // 
            // tb_nome
            // 
            this.tb_nome.BackColor = System.Drawing.SystemColors.Control;
            this.tb_nome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_nome.Location = new System.Drawing.Point(15, 98);
            this.tb_nome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(283, 23);
            this.tb_nome.TabIndex = 0;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 216;
            this.label4.Text = "DESCRIÇÃO";
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
            this.bt_Modificar.Location = new System.Drawing.Point(330, 259);
            this.bt_Modificar.Name = "bt_Modificar";
            this.bt_Modificar.Size = new System.Drawing.Size(118, 33);
            this.bt_Modificar.TabIndex = 218;
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
            this.bt_Cadastrar.Location = new System.Drawing.Point(330, 216);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(118, 33);
            this.bt_Cadastrar.TabIndex = 219;
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
            this.bt_Atualizar.Location = new System.Drawing.Point(330, 173);
            this.bt_Atualizar.Name = "bt_Atualizar";
            this.bt_Atualizar.Size = new System.Drawing.Size(118, 33);
            this.bt_Atualizar.TabIndex = 220;
            this.bt_Atualizar.Text = "Atualizar ";
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
            this.bt_Selecionar.Location = new System.Drawing.Point(330, 130);
            this.bt_Selecionar.Name = "bt_Selecionar";
            this.bt_Selecionar.Size = new System.Drawing.Size(118, 33);
            this.bt_Selecionar.TabIndex = 221;
            this.bt_Selecionar.Text = "Selecionar";
            this.bt_Selecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Selecionar.UseVisualStyleBackColor = false;
            this.bt_Selecionar.Click += new System.EventHandler(this.bt_Confirmar_Click);
            // 
            // ListaGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(460, 306);
            this.Controls.Add(this.bt_Modificar);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.bt_Atualizar);
            this.Controls.Add(this.bt_Selecionar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridDados);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ListaGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsGrupo";
            this.Load += new System.EventHandler(this.ConsGrupo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.DataGridView gridDados;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Modificar;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Atualizar;
        private System.Windows.Forms.Button bt_Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col00;
        private System.Windows.Forms.DataGridViewTextBoxColumn col01;
        private System.Windows.Forms.DataGridViewTextBoxColumn col02;
    }
}