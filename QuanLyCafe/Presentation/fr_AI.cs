using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCafe.Business.Component;
using QuanLyCafe.Business.EntitiesClass;
using QuanLyCafe.DataAccess;
using QuanLyCafe.Presentation;
//using COMExcel = Microsoft.Office.Interop.Excel;
using QuanLyCafe.BaoCao;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Workbook = Microsoft.Office.Interop.Excel.Workbook;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

using System.Diagnostics;
using System.IO;

namespace QuanLyCafe.Presentation
{
    public partial class fr_AI : Form
    {


        DataTable tbLoai;
        ConnectDB cn = new ConnectDB();

        public fr_AI()
        {
            InitializeComponent();
        }

        private void fr_AI_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboboxTen_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            excell();
            run_cmd();
        }

        void comboboxTen_Load()
        {
            tbLoai = cn.taobang("SELECT tenloai FROM tb_Loai ");
            comboBox2.DataSource = tbLoai;
            comboBox2.DisplayMember = "tenloai";
        }
        private void run_cmd()
        {

            string fileName = @"D:\QuanLyCafe\QuanLyCafe\hello2.py";


            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Users\E7440\AppData\Local\Programs\Python\Python38-32\python.exe", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,



            };
            p.Start();
            string output = "";

                output += p.StandardOutput.ReadLine();


            p.WaitForExit();


            textBox1.Text = quydoi(output);




        }

        private void excell()
        {
            string path = @"C:\QuanLyCafe\weather.csv";
            string st = File.ReadAllText(path);
            string[] words = st.Split(',');

            words[4] = changeCbx1();
            words[5] = changeCbx2();
            string str = "";

            foreach (string s in words)
            {
                str += s;
                str += ",";
            }
            str = str.Remove(str.Length - 1);
            File.WriteAllText(path, str);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string quydoi(string text)
        {
            if (text == "F2")
            {
                return "Cà Phê Sữa";
            }
            else if (text == "F1")
            {
                return "Trà gừng";
            }
            else if (text == "F4")
            {
                return "Cà Phê Đen Đá";
            }
            else if (text == "F3")
            {
                return "Nước Tăng Lực";
            }
            else
            {
                return "Bánh ngọt";
            }


           
        }
        string changeCbx1()
        {
        
          List<string> arr = new List<string>();
            arr.Add("sunny");
            arr.Add("rainy");
            arr.Add("overcast");
            return arr[comboBox1.SelectedIndex];

        }
        string changeCbx2()
        {

            List<string> arr = new List<string>();
            arr.Add("L03");
            arr.Add("L02");
            arr.Add("L01");
            arr.Add("L04");
            arr.Add("L05");
      
     
            return arr[comboBox2.SelectedIndex];

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}
