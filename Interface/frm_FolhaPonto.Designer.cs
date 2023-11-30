namespace RHS_Folha_de_Pagamento.Interface
{
    partial class frm_FolhaPonto
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
            panel1 = new Panel();
            lsv_Listagem = new ListView();
            btn_fechar = new Button();
            label2 = new Label();
            lbl_nome = new Label();
            label3 = new Label();
            monthCalendar1 = new MonthCalendar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(366, 20);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 11;
            label1.Text = "Registros";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lsv_Listagem);
            panel1.Location = new Point(346, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 418);
            panel1.TabIndex = 10;
            panel1.Paint += pintar_Borda;
            // 
            // lsv_Listagem
            // 
            lsv_Listagem.Location = new Point(21, 20);
            lsv_Listagem.Name = "lsv_Listagem";
            lsv_Listagem.Size = new Size(612, 374);
            lsv_Listagem.TabIndex = 3;
            lsv_Listagem.UseCompatibleStateImageBehavior = false;
            // 
            // btn_fechar
            // 
            btn_fechar.FlatStyle = FlatStyle.Flat;
            btn_fechar.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_fechar.ForeColor = Color.White;
            btn_fechar.Location = new Point(915, 469);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(89, 40);
            btn_fechar.TabIndex = 18;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 31);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 19;
            label2.Text = "Funcioário: ";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nome.ForeColor = Color.White;
            lbl_nome.Location = new Point(83, 31);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(0, 19);
            lbl_nome.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(93, 19);
            label3.TabIndex = 21;
            label3.Text = "Filtrar por data:";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 95);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 22;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // frm_FolhaPonto
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 57, 69);
            ClientSize = new Size(1019, 521);
            Controls.Add(monthCalendar1);
            Controls.Add(label3);
            Controls.Add(lbl_nome);
            Controls.Add(label2);
            Controls.Add(btn_fechar);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_FolhaPonto";
            Text = "Folha de Ponto";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private ListView lsv_Listagem;
        private Button btn_fechar;
        private Label label2;
        private Label lbl_nome;
        private Label label3;
        private MonthCalendar monthCalendar1;
    }
}