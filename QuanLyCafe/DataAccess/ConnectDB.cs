using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace QuanLyCafe.DataAccess
{
    class ConnectDB
    {
        SqlConnection con;
         SqlCommand sqlcom;
        SqlDataReader sqldr;
        public string Server { get; set; }
        public string Database { get; set; }

        AppSetting appsetting = new AppSetting();
        //public static string sqlCon = @" server =DESKTOP-MN357EG\SQLEXPRESS; database=QL_Quancaphe; Integrated Security = false; uid =sa; pwd =123;";
        //public static string sqlCon = @"Data Source=MMTNGUYENQUANGM\SQLEXPRESS;Initial Catalog=QL_Quancaphe;Integrated Security=True";          
        

       


        public ConnectDB()
        {
            try
            {
                
                StreamReader read = new StreamReader("Sinfo");
                this.Server = (read.ReadLine().Split(':')[1]);
                this.Database = (read.ReadLine().Split(':')[1]);
                read.Close();
            }
            catch
            {

            }
        }

        public bool testConnection(string connectionString)
        {
            con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public SqlConnection getcon()
        {

            string chuoiketnoi = appsetting.getConnectionString("QL_QuancapheConnectionString");
            con = new SqlConnection(chuoiketnoi);
            return con;

        }

        public void open()
        {
            try
            {
                if (getcon().State == ConnectionState.Closed) ;
                getcon().Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        public void close()
        {
            try
            {
                if (getcon().State == ConnectionState.Open) ;
                getcon().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        public static void writefile(string server, string db)
        {
            StreamWriter write = new StreamWriter("Sinfo");
            write.WriteLine("SV=:" + server);
            write.WriteLine("DB=:" + db);
            write.Close();

        }
        public  DataSet filldataSet(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, getcon());
                da.Fill(ds);
                da.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:"+ ex.Message);
            }

            return ds;
        }

        public DataSet filldataSet(string sql,string table)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, getcon());
                da.Fill(ds,table);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

            return ds;
        }

        public DataSet filldataSet(string strQuery, CommandType cmdtype)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection();
                con = getcon();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = cmdtype;
                cmd.Connection = con;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

            return ds;
        }
        
        public DataTable taobang(string sql)
        {
            

                con = getcon();
                SqlDataAdapter ad = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                return dt;
            
           
        }
        public void ExcuteNonQuery(string sql)
        {
            try
            {
                con = getcon();
                sqlcom = new SqlCommand(sql, con);
                con.Open();
                sqlcom.ExecuteNonQuery();
                con.Close();
                con.Dispose();
            }
            catch
            {

            }
        }

        public bool kiemtra(string sql)
        {
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(sql, con);
            int n = (int)sqlcom.ExecuteScalar();
            con.Close();
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public int returnscalarnumber(string sql)
        {
            con = getcon();            
            if (con.State == ConnectionState.Closed)
                con.Open();
            //con.Open();
            sqlcom = new SqlCommand(sql, con);
            int n = (int)sqlcom.ExecuteScalar();
            con.Close();
            return n;
        }
        public bool returnscalarbool(string sql)
        {
            con = getcon();
            if (con.State == ConnectionState.Closed)
                con.Open();
            //con.Open();
            sqlcom = new SqlCommand(sql, con);
            bool kq = (bool)sqlcom.ExecuteScalar();
            con.Close();
            return kq;
        }

        public string LoadLable(string sql)
        {
            string ketqua = "";
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(sql, con);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                ketqua = sqldr[0].ToString();
            }
            con.Close();
            return ketqua;
        }
        public void LoadLenCombobox(ComboBox cb, string SQL, int chiso)
        {
            cb.Items.Clear();
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(SQL, con);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Items.Add(sqldr[chiso].ToString());
            }
            con.Close();
        }

        public static string ToTitleCase(string mText)
        {
            string rText = "";
            try
            {
                System.Globalization.CultureInfo cultureInfo =
                System.Threading.Thread.CurrentThread.CurrentCulture;
                System.Globalization.TextInfo TextInfo = cultureInfo.TextInfo;
                rText = TextInfo.ToTitleCase(mText);
            }
            catch
            {
                rText = mText;
            }
            return rText;
        }

        public bool kiemtrauser(string sql, string user, string pass)
        {
            con = getcon();
            bool a = true;
            sqlcom = new SqlCommand(sql, con);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (user == sqldr[0].ToString() && pass == sqldr[1].ToString())
                {
                    a = false;
                }
                else
                {
                    a = true;
                }
            }
            return a;
        }

        public bool KiemtraUsername(string strsql)
        {
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(strsql, con);
            int tontai = (int)(sqlcom.ExecuteScalar());
            con.Close();
            if (tontai > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string ExcuteScalar (string sql)
        {
            string s = "";
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(sql, con);
            sqlcom.CommandText = sql;
            try
            {
                s = "" + sqlcom.ExecuteScalar();
                return s;
            }
            catch
            {
                return "";
            }
            
            
        }
    }
}
