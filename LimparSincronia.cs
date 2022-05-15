using Dapper;
using MenewUtils.Domain.DAO;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace MenewUtils
{
    public partial class LimparSincronia : MetroForm
    {
        public LimparSincronia()
        {
            InitializeComponent();
        }

        private void LimparSincronia_Load(object sender, EventArgs e)
        {



        }

        private async void btLimparSinc_Click(object sender, EventArgs e)
        {
            var tabelasMov = new[] { "tbcabconta","tbdetconta","tbpagconta","tbocor","tbretirada","tbfecha","tbidentifica" };
            var tabelasCad = new[] { "tbprod","tbope","tbtipo_categ","tbpizza","tbobs","tbkit","tbforma","tbfavoritos","tbentregador","tbcombo","tbcliente","tbnfce_inutilizacao"};
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
                foreach (var tabela in tabelasCad)
                {
                    var sql = $"update {tabela} set menew_sinc='N'";
                    await dao.Connection.ExecuteAsync(sql);
                }
                var sqltbNfce = $"update TBNFCE set menew_sinc='N' where (data_emissao>=@dtInicio and data_emissao<=@dtFinal)";
                var sqltbNfce_Itens = $"update TBNFCE_ITENS set menew_sinc='N' WHERE COD_DOC IN (SELECT DOC FROM TBNFCE WHERE (data_emissao>=@dtInicio and data_emissao<=@dtFinal))";
                var sqltbNfce_Pag = $"update TBNFCE_PAG set menew_sinc='N' WHERE COD_DOC IN (SELECT DOC FROM TBNFCE WHERE (data_emissao>=@dtInicio and data_emissao<=@dtFinal))";
                var paramNfce = new { dtInicio, dtFinal };
                await dao.Connection.ExecuteAsync(sqltbNfce, paramNfce);
                await dao.Connection.ExecuteAsync(sqltbNfce_Itens, paramNfce);
                await dao.Connection.ExecuteAsync(sqltbNfce_Pag, paramNfce);
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

        private void cbDtFinal_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
