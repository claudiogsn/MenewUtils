namespace MenewUtils
{
    partial class LimparSincronia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LimparSincronia));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbDtInicial = new System.Windows.Forms.DateTimePicker();
            this.cbDtFinal = new System.Windows.Forms.DateTimePicker();
            this.btXml = new MetroFramework.Controls.MetroButton();
            this.btLimparSinc = new MetroFramework.Controls.MetroButton();
            this.btCloseSinc = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(25, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "De";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(223, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(29, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Até";
            // 
            // cbDtInicial
            // 
            this.cbDtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbDtInicial.Location = new System.Drawing.Point(90, 82);
            this.cbDtInicial.Name = "cbDtInicial";
            this.cbDtInicial.Size = new System.Drawing.Size(103, 20);
            this.cbDtInicial.TabIndex = 3;
            this.cbDtInicial.Value = new System.DateTime(2022, 4, 14, 0, 0, 0, 0);
            // 
            // cbDtFinal
            // 
            this.cbDtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbDtFinal.Location = new System.Drawing.Point(282, 82);
            this.cbDtFinal.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.cbDtFinal.Name = "cbDtFinal";
            this.cbDtFinal.Size = new System.Drawing.Size(103, 20);
            this.cbDtFinal.TabIndex = 4;
            this.cbDtFinal.Value = new System.DateTime(2022, 4, 14, 0, 0, 0, 0);
            // 
            // btXml
            // 
            this.btXml.Location = new System.Drawing.Point(23, 154);
            this.btXml.Name = "btXml";
            this.btXml.Size = new System.Drawing.Size(98, 23);
            this.btXml.TabIndex = 7;
            this.btXml.Text = "Reenviar XML ";
            // 
            // btLimparSinc
            // 
            this.btLimparSinc.Location = new System.Drawing.Point(156, 154);
            this.btLimparSinc.Name = "btLimparSinc";
            this.btLimparSinc.Size = new System.Drawing.Size(98, 23);
            this.btLimparSinc.TabIndex = 6;
            this.btLimparSinc.Text = "Limpar Sincronia";
            this.btLimparSinc.Click += new System.EventHandler(this.btLimparSinc_Click);
            // 
            // btCloseSinc
            // 
            this.btCloseSinc.Location = new System.Drawing.Point(289, 154);
            this.btCloseSinc.Name = "btCloseSinc";
            this.btCloseSinc.Size = new System.Drawing.Size(98, 23);
            this.btCloseSinc.TabIndex = 5;
            this.btCloseSinc.Text = "FECHAR";
            this.btCloseSinc.Click += new System.EventHandler(this.btCloseSinc_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(116, 31);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(179, 25);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Selecione o Periodo";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // LimparSincronia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 200);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btXml);
            this.Controls.Add(this.btLimparSinc);
            this.Controls.Add(this.btCloseSinc);
            this.Controls.Add(this.cbDtFinal);
            this.Controls.Add(this.cbDtInicial);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LimparSincronia";
            this.Load += new System.EventHandler(this.LimparSincronia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker cbDtInicial;
        private System.Windows.Forms.DateTimePicker cbDtFinal;
        private MetroFramework.Controls.MetroButton btXml;
        private MetroFramework.Controls.MetroButton btLimparSinc;
        private MetroFramework.Controls.MetroButton btCloseSinc;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}