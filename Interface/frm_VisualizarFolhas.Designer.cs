namespace RHS_Folha_de_Pagamento.Interface
{
    partial class frm_VisualizarFolhas
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
            btn_fechar = new Button();
            label1 = new Label();
            panel1 = new Panel();
            lsv_Listagem = new ListView();
            lbl_nome = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_fechar
            // 
            btn_fechar.FlatStyle = FlatStyle.Flat;
            btn_fechar.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_fechar.ForeColor = Color.White;
            btn_fechar.Location = new Point(461, 33);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(89, 40);
            btn_fechar.TabIndex = 25;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 68);
            label1.Name = "label1";
            label1.Size = new Size(167, 19);
            label1.TabIndex = 24;
            label1.Text = "Lista de Folhas de Pagamento";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lsv_Listagem);
            panel1.Location = new Point(14, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(536, 404);
            panel1.TabIndex = 23;
            panel1.Paint += pintar_Borda;
            // 
            // lsv_Listagem
            // 
            lsv_Listagem.Location = new Point(21, 20);
            lsv_Listagem.Name = "lsv_Listagem";
            lsv_Listagem.Size = new Size(507, 352);
            lsv_Listagem.TabIndex = 3;
            lsv_Listagem.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nome.ForeColor = Color.White;
            lbl_nome.Location = new Point(85, 28);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(0, 19);
            lbl_nome.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 28);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 26;
            label2.Text = "Funcioário: ";
            // 
            // frm_VisualizarFolhas
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 57, 69);
            ClientSize = new Size(572, 504);
            Controls.Add(lbl_nome);
            Controls.Add(label2);
            Controls.Add(btn_fechar);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_VisualizarFolhas";
            Text = "Visualizar Folhas de Pagamento";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_fechar;
        private Label label1;
        private Panel panel1;
        private ListView lsv_Listagem;
        private Label lbl_nome;
        private Label label2;
    }
}