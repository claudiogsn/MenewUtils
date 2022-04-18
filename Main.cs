﻿using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
using MenewUtils.Domain.DAO;


using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.IO.Compression;

namespace MenewUtils
{
    
    public partial class Main : MetroForm
    {
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
            txtLogComandos.Text = "Finalizando Processo MenewPdv";
            if (process.Length > 0)
            {
                process[0].Kill();
                if (!File.Exists(@"C:\MvarandasTecnologia\MenewPdv\MenewPdv.exe"))
                { MessageBox.Show("Arquivo MenewPdv.exe não encontrado"); }
                else { System.Diagnostics.Process.Start(@"C:\MvarandasTecnologia\MenewPdv\MenewPdv.exe"); }
            }
            else
            { MessageBox.Show("MenewPdv não está em execução"); }

            if (process.Length > 0)
            { txtLogComandos.Text = "MenewPdv Reiniciado com sucesso!"; }



        }

        private void btMenewIntegrador_Click(object sender, EventArgs e)
        {
            var process = System.Diagnostics.Process.GetProcessesByName("MenewFoodIntegrador");
            txtLogComandos.Text = "Finalizando Processo MenewFoodIntegrador";
            if (process.Length > 0)
            {
                process[0].Kill();
                if (!File.Exists(@"C:\MvarandasTecnologia\MenewFoodIntegrador\MenewFoodIntegrador.exe"))
                { MessageBox.Show("Arquivo MenewFoodIntegrador.exe não encontrado"); }
                else { System.Diagnostics.Process.Start(@"C:\MvarandasTecnologia\MenewFoodIntegrador\MenewFoodIntegrador.exe"); }
            }
            else
            { MessageBox.Show("MenewFoodIntegrador não está em execução"); }

            if (process.Length > 0)
            { txtLogComandos.Text = "MenewFoodIntegrador Reiniciado com sucesso!"; }

        }

        private void btMenewPayServer_Click(object sender, EventArgs e)
        {
            var process = System.Diagnostics.Process.GetProcessesByName("MenewPAYServer");
            txtLogComandos.Text = "Finalizando Processo MenewPAYServer";
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
            { txtLogComandos.Text = "MenewPAYServer Reiniciado com sucesso!"; }

        }

        private void btMenewSincronizador_Click(object sender, EventArgs e)
        {
            var process = System.Diagnostics.Process.GetProcessesByName("MenewSincronizador");
            txtLogComandos.AppendText("Finalizando Processo MenewSincronizador");
            
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
            { txtLogComandos.AppendText("MenewSincronizador Reiniciado com sucesso!"); }

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
                        this.Invoke(new Action(() => txtLogComandos.AppendText(d.Data)));
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
                        this.Invoke(new Action(() => txtLogComandos.AppendText(d.Data)));
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
                        this.Invoke(new Action(() => txtLogComandos.AppendText(d.Data)));
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
                        this.Invoke(new Action(() => txtLogComandos.AppendText(d.Data)));
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

        private void BtBuscarCaminhoRaiz_Click(object sender, EventArgs e)
        
        {
            SelectRaiz.ShowDialog(); 
            string folderPath = SelectRaiz.SelectedPath;
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
                        this.Invoke(new Action(() => TxLogBkpAnalise.AppendText(d.Data)));
                    }
                };
                process.Start();
                process.BeginOutputReadLine();
            
            string str1 = File.ReadAllText(end_bkp).Replace("\r\n", "").Trim();
                //MessageBox.Show("Montando String 1!" + str1);
                string str2 = str1.EndsWith("\\") ? str1.Substring(0, str1.Length - 1) : str1;
                //MessageBox.Show("Montando String 2!" + str2);
                //if (!Directory.Exists(str2))
                   // return;            
                this.TxLogBkpAnalise.Invoke(new Action(() => TxLogBkpAnalise.AppendText("Compactando dados para análise.\r\n")));
                string str3 = DateTime.Now.ToString("dd-MM-yyyy hh#mm.ss&").Replace("#", "h").Replace(".", "m").Replace("&", "s");
                //MessageBox.Show("Montando String 3!" + str3);
                string PathBkpZip = str2 + "[" + str3 + "].zip";
                MessageBox.Show("Compactando dados para análise!");
                ZipFile.CreateFromDirectory(str2, PathBkpZip);
                MessageBox.Show("Backup realizado com sucesso! Caminho do arquivo: " + PathBkpZip);
                if (File.Exists(PathBkpZip))
                    {
                        Directory.Delete(str2, true);
                        Process.Start("Explorer.exe", @"C:\MvarandasTecnologia\BKP");
                    }
            }));                







        }

        private void BtBackup_Click(object sender, EventArgs e) => this.ExecutarBkp();

        private void BtCaminhoMenewPdv_Click(object sender, EventArgs e)
        {
            SelectRaiz.ShowDialog();
            string folderPath = SelectRaiz.SelectedPath;
            TxCaminhoMenewPdv.Text = folderPath;
        }

        private void BtCaminhoMenewPayServer_Click(object sender, EventArgs e)
        {
            SelectRaiz.ShowDialog();
            string folderPath = SelectRaiz.SelectedPath;
            TxCaminhoMenewPayServer.Text = folderPath;
        }

        private void BtCaminhoMenewIntegrador_Click(object sender, EventArgs e)
        {
            SelectRaiz.ShowDialog();
            string folderPath = SelectRaiz.SelectedPath;
            TxCaminhoMenewIntegrador.Text = folderPath;
        }

        private void BtCaminhoMenewSincronizador_Click(object sender, EventArgs e)
        {
            SelectRaiz.ShowDialog();
            string folderPath = SelectRaiz.SelectedPath;
            TxCaminhoMenewSincronizador.Text = folderPath;
        }

        private void BtCaminhoMenewSvc_Click(object sender, EventArgs e)
        {
            SelectRaiz.ShowDialog();
            string folderPath = SelectRaiz.SelectedPath;
            TxCaminhoMenewSvc.Text = folderPath;
        }

        private void BtCaminhoMenewUpdater_Click(object sender, EventArgs e)
        {
            SelectRaiz.ShowDialog();
            string folderPath = SelectRaiz.SelectedPath;
            TxCaminhoMenewUpdater.Text = folderPath;
        }

        private void BtCaminhoBanco_Click(object sender, EventArgs e)
        {
            SelectRaiz.ShowDialog();
            string folderPath = SelectRaiz.SelectedPath;
            TxCaminhoBanco.Text = folderPath;
        }
    }
}
