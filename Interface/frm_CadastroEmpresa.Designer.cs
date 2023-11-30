namespace RHS_Folha_de_Pagamento.Interface
{
    partial class frm_CadastroEmpresa
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
            label9 = new Label();
            txb_Cnpj = new MaskedTextBox();
            txb_Telefone = new MaskedTextBox();
            btn_Fechar = new Button();
            btn_salvar = new Button();
            txb_quant_Func = new TextBox();
            label8 = new Label();
            txt_Area = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txb_Estado = new TextBox();
            label5 = new Label();
            txb_Cidade = new TextBox();
            label4 = new Label();
            txb_Logradouro = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txb_razao_Social = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonShadow;
            label9.Location = new Point(34, 157);
            label9.Name = "label9";
            label9.Size = new Size(282, 19);
            label9.TabIndex = 42;
            label9.Text = "Nome do lougradouro, n.º, complemento (se houver)";
            // 
            // txb_Cnpj
            // 
            txb_Cnpj.Location = new Point(467, 70);
            txb_Cnpj.Mask = "99,999,999/9999-99";
            txb_Cnpj.Name = "txb_Cnpj";
            txb_Cnpj.ResetOnSpace = false;
            txb_Cnpj.Size = new Size(159, 23);
            txb_Cnpj.TabIndex = 41;
            // 
            // txb_Telefone
            // 
            txb_Telefone.Location = new Point(34, 214);
            txb_Telefone.Mask = "(99) 00000-0000";
            txb_Telefone.Name = "txb_Telefone";
            txb_Telefone.ResetOnSpace = false;
            txb_Telefone.Size = new Size(109, 23);
            txb_Telefone.TabIndex = 40;
            // 
            // btn_Fechar
            // 
            btn_Fechar.Anchor = AnchorStyles.None;
            btn_Fechar.FlatAppearance.BorderSize = 0;
            btn_Fechar.FlatStyle = FlatStyle.Flat;
            btn_Fechar.Font = new Font("Bahnschrift SemiBold Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Fechar.ForeColor = Color.White;
            btn_Fechar.Location = new Point(609, 271);
            btn_Fechar.Name = "btn_Fechar";
            btn_Fechar.Size = new Size(75, 36);
            btn_Fechar.TabIndex = 39;
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
            btn_salvar.Location = new Point(517, 271);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 36);
            btn_salvar.TabIndex = 37;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // txb_quant_Func
            // 
            txb_quant_Func.Location = new Point(523, 214);
            txb_quant_Func.MaxLength = 15;
            txb_quant_Func.Name = "txb_quant_Func";
            txb_quant_Func.Size = new Size(129, 23);
            txb_quant_Func.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(523, 192);
            label8.Name = "label8";
            label8.Size = new Size(122, 19);
            label8.TabIndex = 35;
            label8.Text = "Total de Funcionários";
            // 
            // txt_Area
            // 
            txt_Area.Location = new Point(169, 214);
            txt_Area.MaxLength = 50;
            txt_Area.Name = "txt_Area";
            txt_Area.Size = new Size(328, 23);
            txt_Area.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(169, 192);
            label7.Name = "label7";
            label7.Size = new Size(96, 19);
            label7.TabIndex = 33;
            label7.Text = "Área de Atuação";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(34, 192);
            label6.Name = "label6";
            label6.Size = new Size(53, 19);
            label6.TabIndex = 32;
            label6.Text = "Telefone";
            // 
            // txb_Estado
            // 
            txb_Estado.Location = new Point(523, 132);
            txb_Estado.MaxLength = 30;
            txb_Estado.Name = "txb_Estado";
            txb_Estado.Size = new Size(129, 23);
            txb_Estado.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(523, 109);
            label5.Name = "label5";
            label5.Size = new Size(44, 19);
            label5.TabIndex = 30;
            label5.Text = "Estado";
            // 
            // txb_Cidade
            // 
            txb_Cidade.Location = new Point(381, 132);
            txb_Cidade.MaxLength = 30;
            txb_Cidade.Name = "txb_Cidade";
            txb_Cidade.Size = new Size(129, 23);
            txb_Cidade.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(381, 109);
            label4.Name = "label4";
            label4.Size = new Size(44, 19);
            label4.TabIndex = 28;
            label4.Text = "Cidade";
            // 
            // txb_Logradouro
            // 
            txb_Logradouro.Location = new Point(34, 131);
            txb_Logradouro.MaxLength = 50;
            txb_Logradouro.Name = "txb_Logradouro";
            txb_Logradouro.Size = new Size(328, 23);
            txb_Logradouro.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 108);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 26;
            label3.Text = "Logradouro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(467, 49);
            label1.Name = "label1";
            label1.Size = new Size(35, 19);
            label1.TabIndex = 25;
            label1.Text = "CNPJ";
            // 
            // txb_razao_Social
            // 
            txb_razao_Social.Location = new Point(34, 70);
            txb_razao_Social.MaxLength = 30;
            txb_razao_Social.Name = "txb_razao_Social";
            txb_razao_Social.Size = new Size(407, 23);
            txb_razao_Social.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 48);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 23;
            label2.Text = "Razão Social";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_Fechar);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txb_Cnpj);
            panel1.Controls.Add(txb_razao_Social);
            panel1.Controls.Add(txb_Telefone);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_salvar);
            panel1.Controls.Add(txb_Logradouro);
            panel1.Controls.Add(txb_quant_Func);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txb_Cidade);
            panel1.Controls.Add(txt_Area);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txb_Estado);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(22, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 312);
            panel1.TabIndex = 43;
            panel1.Paint += pintar_Borda;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(202, 11);
            label10.Name = "label10";
            label10.Size = new Size(301, 29);
            label10.TabIndex = 43;
            label10.Text = "Formulário de cadastro de Empresa";
            // 
            // frm_CadastroEmpresa
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 57, 69);
            ClientSize = new Size(740, 365);
            ControlBox = false;
            Controls.Add(label10);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frm_CadastroEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de cadastro de Empresa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private MaskedTextBox txb_Cnpj;
        private MaskedTextBox txb_Telefone;
        private Button btn_Fechar;
        private Button btn_salvar;
        private TextBox txb_quant_Func;
        private Label label8;
        private TextBox txt_Area;
        private Label label7;
        private Label label6;
        private TextBox txb_Estado;
        private Label label5;
        private TextBox txb_Cidade;
        private Label label4;
        private TextBox txb_Logradouro;
        private Label label3;
        private Label label1;
        private TextBox txb_razao_Social;
        private Label label2;
        private Panel panel1;
        private Label label10;
    }
}