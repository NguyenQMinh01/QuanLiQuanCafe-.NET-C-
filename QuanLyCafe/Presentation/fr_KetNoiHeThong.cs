using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyCafe.DataAccess;
using System.Data.SqlClient;
using System.Data.Sql;
namespace QuanLyCafe.Presentation
{
    public partial class fr_KetNoiHeThong : Form
    {
        ConnectDB db = new ConnectDB();
        AppSetting ap = new AppSetting();
        string connectionString;
        public fr_KetNoiHeThong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtUsername.Text == "")
            //{
            //    connectionString = string.Format("server = {0}; database = {1}; Integrated Security = True;", textBox1.Text, textBox2.Text);
            //}
            //else
            //{
            //    connectionString = string.Format("server = {0}; database = {1}; Integrated Security = False; uid = {2}; pwd = {3};", textBox1.Text, textBox2.Text, txtUsername.Text, txtPassword.Text);
            //}
            //if (db.testConnection(connectionString))
            //{
            //    MessageBox.Show("Success");
            //}
            //else
            //    MessageBox.Show("Connection fail");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveConfig(cbbSevername.Text, txtUsername.Text, txtPassword.Text, cbbDatabase.Text);
            
            this.Close();
        }
        private static void UpdateSetting(string key, string value)
        {
            
        }
        
        private void cbbSevername_DropDown(object sender, EventArgs e)
        {
            cbbSevername.DataSource = GetServerName();
            cbbSevername.DisplayMember = "ServerName";
        }

        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }

        private void cbbDatabase_DropDown(object sender, EventArgs e)
        {
            cbbDatabase.DataSource = GetDBName(cbbSevername.Text, txtUsername.Text, txtPassword.Text);
            cbbDatabase.DisplayMember = "name";
        }

        public DataTable GetDBName(string pServer, string pUser, string pPass)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source=" +
                pServer + ";Initial Catalog=master;User ID=" + pUser + ";pwd = " + pPass + "");
                da.Fill(dt);
                return dt;
            }
            catch
            {
            }
            return new DataTable();

            
           
        }

        public void SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        {
            
            QuanLyCafe.Properties.Settings.Default.Quanlicaphe = "Data Source=" + pServer + ";Initial Catalog=" +
                pDBname + ";User ID=" + pUser + ";pwd = " + pPass + "";
            QuanLyCafe.Properties.Settings.Default.Save();

            

            
        }


        private void fr_KetNoiHeThong_Load(object sender, EventArgs e)
        {

        }
    }
}
