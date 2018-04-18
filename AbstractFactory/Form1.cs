using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        string providerName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            providerName = "System.Data.OleDb";
            CreateAbstractClass(providerName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            providerName = "System.Data.SqlClient";
            CreateAbstractClass(providerName);
        }
        public void CreateAbstractClass(string providerName)
        {

            //DbProviderFactory factory = DbProviderFactories.GetFactory(providerName);
            //var commandprovider = factory.CreateCommand();
            //var connectionprovider = factory.CreateConnection();
            ////var con = connectionprovider.ConnectionString();
            //commandprovider.CommandText = "select * from sometable";


            //DbConnection con = factory.Createconnection();
            //DbCommand cmd = con.CreateCommand();
            //cmd.CommandText = "Select * From [sometable]";
            //cmd.CommandType = CommandType.Text;

            //DataSet ds = new DataSet();
            //DbDataAdapter ad = factory.CreateDataAdapter();
            //ad.SelectCommand = cmd;

            //con.Open();
            //ad.Fill(ds);
            //con.Close();
        }
    }
}
