namespace RHS_Folha_de_Pagamento.Interface
{
    partial class frm_Listagem
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
            btn_Buscar = new Button();
            txb_buscar = new TextBox();
            lsv_Listagem = new ListView();
            panel1 = new Panel();
            label1 = new Label();
            btn_fechar = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Buscar
            // 
            btn_Buscar.FlatStyle = FlatStyle.Flat;
            btn_Buscar.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Buscar.ForeColor = Color.White;
            btn_Buscar.Location = new Point(951, 24);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(89, 40);
            btn_Buscar.TabIndex = 0;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // txb_buscar
            // 
            txb_buscar.Location = new Point(542, 35);
            txb_buscar.Name = "txb_buscar";
            txb_buscar.Size = new Size(388, 23);
            txb_buscar.TabIndex = 2;
            // 
            // lsv_Listagem
            // 
            lsv_Listagem.CheckBoxes = true;
            lsv_Listagem.Location = new Point(21, 20);
            lsv_Listagem.Name = "lsv_Listagem";
            lsv_Listagem.Size = new Size(1194, 442);
            lsv_Listagem.TabIndex = 3;
            lsv_Listagem.UseCompatibleStateImageBehavior = false;
            lsv_Listagem.DoubleClick += lsv_Listagem_DoubleClick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lsv_Listagem);
            panel1.Location = new Point(25, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 467);
            panel1.TabIndex = 4;
            panel1.Paint += pintar_Borda;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 69);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 5;
            label1.Text = "Listagem";
            // 
            // btn_fechar
            // 
            btn_fechar.FlatStyle = FlatStyle.Flat;
            btn_fechar.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_fechar.ForeColor = Color.White;
            btn_fechar.Location = new Point(1171, 24);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(89, 40);
            btn_fechar.TabIndex = 4;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1061, 24);
            button1.Name = "button1";
            button1.Size = new Size(89, 40);
            button1.TabIndex = 3;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_Limpar_Click;
            // 
            // frm_Listagem
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 57, 69);
            ClientSize = new Size(1302, 559);
            ControlBox = false;
            Controls.Add(btn_fechar);
            Controls.Add(button1);
            Controls.Add(btn_Buscar);
            Controls.Add(txb_buscar);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_Listagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listagem";
            Load += frm_Listagem_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Buscar;
        private TextBox txb_buscar;
        private ListView lsv_Listagem;
        private Panel panel1;
        private Label label1;
        private Button btn_fechar;
        private Button button1;
    }
}