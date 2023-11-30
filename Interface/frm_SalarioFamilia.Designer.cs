namespace RHS_Folha_de_Pagamento.Interface
{
    partial class frm_SalarioFamilia
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
            cb_Ano = new ComboBox();
            label1 = new Label();
            txb_Numfilhos = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txb_RemunBase = new TextBox();
            label4 = new Label();
            txb_Valorunit = new TextBox();
            btn_ok = new Button();
            txb_Remunate = new TextBox();
            label5 = new Label();
            txb_Remunde = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // cb_Ano
            // 
            cb_Ano.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Ano.FormattingEnabled = true;
            cb_Ano.Location = new Point(121, 9);
            cb_Ano.Name = "cb_Ano";
            cb_Ano.Size = new Size(124, 28);
            cb_Ano.TabIndex = 0;
            cb_Ano.SelectedIndexChanged += cb_Ano_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(186, 194, 204);
            label1.Location = new Point(57, 244);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 1;
            label1.Text = "Nº Filhos:";
            // 
            // txb_Numfilhos
            // 
            txb_Numfilhos.Enabled = false;
            txb_Numfilhos.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Numfilhos.Location = new Point(137, 241);
            txb_Numfilhos.Name = "txb_Numfilhos";
            txb_Numfilhos.Size = new Size(91, 26);
            txb_Numfilhos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(186, 194, 204);
            label2.Location = new Point(134, 274);
            label2.Name = "label2";
            label2.Size = new Size(98, 17);
            label2.TabIndex = 3;
            label2.Text = "Menores de 14 anos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(186, 194, 204);
            label3.Location = new Point(1, 197);
            label3.Name = "label3";
            label3.Size = new Size(115, 19);
            label3.TabIndex = 4;
            label3.Text = "Remuneração Base:";
            // 
            // txb_RemunBase
            // 
            txb_RemunBase.Enabled = false;
            txb_RemunBase.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_RemunBase.Location = new Point(136, 195);
            txb_RemunBase.Name = "txb_RemunBase";
            txb_RemunBase.Size = new Size(92, 26);
            txb_RemunBase.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(186, 194, 204);
            label4.Location = new Point(31, 152);
            label4.Name = "label4";
            label4.Size = new Size(85, 19);
            label4.TabIndex = 6;
            label4.Text = "Valor Unitário:";
            // 
            // txb_Valorunit
            // 
            txb_Valorunit.Enabled = false;
            txb_Valorunit.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Valorunit.Location = new Point(137, 149);
            txb_Valorunit.Name = "txb_Valorunit";
            txb_Valorunit.Size = new Size(90, 26);
            txb_Valorunit.TabIndex = 7;
            // 
            // btn_ok
            // 
            btn_ok.FlatStyle = FlatStyle.Flat;
            btn_ok.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ok.ForeColor = Color.FromArgb(186, 194, 204);
            btn_ok.Location = new Point(234, 307);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(72, 33);
            btn_ok.TabIndex = 8;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // txb_Remunate
            // 
            txb_Remunate.Enabled = false;
            txb_Remunate.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Remunate.Location = new Point(137, 103);
            txb_Remunate.Name = "txb_Remunate";
            txb_Remunate.Size = new Size(90, 26);
            txb_Remunate.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(186, 194, 204);
            label5.Location = new Point(10, 106);
            label5.Name = "label5";
            label5.Size = new Size(106, 19);
            label5.TabIndex = 9;
            label5.Text = "Remuneração até:";
            // 
            // txb_Remunde
            // 
            txb_Remunde.Enabled = false;
            txb_Remunde.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Remunde.Location = new Point(137, 57);
            txb_Remunde.Name = "txb_Remunde";
            txb_Remunde.Size = new Size(90, 26);
            txb_Remunde.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(186, 194, 204);
            label6.Location = new Point(15, 60);
            label6.Name = "label6";
            label6.Size = new Size(101, 19);
            label6.TabIndex = 11;
            label6.Text = "Remuneração de:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(186, 194, 204);
            label7.Location = new Point(78, 12);
            label7.Name = "label7";
            label7.Size = new Size(32, 19);
            label7.TabIndex = 13;
            label7.Text = "Ano:";
            // 
            // frm_SalarioFamilia
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 57, 69);
            ClientSize = new Size(318, 352);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(txb_Remunde);
            Controls.Add(label6);
            Controls.Add(txb_Remunate);
            Controls.Add(label5);
            Controls.Add(btn_ok);
            Controls.Add(txb_Valorunit);
            Controls.Add(label4);
            Controls.Add(txb_RemunBase);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txb_Numfilhos);
            Controls.Add(label1);
            Controls.Add(cb_Ano);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frm_SalarioFamilia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cálculo Salário Família";
            Load += frm_SalarioFamilia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_Ano;
        private Label label1;
        private TextBox txb_Numfilhos;
        private Label label2;
        private Label label3;
        private TextBox txb_RemunBase;
        private Label label4;
        private TextBox txb_Valorunit;
        private Button btn_ok;
        private TextBox txb_Remunate;
        private Label label5;
        private TextBox txb_Remunde;
        private Label label6;
        private Label label7;

        public string set_RemunBase
        {
            set { txb_RemunBase.Text = value; }
        }
        public TextBox get_RemunBase
        {
            get { return txb_RemunBase; }
        }
        public TextBox get_Numfilhos
        {
            get { return txb_Numfilhos; }
        }
        public TextBox get_RemunMax
        {
            get { return txb_Remunate; }
        }
        public TextBox get_RemunMin
        {
            get { return txb_Remunde; }
        }
        public TextBox get_ValorUnit
        {
            get { return txb_Valorunit; }
        }
    }
}