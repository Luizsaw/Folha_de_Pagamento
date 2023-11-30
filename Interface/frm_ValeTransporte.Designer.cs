namespace RHS_Folha_de_Pagamento.Interface
{
    partial class frm_ValeTransporte
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
            label1 = new Label();
            txb_Dias = new TextBox();
            txb_valorDiario = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_okVT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(186, 194, 204);
            label1.Location = new Point(53, 51);
            label1.Name = "label1";
            label1.Size = new Size(35, 19);
            label1.TabIndex = 0;
            label1.Text = "Dias:";
            // 
            // txb_Dias
            // 
            txb_Dias.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Dias.Location = new Point(95, 48);
            txb_Dias.Name = "txb_Dias";
            txb_Dias.Size = new Size(70, 26);
            txb_Dias.TabIndex = 2;
            // 
            // txb_valorDiario
            // 
            txb_valorDiario.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_valorDiario.Location = new Point(95, 5);
            txb_valorDiario.Name = "txb_valorDiario";
            txb_valorDiario.Size = new Size(70, 26);
            txb_valorDiario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(186, 194, 204);
            label2.Location = new Point(10, 8);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 2;
            label2.Text = "Valor Diário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold Condensed", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(186, 194, 204);
            label3.Location = new Point(169, 10);
            label3.Name = "label3";
            label3.Size = new Size(20, 17);
            label3.TabIndex = 4;
            label3.Text = "R$";
            // 
            // btn_okVT
            // 
            btn_okVT.FlatStyle = FlatStyle.Flat;
            btn_okVT.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_okVT.ForeColor = Color.FromArgb(186, 194, 204);
            btn_okVT.Location = new Point(102, 88);
            btn_okVT.Name = "btn_okVT";
            btn_okVT.Size = new Size(63, 28);
            btn_okVT.TabIndex = 3;
            btn_okVT.Text = "OK";
            btn_okVT.UseVisualStyleBackColor = true;
            btn_okVT.Click += btn_okVT_Click;
            // 
            // frm_ValeTransporte
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 57, 69);
            ClientSize = new Size(197, 128);
            ControlBox = false;
            Controls.Add(btn_okVT);
            Controls.Add(label3);
            Controls.Add(txb_valorDiario);
            Controls.Add(label2);
            Controls.Add(txb_Dias);
            Controls.Add(label1);
            Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frm_ValeTransporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cálculo de Vale Transporte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txb_Dias;
        private TextBox txb_valorDiario;
        private Label label2;
        private Label label3;
        private Button btn_okVT;

        public TextBox txb_dias
        {
            get { return txb_Dias; }
        }
        public TextBox txb_valordiario
        {
            get { return txb_valorDiario; }
        }
    }
}
