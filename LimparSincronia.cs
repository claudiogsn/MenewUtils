using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Dapper;
using System.Data.SqlClient;
using MenewUtils.Domain.DAO;

namespace MenewUtils
{
    public partial class LimparSincronia : MetroForm
    {
        public LimparSincronia()
        {
            InitializeComponent();
        }

        private  void LimparSincronia_Load(object sender, EventArgs e)
        {
            


        }

        private async void btLimparSinc_Click(object sender, EventArgs e)
        {
            var tabelasMov = new[] { "tbcabconta", "tbdetconta", "tbpagconta" };
            var dtInicio = (cbDtInicial.Value);
            var dtFinal = (cbDtFinal.Value);
           

            using (var dao = new DaoConnection())
            {
                foreach (var tabela in tabelasMov)
                {
                    var sql = $"update {tabela} set menew_sinc='N' where (dt_mov>=@dtInicio and dt_mov<=@dtFinal)";
                    var param = new { dtInicio, dtFinal };
                    await dao.Connection.ExecuteAsync(sql, param);
                }   
            }
            MessageBox.Show("Limpeza Realizada com Sucesso");

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btCloseSinc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
