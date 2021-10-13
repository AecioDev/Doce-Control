
namespace GS.WIN.Vendas
{
    partial class CadClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ClienteId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ClienteNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ClienteCell = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_TotalCompras = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_CodEndereco = new System.Windows.Forms.TextBox();
            this.tb_DadosEndereco = new System.Windows.Forms.TextBox();
            this.bt_Endereco = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_DataCadastro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_Status = new System.Windows.Forms.Button();
            this.bt_Gravar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(502, 60);
            this.panel1.TabIndex = 11;
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Fechar.FlatAppearance.BorderSize = 0;
            this.bt_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Fechar.Image = global::GS.WIN.Properties.Resources.Fechar_Ylw_24x24;
            this.bt_Fechar.Location = new System.Drawing.Point(461, 8);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(32, 27);
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
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CÓDIGO";
            // 
            // tb_ClienteId
            // 
            this.tb_ClienteId.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_ClienteId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ClienteId.Location = new System.Drawing.Point(64, 263);
            this.tb_ClienteId.Name = "tb_ClienteId";
            this.tb_ClienteId.ReadOnly = true;
            this.tb_ClienteId.Size = new System.Drawing.Size(59, 16);
            this.tb_ClienteId.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "NOME";
            // 
            // tb_ClienteNome
            // 
            this.tb_ClienteNome.Location = new System.Drawing.Point(12, 98);
            this.tb_ClienteNome.Name = "tb_ClienteNome";
            this.tb_ClienteNome.Size = new System.Drawing.Size(331, 23);
            this.tb_ClienteNome.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(349, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "CELULAR";
            // 
            // tb_ClienteCell
            // 
            this.tb_ClienteCell.Location = new System.Drawing.Point(349, 98);
            this.tb_ClienteCell.Name = "tb_ClienteCell";
            this.tb_ClienteCell.Size = new System.Drawing.Size(145, 23);
            this.tb_ClienteCell.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "NASCIMENTO";
            // 
            // dt_Nascimento
            // 
            this.dt_Nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Nascimento.Location = new System.Drawing.Point(12, 147);
            this.dt_Nascimento.Name = "dt_Nascimento";
            this.dt_Nascimento.Size = new System.Drawing.Size(101, 23);
            this.dt_Nascimento.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(135, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "TOTAL COMPRAS";
            // 
            // tb_TotalCompras
            // 
            this.tb_TotalCompras.Location = new System.Drawing.Point(135, 147);
            this.tb_TotalCompras.Name = "tb_TotalCompras";
            this.tb_TotalCompras.Size = new System.Drawing.Size(145, 23);
            this.tb_TotalCompras.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(12, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "ENDEREÇO";
            // 
            // tb_CodEndereco
            // 
            this.tb_CodEndereco.Location = new System.Drawing.Point(12, 202);
            this.tb_CodEndereco.Name = "tb_CodEndereco";
            this.tb_CodEndereco.ReadOnly = true;
            this.tb_CodEndereco.Size = new System.Drawing.Size(66, 23);
            this.tb_CodEndereco.TabIndex = 5;
            // 
            // tb_DadosEndereco
            // 
            this.tb_DadosEndereco.Location = new System.Drawing.Point(135, 184);
            this.tb_DadosEndereco.Multiline = true;
            this.tb_DadosEndereco.Name = "tb_DadosEndereco";
            this.tb_DadosEndereco.ReadOnly = true;
            this.tb_DadosEndereco.Size = new System.Drawing.Size(359, 41);
            this.tb_DadosEndereco.TabIndex = 20;
            // 
            // bt_Endereco
            // 
            this.bt_Endereco.FlatAppearance.BorderSize = 0;
            this.bt_Endereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Endereco.Image = ((System.Drawing.Image)(resources.GetObject("bt_Endereco.Image")));
            this.bt_Endereco.Location = new System.Drawing.Point(84, 200);
            this.bt_Endereco.Name = "bt_Endereco";
            this.bt_Endereco.Size = new System.Drawing.Size(27, 25);
            this.bt_Endereco.TabIndex = 6;
            this.bt_Endereco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Endereco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Endereco.UseVisualStyleBackColor = true;
            this.bt_Endereco.Click += new System.EventHandler(this.bt_Endereco_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(135, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "DATA CADASTRO";
            // 
            // tb_DataCadastro
            // 
            this.tb_DataCadastro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_DataCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_DataCadastro.Location = new System.Drawing.Point(239, 263);
            this.tb_DataCadastro.Name = "tb_DataCadastro";
            this.tb_DataCadastro.ReadOnly = true;
            this.tb_DataCadastro.Size = new System.Drawing.Size(101, 16);
            this.tb_DataCadastro.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(445, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "STATUS";
            // 
            // bt_Status
            // 
            this.bt_Status.FlatAppearance.BorderSize = 0;
            this.bt_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Status.Image = global::GS.WIN.Properties.Resources.switch_off_icon_48X48;
            this.bt_Status.Location = new System.Drawing.Point(445, 143);
            this.bt_Status.Name = "bt_Status";
            this.bt_Status.Size = new System.Drawing.Size(49, 29);
            this.bt_Status.TabIndex = 4;
            this.bt_Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Status.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Status.UseVisualStyleBackColor = true;
            this.bt_Status.Click += new System.EventHandler(this.bt_Status_Click);
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
            this.bt_Gravar.Location = new System.Drawing.Point(358, 236);
            this.bt_Gravar.Name = "bt_Gravar";
            this.bt_Gravar.Size = new System.Drawing.Size(136, 43);
            this.bt_Gravar.TabIndex = 6;
            this.bt_Gravar.Text = "Confirmar";
            this.bt_Gravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Gravar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Gravar.UseVisualStyleBackColor = false;
            this.bt_Gravar.Click += new System.EventHandler(this.bt_Gravar_Click);
            // 
            // CadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(509, 296);
            this.Controls.Add(this.bt_Status);
            this.Controls.Add(this.bt_Gravar);
            this.Controls.Add(this.bt_Endereco);
            this.Controls.Add(this.dt_Nascimento);
            this.Controls.Add(this.tb_DadosEndereco);
            this.Controls.Add(this.tb_ClienteNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_TotalCompras);
            this.Controls.Add(this.tb_ClienteCell);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_CodEndereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_DataCadastro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_ClienteId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ClienteId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ClienteNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ClienteCell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_Nascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_TotalCompras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_DadosEndereco;
        private System.Windows.Forms.Button bt_Endereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_DataCadastro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_Status;
        private System.Windows.Forms.Button bt_Gravar;
        public System.Windows.Forms.TextBox tb_CodEndereco;
    }
}