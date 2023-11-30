namespace RHS_Folha_de_Pagamento.Interface
{
    partial class frm_Adicionais
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
            btn_ok = new Button();
            tb_valor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txb_cargaHoraria = new TextBox();
            label7 = new Label();
            txb_salario = new TextBox();
            Sa = new Label();
            label6 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            txb_percentual = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label4 = new Label();
            txb_horas = new TextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_ok
            // 
            btn_ok.FlatStyle = FlatStyle.Flat;
            btn_ok.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ok.ForeColor = Color.FromArgb(186, 194, 204);
            btn_ok.Location = new Point(170, 205);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(61, 28);
            btn_ok.TabIndex = 0;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // tb_valor
            // 
            tb_valor.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_valor.Location = new Point(90, 71);
            tb_valor.Name = "tb_valor";
            tb_valor.Size = new Size(77, 26);
            tb_valor.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(186, 194, 204);
            label1.Location = new Point(51, 75);
            label1.Name = "label1";
            label1.Size = new Size(37, 19);
            label1.TabIndex = 5;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(186, 194, 204);
            label2.Location = new Point(50, 99);
            label2.Name = "label2";
            label2.Size = new Size(151, 17);
            label2.TabIndex = 6;
            label2.Text = "em porcentagem(Ex: 10, 20, 30)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(186, 194, 204);
            label3.Location = new Point(170, 74);
            label3.Name = "label3";
            label3.Size = new Size(18, 19);
            label3.TabIndex = 7;
            label3.Text = "%";
            // 
            // txb_cargaHoraria
            // 
            txb_cargaHoraria.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_cargaHoraria.Location = new Point(166, 78);
            txb_cargaHoraria.Name = "txb_cargaHoraria";
            txb_cargaHoraria.Size = new Size(143, 26);
            txb_cargaHoraria.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(186, 194, 204);
            label7.Location = new Point(32, 82);
            label7.Name = "label7";
            label7.Size = new Size(129, 19);
            label7.TabIndex = 12;
            label7.Text = "Carga Horária Mensal:";
            // 
            // txb_salario
            // 
            txb_salario.Enabled = false;
            txb_salario.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_salario.Location = new Point(166, 36);
            txb_salario.Name = "txb_salario";
            txb_salario.Size = new Size(143, 26);
            txb_salario.TabIndex = 17;
            // 
            // Sa
            // 
            Sa.AutoSize = true;
            Sa.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Sa.ForeColor = Color.FromArgb(186, 194, 204);
            Sa.Location = new Point(110, 39);
            Sa.Name = "Sa";
            Sa.Size = new Size(51, 19);
            Sa.TabIndex = 16;
            Sa.Text = "Salário:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiBold Condensed", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(468, 32);
            label6.Name = "label6";
            label6.Size = new Size(183, 23);
            label6.TabIndex = 19;
            label6.Text = "Adicional de insalubridade ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiBold Condensed", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(165, 33);
            label8.Name = "label8";
            label8.Size = new Size(125, 23);
            label8.TabIndex = 20;
            label8.Text = "Adicional noturno ";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txb_percentual);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txb_cargaHoraria);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txb_salario);
            panel1.Controls.Add(txb_horas);
            panel1.Controls.Add(Sa);
            panel1.Location = new Point(31, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 249);
            panel1.TabIndex = 21;
            panel1.Paint += pintar_Borda;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiBold Condensed", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(186, 194, 204);
            label5.Location = new Point(170, 193);
            label5.Name = "label5";
            label5.Size = new Size(136, 17);
            label5.TabIndex = 18;
            label5.Text = "em porcentagem(Ex: 20, 25)";
            // 
            // txb_percentual
            // 
            txb_percentual.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_percentual.Location = new Point(169, 164);
            txb_percentual.Name = "txb_percentual";
            txb_percentual.Size = new Size(140, 26);
            txb_percentual.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(186, 194, 204);
            label9.Location = new Point(94, 168);
            label9.Name = "label9";
            label9.Size = new Size(67, 19);
            label9.TabIndex = 9;
            label9.Text = "Percentual";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(186, 194, 204);
            label10.Location = new Point(313, 168);
            label10.Name = "label10";
            label10.Size = new Size(18, 19);
            label10.TabIndex = 10;
            label10.Text = "%";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(186, 194, 204);
            label4.Location = new Point(66, 125);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 14;
            label4.Text = "Horas Noturnas:";
            // 
            // txb_horas
            // 
            txb_horas.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_horas.Location = new Point(169, 121);
            txb_horas.Name = "txb_horas";
            txb_horas.Size = new Size(140, 26);
            txb_horas.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.AutoSize = true;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tb_valor);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btn_ok);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(431, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 249);
            panel2.TabIndex = 22;
            panel2.Paint += pintar_Borda;
            // 
            // frm_Adicionais
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 57, 69);
            ClientSize = new Size(697, 306);
            ControlBox = false;
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frm_Adicionais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionais";
            Load += frm_Adicionais_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ok;
        private TextBox tb_valor;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txb_cargaHoraria;
        private Label label7;
        private TextBox txb_salario;
        private Label Sa;
        private Label label6;
        private Label label8;
        private Panel panel1;
        private Panel panel2;
        private TextBox txb_percentual;
        private Label label9;
        private Label label10;
        private Label label4;
        private TextBox txb_horas;
        private Label label5;

        public string set_RemunBase
        {
            set { txb_salario.Text = value; }
        }
        public string set_cargaHoraria
        {
            set { txb_cargaHoraria.Text = value; }
        }
        public TextBox get_cargaHoraria
        {
            get { return txb_cargaHoraria; }
        }
        public TextBox get_horas
        {
            get { return txb_horas; }
        }
        public TextBox get_valor
        {
            get { return tb_valor; }
        }
        public TextBox get_percentual
        {
            get { return txb_percentual; }
        }
    }
}