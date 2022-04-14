namespace MenewUtils
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btCloseLogin = new MetroFramework.Controls.MetroButton();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.LbLogin = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLogin = new MetroFramework.Controls.MetroButton();
            this.lbVersao = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btCloseLogin
            // 
            this.btCloseLogin.Location = new System.Drawing.Point(635, 593);
            this.btCloseLogin.Name = "btCloseLogin";
            this.btCloseLogin.Size = new System.Drawing.Size(75, 23);
            this.btCloseLogin.Style = MetroFramework.MetroColorStyle.Red;
            this.btCloseLogin.TabIndex = 0;
            this.btCloseLogin.Text = "FECHAR";
            this.btCloseLogin.Click += new System.EventHandler(this.btCloseLogin_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(225, 279);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(303, 23);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Click += new System.EventHandler(this.metroTextBox1_Click);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // LbLogin
            // 
            this.LbLogin.AutoSize = true;
            this.LbLogin.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LbLogin.Location = new System.Drawing.Point(225, 256);
            this.LbLogin.Name = "LbLogin";
            this.LbLogin.Size = new System.Drawing.Size(303, 19);
            this.LbLogin.TabIndex = 2;
            this.LbLogin.Text = "Digite a senha de administrador para iniciar";
            this.LbLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LbLogin.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::MenewUtils.Properties.Resources.menewPrincipalazul__1_;
            this.pictureBox1.Location = new System.Drawing.Point(23, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(339, 306);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Entrar";
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lbVersao
            // 
            this.lbVersao.AutoSize = true;
            this.lbVersao.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbVersao.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbVersao.Location = new System.Drawing.Point(13, 597);
            this.lbVersao.Name = "lbVersao";
            this.lbVersao.Size = new System.Drawing.Size(74, 15);
            this.lbVersao.TabIndex = 5;
            this.lbVersao.Text = "Versão 1.0.0";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 630);
            this.Controls.Add(this.lbVersao);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LbLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btCloseLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Resizable = false;
            this.Text = "           | Menew Utils";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btCloseLogin;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroLabel LbLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btLogin;
        private MetroFramework.Controls.MetroLabel lbVersao;
    }
}

