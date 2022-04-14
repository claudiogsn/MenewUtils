namespace MenewUtils
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabMain = new MetroFramework.Controls.MetroTabControl();
            this.pgComandos = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btFirebird = new MetroFramework.Controls.MetroButton();
            this.btLiberarFirewall = new MetroFramework.Controls.MetroButton();
            this.btLimparSpooler = new MetroFramework.Controls.MetroButton();
            this.btLiberarCompartilhamento = new MetroFramework.Controls.MetroButton();
            this.lbLiberacoes = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btLimparSincronia = new MetroFramework.Controls.MetroButton();
            this.btMenewSincronizador = new MetroFramework.Controls.MetroButton();
            this.btMenewPayServer = new MetroFramework.Controls.MetroButton();
            this.btMenewIntegrador = new MetroFramework.Controls.MetroButton();
            this.btMenewPdv = new MetroFramework.Controls.MetroButton();
            this.lbLogComando = new MetroFramework.Controls.MetroLabel();
            this.txtLogComandos = new MetroFramework.Controls.MetroTextBox();
            this.pgBackup = new MetroFramework.Controls.MetroTabPage();
            this.lbBackupAnalise = new MetroFramework.Controls.MetroLabel();
            this.txtBackup = new MetroFramework.Controls.MetroTextBox();
            this.pgReparador = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabMain.SuspendLayout();
            this.pgComandos.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.pgBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::MenewUtils.Properties.Resources.menewPrincipalazul__1_;
            this.pictureBox1.Location = new System.Drawing.Point(23, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.pgComandos);
            this.tabMain.Controls.Add(this.pgBackup);
            this.tabMain.Controls.Add(this.pgReparador);
            this.tabMain.Location = new System.Drawing.Point(7, 83);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 1;
            this.tabMain.Size = new System.Drawing.Size(736, 538);
            this.tabMain.TabIndex = 5;
            // 
            // pgComandos
            // 
            this.pgComandos.BackColor = System.Drawing.Color.Transparent;
            this.pgComandos.Controls.Add(this.metroLabel1);
            this.pgComandos.Controls.Add(this.metroPanel2);
            this.pgComandos.Controls.Add(this.lbLiberacoes);
            this.pgComandos.Controls.Add(this.metroPanel1);
            this.pgComandos.Controls.Add(this.lbLogComando);
            this.pgComandos.Controls.Add(this.txtLogComandos);
            this.pgComandos.HorizontalScrollbarBarColor = true;
            this.pgComandos.Location = new System.Drawing.Point(4, 35);
            this.pgComandos.Name = "pgComandos";
            this.pgComandos.Size = new System.Drawing.Size(728, 499);
            this.pgComandos.TabIndex = 0;
            this.pgComandos.Text = "Comandos Básicos";
            this.pgComandos.VerticalScrollbarBarColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(386, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(146, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Liberações e Impressão";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel2.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.btFirebird);
            this.metroPanel2.Controls.Add(this.btLiberarFirewall);
            this.metroPanel2.Controls.Add(this.btLimparSpooler);
            this.metroPanel2.Controls.Add(this.btLiberarCompartilhamento);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(371, 28);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(345, 236);
            this.metroPanel2.TabIndex = 11;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btFirebird
            // 
            this.btFirebird.Highlight = true;
            this.btFirebird.Location = new System.Drawing.Point(15, 177);
            this.btFirebird.Name = "btFirebird";
            this.btFirebird.Size = new System.Drawing.Size(170, 30);
            this.btFirebird.TabIndex = 9;
            this.btFirebird.Text = "Reiniciar Firebird";
            this.btFirebird.Click += new System.EventHandler(this.btFirebird_Click);
            // 
            // btLiberarFirewall
            // 
            this.btLiberarFirewall.Highlight = true;
            this.btLiberarFirewall.Location = new System.Drawing.Point(15, 126);
            this.btLiberarFirewall.Name = "btLiberarFirewall";
            this.btLiberarFirewall.Size = new System.Drawing.Size(170, 30);
            this.btLiberarFirewall.TabIndex = 8;
            this.btLiberarFirewall.Text = "Liberar Portas Firewall";
            this.btLiberarFirewall.Click += new System.EventHandler(this.btLiberarFirewall_Click);
            // 
            // btLimparSpooler
            // 
            this.btLimparSpooler.Highlight = true;
            this.btLimparSpooler.Location = new System.Drawing.Point(15, 75);
            this.btLimparSpooler.Name = "btLimparSpooler";
            this.btLimparSpooler.Size = new System.Drawing.Size(170, 30);
            this.btLimparSpooler.TabIndex = 7;
            this.btLimparSpooler.Text = "Limpar Spooler";
            this.btLimparSpooler.Click += new System.EventHandler(this.btLimparSpooler_Click);
            // 
            // btLiberarCompartilhamento
            // 
            this.btLiberarCompartilhamento.Highlight = true;
            this.btLiberarCompartilhamento.Location = new System.Drawing.Point(15, 24);
            this.btLiberarCompartilhamento.Name = "btLiberarCompartilhamento";
            this.btLiberarCompartilhamento.Size = new System.Drawing.Size(170, 30);
            this.btLiberarCompartilhamento.TabIndex = 6;
            this.btLiberarCompartilhamento.Text = "Liberar Compartilhamento";
            this.btLiberarCompartilhamento.Click += new System.EventHandler(this.btLiberarCompartilhamento_Click);
            // 
            // lbLiberacoes
            // 
            this.lbLiberacoes.AutoSize = true;
            this.lbLiberacoes.Location = new System.Drawing.Point(27, 18);
            this.lbLiberacoes.Name = "lbLiberacoes";
            this.lbLiberacoes.Size = new System.Drawing.Size(170, 19);
            this.lbLiberacoes.TabIndex = 8;
            this.lbLiberacoes.Text = "Reiniciar Aplicações Menew";
            this.lbLiberacoes.Click += new System.EventHandler(this.metroLabel1_Click_1);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btLimparSincronia);
            this.metroPanel1.Controls.Add(this.btMenewSincronizador);
            this.metroPanel1.Controls.Add(this.btMenewPayServer);
            this.metroPanel1.Controls.Add(this.btMenewIntegrador);
            this.metroPanel1.Controls.Add(this.btMenewPdv);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 28);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(345, 236);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btLimparSincronia
            // 
            this.btLimparSincronia.Highlight = true;
            this.btLimparSincronia.Location = new System.Drawing.Point(191, 177);
            this.btLimparSincronia.Name = "btLimparSincronia";
            this.btLimparSincronia.Size = new System.Drawing.Size(139, 30);
            this.btLimparSincronia.TabIndex = 6;
            this.btLimparSincronia.Text = "Limpar Sincronia";
            this.btLimparSincronia.Click += new System.EventHandler(this.btLimparSincronia_Click);
            // 
            // btMenewSincronizador
            // 
            this.btMenewSincronizador.Highlight = true;
            this.btMenewSincronizador.Location = new System.Drawing.Point(15, 177);
            this.btMenewSincronizador.Name = "btMenewSincronizador";
            this.btMenewSincronizador.Size = new System.Drawing.Size(170, 30);
            this.btMenewSincronizador.TabIndex = 5;
            this.btMenewSincronizador.Text = "Reiniciar MenewSincronizador";
            this.btMenewSincronizador.Click += new System.EventHandler(this.btMenewSincronizador_Click);
            // 
            // btMenewPayServer
            // 
            this.btMenewPayServer.Highlight = true;
            this.btMenewPayServer.Location = new System.Drawing.Point(15, 126);
            this.btMenewPayServer.Name = "btMenewPayServer";
            this.btMenewPayServer.Size = new System.Drawing.Size(170, 30);
            this.btMenewPayServer.TabIndex = 4;
            this.btMenewPayServer.Text = "Reiniciar MenewPayServer";
            this.btMenewPayServer.Click += new System.EventHandler(this.btMenewPayServer_Click);
            // 
            // btMenewIntegrador
            // 
            this.btMenewIntegrador.Highlight = true;
            this.btMenewIntegrador.Location = new System.Drawing.Point(15, 75);
            this.btMenewIntegrador.Name = "btMenewIntegrador";
            this.btMenewIntegrador.Size = new System.Drawing.Size(170, 30);
            this.btMenewIntegrador.TabIndex = 3;
            this.btMenewIntegrador.Text = "Reiniciar MenewIntegrador";
            this.btMenewIntegrador.Click += new System.EventHandler(this.btMenewIntegrador_Click);
            // 
            // btMenewPdv
            // 
            this.btMenewPdv.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btMenewPdv.Highlight = true;
            this.btMenewPdv.Location = new System.Drawing.Point(15, 24);
            this.btMenewPdv.Name = "btMenewPdv";
            this.btMenewPdv.Size = new System.Drawing.Size(170, 30);
            this.btMenewPdv.TabIndex = 2;
            this.btMenewPdv.Text = "Reiniciar MenewPdv";
            this.btMenewPdv.Click += new System.EventHandler(this.btMenewPdv_Click);
            // 
            // lbLogComando
            // 
            this.lbLogComando.AutoSize = true;
            this.lbLogComando.Location = new System.Drawing.Point(-4, 286);
            this.lbLogComando.Name = "lbLogComando";
            this.lbLogComando.Size = new System.Drawing.Size(113, 19);
            this.lbLogComando.TabIndex = 3;
            this.lbLogComando.Text = "Logs de Execução";
            this.lbLogComando.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txtLogComandos
            // 
            this.txtLogComandos.Location = new System.Drawing.Point(-4, 308);
            this.txtLogComandos.Multiline = true;
            this.txtLogComandos.Name = "txtLogComandos";
            this.txtLogComandos.ReadOnly = true;
            this.txtLogComandos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogComandos.Size = new System.Drawing.Size(732, 195);
            this.txtLogComandos.TabIndex = 2;
            this.txtLogComandos.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // pgBackup
            // 
            this.pgBackup.Controls.Add(this.metroButton1);
            this.pgBackup.Controls.Add(this.lbBackupAnalise);
            this.pgBackup.Controls.Add(this.txtBackup);
            this.pgBackup.HorizontalScrollbarBarColor = true;
            this.pgBackup.Location = new System.Drawing.Point(4, 35);
            this.pgBackup.Name = "pgBackup";
            this.pgBackup.Size = new System.Drawing.Size(728, 499);
            this.pgBackup.TabIndex = 1;
            this.pgBackup.Text = "Backup Análise";
            this.pgBackup.VerticalScrollbarBarColor = true;
            // 
            // lbBackupAnalise
            // 
            this.lbBackupAnalise.AutoSize = true;
            this.lbBackupAnalise.Location = new System.Drawing.Point(4, 268);
            this.lbBackupAnalise.Name = "lbBackupAnalise";
            this.lbBackupAnalise.Size = new System.Drawing.Size(108, 19);
            this.lbBackupAnalise.TabIndex = 3;
            this.lbBackupAnalise.Text = "Log de Execucao";
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(0, 293);
            this.txtBackup.Multiline = true;
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.ReadOnly = true;
            this.txtBackup.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBackup.Size = new System.Drawing.Size(725, 210);
            this.txtBackup.TabIndex = 2;
            this.txtBackup.Click += new System.EventHandler(this.txtBackup_Click);
            // 
            // pgReparador
            // 
            this.pgReparador.HorizontalScrollbarBarColor = true;
            this.pgReparador.Location = new System.Drawing.Point(4, 35);
            this.pgReparador.Name = "pgReparador";
            this.pgReparador.Size = new System.Drawing.Size(728, 499);
            this.pgReparador.TabIndex = 2;
            this.pgReparador.Text = "Reparador de Banco";
            this.pgReparador.VerticalScrollbarBarColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(302, 135);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 630);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "           | Menew Utils";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.pgComandos.ResumeLayout(false);
            this.pgComandos.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.pgBackup.ResumeLayout(false);
            this.pgBackup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabControl tabMain;
        private MetroFramework.Controls.MetroTabPage pgComandos;
        private MetroFramework.Controls.MetroTabPage pgBackup;
        private MetroFramework.Controls.MetroTabPage pgReparador;
        private MetroFramework.Controls.MetroTextBox txtLogComandos;
        private MetroFramework.Controls.MetroLabel lbLogComando;
        private MetroFramework.Controls.MetroLabel lbLiberacoes;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btFirebird;
        private MetroFramework.Controls.MetroButton btLiberarFirewall;
        private MetroFramework.Controls.MetroButton btLimparSpooler;
        private MetroFramework.Controls.MetroButton btLiberarCompartilhamento;
        private MetroFramework.Controls.MetroButton btMenewSincronizador;
        private MetroFramework.Controls.MetroButton btMenewPayServer;
        private MetroFramework.Controls.MetroButton btMenewIntegrador;
        private MetroFramework.Controls.MetroButton btMenewPdv;
        private MetroFramework.Controls.MetroButton btLimparSincronia;
        private MetroFramework.Controls.MetroLabel lbBackupAnalise;
        private MetroFramework.Controls.MetroTextBox txtBackup;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}