namespace RHS_Folha_de_Pagamento.Interface
{
    partial class frm_Faltas
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
            Sa = new Label();
            txb_salario = new TextBox();
            txb_diasmes = new TextBox();
            label1 = new Label();
            txb_faltas = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_ok
            // 
            btn_ok.FlatStyle = FlatStyle.Flat;
            btn_ok.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ok.ForeColor = Color.FromArgb(186, 194, 204);
            btn_ok.Location = new Point(182, 188);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(71, 32);
            btn_ok.TabIndex = 0;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // Sa
            // 
            Sa.AutoSize = true;
            Sa.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Sa.ForeColor = Color.FromArgb(186, 194, 204);
            Sa.Location = new Point(93, 31);
            Sa.Name = "Sa";
            Sa.Size = new Size(51, 19);
            Sa.TabIndex = 1;
            Sa.Text = "Salário:";
            // 
            // txb_salario
            // 
            txb_salario.Enabled = false;
            txb_salario.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_salario.Location = new Point(153, 27);
            txb_salario.Name = "txb_salario";
            txb_salario.Size = new Size(143, 26);
            txb_salario.TabIndex = 2;
            // 
            // txb_diasmes
            // 
            txb_diasmes.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_diasmes.Location = new Point(153, 79);
            txb_diasmes.Name = "txb_diasmes";
            txb_diasmes.Size = new Size(143, 26);
            txb_diasmes.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(186, 194, 204);
            label1.Location = new Point(27, 82);
            label1.Name = "label1";
            label1.Size = new Size(117, 19);
            label1.TabIndex = 3;
            label1.Text = "N° total dias no mês:";
            // 
            // txb_faltas
            // 
            txb_faltas.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_faltas.Location = new Point(153, 131);
            txb_faltas.Name = "txb_faltas";
            txb_faltas.Size = new Size(143, 26);
            txb_faltas.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(186, 194, 204);
            label2.Location = new Point(23, 133);
            label2.Name = "label2";
            label2.Size = new Size(121, 19);
            label2.TabIndex = 5;
            label2.Text = "Faltas injustificadas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold Condensed", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(186, 194, 204);
            label3.Location = new Point(157, 161);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 7;
            label3.Text = "total em dias";
            // 
            // frm_Faltas
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 57, 69);
            ClientSize = new Size(348, 233);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(txb_faltas);
            Controls.Add(label2);
            Controls.Add(txb_diasmes);
            Controls.Add(label1);
            Controls.Add(txb_salario);
            Controls.Add(Sa);
            Controls.Add(btn_ok);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frm_Faltas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Cálculo de Faltas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ok;
        private Label Sa;
        private TextBox txb_salario;
        private TextBox txb_diasmes;
        private Label label1;
        private TextBox txb_faltas;
        private Label label2;
        private Label label3;

        public string set_RemunBase
        {
            set { txb_salario.Text = value; }
        }
        public TextBox get_RemunBase
        {
            get { return txb_salario; }
        }
        public TextBox get_Dias
        {
            get { return txb_diasmes; }
        }
        public TextBox get_Faltas
        {
            get { return txb_faltas; }
        }
    }
}