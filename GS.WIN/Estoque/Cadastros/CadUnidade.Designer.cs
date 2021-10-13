namespace GS.WIN.Estoque
{
    partial class CadUnidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadUnidade));
            this.bt_Gravar = new System.Windows.Forms.Button();
            this.lb_sigUni = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_sigUni = new System.Windows.Forms.TextBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Gravar
            // 
            this.bt_Gravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Gravar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Gravar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_Gravar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_Gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Gravar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Gravar.ForeColor = System.Drawing.Color.Yellow;
            this.bt_Gravar.Image = global::GS.WIN.Properties.Resources.ok_32;
            this.bt_Gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Gravar.Location = new System.Drawing.Point(262, 142);
            this.bt_Gravar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_Gravar.Name = "bt_Gravar";
            this.bt_Gravar.Size = new System.Drawing.Size(136, 43);
            this.bt_Gravar.TabIndex = 2;
            this.bt_Gravar.Text = "Confirmar";
            this.bt_Gravar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Gravar.UseVisualStyleBackColor = false;
            this.bt_Gravar.Click += new System.EventHandler(this.bt_Gravar_Click);
            // 
            // lb_sigUni
            // 
            this.lb_sigUni.AutoSize = true;
            this.lb_sigUni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_sigUni.ForeColor = System.Drawing.Color.Yellow;
            this.lb_sigUni.Location = new System.Drawing.Point(26, 124);
            this.lb_sigUni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sigUni.Name = "lb_sigUni";
            this.lb_sigUni.Size = new System.Drawing.Size(38, 15);
            this.lb_sigUni.TabIndex = 50;
            this.lb_sigUni.Text = "SIGLA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(26, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "DESCRIÇÃO";
            // 
            // tb_sigUni
            // 
            this.tb_sigUni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_sigUni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_sigUni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_sigUni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_sigUni.Location = new System.Drawing.Point(108, 120);
            this.tb_sigUni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_sigUni.Name = "tb_sigUni";
            this.tb_sigUni.Size = new System.Drawing.Size(85, 23);
            this.tb_sigUni.TabIndex = 1;
            // 
            // tb_Nome
            // 
            this.tb_Nome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Nome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Nome.Location = new System.Drawing.Point(108, 91);
            this.tb_Nome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(290, 23);
            this.tb_Nome.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(76)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bt_Fechar);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 60);
            this.panel1.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 44);
            this.label2.TabIndex = 148;
            this.label2.Text = "Unidade";
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(76)))), ((int)(((byte)(255)))));
            this.bt_Fechar.FlatAppearance.BorderSize = 0;
            this.bt_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Fechar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Fechar.Image = global::GS.WIN.Properties.Resources.Fechar_Ylw_24x24;
            this.bt_Fechar.Location = new System.Drawing.Point(380, 6);
            this.bt_Fechar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(30, 30);
            this.bt_Fechar.TabIndex = 10;
            this.bt_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Fechar.UseVisualStyleBackColor = false;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // CadUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(425, 197);
            this.Controls.Add(this.lb_sigUni);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_Gravar);
            this.Controls.Add(this.tb_sigUni);
            this.Controls.Add(this.tb_Nome);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CadUnidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadUnidade";
            this.Load += new System.EventHandler(this.CadUnidade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Gravar;
        private System.Windows.Forms.Label lb_sigUni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_sigUni;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Fechar;
    }
}