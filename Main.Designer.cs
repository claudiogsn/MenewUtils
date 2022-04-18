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
            this.lbCaminhosMenew = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.BtCaminhoBanco = new MetroFramework.Controls.MetroButton();
            this.BtCaminhoMenewUpdater = new MetroFramework.Controls.MetroButton();
            this.BtCaminhoMenewSvc = new MetroFramework.Controls.MetroButton();
            this.BtCaminhoMenewSincronizador = new MetroFramework.Controls.MetroButton();
            this.BtCaminhoMenewIntegrador = new MetroFramework.Controls.MetroButton();
            this.BtCaminhoMenewPayServer = new MetroFramework.Controls.MetroButton();
            this.BtCaminhoMenewPdv = new MetroFramework.Controls.MetroButton();
            this.BtBackup = new MetroFramework.Controls.MetroButton();
            this.BtBuscarCaminhoRaiz = new MetroFramework.Controls.MetroButton();
            this.TxCaminhoMenewUpdater = new MetroFramework.Controls.MetroTextBox();
            this.TxCaminhoBanco = new MetroFramework.Controls.MetroTextBox();
            this.TxCaminhoMenewSvc = new MetroFramework.Controls.MetroTextBox();
            this.TxCaminhoMenewSincronizador = new MetroFramework.Controls.MetroTextBox();
            this.TxCaminhoMenewIntegrador = new MetroFramework.Controls.MetroTextBox();
            this.TxCaminhoMenewPayServer = new MetroFramework.Controls.MetroTextBox();
            this.TxCaminhoMenewPdv = new MetroFramework.Controls.MetroTextBox();
            this.TxCaminhoRaiz = new MetroFramework.Controls.MetroTextBox();
            this.BtLimparLogBkp = new MetroFramework.Controls.MetroButton();
            this.lbBackupAnalise = new MetroFramework.Controls.MetroLabel();
            this.TxLogBkpAnalise = new MetroFramework.Controls.MetroTextBox();
            this.pgReparador = new MetroFramework.Controls.MetroTabPage();
            this.SelectRaiz = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabMain.SuspendLayout();
            this.pgComandos.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.pgBackup.SuspendLayout();
            this.metroPanel3.SuspendLayout();
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
            this.tabMain.Location = new System.Drawing.Point(7, 69);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(736, 544);
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
            this.pgComandos.Size = new System.Drawing.Size(728, 505);
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
            this.metroPanel2.Size = new System.Drawing.Size(345, 281);
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
            this.metroPanel1.Size = new System.Drawing.Size(345, 281);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btLimparSincronia
            // 
            this.btLimparSincronia.Highlight = true;
            this.btLimparSincronia.Location = new System.Drawing.Point(15, 225);
            this.btLimparSincronia.Name = "btLimparSincronia";
            this.btLimparSincronia.Size = new System.Drawing.Size(170, 30);
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
            this.lbLogComando.Location = new System.Drawing.Point(-4, 331);
            this.lbLogComando.Name = "lbLogComando";
            this.lbLogComando.Size = new System.Drawing.Size(113, 19);
            this.lbLogComando.TabIndex = 3;
            this.lbLogComando.Text = "Logs de Execução";
            this.lbLogComando.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txtLogComandos
            // 
            this.txtLogComandos.Location = new System.Drawing.Point(-2, 353);
            this.txtLogComandos.Multiline = true;
            this.txtLogComandos.Name = "txtLogComandos";
            this.txtLogComandos.ReadOnly = true;
            this.txtLogComandos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogComandos.Size = new System.Drawing.Size(730, 150);
            this.txtLogComandos.TabIndex = 2;
            this.txtLogComandos.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // pgBackup
            // 
            this.pgBackup.Controls.Add(this.lbCaminhosMenew);
            this.pgBackup.Controls.Add(this.metroPanel3);
            this.pgBackup.Controls.Add(this.BtLimparLogBkp);
            this.pgBackup.Controls.Add(this.lbBackupAnalise);
            this.pgBackup.Controls.Add(this.TxLogBkpAnalise);
            this.pgBackup.HorizontalScrollbarBarColor = true;
            this.pgBackup.Location = new System.Drawing.Point(4, 35);
            this.pgBackup.Name = "pgBackup";
            this.pgBackup.Size = new System.Drawing.Size(728, 505);
            this.pgBackup.TabIndex = 1;
            this.pgBackup.Text = "Backup Análise";
            this.pgBackup.VerticalScrollbarBarColor = true;
            // 
            // lbCaminhosMenew
            // 
            this.lbCaminhosMenew.AutoSize = true;
            this.lbCaminhosMenew.BackColor = System.Drawing.Color.White;
            this.lbCaminhosMenew.Location = new System.Drawing.Point(24, 15);
            this.lbCaminhosMenew.Name = "lbCaminhosMenew";
            this.lbCaminhosMenew.Size = new System.Drawing.Size(113, 19);
            this.lbCaminhosMenew.TabIndex = 2;
            this.lbCaminhosMenew.Text = "Caminhos Menew";
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel3.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.BtCaminhoBanco);
            this.metroPanel3.Controls.Add(this.BtCaminhoMenewUpdater);
            this.metroPanel3.Controls.Add(this.BtCaminhoMenewSvc);
            this.metroPanel3.Controls.Add(this.BtCaminhoMenewSincronizador);
            this.metroPanel3.Controls.Add(this.BtCaminhoMenewIntegrador);
            this.metroPanel3.Controls.Add(this.BtCaminhoMenewPayServer);
            this.metroPanel3.Controls.Add(this.BtCaminhoMenewPdv);
            this.metroPanel3.Controls.Add(this.BtBackup);
            this.metroPanel3.Controls.Add(this.BtBuscarCaminhoRaiz);
            this.metroPanel3.Controls.Add(this.TxCaminhoMenewUpdater);
            this.metroPanel3.Controls.Add(this.TxCaminhoBanco);
            this.metroPanel3.Controls.Add(this.TxCaminhoMenewSvc);
            this.metroPanel3.Controls.Add(this.TxCaminhoMenewSincronizador);
            this.metroPanel3.Controls.Add(this.TxCaminhoMenewIntegrador);
            this.metroPanel3.Controls.Add(this.TxCaminhoMenewPayServer);
            this.metroPanel3.Controls.Add(this.TxCaminhoMenewPdv);
            this.metroPanel3.Controls.Add(this.TxCaminhoRaiz);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(4, 26);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(724, 278);
            this.metroPanel3.TabIndex = 5;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // BtCaminhoBanco
            // 
            this.BtCaminhoBanco.Location = new System.Drawing.Point(508, 205);
            this.BtCaminhoBanco.Name = "BtCaminhoBanco";
            this.BtCaminhoBanco.Size = new System.Drawing.Size(50, 23);
            this.BtCaminhoBanco.TabIndex = 12;
            this.BtCaminhoBanco.Text = "...";
            this.BtCaminhoBanco.Click += new System.EventHandler(this.BtCaminhoBanco_Click);
            // 
            // BtCaminhoMenewUpdater
            // 
            this.BtCaminhoMenewUpdater.Location = new System.Drawing.Point(660, 146);
            this.BtCaminhoMenewUpdater.Name = "BtCaminhoMenewUpdater";
            this.BtCaminhoMenewUpdater.Size = new System.Drawing.Size(50, 23);
            this.BtCaminhoMenewUpdater.TabIndex = 12;
            this.BtCaminhoMenewUpdater.Text = "...";
            this.BtCaminhoMenewUpdater.Click += new System.EventHandler(this.BtCaminhoMenewUpdater_Click);
            // 
            // BtCaminhoMenewSvc
            // 
            this.BtCaminhoMenewSvc.Location = new System.Drawing.Point(660, 103);
            this.BtCaminhoMenewSvc.Name = "BtCaminhoMenewSvc";
            this.BtCaminhoMenewSvc.Size = new System.Drawing.Size(50, 23);
            this.BtCaminhoMenewSvc.TabIndex = 12;
            this.BtCaminhoMenewSvc.Text = "...";
            this.BtCaminhoMenewSvc.Click += new System.EventHandler(this.BtCaminhoMenewSvc_Click);
            // 
            // BtCaminhoMenewSincronizador
            // 
            this.BtCaminhoMenewSincronizador.Location = new System.Drawing.Point(660, 62);
            this.BtCaminhoMenewSincronizador.Name = "BtCaminhoMenewSincronizador";
            this.BtCaminhoMenewSincronizador.Size = new System.Drawing.Size(50, 23);
            this.BtCaminhoMenewSincronizador.TabIndex = 12;
            this.BtCaminhoMenewSincronizador.Text = "...";
            this.BtCaminhoMenewSincronizador.Click += new System.EventHandler(this.BtCaminhoMenewSincronizador_Click);
            // 
            // BtCaminhoMenewIntegrador
            // 
            this.BtCaminhoMenewIntegrador.Location = new System.Drawing.Point(296, 146);
            this.BtCaminhoMenewIntegrador.Name = "BtCaminhoMenewIntegrador";
            this.BtCaminhoMenewIntegrador.Size = new System.Drawing.Size(50, 23);
            this.BtCaminhoMenewIntegrador.TabIndex = 12;
            this.BtCaminhoMenewIntegrador.Text = "...";
            this.BtCaminhoMenewIntegrador.Click += new System.EventHandler(this.BtCaminhoMenewIntegrador_Click);
            // 
            // BtCaminhoMenewPayServer
            // 
            this.BtCaminhoMenewPayServer.Location = new System.Drawing.Point(296, 103);
            this.BtCaminhoMenewPayServer.Name = "BtCaminhoMenewPayServer";
            this.BtCaminhoMenewPayServer.Size = new System.Drawing.Size(50, 23);
            this.BtCaminhoMenewPayServer.TabIndex = 12;
            this.BtCaminhoMenewPayServer.Text = "...";
            this.BtCaminhoMenewPayServer.Click += new System.EventHandler(this.BtCaminhoMenewPayServer_Click);
            // 
            // BtCaminhoMenewPdv
            // 
            this.BtCaminhoMenewPdv.Location = new System.Drawing.Point(296, 62);
            this.BtCaminhoMenewPdv.Name = "BtCaminhoMenewPdv";
            this.BtCaminhoMenewPdv.Size = new System.Drawing.Size(50, 23);
            this.BtCaminhoMenewPdv.TabIndex = 12;
            this.BtCaminhoMenewPdv.Text = "...";
            this.BtCaminhoMenewPdv.Click += new System.EventHandler(this.BtCaminhoMenewPdv_Click);
            // 
            // BtBackup
            // 
            this.BtBackup.Highlight = true;
            this.BtBackup.Location = new System.Drawing.Point(231, 243);
            this.BtBackup.Name = "BtBackup";
            this.BtBackup.Size = new System.Drawing.Size(270, 23);
            this.BtBackup.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtBackup.TabIndex = 11;
            this.BtBackup.Text = "Realizar Backup";
            this.BtBackup.Click += new System.EventHandler(this.BtBackup_Click);
            // 
            // BtBuscarCaminhoRaiz
            // 
            this.BtBuscarCaminhoRaiz.Location = new System.Drawing.Point(508, 19);
            this.BtBuscarCaminhoRaiz.Name = "BtBuscarCaminhoRaiz";
            this.BtBuscarCaminhoRaiz.Size = new System.Drawing.Size(75, 23);
            this.BtBuscarCaminhoRaiz.TabIndex = 10;
            this.BtBuscarCaminhoRaiz.Text = "...";
            this.BtBuscarCaminhoRaiz.Click += new System.EventHandler(this.BtBuscarCaminhoRaiz_Click);
            // 
            // TxCaminhoMenewUpdater
            // 
            this.TxCaminhoMenewUpdater.Location = new System.Drawing.Point(384, 146);
            this.TxCaminhoMenewUpdater.Name = "TxCaminhoMenewUpdater";
            this.TxCaminhoMenewUpdater.Size = new System.Drawing.Size(270, 23);
            this.TxCaminhoMenewUpdater.TabIndex = 9;
            this.TxCaminhoMenewUpdater.Text = "TxCaminhoMenewUpdater";
            // 
            // TxCaminhoBanco
            // 
            this.TxCaminhoBanco.Location = new System.Drawing.Point(231, 205);
            this.TxCaminhoBanco.Name = "TxCaminhoBanco";
            this.TxCaminhoBanco.Size = new System.Drawing.Size(270, 23);
            this.TxCaminhoBanco.TabIndex = 8;
            this.TxCaminhoBanco.Text = "TxCaminhoBanco";
            // 
            // TxCaminhoMenewSvc
            // 
            this.TxCaminhoMenewSvc.Location = new System.Drawing.Point(384, 103);
            this.TxCaminhoMenewSvc.Name = "TxCaminhoMenewSvc";
            this.TxCaminhoMenewSvc.Size = new System.Drawing.Size(270, 23);
            this.TxCaminhoMenewSvc.TabIndex = 7;
            this.TxCaminhoMenewSvc.Text = "TxCaminhoMenewSvc";
            this.TxCaminhoMenewSvc.Click += new System.EventHandler(this.metroTextBox6_Click);
            // 
            // TxCaminhoMenewSincronizador
            // 
            this.TxCaminhoMenewSincronizador.Location = new System.Drawing.Point(384, 62);
            this.TxCaminhoMenewSincronizador.Name = "TxCaminhoMenewSincronizador";
            this.TxCaminhoMenewSincronizador.Size = new System.Drawing.Size(270, 23);
            this.TxCaminhoMenewSincronizador.TabIndex = 6;
            this.TxCaminhoMenewSincronizador.Text = "TxCaminhoMenewSincronizador";
            // 
            // TxCaminhoMenewIntegrador
            // 
            this.TxCaminhoMenewIntegrador.Location = new System.Drawing.Point(20, 146);
            this.TxCaminhoMenewIntegrador.Name = "TxCaminhoMenewIntegrador";
            this.TxCaminhoMenewIntegrador.Size = new System.Drawing.Size(270, 23);
            this.TxCaminhoMenewIntegrador.TabIndex = 5;
            this.TxCaminhoMenewIntegrador.Text = "TxCaminhoMenewIntegrador";
            this.TxCaminhoMenewIntegrador.Click += new System.EventHandler(this.metroTextBox4_Click);
            // 
            // TxCaminhoMenewPayServer
            // 
            this.TxCaminhoMenewPayServer.Location = new System.Drawing.Point(20, 103);
            this.TxCaminhoMenewPayServer.Name = "TxCaminhoMenewPayServer";
            this.TxCaminhoMenewPayServer.Size = new System.Drawing.Size(270, 23);
            this.TxCaminhoMenewPayServer.TabIndex = 4;
            this.TxCaminhoMenewPayServer.Text = "TxCaminhoMenewPayServer";
            // 
            // TxCaminhoMenewPdv
            // 
            this.TxCaminhoMenewPdv.Location = new System.Drawing.Point(20, 62);
            this.TxCaminhoMenewPdv.Name = "TxCaminhoMenewPdv";
            this.TxCaminhoMenewPdv.Size = new System.Drawing.Size(270, 23);
            this.TxCaminhoMenewPdv.TabIndex = 3;
            this.TxCaminhoMenewPdv.Text = "TxCaminhoMenewPdv";
            // 
            // TxCaminhoRaiz
            // 
            this.TxCaminhoRaiz.Location = new System.Drawing.Point(231, 19);
            this.TxCaminhoRaiz.Name = "TxCaminhoRaiz";
            this.TxCaminhoRaiz.Size = new System.Drawing.Size(270, 23);
            this.TxCaminhoRaiz.TabIndex = 2;
            this.TxCaminhoRaiz.Text = "Buscar Pasta Raiz";
            this.TxCaminhoRaiz.Click += new System.EventHandler(this.metroTextBox1_Click_1);
            // 
            // BtLimparLogBkp
            // 
            this.BtLimparLogBkp.Location = new System.Drawing.Point(648, 327);
            this.BtLimparLogBkp.Name = "BtLimparLogBkp";
            this.BtLimparLogBkp.Size = new System.Drawing.Size(75, 23);
            this.BtLimparLogBkp.TabIndex = 4;
            this.BtLimparLogBkp.Text = "Limpar Logs";
            this.BtLimparLogBkp.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // lbBackupAnalise
            // 
            this.lbBackupAnalise.AutoSize = true;
            this.lbBackupAnalise.Location = new System.Drawing.Point(-2, 331);
            this.lbBackupAnalise.Name = "lbBackupAnalise";
            this.lbBackupAnalise.Size = new System.Drawing.Size(111, 19);
            this.lbBackupAnalise.TabIndex = 3;
            this.lbBackupAnalise.Text = "Log de Execução:";
            // 
            // TxLogBkpAnalise
            // 
            this.TxLogBkpAnalise.Location = new System.Drawing.Point(-2, 353);
            this.TxLogBkpAnalise.Multiline = true;
            this.TxLogBkpAnalise.Name = "TxLogBkpAnalise";
            this.TxLogBkpAnalise.ReadOnly = true;
            this.TxLogBkpAnalise.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxLogBkpAnalise.Size = new System.Drawing.Size(725, 150);
            this.TxLogBkpAnalise.TabIndex = 2;
            this.TxLogBkpAnalise.Click += new System.EventHandler(this.txtBackup_Click);
            // 
            // pgReparador
            // 
            this.pgReparador.HorizontalScrollbarBarColor = true;
            this.pgReparador.Location = new System.Drawing.Point(4, 35);
            this.pgReparador.Name = "pgReparador";
            this.pgReparador.Size = new System.Drawing.Size(728, 505);
            this.pgReparador.TabIndex = 2;
            this.pgReparador.Text = "Reparador de Banco";
            this.pgReparador.VerticalScrollbarBarColor = true;
            // 
            // SelectRaiz
            // 
            this.SelectRaiz.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.SelectRaiz.SelectedPath = "C:\\MvarandasTecnologia";
            this.SelectRaiz.ShowNewFolderButton = false;
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
            this.metroPanel3.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTextBox TxLogBkpAnalise;
        private MetroFramework.Controls.MetroButton BtLimparLogBkp;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel lbCaminhosMenew;
        private MetroFramework.Controls.MetroTextBox TxCaminhoMenewUpdater;
        private MetroFramework.Controls.MetroTextBox TxCaminhoBanco;
        private MetroFramework.Controls.MetroTextBox TxCaminhoMenewSvc;
        private MetroFramework.Controls.MetroTextBox TxCaminhoMenewSincronizador;
        private MetroFramework.Controls.MetroTextBox TxCaminhoMenewIntegrador;
        private MetroFramework.Controls.MetroTextBox TxCaminhoMenewPayServer;
        private MetroFramework.Controls.MetroTextBox TxCaminhoMenewPdv;
        private MetroFramework.Controls.MetroTextBox TxCaminhoRaiz;
        private MetroFramework.Controls.MetroButton BtBuscarCaminhoRaiz;
        private System.Windows.Forms.FolderBrowserDialog SelectRaiz;
        private MetroFramework.Controls.MetroButton BtBackup;
        private MetroFramework.Controls.MetroButton BtCaminhoMenewUpdater;
        private MetroFramework.Controls.MetroButton BtCaminhoMenewSvc;
        private MetroFramework.Controls.MetroButton BtCaminhoMenewSincronizador;
        private MetroFramework.Controls.MetroButton BtCaminhoMenewIntegrador;
        private MetroFramework.Controls.MetroButton BtCaminhoMenewPayServer;
        private MetroFramework.Controls.MetroButton BtCaminhoMenewPdv;
        private MetroFramework.Controls.MetroButton BtCaminhoBanco;
    }
}