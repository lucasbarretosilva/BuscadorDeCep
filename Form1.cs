using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula41WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml"
                .Replace("@cep", txtCEP.Text);
        
          dataSet.ReadXml(xml);
            txtLogradouro.Text = dataSet.Tables[0].Rows[0]["Logradouro"].ToString();
            txtBairro.Text = dataSet.Tables[0].Rows[0]["Bairro"].ToString();
            txtCidade.Text = dataSet.Tables[0].Rows[0]["Cidade"].ToString();
            txtUF.Text = dataSet.Tables[0].Rows[0]["UF"].ToString();


        }
    }
}
