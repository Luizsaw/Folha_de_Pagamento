namespace RHS_Folha_de_Pagamento.Interface
{
    partial class frm_CadastrarUsuario
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
            btn_Fechar = new Button();
            btn_salvar = new Button();
            txb_login = new TextBox();
            label3 = new Label();
            txb_nome = new TextBox();
            label2 = new Label();
            cb_tipo = new ComboBox();
            label1 = new Label();
            txb_senha = new TextBox();
            label4 = new Label();
            pn_principal = new Panel();
            label5 = new Label();
            pn_principal.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Fechar
            // 
            btn_Fechar.Anchor = AnchorStyles.None;
            btn_Fechar.FlatAppearance.BorderSize = 0;
            btn_Fechar.FlatStyle = FlatStyle.Flat;
            btn_Fechar.Font = new Font("Bahnschrift SemiBold Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Fechar.ForeColor = Color.White;
            btn_Fechar.Location = new Point(508, 326);
            btn_Fechar.Name = "btn_Fechar";
            btn_Fechar.Size = new Size(80, 36);
            btn_Fechar.TabIndex = 58;
            btn_Fechar.Text = "Fechar";
            btn_Fechar.UseVisualStyleBackColor = true;
            btn_Fechar.Click += btn_Fechar_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Anchor = AnchorStyles.None;
            btn_salvar.FlatAppearance.BorderSize = 0;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Bahnschrift SemiBold Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvar.ForeColor = Color.White;
            btn_salvar.Location = new Point(416, 326);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(80, 36);
            btn_salvar.TabIndex = 57;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // txb_login
            // 
            txb_login.Location = new Point(25, 189);
            txb_login.MaxLength = 50;
            txb_login.Name = "txb_login";
            txb_login.Size = new Size(202, 23);
            txb_login.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 162);
            label3.Name = "label3";
            label3.Size = new Size(37, 19);
            label3.TabIndex = 46;
            label3.Text = "Login";
            // 
            // txb_nome
            // 
            txb_nome.Location = new Point(25, 65);
            txb_nome.MaxLength = 30;
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(517, 23);
            txb_nome.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 38);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 43;
            label2.Text = "Nome Completo";
            // 
            // cb_tipo
            // 
            cb_tipo.FormattingEnabled = true;
            cb_tipo.Items.AddRange(new object[] { "Administrador", "Gerente" });
            cb_tipo.Location = new Point(25, 127);
            cb_tipo.Name = "cb_tipo";
            cb_tipo.Size = new Size(106, 23);
            cb_tipo.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 100);
            label1.Name = "label1";
            label1.Size = new Size(30, 19);
            label1.TabIndex = 60;
            label1.Text = "Tipo";
            // 
            // txb_senha
            // 
            txb_senha.Location = new Point(25, 251);
            txb_senha.MaxLength = 50;
            txb_senha.Name = "txb_senha";
            txb_senha.Size = new Size(263, 23);
            txb_senha.TabIndex = 62;
            txb_senha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 224);
            label4.Name = "label4";
            label4.Size = new Size(43, 19);
            label4.TabIndex = 61;
            label4.Text = "Senha";
            // 
            // pn_principal
            // 
            pn_principal.BorderStyle = BorderStyle.FixedSingle;
            pn_principal.Controls.Add(label2);
            pn_principal.Controls.Add(btn_Fechar);
            pn_principal.Controls.Add(txb_senha);
            pn_principal.Controls.Add(btn_salvar);
            pn_principal.Controls.Add(txb_nome);
            pn_principal.Controls.Add(label4);
            pn_principal.Controls.Add(label3);
            pn_principal.Controls.Add(label1);
            pn_principal.Controls.Add(txb_login);
            pn_principal.Controls.Add(cb_tipo);
            pn_principal.Location = new Point(30, 31);
            pn_principal.Name = "pn_principal";
            pn_principal.Size = new Size(633, 376);
            pn_principal.TabIndex = 63;
            pn_principal.Paint += pintar_Borda;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(176, 17);
            label5.Name = "label5";
            label5.Size = new Size(293, 29);
            label5.TabIndex = 63;
            label5.Text = "Formulário de Cadastro de Usuário";
            // 
            // frm_CadastrarUsuario
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 57, 69);
            ClientSize = new Size(698, 453);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(pn_principal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frm_CadastrarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Cadastro de Usuário";
            pn_principal.ResumeLayout(false);
            pn_principal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Fechar;
        private Button btn_salvar;
        private TextBox txb_login;
        private Label label3;
        private TextBox txb_nome;
        private Label label2;
        private ComboBox cb_tipo;
        private Label label1;
        private TextBox txb_senha;
        private Label label4;
        private Panel pn_principal;
        private Label label5;
    }
}