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
            //var dataCerta = cbDtInicial.DataBindings.ToString();
            //var dataCertafim = cbDtInicial.DataBindings.ToString();
            w DtInicio = Convert.ToDateTime(cbDtInicial.Value);
            var DtFinal = Convert.ToString(cbDtFinal.Value);
            MessageBox.Show("Data Inicio: " + DtInicio + " Data Final " + DtFinal);




            using (var dao = new DaoConnection())
            {
                await dao.Connection.ExecuteAsync("update tbcabconta set menew_sinc='N' where (dt_mov>='" + DtInicio + "' and dt_mov<='" + DtFinal + "')");
           }

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
