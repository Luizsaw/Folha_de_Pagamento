namespace RHS_Folha_de_Pagamento.Interface
{
    partial class frm_PlanoSaude
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
            label1 = new Label();
            label2 = new Label();
            txb_valor = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_ok
            // 
            btn_ok.FlatStyle = FlatStyle.Flat;
            btn_ok.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ok.ForeColor = Color.FromArgb(186, 194, 204);
            btn_ok.Location = new Point(210, 116);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(61, 28);
            btn_ok.TabIndex = 0;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(186, 194, 204);
            label1.Location = new Point(54, 35);
            label1.Name = "label1";
            label1.Size = new Size(140, 19);
            label1.TabIndex = 1;
            label1.Text = "Valor do Plano de Saúde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 72);
            label2.Name = "label2";
            label2.Size = new Size(442, 19);
            label2.TabIndex = 2;
            label2.Text = "A parcela mensal não pode comprometer mais que 30% do salário do trabalhador.";
            // 
            // txb_valor
            // 
            txb_valor.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_valor.Location = new Point(201, 32);
            txb_valor.Name = "txb_valor";
            txb_valor.Size = new Size(175, 26);
            txb_valor.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(186, 194, 204);
            label3.Location = new Point(379, 37);
            label3.Name = "label3";
            label3.Size = new Size(23, 19);
            label3.TabIndex = 4;
            label3.Text = "R$";
            // 
            // frm_PlanoSaude
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 57, 69);
            ClientSize = new Size(462, 169);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(txb_valor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_ok);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frm_PlanoSaude";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Valor Plano de Saúde";
            Load += frm_PlanoSaude_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ok;
        private Label label1;
        private Label label2;
        private TextBox txb_valor;
        private Label label3;

        public TextBox get_valor
        {
            get { return txb_valor; }
        }
    }
}