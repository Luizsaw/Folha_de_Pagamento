namespace PrjFolhaPagamento.Forms
{
    partial class frm_Login
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
            txt_senha = new TextBox();
            label2 = new Label();
            txt_username = new TextBox();
            label1 = new Label();
            btn_Login = new Button();
            btn_sair = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_senha
            // 
            txt_senha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_senha.Location = new Point(55, 347);
            txt_senha.Margin = new Padding(3, 2, 3, 2);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(274, 23);
            txt_senha.TabIndex = 2;
            txt_senha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(82, 109, 124);
            label2.Location = new Point(159, 314);
            label2.Name = "label2";
            label2.Size = new Size(62, 29);
            label2.TabIndex = 6;
            label2.Text = "Senha";
            // 
            // txt_username
            // 
            txt_username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_username.Location = new Point(55, 279);
            txt_username.Margin = new Padding(3, 2, 3, 2);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(274, 23);
            txt_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(82, 109, 124);
            label1.Location = new Point(154, 245);
            label1.Name = "label1";
            label1.Size = new Size(69, 29);
            label1.TabIndex = 3;
            label1.Text = "Acesso";
            // 
            // btn_Login
            // 
            btn_Login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Bahnschrift SemiBold Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.ForeColor = Color.FromArgb(82, 109, 124);
            btn_Login.Location = new Point(132, 391);
            btn_Login.Margin = new Padding(3, 2, 3, 2);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(121, 46);
            btn_Login.TabIndex = 7;
            btn_Login.Text = "Entrar";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Logar_Click;
            // 
            // btn_sair
            // 
            btn_sair.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_sair.FlatStyle = FlatStyle.Flat;
            btn_sair.Font = new Font("Bahnschrift SemiBold Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sair.ForeColor = Color.FromArgb(82, 109, 124);
            btn_sair.Location = new Point(132, 458);
            btn_sair.Margin = new Padding(3, 2, 3, 2);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(121, 46);
            btn_sair.TabIndex = 8;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(253, 253, 253);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_senha);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_sair);
            panel1.Controls.Add(btn_Login);
            panel1.Location = new Point(25, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 540);
            panel1.TabIndex = 10;
            panel1.Paint += pintar_Borda;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = RHS_Folha_de_Pagamento.Properties.Resources.folha_de_pagamento_logo_menor;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(82, 109, 124);
            label7.Location = new Point(307, 517);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 9;
            label7.Text = "Versão: 1.0.0";
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.FromArgb(90, 112, 126);
            ClientSize = new Size(432, 564);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frm_Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_senha;
        private Label label2;
        private TextBox txt_username;
        private Label label1;
        private Button btn_Login;
        private Button btn_sair;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox1;
    }
}