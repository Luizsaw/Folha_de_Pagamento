namespace RHS_Folha_de_Pagamento.Interface
{
    partial class frm_FolhaPagamento
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FolhaPagamento));
            label1 = new Label();
            txb_Nome = new TextBox();
            btn_enviar = new Button();
            btn_Limpar = new Button();
            btn_Exit = new Button();
            pnl_Lancamentos = new Panel();
            label15 = new Label();
            label14 = new Label();
            pb_Ajuda = new PictureBox();
            cb_DescSim = new CheckBox();
            cb_Deducao = new ComboBox();
            cb_Remun = new ComboBox();
            label31 = new Label();
            dtp_calendario = new DateTimePicker();
            label17 = new Label();
            cb_Irrf = new ComboBox();
            cb_tipofolha = new ComboBox();
            cb_Inss = new ComboBox();
            label20 = new Label();
            label30 = new Label();
            txb_CargaHora = new TextBox();
            label29 = new Label();
            pnl_val_lancados = new Panel();
            label6 = new Label();
            lbl_valores = new Label();
            panel7 = new Panel();
            label25 = new Label();
            txb_Totalvencimentos = new TextBox();
            txb_Totaldescontos = new TextBox();
            label24 = new Label();
            label23 = new Label();
            txb_SalarioLiquid = new TextBox();
            txb_BaseCalFgts = new TextBox();
            txb_Fgts = new TextBox();
            txb_BaseCalInss = new TextBox();
            label28 = new Label();
            label33 = new Label();
            txb_Irrf = new TextBox();
            txb_BaseCalIrrf = new TextBox();
            label27 = new Label();
            label32 = new Label();
            label26 = new Label();
            lsv_Lancamentos = new ListView();
            pnl_DadosEmp = new Panel();
            txb_Razao = new TextBox();
            label7 = new Label();
            txb_Id = new TextBox();
            label9 = new Label();
            txb_Cnpj = new TextBox();
            label10 = new Label();
            pnl_DadosFunc = new Panel();
            label22 = new Label();
            txb_Conta = new TextBox();
            label19 = new Label();
            txb_Agencia = new TextBox();
            label18 = new Label();
            txb_Banco = new TextBox();
            label13 = new Label();
            txb_Depen = new TextBox();
            label12 = new Label();
            txb_Salario = new TextBox();
            label5 = new Label();
            txb_Depart = new TextBox();
            txb_Mat = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txb_Admissao = new TextBox();
            txb_Cargo = new TextBox();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            panel2 = new Panel();
            panel1 = new Panel();
            pnl_Lancamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Ajuda).BeginInit();
            pnl_val_lancados.SuspendLayout();
            panel7.SuspendLayout();
            pnl_DadosEmp.SuspendLayout();
            pnl_DadosFunc.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(45, 57, 69);
            label1.Location = new Point(83, 17);
            label1.Name = "label1";
            label1.Size = new Size(119, 19);
            label1.TabIndex = 0;
            label1.Text = "Nome do Funcionário";
            // 
            // txb_Nome
            // 
            txb_Nome.Location = new Point(87, 39);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(441, 23);
            txb_Nome.TabIndex = 1;
            // 
            // btn_enviar
            // 
            btn_enviar.FlatAppearance.BorderColor = Color.White;
            btn_enviar.FlatStyle = FlatStyle.Flat;
            btn_enviar.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_enviar.ForeColor = Color.FromArgb(45, 57, 69);
            btn_enviar.Location = new Point(140, 7);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(93, 37);
            btn_enviar.TabIndex = 2;
            btn_enviar.Text = "Emitir";
            btn_enviar.UseVisualStyleBackColor = true;
            btn_enviar.Visible = false;
            btn_enviar.Click += btnGerarPDF_Click;
            // 
            // btn_Limpar
            // 
            btn_Limpar.FlatAppearance.BorderColor = Color.White;
            btn_Limpar.FlatStyle = FlatStyle.Flat;
            btn_Limpar.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpar.ForeColor = Color.FromArgb(45, 57, 69);
            btn_Limpar.Location = new Point(11, 7);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(93, 37);
            btn_Limpar.TabIndex = 1;
            btn_Limpar.Text = "Apagar";
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Visible = false;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.FlatAppearance.BorderColor = Color.White;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Exit.ForeColor = Color.FromArgb(45, 57, 69);
            btn_Exit.Location = new Point(268, 6);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(93, 37);
            btn_Exit.TabIndex = 1;
            btn_Exit.Text = "Fechar";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Visible = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // pnl_Lancamentos
            // 
            pnl_Lancamentos.Anchor = AnchorStyles.None;
            pnl_Lancamentos.BackColor = Color.FromArgb(186, 194, 204);
            pnl_Lancamentos.BorderStyle = BorderStyle.FixedSingle;
            pnl_Lancamentos.Controls.Add(label15);
            pnl_Lancamentos.Controls.Add(label14);
            pnl_Lancamentos.Controls.Add(pb_Ajuda);
            pnl_Lancamentos.Controls.Add(cb_DescSim);
            pnl_Lancamentos.Controls.Add(cb_Deducao);
            pnl_Lancamentos.Controls.Add(cb_Remun);
            pnl_Lancamentos.Controls.Add(label31);
            pnl_Lancamentos.Controls.Add(dtp_calendario);
            pnl_Lancamentos.Controls.Add(label17);
            pnl_Lancamentos.Controls.Add(cb_Irrf);
            pnl_Lancamentos.Controls.Add(cb_tipofolha);
            pnl_Lancamentos.Controls.Add(cb_Inss);
            pnl_Lancamentos.Controls.Add(label20);
            pnl_Lancamentos.Controls.Add(label30);
            pnl_Lancamentos.Location = new Point(11, 353);
            pnl_Lancamentos.Name = "pnl_Lancamentos";
            pnl_Lancamentos.Size = new Size(548, 175);
            pnl_Lancamentos.TabIndex = 12;
            pnl_Lancamentos.Visible = false;
            pnl_Lancamentos.Paint += pintar_Borda;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(45, 57, 69);
            label15.Location = new Point(172, 51);
            label15.Name = "label15";
            label15.Size = new Size(91, 19);
            label15.TabIndex = 32;
            label15.Text = "Remunerações:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(45, 57, 69);
            label14.Location = new Point(201, 16);
            label14.Name = "label14";
            label14.Size = new Size(62, 19);
            label14.TabIndex = 25;
            label14.Text = "Deduções:";
            // 
            // pb_Ajuda
            // 
            pb_Ajuda.Image = (Image)resources.GetObject("pb_Ajuda.Image");
            pb_Ajuda.Location = new Point(484, 120);
            pb_Ajuda.Name = "pb_Ajuda";
            pb_Ajuda.Size = new Size(26, 26);
            pb_Ajuda.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Ajuda.TabIndex = 30;
            pb_Ajuda.TabStop = false;
            // 
            // cb_DescSim
            // 
            cb_DescSim.AutoSize = true;
            cb_DescSim.Enabled = false;
            cb_DescSim.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cb_DescSim.ForeColor = Color.FromArgb(45, 57, 69);
            cb_DescSim.Location = new Point(310, 122);
            cb_DescSim.Name = "cb_DescSim";
            cb_DescSim.Size = new Size(170, 23);
            cb_DescSim.TabIndex = 31;
            cb_DescSim.Text = "IRRF Desconto Simplificado";
            cb_DescSim.UseVisualStyleBackColor = true;
            cb_DescSim.CheckedChanged += cb_DescSimplificadoChanged;
            // 
            // cb_Deducao
            // 
            cb_Deducao.Enabled = false;
            cb_Deducao.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Deducao.ForeColor = Color.FromArgb(45, 57, 69);
            cb_Deducao.FormattingEnabled = true;
            cb_Deducao.Items.AddRange(new object[] { "Plano de Saúde", "Atrasos", "Faltas", "Vale Transporte", "Outros" });
            cb_Deducao.Location = new Point(269, 13);
            cb_Deducao.Name = "cb_Deducao";
            cb_Deducao.Size = new Size(121, 28);
            cb_Deducao.TabIndex = 21;
            cb_Deducao.SelectedIndexChanged += cb_Deducao_SelectedIndexChanged;
            // 
            // cb_Remun
            // 
            cb_Remun.Enabled = false;
            cb_Remun.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Remun.ForeColor = Color.FromArgb(45, 57, 69);
            cb_Remun.FormattingEnabled = true;
            cb_Remun.Items.AddRange(new object[] { "Hora Extras", "Salario Familia", "Adicionais", "Outros" });
            cb_Remun.Location = new Point(269, 47);
            cb_Remun.Name = "cb_Remun";
            cb_Remun.Size = new Size(121, 28);
            cb_Remun.TabIndex = 19;
            cb_Remun.SelectedIndexChanged += cb_Remuneracao_SelectedIndexChanged;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label31.ForeColor = Color.FromArgb(45, 57, 69);
            label31.Location = new Point(11, 125);
            label31.Name = "label31";
            label31.Size = new Size(34, 19);
            label31.TabIndex = 27;
            label31.Text = "IRRF:";
            // 
            // dtp_calendario
            // 
            dtp_calendario.CalendarForeColor = Color.FromArgb(162, 168, 186);
            dtp_calendario.CalendarTitleForeColor = Color.FromArgb(45, 57, 69);
            dtp_calendario.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_calendario.Format = DateTimePickerFormat.Short;
            dtp_calendario.Location = new Point(50, 48);
            dtp_calendario.Name = "dtp_calendario";
            dtp_calendario.Size = new Size(100, 26);
            dtp_calendario.TabIndex = 16;
            dtp_calendario.Value = new DateTime(2023, 10, 18, 0, 0, 0, 0);
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(45, 57, 69);
            label17.Location = new Point(3, 17);
            label17.Name = "label17";
            label17.Size = new Size(42, 19);
            label17.TabIndex = 15;
            label17.Text = "Folha:";
            // 
            // cb_Irrf
            // 
            cb_Irrf.Enabled = false;
            cb_Irrf.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Irrf.ForeColor = Color.FromArgb(45, 57, 69);
            cb_Irrf.Items.AddRange(new object[] { "Maio/2023" });
            cb_Irrf.Location = new Point(50, 122);
            cb_Irrf.Name = "cb_Irrf";
            cb_Irrf.Size = new Size(121, 28);
            cb_Irrf.TabIndex = 2;
            cb_Irrf.Text = "Mês/Ano";
            cb_Irrf.SelectedIndexChanged += cb_Irrf_SelectedIndexChanged;
            // 
            // cb_tipofolha
            // 
            cb_tipofolha.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_tipofolha.ForeColor = Color.FromArgb(45, 57, 69);
            cb_tipofolha.FormattingEnabled = true;
            cb_tipofolha.Items.AddRange(new object[] { "Mensal", "Semanal", "Quizenal" });
            cb_tipofolha.Location = new Point(50, 14);
            cb_tipofolha.Name = "cb_tipofolha";
            cb_tipofolha.Size = new Size(96, 28);
            cb_tipofolha.TabIndex = 14;
            // 
            // cb_Inss
            // 
            cb_Inss.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Inss.ForeColor = Color.FromArgb(45, 57, 69);
            cb_Inss.Items.AddRange(new object[] { "Maio/2023" });
            cb_Inss.Location = new Point(50, 84);
            cb_Inss.Name = "cb_Inss";
            cb_Inss.Size = new Size(121, 28);
            cb_Inss.TabIndex = 26;
            cb_Inss.Text = "Mês/Ano";
            cb_Inss.SelectedIndexChanged += cb_Inss_SelectedIndexChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.FromArgb(45, 57, 69);
            label20.Location = new Point(8, 48);
            label20.Name = "label20";
            label20.Size = new Size(37, 19);
            label20.TabIndex = 4;
            label20.Text = "Data:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label30.ForeColor = Color.FromArgb(45, 57, 69);
            label30.Location = new Point(9, 87);
            label30.Name = "label30";
            label30.Size = new Size(36, 19);
            label30.TabIndex = 25;
            label30.Text = "INSS:";
            // 
            // txb_CargaHora
            // 
            txb_CargaHora.Location = new Point(299, 146);
            txb_CargaHora.Name = "txb_CargaHora";
            txb_CargaHora.Size = new Size(106, 23);
            txb_CargaHora.TabIndex = 24;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label29.ForeColor = Color.FromArgb(45, 57, 69);
            label29.Location = new Point(295, 123);
            label29.Name = "label29";
            label29.Size = new Size(84, 19);
            label29.TabIndex = 23;
            label29.Text = "Carga Horária";
            // 
            // pnl_val_lancados
            // 
            pnl_val_lancados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnl_val_lancados.Controls.Add(label6);
            pnl_val_lancados.Controls.Add(lbl_valores);
            pnl_val_lancados.Controls.Add(panel7);
            pnl_val_lancados.Controls.Add(lsv_Lancamentos);
            pnl_val_lancados.Location = new Point(599, 13);
            pnl_val_lancados.Name = "pnl_val_lancados";
            pnl_val_lancados.Size = new Size(777, 584);
            pnl_val_lancados.TabIndex = 22;
            pnl_val_lancados.Visible = false;
            pnl_val_lancados.Paint += pintar_Borda;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(353, 439);
            label6.Name = "label6";
            label6.Size = new Size(114, 19);
            label6.TabIndex = 29;
            label6.Text = "Valores CaLculados";
            // 
            // lbl_valores
            // 
            lbl_valores.AutoSize = true;
            lbl_valores.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_valores.Location = new Point(350, 7);
            lbl_valores.Name = "lbl_valores";
            lbl_valores.Size = new Size(103, 19);
            lbl_valores.TabIndex = 25;
            lbl_valores.Text = "Valores Lançados";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(186, 194, 204);
            panel7.Controls.Add(label25);
            panel7.Controls.Add(txb_Totalvencimentos);
            panel7.Controls.Add(txb_Totaldescontos);
            panel7.Controls.Add(label24);
            panel7.Controls.Add(label23);
            panel7.Controls.Add(txb_SalarioLiquid);
            panel7.Controls.Add(txb_BaseCalFgts);
            panel7.Controls.Add(txb_Fgts);
            panel7.Controls.Add(txb_BaseCalInss);
            panel7.Controls.Add(label28);
            panel7.Controls.Add(label33);
            panel7.Controls.Add(txb_Irrf);
            panel7.Controls.Add(txb_BaseCalIrrf);
            panel7.Controls.Add(label27);
            panel7.Controls.Add(label32);
            panel7.Controls.Add(label26);
            panel7.Location = new Point(7, 465);
            panel7.Name = "panel7";
            panel7.Size = new Size(763, 112);
            panel7.TabIndex = 28;
            panel7.Paint += pintar_Borda;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label25.ForeColor = Color.FromArgb(45, 57, 69);
            label25.Location = new Point(570, 55);
            label25.Name = "label25";
            label25.Size = new Size(98, 20);
            label25.TabIndex = 37;
            label25.Text = "Salário Líquido";
            // 
            // txb_Totalvencimentos
            // 
            txb_Totalvencimentos.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Totalvencimentos.ForeColor = Color.FromArgb(45, 57, 69);
            txb_Totalvencimentos.Location = new Point(482, 26);
            txb_Totalvencimentos.Name = "txb_Totalvencimentos";
            txb_Totalvencimentos.Size = new Size(130, 26);
            txb_Totalvencimentos.TabIndex = 33;
            txb_Totalvencimentos.TextAlign = HorizontalAlignment.Center;
            // 
            // txb_Totaldescontos
            // 
            txb_Totaldescontos.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Totaldescontos.ForeColor = Color.FromArgb(45, 57, 69);
            txb_Totaldescontos.Location = new Point(620, 26);
            txb_Totaldescontos.Name = "txb_Totaldescontos";
            txb_Totaldescontos.Size = new Size(132, 26);
            txb_Totaldescontos.TabIndex = 34;
            txb_Totaldescontos.TextAlign = HorizontalAlignment.Center;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = Color.FromArgb(45, 57, 69);
            label24.Location = new Point(632, 4);
            label24.Name = "label24";
            label24.Size = new Size(105, 20);
            label24.TabIndex = 38;
            label24.Text = "Total Descontos";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.FromArgb(186, 194, 204);
            label23.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.FromArgb(45, 57, 69);
            label23.Location = new Point(488, 4);
            label23.Name = "label23";
            label23.Size = new Size(119, 20);
            label23.TabIndex = 36;
            label23.Text = "Total Vencimentos";
            // 
            // txb_SalarioLiquid
            // 
            txb_SalarioLiquid.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_SalarioLiquid.ForeColor = Color.FromArgb(45, 57, 69);
            txb_SalarioLiquid.Location = new Point(486, 78);
            txb_SalarioLiquid.Name = "txb_SalarioLiquid";
            txb_SalarioLiquid.Size = new Size(261, 26);
            txb_SalarioLiquid.TabIndex = 35;
            txb_SalarioLiquid.TextAlign = HorizontalAlignment.Center;
            // 
            // txb_BaseCalFgts
            // 
            txb_BaseCalFgts.BorderStyle = BorderStyle.None;
            txb_BaseCalFgts.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_BaseCalFgts.ForeColor = Color.FromArgb(45, 57, 69);
            txb_BaseCalFgts.Location = new Point(317, 30);
            txb_BaseCalFgts.Name = "txb_BaseCalFgts";
            txb_BaseCalFgts.Size = new Size(151, 19);
            txb_BaseCalFgts.TabIndex = 32;
            txb_BaseCalFgts.TextAlign = HorizontalAlignment.Center;
            // 
            // txb_Fgts
            // 
            txb_Fgts.BorderStyle = BorderStyle.None;
            txb_Fgts.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Fgts.ForeColor = Color.FromArgb(45, 57, 69);
            txb_Fgts.Location = new Point(317, 82);
            txb_Fgts.Name = "txb_Fgts";
            txb_Fgts.Size = new Size(152, 19);
            txb_Fgts.TabIndex = 27;
            txb_Fgts.TextAlign = HorizontalAlignment.Center;
            // 
            // txb_BaseCalInss
            // 
            txb_BaseCalInss.BorderStyle = BorderStyle.None;
            txb_BaseCalInss.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_BaseCalInss.ForeColor = Color.FromArgb(45, 57, 69);
            txb_BaseCalInss.Location = new Point(153, 30);
            txb_BaseCalInss.Name = "txb_BaseCalInss";
            txb_BaseCalInss.Size = new Size(144, 19);
            txb_BaseCalInss.TabIndex = 29;
            txb_BaseCalInss.TextAlign = HorizontalAlignment.Center;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label28.ForeColor = Color.FromArgb(45, 57, 69);
            label28.Location = new Point(376, 55);
            label28.Name = "label28";
            label28.Size = new Size(43, 20);
            label28.TabIndex = 24;
            label28.Text = "FGTS";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label33.ForeColor = Color.FromArgb(45, 57, 69);
            label33.Location = new Point(159, 4);
            label33.Name = "label33";
            label33.Size = new Size(144, 20);
            label33.TabIndex = 23;
            label33.Text = "Sal. Contribuição INSS";
            // 
            // txb_Irrf
            // 
            txb_Irrf.BorderStyle = BorderStyle.None;
            txb_Irrf.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Irrf.ForeColor = Color.FromArgb(45, 57, 69);
            txb_Irrf.Location = new Point(4, 82);
            txb_Irrf.Name = "txb_Irrf";
            txb_Irrf.Size = new Size(130, 19);
            txb_Irrf.TabIndex = 3;
            txb_Irrf.TextAlign = HorizontalAlignment.Center;
            // 
            // txb_BaseCalIrrf
            // 
            txb_BaseCalIrrf.BorderStyle = BorderStyle.None;
            txb_BaseCalIrrf.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_BaseCalIrrf.ForeColor = Color.FromArgb(45, 57, 69);
            txb_BaseCalIrrf.Location = new Point(3, 30);
            txb_BaseCalIrrf.Name = "txb_BaseCalIrrf";
            txb_BaseCalIrrf.Size = new Size(130, 19);
            txb_BaseCalIrrf.TabIndex = 28;
            txb_BaseCalIrrf.TextAlign = HorizontalAlignment.Center;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label27.ForeColor = Color.FromArgb(45, 57, 69);
            label27.Location = new Point(29, 55);
            label27.Name = "label27";
            label27.Size = new Size(74, 20);
            label27.TabIndex = 25;
            label27.Text = "Faixa IRRF";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label32.ForeColor = Color.FromArgb(45, 57, 69);
            label32.Location = new Point(334, 4);
            label32.Name = "label32";
            label32.Size = new Size(126, 20);
            label32.TabIndex = 23;
            label32.Text = "Base Cálculo FGTS";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label26.ForeColor = Color.FromArgb(45, 57, 69);
            label26.Location = new Point(7, 4);
            label26.Name = "label26";
            label26.Size = new Size(121, 20);
            label26.TabIndex = 22;
            label26.Text = "Base Cálculo IRRF";
            // 
            // lsv_Lancamentos
            // 
            lsv_Lancamentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lsv_Lancamentos.AutoArrange = false;
            lsv_Lancamentos.BackColor = Color.FromArgb(186, 194, 204);
            lsv_Lancamentos.Location = new Point(7, 34);
            lsv_Lancamentos.Name = "lsv_Lancamentos";
            lsv_Lancamentos.Size = new Size(763, 398);
            lsv_Lancamentos.TabIndex = 0;
            lsv_Lancamentos.UseCompatibleStateImageBehavior = false;
            // 
            // pnl_DadosEmp
            // 
            pnl_DadosEmp.Anchor = AnchorStyles.None;
            pnl_DadosEmp.BackColor = Color.FromArgb(186, 194, 204);
            pnl_DadosEmp.BorderStyle = BorderStyle.FixedSingle;
            pnl_DadosEmp.Controls.Add(txb_Razao);
            pnl_DadosEmp.Controls.Add(label7);
            pnl_DadosEmp.Controls.Add(txb_Id);
            pnl_DadosEmp.Controls.Add(label9);
            pnl_DadosEmp.Controls.Add(txb_Cnpj);
            pnl_DadosEmp.Controls.Add(label10);
            pnl_DadosEmp.Location = new Point(11, 9);
            pnl_DadosEmp.Name = "pnl_DadosEmp";
            pnl_DadosEmp.Size = new Size(546, 101);
            pnl_DadosEmp.TabIndex = 11;
            pnl_DadosEmp.Visible = false;
            pnl_DadosEmp.Paint += pintar_Borda;
            // 
            // txb_Razao
            // 
            txb_Razao.Location = new Point(7, 39);
            txb_Razao.Name = "txb_Razao";
            txb_Razao.Size = new Size(521, 23);
            txb_Razao.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(45, 57, 69);
            label7.Location = new Point(5, 15);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 0;
            label7.Text = "Razão Social";
            // 
            // txb_Id
            // 
            txb_Id.Location = new Point(33, 69);
            txb_Id.Name = "txb_Id";
            txb_Id.Size = new Size(39, 23);
            txb_Id.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(45, 57, 69);
            label9.Location = new Point(7, 70);
            label9.Name = "label9";
            label9.Size = new Size(22, 19);
            label9.TabIndex = 2;
            label9.Text = "ID:";
            // 
            // txb_Cnpj
            // 
            txb_Cnpj.Location = new Point(158, 70);
            txb_Cnpj.Name = "txb_Cnpj";
            txb_Cnpj.Size = new Size(167, 23);
            txb_Cnpj.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(45, 57, 69);
            label10.Location = new Point(106, 71);
            label10.Name = "label10";
            label10.Size = new Size(38, 19);
            label10.TabIndex = 4;
            label10.Text = "CNPJ:";
            // 
            // pnl_DadosFunc
            // 
            pnl_DadosFunc.Anchor = AnchorStyles.None;
            pnl_DadosFunc.BackColor = Color.FromArgb(186, 194, 204);
            pnl_DadosFunc.BorderStyle = BorderStyle.FixedSingle;
            pnl_DadosFunc.Controls.Add(label22);
            pnl_DadosFunc.Controls.Add(txb_CargaHora);
            pnl_DadosFunc.Controls.Add(txb_Conta);
            pnl_DadosFunc.Controls.Add(label29);
            pnl_DadosFunc.Controls.Add(label19);
            pnl_DadosFunc.Controls.Add(txb_Agencia);
            pnl_DadosFunc.Controls.Add(label18);
            pnl_DadosFunc.Controls.Add(txb_Banco);
            pnl_DadosFunc.Controls.Add(label13);
            pnl_DadosFunc.Controls.Add(txb_Depen);
            pnl_DadosFunc.Controls.Add(label12);
            pnl_DadosFunc.Controls.Add(txb_Salario);
            pnl_DadosFunc.Controls.Add(txb_Nome);
            pnl_DadosFunc.Controls.Add(label5);
            pnl_DadosFunc.Controls.Add(label1);
            pnl_DadosFunc.Controls.Add(txb_Depart);
            pnl_DadosFunc.Controls.Add(txb_Mat);
            pnl_DadosFunc.Controls.Add(label4);
            pnl_DadosFunc.Controls.Add(label2);
            pnl_DadosFunc.Controls.Add(txb_Admissao);
            pnl_DadosFunc.Controls.Add(txb_Cargo);
            pnl_DadosFunc.Controls.Add(label3);
            pnl_DadosFunc.ForeColor = Color.White;
            pnl_DadosFunc.Location = new Point(11, 116);
            pnl_DadosFunc.Name = "pnl_DadosFunc";
            pnl_DadosFunc.Size = new Size(547, 232);
            pnl_DadosFunc.TabIndex = 10;
            pnl_DadosFunc.Visible = false;
            pnl_DadosFunc.Paint += pintar_Borda;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.FromArgb(45, 57, 69);
            label22.Location = new Point(277, 175);
            label22.Name = "label22";
            label22.Size = new Size(40, 19);
            label22.TabIndex = 18;
            label22.Text = "Conta";
            // 
            // txb_Conta
            // 
            txb_Conta.Location = new Point(279, 196);
            txb_Conta.Name = "txb_Conta";
            txb_Conta.Size = new Size(126, 23);
            txb_Conta.TabIndex = 19;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(45, 57, 69);
            label19.Location = new Point(154, 175);
            label19.Name = "label19";
            label19.Size = new Size(51, 19);
            label19.TabIndex = 16;
            label19.Text = "Agência";
            // 
            // txb_Agencia
            // 
            txb_Agencia.Location = new Point(154, 196);
            txb_Agencia.Name = "txb_Agencia";
            txb_Agencia.Size = new Size(102, 23);
            txb_Agencia.TabIndex = 17;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(45, 57, 69);
            label18.Location = new Point(8, 175);
            label18.Name = "label18";
            label18.Size = new Size(42, 19);
            label18.TabIndex = 14;
            label18.Text = "Banco";
            // 
            // txb_Banco
            // 
            txb_Banco.Location = new Point(7, 196);
            txb_Banco.Name = "txb_Banco";
            txb_Banco.Size = new Size(132, 23);
            txb_Banco.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(45, 57, 69);
            label13.Location = new Point(160, 120);
            label13.Name = "label13";
            label13.Size = new Size(76, 19);
            label13.TabIndex = 12;
            label13.Text = "Dependentes";
            // 
            // txb_Depen
            // 
            txb_Depen.Location = new Point(162, 145);
            txb_Depen.Name = "txb_Depen";
            txb_Depen.Size = new Size(102, 23);
            txb_Depen.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(45, 57, 69);
            label12.Location = new Point(8, 121);
            label12.Name = "label12";
            label12.Size = new Size(77, 19);
            label12.TabIndex = 10;
            label12.Text = "Salário Base";
            // 
            // txb_Salario
            // 
            txb_Salario.Location = new Point(8, 145);
            txb_Salario.Name = "txb_Salario";
            txb_Salario.Size = new Size(131, 23);
            txb_Salario.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(45, 57, 69);
            label5.Location = new Point(360, 66);
            label5.Name = "label5";
            label5.Size = new Size(84, 19);
            label5.TabIndex = 8;
            label5.Text = "Departamento";
            // 
            // txb_Depart
            // 
            txb_Depart.Location = new Point(363, 90);
            txb_Depart.Name = "txb_Depart";
            txb_Depart.Size = new Size(165, 23);
            txb_Depart.TabIndex = 9;
            // 
            // txb_Mat
            // 
            txb_Mat.Location = new Point(8, 39);
            txb_Mat.Name = "txb_Mat";
            txb_Mat.Size = new Size(73, 23);
            txb_Mat.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(45, 57, 69);
            label4.Location = new Point(262, 67);
            label4.Name = "label4";
            label4.Size = new Size(60, 19);
            label4.TabIndex = 6;
            label4.Text = "Admissão";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(45, 57, 69);
            label2.Location = new Point(6, 17);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 2;
            label2.Text = "Matrícula";
            // 
            // txb_Admissao
            // 
            txb_Admissao.Location = new Point(262, 90);
            txb_Admissao.Name = "txb_Admissao";
            txb_Admissao.Size = new Size(85, 23);
            txb_Admissao.TabIndex = 7;
            // 
            // txb_Cargo
            // 
            txb_Cargo.Location = new Point(8, 90);
            txb_Cargo.Name = "txb_Cargo";
            txb_Cargo.Size = new Size(239, 23);
            txb_Cargo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(45, 57, 69);
            label3.Location = new Point(5, 68);
            label3.Name = "label3";
            label3.Size = new Size(40, 19);
            label3.TabIndex = 4;
            label3.Text = "Cargo";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(186, 194, 204);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_Limpar);
            panel2.Controls.Add(btn_Exit);
            panel2.Controls.Add(btn_enviar);
            panel2.Location = new Point(82, 532);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 48);
            panel2.TabIndex = 23;
            panel2.Paint += pintar_Borda;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnl_DadosEmp);
            panel1.Controls.Add(pnl_DadosFunc);
            panel1.Controls.Add(pnl_Lancamentos);
            panel1.Location = new Point(23, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 584);
            panel1.TabIndex = 24;
            // 
            // frm_FolhaPagamento
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 57, 69);
            ClientSize = new Size(1392, 609);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(pnl_val_lancados);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_FolhaPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lançamentos";
            Load += frm_FolhaPagamento_Load;
            pnl_Lancamentos.ResumeLayout(false);
            pnl_Lancamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Ajuda).EndInit();
            pnl_val_lancados.ResumeLayout(false);
            pnl_val_lancados.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            pnl_DadosEmp.ResumeLayout(false);
            pnl_DadosEmp.PerformLayout();
            pnl_DadosFunc.ResumeLayout(false);
            pnl_DadosFunc.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox txb_Nome;
        private Label label1;
        private Label label5;
        private TextBox txb_Depart;
        private Label label4;
        private TextBox txb_Admissao;
        private Label label3;
        private TextBox txb_Cargo;
        private Label label2;
        private TextBox txb_Mat;
        private Panel pnl_DadosEmp;
        private TextBox txb_Razao;
        private Label label7;
        private TextBox txb_Id;
        private Label label9;
        private TextBox txb_Cnpj;
        private Label label10;
        private Panel pnl_DadosFunc;
        private Label label13;
        private TextBox txb_Depen;
        private Label label12;
        private TextBox txb_Salario;
        private Panel pnl_Lancamentos;
        private Label label20;
        private ComboBox cb_tipofolha;
        private Label label17;
        private DateTimePicker dtp_calendario;
        private ComboBox cb_Remun;
        private Panel pnl_val_lancados;
        private ListView lsv_Lancamentos;
        private ComboBox cb_Deducao;
        private Button btn_Limpar;
        private Button btn_Exit;
        private Label label22;
        private TextBox txb_Conta;
        private Label label19;
        private TextBox txb_Agencia;
        private Label label18;
        private TextBox txb_Banco;
        private TextBox txb_CargaHora;
        private Label label29;
        private Label label31;
        private ComboBox cb_Inss;
        private Label label30;
        private ComboBox cb_Irrf;
        private ToolTip toolTip1;
        private CheckBox cb_DescSim;
        private Label label15;
        private Label label14;
        private Button btn_enviar;
        private TextBox txb_BaseCalFgts;
        private TextBox txb_BaseCalIrrf;
        private Label label32;
        private Label label33;
        private TextBox txb_BaseCalInss;
        private Label label26;
        private Panel panel7;
        private TextBox txb_Fgts;
        private Label label28;
        private TextBox txb_Irrf;
        private Label label27;
        private PictureBox pb_Ajuda;
        private Label label25;
        private TextBox txb_Totalvencimentos;
        private TextBox txb_Totaldescontos;
        private Label label24;
        private Label label23;
        private TextBox txb_SalarioLiquid;
        private Panel panel2;
        private Panel panel1;
        private Label lbl_valores;
        private Label label6;
    }
}