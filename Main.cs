using Ionic.Zip;
using MenewUtils.Domain.DAO;
using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenewUtils
{

    public partial class Main : MetroForm
    {
        private Process ProcessBkpGfix;

        private Process ProcessBkpGbak;

        private Process ProcessRestaurarGbak;
        public string ExecutableGBak { get; set; }

        public string ExecutableGFix { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void Main_Shown(object sender, EventArgs e)
        {
            DaoConnection.PathDb = @"C:\MvarandasTecnologia\Database\NETUNO.FDB";
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void btMenewPdv_Click(object sender, EventArgs e)
        {
            var process = System.Diagnostics.Process.GetProcessesByName("MenewPdv");
            txtLogComandos.Text = "Finalizando Processo MenewPdv\r\n";
            if (process.Length > 0)
            {
                process[0].Kill();
                if (!File.Exists(@"C:\MvarandasTecnologia\MenewPdv\MenewPdv.exe"))
                { MessageBox.Show("Arquivo MenewPdv.exe não encontrado"); }
                else { System.Diagnostics.Process.Start(@"C:\MvarandasTecnologia\MenewPdv\MenewPdv.exe"); }
            }
            else
            { MessageBox.Show("MenewPdv não está em execução\r\n"); }

            if (process.Length > 0)
            { txtLogComandos.Text = "MenewPdv Reiniciado com sucesso!\r\n"; }



        }

        private void btMenewIntegrador_Click(object sender, EventArgs e)
        {
            var process = System.Diagnostics.Process.GetProcessesByName("MenewFoodIntegrador");
            txtLogComandos.Text = "Finalizando Processo MenewFoodIntegrador\r\n";
            if (process.Length > 0)
            {
                process[0].Kill();
                if (!File.Exists(@"C:\MvarandasTecnologia\MenewFoodIntegrador\MenewFoodIntegrador.exe"))
                { MessageBox.Show("Arquivo MenewFoodIntegrador.exe não encontrado"); }
                else { System.Diagnostics.Process.Start(@"C:\MvarandasTecnologia\MenewFoodIntegrador\MenewFoodIntegrador.exe"); }
            }
            else
            { MessageBox.Show("MenewFoodIntegrador não está em execução\r\n"); }

            if (process.Length > 0)
            { txtLogComandos.Text = "MenewFoodIntegrador Reiniciado com sucesso!\r\n"; }

        }

        private void btMenewPayServer_Click(object sender, EventArgs e)
        {
            var process = System.Diagnostics.Process.GetProcessesByName("MenewPAYServer");
            txtLogComandos.Text = "Finalizando Processo MenewPAYServer\r\n";
            if (process.Length > 0)
            {
                process[0].Kill();
                if (!File.Exists(@"C:\MvarandasTecnologia\MenewPAYServer\MenewPAYServer.exe"))
                { MessageBox.Show("Arquivo MenewPAYServer.exe não encontrado"); }
                else { System.Diagnostics.Process.Start(@"C:\MvarandasTecnologia\MenewPAYServer\MenewPAYServer.exe"); }
            }
            else
            { MessageBox.Show("MenewPAYServer não está em execução"); }

            if (process.Length > 0)
            { txtLogComandos.Text = "MenewPAYServer Reiniciado com sucesso!\r\n"; }

        }

        private void btMenewSincronizador_Click(object sender, EventArgs e)
        {
            var process = System.Diagnostics.Process.GetProcessesByName("MenewSincronizador");
            txtLogComandos.AppendText("Finalizando Processo MenewSincronizador\r\n");

            if (process.Length > 0)
            {
                process[0].Kill();
                if (!File.Exists(@"C:\MvarandasTecnologia\MenewSincronizador\MenewSincronizador.exe"))
                { MessageBox.Show("Arquivo MenewSincronizador.exe não encontrado"); }
                else { System.Diagnostics.Process.Start(@"C:\MvarandasTecnologia\MenewSincronizador\MenewSincronizador.exe"); }
            }
            else
            { MessageBox.Show("MenewSincronizador não está em execução"); }

            if (process.Length > 0)
            { txtLogComandos.AppendText("MenewSincronizador Reiniciado com sucesso! \r\n"); }

        }

        private void btLiberarCompartilhamento_Click(object sender, EventArgs e)
        {
            {
                var process = new Process();
                txtLogComandos.Text = "";
                process.StartInfo.FileName = Application.StartupPath + "\\bats\\LiberaPasta.bat";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.OutputDataReceived += (s, d) =>
                {
                    if (d.Data != null)
                    {
                        this.Invoke(new Action(() => txtLogComandos.AppendText(d.Data + "\r\n")));
                    }
                };
                process.Start();
                process.BeginOutputReadLine();
            }

        }

        private void btLimparSpooler_Click(object sender, EventArgs e)
        {
            {
                var process = new Process();
                txtLogComandos.Text = "";
                process.StartInfo.FileName = Application.StartupPath + "\\bats\\LimparSpooler.bat";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.OutputDataReceived += (s, d) =>
                {
                    if (d.Data != null)
                    {
                        this.Invoke(new Action(() => txtLogComandos.AppendText(d.Data + "\r\n")));
                    }
                };
                process.Start();
                process.BeginOutputReadLine();
            }
        }

        private void btLiberarFirewall_Click(object sender, EventArgs e)
        {

            {
                var process = new Process();
                txtLogComandos.Text = "";
                process.StartInfo.FileName = Application.StartupPath + "\\bats\\LiberarFirewall.bat";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.OutputDataReceived += (s, d) =>
                {
                    if (d.Data != null)
                    {
                        this.Invoke(new Action(() => txtLogComandos.AppendText(d.Data + "\r\n")));
                    }
                };
                process.Start();
                process.BeginOutputReadLine();
            }

        }

        private void btFirebird_Click(object sender, EventArgs e)
        {

            {
                var process = new Process();
                txtLogComandos.Clear();
                process.StartInfo.FileName = Application.StartupPath + "\\bats\\Firebird.bat";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.OutputDataReceived += (s, d) =>
                {
                    if (d.Data != null)
                    {
                        this.Invoke(new Action(() => txtLogComandos.AppendText(d.Data + "\r\n")));
                    }
                };
                process.Start();
                process.BeginOutputReadLine();
            }
        }

        private void btLimparSincronia_Click(object sender, EventArgs e)
        {
            LimparSincronia limparSincronia = new LimparSincronia();
            limparSincronia.Show();
        }

        private void txtBackup_Click(object sender, EventArgs e)
        {


        }


        private void metroButton1_Click(object sender, EventArgs e)
        {


            TxLogBkpAnalise.Clear();

        }

        private void metroTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }


        //=================================== Metodo para Executar o Backup ============================================    
        private async void ExecutarBkp()
        {
            string BatAnalise = Application.StartupPath + "\\Execute.bat";
            string end_bkp = Application.StartupPath + "\\end_bkp.true";
            await Task.Run((Action)(() =>
            {
                Process process = new Process();
                process.StartInfo.FileName = BatAnalise;
                process.StartInfo.Arguments = "\"" + this.TxCaminhoBanco.Text + "\" \"" + this.TxCaminhoMenewPdv.Text + "\" \"" + this.TxCaminhoMenewIntegrador.Text + "\" \"" + this.TxCaminhoMenewPayServer.Text + "\" \"" + this.TxCaminhoMenewSincronizador.Text + "\" \"" + this.TxCaminhoMenewSvc.Text + "\" \"" + this.TxCaminhoMenewUpdater.Text + "\" \"" + end_bkp + "\"";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.OutputDataReceived += (s, d) =>
                {
                    if (d.Data != null)
                    {
                        this.Invoke(new Action(() => TxLogBkpAnalise.AppendText(d.Data + "\r\n")));
                    }
                };
                process.Start();
                process.BeginOutputReadLine();

                string str1 = File.ReadAllText(end_bkp).Replace("\r\n", "").Trim();
                string str2 = str1.EndsWith("\\") ? str1.Substring(0, str1.Length - 1) : str1;
                this.TxLogBkpAnalise.Invoke(new Action(() => TxLogBkpAnalise.AppendText("Compactando dados para análise.\r\n")));
                string str3 = DateTime.Now.ToString("dd-MM-yyyy hh#mm.ss&").Replace("#", "h").Replace(".", "m").Replace("&", "s");
                string PathBkpZip = str2 + "[" + str3 + "].zip";
                MessageBox.Show("Compactando dados para análise! \r\n Aguarde a Confirmação com o caminho do Arquivo!\r\n");
                CreateZip(str2, PathBkpZip);
                MessageBox.Show("Backup realizado com sucesso! Caminho do arquivo: " + PathBkpZip);
                if (File.Exists(PathBkpZip))
                {
                    Directory.Delete(str2, true);
                    Process.Start("Explorer.exe", @"C:\MvarandasTecnologia\BKP");
                }
            }));


        }
        //=================================== Metodo para Zipar os Arquivos ============================================    
        private void CreateZip(string PathBkpZip, string str2)
        {
            using (ZipFile zip = new ZipFile())
            {
                zip.SaveProgress += Zip_SaveProgress;
                zip.CompressionMethod = Ionic.Zip.CompressionMethod.Deflate;
                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                zip.UseZip64WhenSaving = Zip64Option.AsNecessary;
                if (!string.IsNullOrEmpty(PathBkpZip))
                {
                    zip.AddDirectory(PathBkpZip, new DirectoryInfo(PathBkpZip).Name);
                }
                var d = zip;

                if (File.Exists(str2))
                {
                    File.Delete(str2);
                }
                zip.Save(str2);
            }
        }


        //===================================Adicionar o Progresso da compactação no progress bar ============================================      
        private void Zip_SaveProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EntriesSaved > 0 && e.EntriesTotal > 0)
            {
                int progress = (int)Math.Floor((decimal)((e.EntriesSaved * 100) / e.EntriesTotal));
                this.Invoke(new Action(() =>
                {
                    pbTotalFile.Value = progress;
                    lblTotal.Text = Convert.ToString(progress) + "%";
                }));
            }

        }

        private void BtBackup_Click(object sender, EventArgs e) => this.ExecutarBkp();

        //================================= Codigo para Preencher os caminhos ===========================================================
        private void BtBuscarCaminhoRaiz_Click(object sender, EventArgs e)

        {
            SelectBanco.ShowDialog();
            string folderPath = SelectBanco.SelectedPath;
            TxCaminhoRaiz.Text = folderPath;
            this.PopularPaths(this.TxCaminhoRaiz.Text);
        }
        private void PopularPaths(string CaminhoRaiz)
        {
            if (CaminhoRaiz.Trim() == "" || !Directory.Exists(CaminhoRaiz))
                return;
            string path1 = CaminhoRaiz + "\\DataBase";
            string path2 = CaminhoRaiz + "\\MenewPdv";
            string path3 = CaminhoRaiz + "\\MenewPAYServer";
            string path4 = CaminhoRaiz + "\\MenewFoodIntegrador";
            string path5 = CaminhoRaiz + "\\MenewSvc";
            string path6 = CaminhoRaiz + "\\MenewSvcUpdater";
            string path7 = CaminhoRaiz + "\\MenewSincronizador";
            string[] strArray = new string[3]
            {
        CaminhoRaiz + "\\DataBase\\Netuno.fdb",
        CaminhoRaiz + "\\DataBase\\Saturno.fdb",
        CaminhoRaiz + "\\DataBase\\DBMVESTOQUE.fdb"
            };
            this.TxCaminhoMenewPdv.Text = Directory.Exists(path2) ? path2 : this.TxCaminhoMenewPdv.Text;
            this.TxCaminhoMenewPayServer.Text = Directory.Exists(path3) ? path3 : this.TxCaminhoMenewPayServer.Text;
            this.TxCaminhoMenewIntegrador.Text = Directory.Exists(path4) ? path4 : this.TxCaminhoMenewIntegrador.Text;
            this.TxCaminhoMenewSvc.Text = Directory.Exists(path5) ? path5 : this.TxCaminhoMenewSvc.Text;
            this.TxCaminhoMenewUpdater.Text = Directory.Exists(path6) ? path6 : this.TxCaminhoMenewUpdater.Text;
            this.TxCaminhoMenewSincronizador.Text = Directory.Exists(path7) ? path7 : this.TxCaminhoMenewSincronizador.Text;
            this.TxCaminhoBanco.Text = Directory.Exists(path1) ? path1 : this.TxCaminhoBanco.Text;
        }
        private void BtCaminhoMenewPdv_Click(object sender, EventArgs e)
        {
            SelectBanco.ShowDialog();
            string folderPath = SelectBanco.SelectedPath;
            TxCaminhoMenewPdv.Text = folderPath;
        }

        private void BtCaminhoMenewPayServer_Click(object sender, EventArgs e)
        {
            SelectBanco.ShowDialog();
            string folderPath = SelectBanco.SelectedPath;
            TxCaminhoMenewPayServer.Text = folderPath;
        }

        private void BtCaminhoMenewIntegrador_Click(object sender, EventArgs e)
        {
            SelectBanco.ShowDialog();
            string folderPath = SelectBanco.SelectedPath;
            TxCaminhoMenewIntegrador.Text = folderPath;
        }

        private void BtCaminhoMenewSincronizador_Click(object sender, EventArgs e)
        {
            SelectBanco.ShowDialog();
            string folderPath = SelectBanco.SelectedPath;
            TxCaminhoMenewSincronizador.Text = folderPath;
        }

        private void BtCaminhoMenewSvc_Click(object sender, EventArgs e)
        {
            SelectBanco.ShowDialog();
            string folderPath = SelectBanco.SelectedPath;
            TxCaminhoMenewSvc.Text = folderPath;
        }

        private void BtCaminhoMenewUpdater_Click(object sender, EventArgs e)
        {
            SelectBanco.ShowDialog();
            string folderPath = SelectBanco.SelectedPath;
            TxCaminhoMenewUpdater.Text = folderPath;
        }

        private void BtCaminhoBanco_Click(object sender, EventArgs e)
        {
            SelectBanco.ShowDialog();
            string folderPath = SelectBanco.SelectedPath;
            TxCaminhoBanco.Text = folderPath;
        }
        //===========================================================================================================================================
        //=======================================================Reparação de Banco de Dados=========================================================  
        private async void ExecutarReparer()
        {

            {
                string PathDbReparer = this.TxCaminhoDbReparer.Text;
                string ExecutableGFix = Application.StartupPath + "\\binfb\\gfix.exe";
                string ExecutableGBak = Application.StartupPath + "\\binfb\\gbak.exe";
                if (!File.Exists(PathDbReparer))
                {
                    int num = (int)MessageBox.Show(string.Format("Não foi encontrado o banco de dados {0} na pasta {1}, por favor ajustar.", (object)PathDbReparer, (object)Directory.GetParent(PathDbReparer)), "Banco de dados não encontrado.");
                }
                else
                {
                    string TextReparacao = this.btOpNormal.Checked ? this.btOpNormal.Text : this.BtOpForcada.Text;
                    await Task.Run((Action)(() =>
                    {
                        this.ProcessBkpGfix = new Process();
                        this.ProcessBkpGfix.StartInfo.FileName = ExecutableGFix;
                        this.ProcessBkpGfix.StartInfo.Arguments = !this.btOpNormal.Checked ? "-user SYSDBA -password masterkey -mend -ig \"" + PathDbReparer + "\"" : "-user SYSDBA -password masterkey -mend \"" + PathDbReparer + "\"";
                        this.ProcessBkpGfix.StartInfo.UseShellExecute = false;
                        this.ProcessBkpGfix.StartInfo.CreateNoWindow = true;
                        this.ProcessBkpGfix.StartInfo.RedirectStandardOutput = true;
                        this.ProcessBkpGfix.OutputDataReceived += (s, d) =>
                        {
                            if (d.Data != null)
                            {
                                this.Invoke(new Action(() => txtLogComandos.AppendText(d.Data + "\r\n")));
                            }
                        };

                        this.ProcessBkpGfix.Start();
                        this.ProcessBkpGfix.BeginOutputReadLine();
                        this.ProcessBkpGfix.WaitForExit();
                        this.ProcessBkpGfix.CancelOutputRead();
                    }));
                    await Task.Run((Action)(() =>
                    {
                        this.ProcessBkpGbak = new Process();
                        this.ProcessBkpGbak.StartInfo.FileName = ExecutableGBak;
                        this.ProcessBkpGbak.StartInfo.Arguments = "-user SYSDBA -password masterkey -b -g -v \"" + PathDbReparer + "\" \"" + PathDbReparer + ".fbk\"";
                        this.ProcessBkpGbak.StartInfo.UseShellExecute = false;
                        this.ProcessBkpGbak.StartInfo.CreateNoWindow = true;
                        this.ProcessBkpGbak.StartInfo.RedirectStandardOutput = true;
                        this.ProcessBkpGfix.OutputDataReceived += (s, d) =>
                        {
                            if (d.Data != null)
                            {
                                this.Invoke(new Action(() => TxLogReparer.AppendText(d.Data + "\r\n")));
                            }
                        };
                        this.TxLogReparer.Invoke(new Action(() => TxLogReparer.Text += "### Criando Backup ###\r\n"));
                        this.ProcessBkpGbak.Start();
                        this.ProcessBkpGbak.BeginOutputReadLine();
                        this.ProcessBkpGbak.WaitForExit();
                        this.ProcessBkpGbak.CancelOutputRead();
                        if ((uint)this.ProcessBkpGbak.ExitCode > 0U)
                        {
                            this.TxLogReparer.Invoke(new Action(() => TxLogReparer.Text += "Houve um erro - Firebird pode estar desativado ou mau instalado.\r\n"));
                        }
                        else
                        {
                            string dateNow = DateTime.Now.ToString("dd-MM-yyyy hh#mm.ss&").Replace("#", "h").Replace(".", "m").Replace("&", "s");
                            this.TxLogReparer.Invoke(new Action(() => TxLogReparer.AppendText("### Restaurando Backup ###\r\n")));
                            this.TxLogReparer.Invoke(new Action(() => TxLogReparer.AppendText("### Renomeando arquivo " + PathDbReparer + " para \"" + PathDbReparer + "[" + dateNow + "].original\" ###\r\n")));
                            File.Move(PathDbReparer, PathDbReparer + "[" + dateNow + "].original");
                            this.ProcessRestaurarGbak = new Process();
                            this.ProcessRestaurarGbak.StartInfo.FileName = this.ExecutableGBak;
                            this.ProcessRestaurarGbak.StartInfo.Arguments = "-user SYSDBA -password masterkey -c -v \"" + PathDbReparer + ".fbk\" \"" + PathDbReparer + "\"";
                            this.ProcessRestaurarGbak.StartInfo.UseShellExecute = false;
                            this.ProcessRestaurarGbak.StartInfo.CreateNoWindow = true;
                            this.ProcessRestaurarGbak.StartInfo.RedirectStandardOutput = true;
                            this.ProcessRestaurarGbak.OutputDataReceived += (DataReceivedEventHandler)((s, ev) =>
                            {
                                this.TxLogReparer.Invoke(new Action(() => TxLogReparer.AppendText(ev.Data + "\r\n")));
                            });
                            this.ProcessRestaurarGbak.Start();
                            this.ProcessRestaurarGbak.BeginOutputReadLine();
                            this.ProcessRestaurarGbak.WaitForExit();
                            this.ProcessRestaurarGbak.CancelOutputRead();
                            File.Delete(PathDbReparer + ".fbk");
                        }
                    }));

                }
            }
        }

        private void Main_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroProgressBar2_Click(object sender, EventArgs e)
        {

        }

        private void lblPercentagePerFile_Click(object sender, EventArgs e)
        {

        }

        private void BtReparer_Click(object sender, EventArgs e) => this.ExecutarReparer();

       private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    btLiberarCompartilhamento_Click(sender, e);
                    break;
                case '2':
                    btLimparSpooler_Click(sender, e);
                    break;
                case '3':
                    btLiberarFirewall_Click(sender, e);
                    break;
                case (char)52:
                    btFirebird_Click(sender, e);
                    break;
                case (char)53:
                    btMenewPdv_Click(sender, e);
                    break;
                case (char)54:
                    btMenewIntegrador_Click(sender, e);
                    break;
                case (char)55:
                    btMenewPayServer_Click(sender, e);
                    break;
                case (char)56:
                    btMenewSincronizador_Click(sender, e);
                    break;
                case '9':
                    LimparSincronia limparSincronia = new LimparSincronia();
                    limparSincronia.Show();
                    break;
                case (char)48:
                    MessageBox.Show("Voce pressionou " + (char)48);
                    break;



            }

        }
    }
}
