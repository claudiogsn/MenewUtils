using MetroFramework.Forms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

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
            txtLogComandos.Text = "Finalizando Processo MenewSincronizador";
            if (process.Length > 0)
            {
                process[0].Kill();
                if (!File.Exists(@"C:\MvarandasTecnologia\MenewSincronizador\MenewSincronizador.exe"))
                { MessageBox.Show("Arquivo MenewSincronizador.exe não encontrado"); }
                else { System.Diagnostics.Process.Start(@"C:\MvarandasTecnologia\MenewSincronizador\MenewSincronizador.exe"); }
            }
            else
            {MessageBox.Show("MenewSincronizador não está em execução");}
            
            if (process.Length > 0)
            {txtLogComandos.Text = "MenewSincronizador Reiniciado com sucesso!";}

        }

        private void btLiberarCompartilhamento_Click(object sender, EventArgs e)
        {
            using (Process process = new Process())
            {
                
                process.StartInfo.FileName = Application.StartupPath + "\\bats\\LiberaPasta.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();

            
                StreamReader reader = process.StandardOutput;
                string output = reader.ReadToEnd();
                txtLogComandos.Text = output;
               

                process.WaitForExit();
            }

        }

        private void btLimparSpooler_Click(object sender, EventArgs e)
        {
            using (Process process = new Process())
            {

                process.StartInfo.FileName = Application.StartupPath + "\\bats\\LimparSpooler.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();


                StreamReader reader = process.StandardOutput;
                string output = reader.ReadToEnd();
                txtLogComandos.Text = output;


                process.WaitForExit();
            }
        }

        private void btLiberarFirewall_Click(object sender, EventArgs e)
        {
            using (Process process = new Process())
            {

                process.StartInfo.FileName = Application.StartupPath + "\\bats\\LiberarFirewall.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();


                StreamReader reader = process.StandardOutput;
                string output = reader.ReadToEnd();
                txtLogComandos.Text = output;


                process.WaitForExit();
            }

        }

        private void btFirebird_Click(object sender, EventArgs e)
        {
            using (Process process = new Process())
            {

                process.StartInfo.FileName = Application.StartupPath + "\\bats\\Firebird.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();


                StreamReader reader = process.StandardOutput;
                string output = reader.ReadToEnd();
                txtLogComandos.Text = output;


                process.WaitForExit();
            }
        }
    }

  }
