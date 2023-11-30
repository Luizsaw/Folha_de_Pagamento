using System.Security.Cryptography;

namespace RHS_Folha_de_Pagamento.Interface
{
    partial class frm_HoraExtras
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
            label2 = new Label();
            txb_cargaHoraria = new TextBox();
            txb_salarioBruto = new TextBox();
            txb_QuantHoras = new TextBox();
            label3 = new Label();
            txb_Percentual = new TextBox();
            label4 = new Label();
            btn_ok = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(186, 194, 204);
            label1.Location = new Point(75, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 4;
            label1.Text = "Salário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(186, 194, 204);
            label2.Location = new Point(32, 70);
            label2.Name = "label2";
            label2.Size = new Size(126, 19);
            label2.TabIndex = 6;
            label2.Text = "Carga Horária Mensal";
            // 
            // txb_cargaHoraria
            // 
            txb_cargaHoraria.Enabled = false;
            txb_cargaHoraria.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_cargaHoraria.Location = new Point(23, 94);
            txb_cargaHoraria.Name = "txb_cargaHoraria";
            txb_cargaHoraria.Size = new Size(159, 26);
            txb_cargaHoraria.TabIndex = 7;
            // 
            // txb_salarioBruto
            // 
            txb_salarioBruto.Enabled = false;
            txb_salarioBruto.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_salarioBruto.Location = new Point(23, 38);
            txb_salarioBruto.Name = "txb_salarioBruto";
            txb_salarioBruto.Size = new Size(159, 26);
            txb_salarioBruto.TabIndex = 8;
            // 
            // txb_QuantHoras
            // 
            txb_QuantHoras.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_QuantHoras.Location = new Point(23, 151);
            txb_QuantHoras.Name = "txb_QuantHoras";
            txb_QuantHoras.Size = new Size(159, 26);
            txb_QuantHoras.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(186, 194, 204);
            label3.Location = new Point(20, 127);
            label3.Name = "label3";
            label3.Size = new Size(155, 19);
            label3.TabIndex = 9;
            label3.Text = "Quantidade de horas extras";
            // 
            // txb_Percentual
            // 
            txb_Percentual.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Percentual.Location = new Point(23, 207);
            txb_Percentual.Name = "txb_Percentual";
            txb_Percentual.Size = new Size(159, 26);
            txb_Percentual.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(186, 194, 204);
            label4.Location = new Point(49, 184);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 11;
            label4.Text = "% da hora extra";
            // 
            // btn_ok
            // 
            btn_ok.FlatStyle = FlatStyle.Flat;
            btn_ok.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ok.ForeColor = Color.FromArgb(186, 194, 204);
            btn_ok.Location = new Point(63, 243);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(79, 28);
            btn_ok.TabIndex = 13;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // frm_HoraExtras
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 57, 69);
            ClientSize = new Size(207, 282);
            ControlBox = false;
            Controls.Add(btn_ok);
            Controls.Add(txb_Percentual);
            Controls.Add(label4);
            Controls.Add(txb_QuantHoras);
            Controls.Add(label3);
            Controls.Add(txb_salarioBruto);
            Controls.Add(txb_cargaHoraria);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frm_HoraExtras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cálculo de Horas Extras";
            Load += frm_HoraExtras_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txb_cargaHoraria;
        private TextBox txb_salarioBruto;
        private TextBox txb_QuantHoras;
        private Label label3;
        private TextBox txb_Percentual;
        private Label label4;
        private Button btn_ok;

        public string txb_cargaH
        {
            set { txb_cargaHoraria.Text = value; }
        }
        public string txb_salarioB
        {
            set { txb_salarioBruto.Text = value; }
        }
        public TextBox txb_quantH
        {
            get { return txb_QuantHoras; }
        }
        public TextBox txb_Percent
        {
            get { return txb_Percentual; }
        }
    }
}