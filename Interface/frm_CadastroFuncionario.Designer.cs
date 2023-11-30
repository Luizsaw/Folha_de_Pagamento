namespace RHS_Folha_de_Pagamento.Interface
{
    partial class frm_CadastroFuncionario
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
            label10 = new Label();
            panel1 = new Panel();
            label21 = new Label();
            cb_status = new ComboBox();
            label24 = new Label();
            panel2 = new Panel();
            label29 = new Label();
            label28 = new Label();
            txb_nome_banco = new TextBox();
            label27 = new Label();
            txb_num_agencia = new TextBox();
            label26 = new Label();
            txb_num_conta = new TextBox();
            label25 = new Label();
            cb_empresa = new ComboBox();
            label7 = new Label();
            txb_carga_hora = new TextBox();
            label23 = new Label();
            mtxb_dat_contrat = new MaskedTextBox();
            label22 = new Label();
            txb_quant_dep = new TextBox();
            label8 = new Label();
            txb_salario = new TextBox();
            label20 = new Label();
            label19 = new Label();
            txb_departamento = new TextBox();
            label18 = new Label();
            txb_cargo = new TextBox();
            label17 = new Label();
            txb_email = new TextBox();
            label15 = new Label();
            mtxb_rg = new MaskedTextBox();
            label16 = new Label();
            label14 = new Label();
            mtxb_cpf = new MaskedTextBox();
            label1 = new Label();
            label13 = new Label();
            mtxb_dat_nascimento = new MaskedTextBox();
            label12 = new Label();
            label11 = new Label();
            btn_Fechar = new Button();
            label9 = new Label();
            label2 = new Label();
            txb_nome = new TextBox();
            txb_Telefone = new MaskedTextBox();
            label3 = new Label();
            btn_salvar = new Button();
            txb_Logradouro = new TextBox();
            label4 = new Label();
            txb_Cidade = new TextBox();
            label5 = new Label();
            txb_Estado = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(268, 8);
            label10.Name = "label10";
            label10.Size = new Size(325, 29);
            label10.TabIndex = 44;
            label10.Text = "Formulário de cadastro de Funcionário";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label21);
            panel1.Controls.Add(cb_status);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(cb_empresa);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txb_carga_hora);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(mtxb_dat_contrat);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(txb_quant_dep);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txb_salario);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(txb_departamento);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(txb_cargo);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(txb_email);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(mtxb_rg);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(mtxb_cpf);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(mtxb_dat_nascimento);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btn_Fechar);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txb_nome);
            panel1.Controls.Add(txb_Telefone);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_salvar);
            panel1.Controls.Add(txb_Logradouro);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txb_Cidade);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txb_Estado);
            panel1.Controls.Add(label6);
            panel1.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(15, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 522);
            panel1.TabIndex = 45;
            panel1.Paint += pintar_Borda;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.ButtonShadow;
            label21.Location = new Point(406, 332);
            label21.Name = "label21";
            label21.Size = new Size(84, 19);
            label21.TabIndex = 71;
            label21.Text = "Ex: 01/04/1992";
            // 
            // cb_status
            // 
            cb_status.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cb_status.FormattingEnabled = true;
            cb_status.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cb_status.Location = new Point(718, 36);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(95, 23);
            cb_status.TabIndex = 70;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Bahnschrift SemiBold Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.White;
            label24.Location = new Point(50, 353);
            label24.Name = "label24";
            label24.Size = new Size(130, 27);
            label24.TabIndex = 46;
            label24.Text = "Dados Bancários";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label29);
            panel2.Controls.Add(label28);
            panel2.Controls.Add(txb_nome_banco);
            panel2.Controls.Add(label27);
            panel2.Controls.Add(txb_num_agencia);
            panel2.Controls.Add(label26);
            panel2.Controls.Add(txb_num_conta);
            panel2.Controls.Add(label25);
            panel2.Location = new Point(34, 366);
            panel2.Name = "panel2";
            panel2.Size = new Size(779, 107);
            panel2.TabIndex = 69;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label29.ForeColor = SystemColors.ButtonShadow;
            label29.Location = new Point(25, 73);
            label29.Name = "label29";
            label29.Size = new Size(128, 19);
            label29.TabIndex = 76;
            label29.Text = "C/ digito, Ex: 1371807-5";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label28.ForeColor = SystemColors.ButtonShadow;
            label28.Location = new Point(229, 73);
            label28.Name = "label28";
            label28.Size = new Size(50, 19);
            label28.TabIndex = 70;
            label28.Text = "Ex: 1234";
            // 
            // txb_nome_banco
            // 
            txb_nome_banco.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nome_banco.Location = new Point(439, 47);
            txb_nome_banco.MaxLength = 15;
            txb_nome_banco.Name = "txb_nome_banco";
            txb_nome_banco.Size = new Size(300, 23);
            txb_nome_banco.TabIndex = 75;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.ForeColor = Color.White;
            label27.Location = new Point(439, 25);
            label27.Name = "label27";
            label27.Size = new Size(89, 19);
            label27.TabIndex = 74;
            label27.Text = "Nome do Banco";
            // 
            // txb_num_agencia
            // 
            txb_num_agencia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_num_agencia.Location = new Point(229, 47);
            txb_num_agencia.MaxLength = 15;
            txb_num_agencia.Name = "txb_num_agencia";
            txb_num_agencia.Size = new Size(177, 23);
            txb_num_agencia.TabIndex = 73;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.ForeColor = Color.White;
            label26.Location = new Point(229, 25);
            label26.Name = "label26";
            label26.Size = new Size(69, 19);
            label26.TabIndex = 72;
            label26.Text = "N.º Agência";
            // 
            // txb_num_conta
            // 
            txb_num_conta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_num_conta.Location = new Point(24, 47);
            txb_num_conta.MaxLength = 15;
            txb_num_conta.Name = "txb_num_conta";
            txb_num_conta.Size = new Size(177, 23);
            txb_num_conta.TabIndex = 71;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.White;
            label25.Location = new Point(24, 25);
            label25.Name = "label25";
            label25.Size = new Size(58, 19);
            label25.TabIndex = 70;
            label25.Text = "N.º Conta";
            // 
            // cb_empresa
            // 
            cb_empresa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cb_empresa.FormattingEnabled = true;
            cb_empresa.Location = new Point(34, 36);
            cb_empresa.Name = "cb_empresa";
            cb_empresa.Size = new Size(177, 23);
            cb_empresa.TabIndex = 68;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(34, 14);
            label7.Name = "label7";
            label7.Size = new Size(55, 19);
            label7.TabIndex = 67;
            label7.Text = "Empresa";
            // 
            // txb_carga_hora
            // 
            txb_carga_hora.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_carga_hora.Location = new Point(538, 306);
            txb_carga_hora.MaxLength = 15;
            txb_carga_hora.Name = "txb_carga_hora";
            txb_carga_hora.Size = new Size(177, 23);
            txb_carga_hora.TabIndex = 66;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.White;
            label23.Location = new Point(538, 284);
            label23.Name = "label23";
            label23.Size = new Size(84, 19);
            label23.TabIndex = 65;
            label23.Text = "Carga Horária";
            // 
            // mtxb_dat_contrat
            // 
            mtxb_dat_contrat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mtxb_dat_contrat.Location = new Point(403, 306);
            mtxb_dat_contrat.Mask = "00/00/0000";
            mtxb_dat_contrat.Name = "mtxb_dat_contrat";
            mtxb_dat_contrat.ResetOnSpace = false;
            mtxb_dat_contrat.Size = new Size(114, 23);
            mtxb_dat_contrat.TabIndex = 63;
            mtxb_dat_contrat.ValidatingType = typeof(DateTime);
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.White;
            label22.Location = new Point(403, 284);
            label22.Name = "label22";
            label22.Size = new Size(119, 19);
            label22.TabIndex = 62;
            label22.Text = "Data da Contratação";
            // 
            // txb_quant_dep
            // 
            txb_quant_dep.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_quant_dep.Location = new Point(234, 306);
            txb_quant_dep.MaxLength = 15;
            txb_quant_dep.Name = "txb_quant_dep";
            txb_quant_dep.Size = new Size(150, 23);
            txb_quant_dep.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(234, 284);
            label8.Name = "label8";
            label8.Size = new Size(147, 19);
            label8.TabIndex = 46;
            label8.Text = "Quantidade de Depedentes";
            // 
            // txb_salario
            // 
            txb_salario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_salario.Location = new Point(34, 306);
            txb_salario.MaxLength = 15;
            txb_salario.Name = "txb_salario";
            txb_salario.Size = new Size(177, 23);
            txb_salario.TabIndex = 61;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.White;
            label20.Location = new Point(34, 284);
            label20.Name = "label20";
            label20.Size = new Size(77, 19);
            label20.TabIndex = 60;
            label20.Text = "Salário Base";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.White;
            label19.Location = new Point(467, 224);
            label19.Name = "label19";
            label19.Size = new Size(84, 19);
            label19.TabIndex = 58;
            label19.Text = "Departamento";
            // 
            // txb_departamento
            // 
            txb_departamento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_departamento.Location = new Point(467, 246);
            txb_departamento.MaxLength = 30;
            txb_departamento.Name = "txb_departamento";
            txb_departamento.Size = new Size(300, 23);
            txb_departamento.TabIndex = 59;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.White;
            label18.Location = new Point(197, 224);
            label18.Name = "label18";
            label18.Size = new Size(40, 19);
            label18.TabIndex = 56;
            label18.Text = "Cargo";
            // 
            // txb_cargo
            // 
            txb_cargo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_cargo.Location = new Point(197, 246);
            txb_cargo.MaxLength = 30;
            txb_cargo.Name = "txb_cargo";
            txb_cargo.Size = new Size(248, 23);
            txb_cargo.TabIndex = 57;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.White;
            label17.Location = new Point(476, 77);
            label17.Name = "label17";
            label17.Size = new Size(45, 19);
            label17.TabIndex = 54;
            label17.Text = "E-mail";
            // 
            // txb_email
            // 
            txb_email.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_email.Location = new Point(476, 99);
            txb_email.MaxLength = 30;
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(277, 23);
            txb_email.TabIndex = 55;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonShadow;
            label15.Location = new Point(323, 125);
            label15.Name = "label15";
            label15.Size = new Size(90, 19);
            label15.TabIndex = 53;
            label15.Text = "Ex: 17.241.997-9";
            // 
            // mtxb_rg
            // 
            mtxb_rg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mtxb_rg.Location = new Point(323, 99);
            mtxb_rg.Mask = "99,999,999-9";
            mtxb_rg.Name = "mtxb_rg";
            mtxb_rg.ResetOnSpace = false;
            mtxb_rg.Size = new Size(122, 23);
            mtxb_rg.TabIndex = 52;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.White;
            label16.Location = new Point(323, 77);
            label16.Name = "label16";
            label16.Size = new Size(23, 19);
            label16.TabIndex = 51;
            label16.Text = "RG";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonShadow;
            label14.Location = new Point(174, 125);
            label14.Name = "label14";
            label14.Size = new Size(108, 19);
            label14.TabIndex = 50;
            label14.Text = "Ex: 325.767.940-84";
            // 
            // mtxb_cpf
            // 
            mtxb_cpf.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mtxb_cpf.Location = new Point(174, 99);
            mtxb_cpf.Mask = "999,999,999-99";
            mtxb_cpf.Name = "mtxb_cpf";
            mtxb_cpf.ResetOnSpace = false;
            mtxb_cpf.Size = new Size(122, 23);
            mtxb_cpf.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(174, 77);
            label1.Name = "label1";
            label1.Size = new Size(29, 19);
            label1.TabIndex = 48;
            label1.Text = "CPF";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonShadow;
            label13.Location = new Point(34, 125);
            label13.Name = "label13";
            label13.Size = new Size(84, 19);
            label13.TabIndex = 47;
            label13.Text = "Ex: 01/04/1992";
            // 
            // mtxb_dat_nascimento
            // 
            mtxb_dat_nascimento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mtxb_dat_nascimento.Location = new Point(34, 99);
            mtxb_dat_nascimento.Mask = "00/00/0000";
            mtxb_dat_nascimento.Name = "mtxb_dat_nascimento";
            mtxb_dat_nascimento.ResetOnSpace = false;
            mtxb_dat_nascimento.Size = new Size(114, 23);
            mtxb_dat_nascimento.TabIndex = 46;
            mtxb_dat_nascimento.ValidatingType = typeof(DateTime);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(34, 77);
            label12.Name = "label12";
            label12.Size = new Size(114, 19);
            label12.TabIndex = 45;
            label12.Text = "Data de Nascimento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(718, 15);
            label11.Name = "label11";
            label11.Size = new Size(44, 19);
            label11.TabIndex = 43;
            label11.Text = "Status";
            // 
            // btn_Fechar
            // 
            btn_Fechar.Anchor = AnchorStyles.None;
            btn_Fechar.FlatAppearance.BorderSize = 0;
            btn_Fechar.FlatStyle = FlatStyle.Flat;
            btn_Fechar.Font = new Font("Bahnschrift SemiBold Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Fechar.ForeColor = Color.White;
            btn_Fechar.Location = new Point(727, 478);
            btn_Fechar.Name = "btn_Fechar";
            btn_Fechar.Size = new Size(86, 37);
            btn_Fechar.TabIndex = 39;
            btn_Fechar.Text = "Fechar";
            btn_Fechar.UseVisualStyleBackColor = true;
            btn_Fechar.Click += btn_Fechar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonShadow;
            label9.Location = new Point(174, 201);
            label9.Name = "label9";
            label9.Size = new Size(282, 19);
            label9.TabIndex = 42;
            label9.Text = "Nome do lougradouro, n.º, complemento (se houver)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(233, 14);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 23;
            label2.Text = "Nome completo";
            // 
            // txb_nome
            // 
            txb_nome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nome.Location = new Point(233, 36);
            txb_nome.MaxLength = 30;
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(470, 23);
            txb_nome.TabIndex = 24;
            // 
            // txb_Telefone
            // 
            txb_Telefone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Telefone.Location = new Point(34, 178);
            txb_Telefone.Mask = "(99) 00000-0000";
            txb_Telefone.Name = "txb_Telefone";
            txb_Telefone.ResetOnSpace = false;
            txb_Telefone.Size = new Size(109, 23);
            txb_Telefone.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(174, 152);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 26;
            label3.Text = "Logradouro";
            // 
            // btn_salvar
            // 
            btn_salvar.Anchor = AnchorStyles.None;
            btn_salvar.FlatAppearance.BorderSize = 0;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Bahnschrift SemiBold Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvar.ForeColor = Color.White;
            btn_salvar.Location = new Point(635, 478);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(86, 37);
            btn_salvar.TabIndex = 37;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // txb_Logradouro
            // 
            txb_Logradouro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Logradouro.Location = new Point(174, 175);
            txb_Logradouro.MaxLength = 50;
            txb_Logradouro.Name = "txb_Logradouro";
            txb_Logradouro.Size = new Size(376, 23);
            txb_Logradouro.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(34, 224);
            label4.Name = "label4";
            label4.Size = new Size(44, 19);
            label4.TabIndex = 28;
            label4.Text = "Cidade";
            // 
            // txb_Cidade
            // 
            txb_Cidade.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Cidade.Location = new Point(34, 246);
            txb_Cidade.MaxLength = 30;
            txb_Cidade.Name = "txb_Cidade";
            txb_Cidade.Size = new Size(129, 23);
            txb_Cidade.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(576, 152);
            label5.Name = "label5";
            label5.Size = new Size(44, 19);
            label5.TabIndex = 30;
            label5.Text = "Estado";
            // 
            // txb_Estado
            // 
            txb_Estado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Estado.Location = new Point(576, 175);
            txb_Estado.MaxLength = 30;
            txb_Estado.Name = "txb_Estado";
            txb_Estado.Size = new Size(237, 23);
            txb_Estado.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(34, 155);
            label6.Name = "label6";
            label6.Size = new Size(53, 19);
            label6.TabIndex = 32;
            label6.Text = "Telefone";
            // 
            // frm_CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 57, 69);
            ClientSize = new Size(872, 559);
            ControlBox = false;
            Controls.Add(label10);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frm_CadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de cadastro de Funcionário";
            Load += frm_CadastroFuncionario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Panel panel1;
        private Button btn_Fechar;
        private Label label9;
        private Label label2;
        private TextBox txb_nome;
        private MaskedTextBox txb_Telefone;
        private Label label3;
        private Button btn_salvar;
        private TextBox txb_Logradouro;
        private Label label4;
        private TextBox txb_Cidade;
        private Label label5;
        private TextBox txb_Estado;
        private Label label6;
        private Label label12;
        private Label label11;
        private Label label13;
        private MaskedTextBox mtxb_dat_nascimento;
        private Label label17;
        private TextBox txb_email;
        private Label label15;
        private MaskedTextBox mtxb_rg;
        private Label label16;
        private Label label14;
        private MaskedTextBox mtxb_cpf;
        private Label label1;
        private MaskedTextBox mtxb_dat_contrat;
        private Label label22;
        private TextBox txb_quant_dep;
        private Label label8;
        private TextBox txb_salario;
        private Label label20;
        private Label label19;
        private TextBox txb_departamento;
        private Label label18;
        private TextBox txb_cargo;
        private TextBox txb_carga_hora;
        private Label label23;
        private ComboBox cb_empresa;
        private Label label7;
        private Panel panel2;
        private Label label24;
        private Label label29;
        private Label label28;
        private TextBox txb_nome_banco;
        private Label label27;
        private TextBox txb_num_agencia;
        private Label label26;
        private TextBox txb_num_conta;
        private Label label25;
        private ComboBox cb_status;
        private Label label21;
    }
}