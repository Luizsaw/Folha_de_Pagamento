namespace RHS_Folha_de_Pagamento.Interface
{
    partial class frm_Atrasos
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
            txb_faltasHoras = new TextBox();
            label2 = new Label();
            txb_cargaHoraria = new TextBox();
            label1 = new Label();
            txb_salario = new TextBox();
            Sa = new Label();
            btn_ok = new Button();
            SuspendLayout();
            // 
            // txb_faltasHoras
            // 
            txb_faltasHoras.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_faltasHoras.Location = new Point(155, 132);
            txb_faltasHoras.Name = "txb_faltasHoras";
            txb_faltasHoras.Size = new Size(143, 26);
            txb_faltasHoras.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(186, 194, 204);
            label2.Location = new Point(25, 134);
            label2.Name = "label2";
            label2.Size = new Size(121, 19);
            label2.TabIndex = 12;
            label2.Text = "Horas  injustificadas:";
            // 
            // txb_cargaHoraria
            // 
            txb_cargaHoraria.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_cargaHoraria.Location = new Point(155, 80);
            txb_cargaHoraria.Name = "txb_cargaHoraria";
            txb_cargaHoraria.Size = new Size(143, 26);
            txb_cargaHoraria.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(186, 194, 204);
            label1.Location = new Point(17, 83);
            label1.Name = "label1";
            label1.Size = new Size(129, 19);
            label1.TabIndex = 10;
            label1.Text = "Carga Horária Mensal:";
            // 
            // txb_salario
            // 
            txb_salario.Enabled = false;
            txb_salario.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_salario.Location = new Point(155, 28);
            txb_salario.Name = "txb_salario";
            txb_salario.Size = new Size(143, 26);
            txb_salario.TabIndex = 9;
            // 
            // Sa
            // 
            Sa.AutoSize = true;
            Sa.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Sa.ForeColor = Color.FromArgb(186, 194, 204);
            Sa.Location = new Point(95, 32);
            Sa.Name = "Sa";
            Sa.Size = new Size(51, 19);
            Sa.TabIndex = 8;
            Sa.Text = "Salário:";
            // 
            // btn_ok
            // 
            btn_ok.FlatStyle = FlatStyle.Flat;
            btn_ok.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ok.ForeColor = Color.FromArgb(186, 194, 204);
            btn_ok.Location = new Point(184, 182);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(71, 32);
            btn_ok.TabIndex = 7;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // frm_Atrasos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 57, 69);
            ClientSize = new Size(326, 229);
            ControlBox = false;
            Controls.Add(txb_faltasHoras);
            Controls.Add(label2);
            Controls.Add(txb_cargaHoraria);
            Controls.Add(label1);
            Controls.Add(txb_salario);
            Controls.Add(Sa);
            Controls.Add(btn_ok);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frm_Atrasos";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcular Atrasos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_faltasHoras;
        private Label label2;
        private TextBox txb_cargaHoraria;
        private Label label1;
        private TextBox txb_salario;
        private Label Sa;
        private Button btn_ok;

        public string set_RemunBase
        {
            set { txb_salario.Text = value; }
        }
        public string set_cargaHoraria
        {
            set { txb_cargaHoraria.Text = value; }
        }
        public TextBox get_Atrasos
        {
            get { return txb_faltasHoras; }
        }
        public TextBox get_cargaHoraria
        {
            get { return txb_cargaHoraria; }
        }
    }
}