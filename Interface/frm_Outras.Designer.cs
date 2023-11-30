namespace RHS_Folha_de_Pagamento.Interface
{
    partial class frm_Outras
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
            label3 = new Label();
            txb_valor = new TextBox();
            label1 = new Label();
            btn_ok = new Button();
            txb_descricao = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(186, 194, 204);
            label3.Location = new Point(275, 91);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(23, 19);
            label3.TabIndex = 9;
            label3.Text = "R$";
            // 
            // txb_valor
            // 
            txb_valor.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_valor.Location = new Point(97, 87);
            txb_valor.Margin = new Padding(4, 3, 4, 3);
            txb_valor.Name = "txb_valor";
            txb_valor.Size = new Size(176, 26);
            txb_valor.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(186, 194, 204);
            label1.Location = new Point(53, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 6;
            label1.Text = "Valor:";
            // 
            // btn_ok
            // 
            btn_ok.FlatStyle = FlatStyle.Flat;
            btn_ok.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ok.ForeColor = Color.FromArgb(186, 194, 204);
            btn_ok.Location = new Point(150, 143);
            btn_ok.Margin = new Padding(4, 3, 4, 3);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(61, 28);
            btn_ok.TabIndex = 5;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // txb_descricao
            // 
            txb_descricao.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_descricao.Location = new Point(97, 39);
            txb_descricao.Margin = new Padding(4, 3, 4, 3);
            txb_descricao.Name = "txb_descricao";
            txb_descricao.Size = new Size(176, 26);
            txb_descricao.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(186, 194, 204);
            label2.Location = new Point(28, 42);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 10;
            label2.Text = "Descrição:";
            // 
            // frm_Outras
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 57, 69);
            ClientSize = new Size(307, 188);
            ControlBox = false;
            Controls.Add(txb_descricao);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txb_valor);
            Controls.Add(label1);
            Controls.Add(btn_ok);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_Outras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Valor Personalizado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txb_valor;
        private Label label1;
        private Button btn_ok;
        private TextBox txb_descricao;
        private Label label2;

        public TextBox get_descricao
        {
            get { return txb_descricao; }
        }
        public TextBox get_valor
        {
            get { return txb_valor; }
        }
    }
}