namespace RHS_Folha_de_Pagamento
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            painel_Superior = new Panel();
            menuStrip1 = new MenuStrip();
            ts_usuario = new ToolStripMenuItem();
            ts_cadastrarUser = new ToolStripMenuItem();
            listaDeUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem1 = new ToolStripMenuItem();
            listaDeEmpresasToolStripMenuItem = new ToolStripMenuItem();
            listaDeClientesToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem2 = new ToolStripMenuItem();
            listaDeFuncionáriosToolStripMenuItem = new ToolStripMenuItem();
            consultarPontoToolStripMenuItem = new ToolStripMenuItem();
            folhaDePagamentoToolStripMenuItem = new ToolStripMenuItem();
            lançamentosToolStripMenuItem = new ToolStripMenuItem();
            exibirFolhasToolStripMenuItem = new ToolStripMenuItem();
            pic_login = new PictureBox();
            pictureBox1 = new PictureBox();
            pnl_Principal = new Panel();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pn_perfil = new Panel();
            btn_fechar = new Button();
            label2 = new Label();
            label1 = new Label();
            btn_sair = new Button();
            lbl_tipo = new Label();
            lbl_user = new Label();
            painel_Superior.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_login).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            pn_perfil.SuspendLayout();
            SuspendLayout();
            // 
            // painel_Superior
            // 
            painel_Superior.BackColor = Color.FromArgb(162, 168, 186);
            painel_Superior.Controls.Add(menuStrip1);
            painel_Superior.Controls.Add(pic_login);
            painel_Superior.Dock = DockStyle.Top;
            painel_Superior.Location = new Point(0, 0);
            painel_Superior.Name = "painel_Superior";
            painel_Superior.Size = new Size(1350, 62);
            painel_Superior.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(162, 168, 186);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ts_usuario, clienteToolStripMenuItem, folhaDePagamentoToolStripMenuItem });
            menuStrip1.Location = new Point(18, 21);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(360, 37);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // ts_usuario
            // 
            ts_usuario.BackColor = Color.FromArgb(162, 168, 186);
            ts_usuario.DropDownItems.AddRange(new ToolStripItem[] { ts_cadastrarUser, listaDeUsuáriosToolStripMenuItem });
            ts_usuario.ForeColor = Color.FromArgb(45, 57, 69);
            ts_usuario.Name = "ts_usuario";
            ts_usuario.Size = new Size(86, 33);
            ts_usuario.Text = "Usuário";
            // 
            // ts_cadastrarUser
            // 
            ts_cadastrarUser.BackColor = Color.FromArgb(162, 168, 186);
            ts_cadastrarUser.ForeColor = Color.FromArgb(45, 57, 69);
            ts_cadastrarUser.Name = "ts_cadastrarUser";
            ts_cadastrarUser.Size = new Size(224, 34);
            ts_cadastrarUser.Text = "Cadastrar";
            ts_cadastrarUser.Click += ts_cadastrarUser_Click;
            // 
            // listaDeUsuáriosToolStripMenuItem
            // 
            listaDeUsuáriosToolStripMenuItem.BackColor = Color.FromArgb(162, 168, 186);
            listaDeUsuáriosToolStripMenuItem.ForeColor = Color.FromArgb(45, 57, 69);
            listaDeUsuáriosToolStripMenuItem.Name = "listaDeUsuáriosToolStripMenuItem";
            listaDeUsuáriosToolStripMenuItem.Size = new Size(224, 34);
            listaDeUsuáriosToolStripMenuItem.Text = "Lista de Usuários";
            listaDeUsuáriosToolStripMenuItem.Click += listaDeUsuáriosToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, listaDeClientesToolStripMenuItem });
            clienteToolStripMenuItem.ForeColor = Color.FromArgb(45, 57, 69);
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(80, 33);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.BackColor = Color.FromArgb(162, 168, 186);
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem1, listaDeEmpresasToolStripMenuItem });
            cadastrarToolStripMenuItem.ForeColor = Color.FromArgb(45, 57, 69);
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(189, 34);
            cadastrarToolStripMenuItem.Text = "Empresa";
            // 
            // cadastrarToolStripMenuItem1
            // 
            cadastrarToolStripMenuItem1.BackColor = Color.FromArgb(162, 168, 186);
            cadastrarToolStripMenuItem1.ForeColor = Color.FromArgb(45, 57, 69);
            cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            cadastrarToolStripMenuItem1.Size = new Size(242, 34);
            cadastrarToolStripMenuItem1.Text = "Cadastrar Empresa";
            cadastrarToolStripMenuItem1.Click += cadastrarToolStripMenuItem_Click;
            // 
            // listaDeEmpresasToolStripMenuItem
            // 
            listaDeEmpresasToolStripMenuItem.BackColor = Color.FromArgb(162, 168, 186);
            listaDeEmpresasToolStripMenuItem.ForeColor = Color.FromArgb(45, 57, 69);
            listaDeEmpresasToolStripMenuItem.Name = "listaDeEmpresasToolStripMenuItem";
            listaDeEmpresasToolStripMenuItem.Size = new Size(242, 34);
            listaDeEmpresasToolStripMenuItem.Text = "Lista de Empresas";
            listaDeEmpresasToolStripMenuItem.Click += listaDeClientesToolStripMenuItem_Click;
            // 
            // listaDeClientesToolStripMenuItem
            // 
            listaDeClientesToolStripMenuItem.BackColor = Color.FromArgb(162, 168, 186);
            listaDeClientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem2, listaDeFuncionáriosToolStripMenuItem, consultarPontoToolStripMenuItem });
            listaDeClientesToolStripMenuItem.ForeColor = Color.FromArgb(45, 57, 69);
            listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            listaDeClientesToolStripMenuItem.Size = new Size(189, 34);
            listaDeClientesToolStripMenuItem.Text = "Funcionários";
            // 
            // cadastrarToolStripMenuItem2
            // 
            cadastrarToolStripMenuItem2.BackColor = Color.FromArgb(162, 168, 186);
            cadastrarToolStripMenuItem2.ForeColor = Color.FromArgb(45, 57, 69);
            cadastrarToolStripMenuItem2.Name = "cadastrarToolStripMenuItem2";
            cadastrarToolStripMenuItem2.Size = new Size(266, 34);
            cadastrarToolStripMenuItem2.Text = "Cadastrar Funcionário";
            cadastrarToolStripMenuItem2.Click += cadastrarToolStripMenuItem2_Click;
            // 
            // listaDeFuncionáriosToolStripMenuItem
            // 
            listaDeFuncionáriosToolStripMenuItem.BackColor = Color.FromArgb(162, 168, 186);
            listaDeFuncionáriosToolStripMenuItem.ForeColor = Color.FromArgb(45, 57, 69);
            listaDeFuncionáriosToolStripMenuItem.Name = "listaDeFuncionáriosToolStripMenuItem";
            listaDeFuncionáriosToolStripMenuItem.Size = new Size(266, 34);
            listaDeFuncionáriosToolStripMenuItem.Text = "Lista de Funcionários";
            listaDeFuncionáriosToolStripMenuItem.Click += listaDeFuncionáriosToolStripMenuItem_Click;
            // 
            // consultarPontoToolStripMenuItem
            // 
            consultarPontoToolStripMenuItem.BackColor = Color.FromArgb(162, 168, 186);
            consultarPontoToolStripMenuItem.ForeColor = Color.FromArgb(45, 57, 69);
            consultarPontoToolStripMenuItem.Name = "consultarPontoToolStripMenuItem";
            consultarPontoToolStripMenuItem.Size = new Size(266, 34);
            consultarPontoToolStripMenuItem.Text = "Consultar Ponto";
            consultarPontoToolStripMenuItem.Click += consultarPontoToolStripMenuItem_Click;
            // 
            // folhaDePagamentoToolStripMenuItem
            // 
            folhaDePagamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lançamentosToolStripMenuItem, exibirFolhasToolStripMenuItem });
            folhaDePagamentoToolStripMenuItem.ForeColor = Color.FromArgb(45, 57, 69);
            folhaDePagamentoToolStripMenuItem.Name = "folhaDePagamentoToolStripMenuItem";
            folhaDePagamentoToolStripMenuItem.Size = new Size(186, 33);
            folhaDePagamentoToolStripMenuItem.Text = "Folha de Pagamento";
            // 
            // lançamentosToolStripMenuItem
            // 
            lançamentosToolStripMenuItem.BackColor = Color.FromArgb(162, 168, 186);
            lançamentosToolStripMenuItem.ForeColor = Color.FromArgb(45, 57, 69);
            lançamentosToolStripMenuItem.Name = "lançamentosToolStripMenuItem";
            lançamentosToolStripMenuItem.Size = new Size(195, 34);
            lançamentosToolStripMenuItem.Text = "Lançamentos";
            lançamentosToolStripMenuItem.Click += lançamentosToolStripMenuItem_Click;
            // 
            // exibirFolhasToolStripMenuItem
            // 
            exibirFolhasToolStripMenuItem.BackColor = Color.FromArgb(162, 168, 186);
            exibirFolhasToolStripMenuItem.ForeColor = Color.FromArgb(45, 57, 69);
            exibirFolhasToolStripMenuItem.Name = "exibirFolhasToolStripMenuItem";
            exibirFolhasToolStripMenuItem.Size = new Size(195, 34);
            exibirFolhasToolStripMenuItem.Text = "Exibir Folhas ";
            exibirFolhasToolStripMenuItem.Click += exibirFolhasToolStripMenuItem_Click;
            // 
            // pic_login
            // 
            pic_login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pic_login.Cursor = Cursors.Hand;
            pic_login.Image = (Image)resources.GetObject("pic_login.Image");
            pic_login.Location = new Point(1293, 6);
            pic_login.Name = "pic_login";
            pic_login.Size = new Size(50, 50);
            pic_login.TabIndex = 22;
            pic_login.TabStop = false;
            pic_login.Click += pic_login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1289, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pnl_Principal
            // 
            pnl_Principal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_Principal.AutoSize = true;
            pnl_Principal.BackColor = Color.FromArgb(45, 57, 69);
            pnl_Principal.BorderStyle = BorderStyle.FixedSingle;
            pnl_Principal.Location = new Point(3, 68);
            pnl_Principal.Name = "pnl_Principal";
            pnl_Principal.Size = new Size(1728, 799);
            pnl_Principal.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(253, 253, 253);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 674);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 55);
            panel1.TabIndex = 30;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(45, 57, 69);
            label6.Location = new Point(1216, 34);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 25;
            label6.Text = "Versão: 1.0.0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(90, 112, 126);
            label5.Font = new Font("Impact", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(101, 7);
            label5.Name = "label5";
            label5.Size = new Size(36, 42);
            label5.TabIndex = 16;
            label5.Text = "S";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(161, 168, 186);
            label4.Font = new Font("Impact", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(59, 7);
            label4.Name = "label4";
            label4.Size = new Size(37, 42);
            label4.TabIndex = 15;
            label4.Text = "H";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(45, 57, 69);
            label3.Font = new Font("Impact", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(18, 7);
            label3.Name = "label3";
            label3.Size = new Size(36, 42);
            label3.TabIndex = 14;
            label3.Text = "R";
            // 
            // pn_perfil
            // 
            pn_perfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pn_perfil.AutoSize = true;
            pn_perfil.BackColor = Color.FromArgb(162, 168, 186);
            pn_perfil.Controls.Add(btn_fechar);
            pn_perfil.Controls.Add(label2);
            pn_perfil.Controls.Add(label1);
            pn_perfil.Controls.Add(btn_sair);
            pn_perfil.Controls.Add(lbl_tipo);
            pn_perfil.Controls.Add(lbl_user);
            pn_perfil.Location = new Point(1126, 64);
            pn_perfil.Name = "pn_perfil";
            pn_perfil.Size = new Size(223, 191);
            pn_perfil.TabIndex = 31;
            pn_perfil.Visible = false;
            // 
            // btn_fechar
            // 
            btn_fechar.BackColor = Color.FromArgb(162, 168, 186);
            btn_fechar.FlatAppearance.BorderSize = 0;
            btn_fechar.FlatStyle = FlatStyle.Flat;
            btn_fechar.Font = new Font("Bahnschrift SemiBold Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_fechar.ForeColor = Color.FromArgb(45, 57, 69);
            btn_fechar.Location = new Point(138, 149);
            btn_fechar.Margin = new Padding(3, 2, 3, 2);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(76, 40);
            btn_fechar.TabIndex = 11;
            btn_fechar.Text = "fechar";
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(45, 57, 69);
            label2.Location = new Point(20, 12);
            label2.Name = "label2";
            label2.Size = new Size(62, 24);
            label2.TabIndex = 10;
            label2.Text = "Usuário:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(45, 57, 69);
            label1.Location = new Point(20, 69);
            label1.Name = "label1";
            label1.Size = new Size(60, 24);
            label1.TabIndex = 2;
            label1.Text = "Acesso:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_sair
            // 
            btn_sair.BackColor = Color.FromArgb(162, 168, 186);
            btn_sair.FlatAppearance.BorderSize = 0;
            btn_sair.FlatStyle = FlatStyle.Flat;
            btn_sair.Font = new Font("Bahnschrift SemiBold Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sair.ForeColor = Color.FromArgb(45, 57, 69);
            btn_sair.Location = new Point(6, 149);
            btn_sair.Margin = new Padding(3, 2, 3, 2);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(83, 40);
            btn_sair.TabIndex = 9;
            btn_sair.Text = "Logout";
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += button2_Click;
            // 
            // lbl_tipo
            // 
            lbl_tipo.AutoSize = true;
            lbl_tipo.Font = new Font("Bahnschrift SemiBold Condensed", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tipo.ForeColor = Color.FromArgb(45, 57, 69);
            lbl_tipo.Location = new Point(79, 69);
            lbl_tipo.Name = "lbl_tipo";
            lbl_tipo.Size = new Size(56, 24);
            lbl_tipo.TabIndex = 1;
            lbl_tipo.Text = "padrão";
            lbl_tipo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_user
            // 
            lbl_user.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_user.AutoSize = true;
            lbl_user.Font = new Font("Bahnschrift SemiBold Condensed", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_user.ForeColor = Color.FromArgb(45, 57, 69);
            lbl_user.Location = new Point(79, 13);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(39, 24);
            lbl_user.TabIndex = 0;
            lbl_user.Text = "ADM";
            lbl_user.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frm_Principal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(92, 111, 126);
            ClientSize = new Size(1350, 729);
            Controls.Add(pn_perfil);
            Controls.Add(panel1);
            Controls.Add(painel_Superior);
            Controls.Add(pnl_Principal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "frm_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RHS-Folha de Pagamento";
            Load += frm_Principal_Load;
            painel_Superior.ResumeLayout(false);
            painel_Superior.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_login).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pn_perfil.ResumeLayout(false);
            pn_perfil.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel painel_Superior;
        private PictureBox pic_login;
        private Panel pnl_Principal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ts_usuario;
        private ToolStripMenuItem ts_cadastrarUser;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem folhaDePagamentoToolStripMenuItem;
        private ToolStripMenuItem lançamentosToolStripMenuItem;
        private Panel panel1;
        private Panel pn_perfil;
        private Label lbl_tipo;
        private Label lbl_user;
        private ToolStripMenuItem listaDeUsuáriosToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem listaDeClientesToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem1;
        private ToolStripMenuItem listaDeEmpresasToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem2;
        private ToolStripMenuItem listaDeFuncionáriosToolStripMenuItem;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btn_sair;
        private Label label1;
        private Label label2;
        private Button btn_fechar;
        private PictureBox pictureBox1;
        private Label label6;
        private ToolStripMenuItem consultarPontoToolStripMenuItem;
        private ToolStripMenuItem exibirFolhasToolStripMenuItem;
    }
}