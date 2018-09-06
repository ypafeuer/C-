using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Windows.Forms;

namespace WA1070904
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection cnn = new OleDbConnection())
                {
                    cnn.ConnectionString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source=C:\Data\北風.mdb";

                    cnn.Open();
                    MessageBox.Show("連接Access成功！");
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection cnn = new OleDbConnection())
                {
                    string cnnS = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Data\資料.xls;";
                    cnnS += "Extended Properties=\"Excel 8.0;HDR=YES;\"";

                    cnn.ConnectionString = cnnS;
                    cnn.Open();
                    MessageBox.Show("連接Excel成功！");
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection cnn = new OleDbConnection())
                {
                    cnn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Data\北風.accdb";

                    cnn.Open();
                    MessageBox.Show("連接Access成功！");
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection cnn = new OleDbConnection())
                {
                    string cnnS = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Data\資料.xlsx;";
                    cnnS += "Extended Properties=\"Excel 12.0;HDR=YES;\"";

                    cnn.ConnectionString = cnnS;
                    cnn.Open();
                    MessageBox.Show("連接Excel 2007成功！");
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection())
                {
                    cnn.ConnectionString = "Data Source=localhost;Initial Catalog=中文北風;Integrated Security=true;";

                    cnn.Open();
                    MessageBox.Show("連接 SQL 中文北風 成功！");
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection())
                {
                    cnn.ConnectionString = "Data Source=localhost;Initial Catalog=中文北風;UID=SQLUser;PWD=1234;";

                    cnn.Open();
                    MessageBox.Show("連接 SQL 中文北風 成功！");
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string uu = textBox1.Text;
            string pp = textBox2.Text;

            try
            {
                using (SqlConnection cnn = new SqlConnection())
                {
                    //cnn.ConnectionString = "Data Source=localhost;Initial Catalog=中文北風;UID=" + uu + ";PWD=" + pp + ";";   //切勿串接SQL命令
                    //cnn.ConnectionString = string.Format("Data Source=localhost;Initial Catalog=中文北風;UID={0};PWD={1};", uu, pp);

                    SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
                    scsb.DataSource = "localhost";
                    scsb.InitialCatalog = "中文北風";
                    scsb.IntegratedSecurity = false;
                    scsb.UserID = uu;
                    scsb.Password = pp;
                    cnn.ConnectionString = scsb.ConnectionString;

                    cnn.Open();
                    MessageBox.Show("連接 SQL 中文北風 成功！");
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                using (OdbcConnection cnn = new OdbcConnection())
                {
                    cnn.ConnectionString = @"Driver={Microsoft Access Driver (*.mdb)};DBQ=C:\Data\北風.mdb;UID=;PWD=;";

                    cnn.Open();
                    MessageBox.Show("ODBC 連接 Access 成功！");
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                using (OdbcConnection cnn = new OdbcConnection())
                {
                    cnn.ConnectionString = @"Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};DBQ=C:\Data\資料.xlsx;UID=;PWD=;";

                    cnn.Open();
                    MessageBox.Show("ODBC 連接 Excel 成功！");
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                using (OdbcConnection cnn = new OdbcConnection())
                {
                    //cnn.ConnectionString = "Driver={SQL Server};Server=localhost;UID=SQLUser;PWD=1234;Database=中文北風;";
                    cnn.ConnectionString = "Driver={ODBC Driver 13 for SQL Server};Server=localhost;UID=SQLUser;PWD=1234;Database=中文北風;";

                    cnn.Open();
                    MessageBox.Show("ODBC 連接 SQL 中文北風 成功！");
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                using (OdbcConnection cnn = new OdbcConnection())
                {
                    cnn.ConnectionString = @"Driver={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=C:\Data\北風.accdb;UID=;PWD=;";

                    cnn.Open();
                    MessageBox.Show("ODBC 連接 Access 2007 成功！");
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                using (OdbcConnection cnn = new OdbcConnection())
                {
                    //cnn.ConnectionString = @"DSN=MyDB;UID=;PWD=;";
                    cnn.ConnectionString = @"DSN=MyDB;Database=中文北風;UID=SQLUser;PWD=1234;";

                    cnn.Open();
                    MessageBox.Show("ODBC 連接 資料庫 成功！");
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string cnnS = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Data\資料.xlsx;";
            cnnS += "Extended Properties=\"Excel 12.0;HDR=YES;\"";

            //string cmdS = "INSERT INTO [Sheet1] VALUES(26,'可樂',30)";
            string cmdS = "INSERT INTO [Sheet1$] VALUES(26,'可樂',30)";

            using (OleDbConnection cnn = new OleDbConnection(cnnS))
            {
                cnn.ConnectionString = cnnS;
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.CommandText = cmdS;
                    cmd.Connection = cnn;

                    cnn.Open();
                    int cc = cmd.ExecuteNonQuery();
                    if(cc>0)
                        MessageBox.Show("Excel 新增資料成功！");
                    else
                        MessageBox.Show("Excel 並未新增任何資料！");

                    cmd.Dispose();
                    cnn.Close();
                }                 
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string cnnS = @"server=localhost;database=中文北風;UID=SQLUser;PWD=1234;";                        
            string cmdS = "SELECT COUNT(*) FROM 產品資料";

            using (SqlConnection cnn = new SqlConnection(cnnS))
            {
                cnn.ConnectionString = cnnS;
                using (SqlCommand cmd = new SqlCommand(cmdS,cnn))
                {
                    cnn.Open();
                    int cc = (int)cmd.ExecuteScalar();
                    cmd.Dispose();
                    cnn.Close();

                    label1.Text = cc.ToString();
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string cnnS = @"server=localhost;database=中文北風;UID=SQLUser;PWD=1234;";
            string cmdS = "SELECT 產品編號,產品,單價,單位數量,庫存量 FROM 產品資料";

            using (SqlConnection cnn = new SqlConnection(cnnS))
            {
                cnn.ConnectionString = cnnS;
                using (SqlCommand cmd = new SqlCommand(cmdS, cnn))
                {
                    cnn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        StringBuilder sb = new StringBuilder();
                        while (dr.Read())
                        {
                            sb.Append(dr[0]).Append("\t");
                            sb.Append(dr["產品"]).Append("\t");
                            sb.Append(dr["單價"]).Append("\t");
                            sb.Append(dr[3]).Append("\t");
                            sb.Append(dr[4]).Append("\t");
                            sb.Append("\r\n");
                        }
                        textBox3.Text = sb.ToString();
                    }
                    else
                    {
                        MessageBox.Show("查無任何資料！");
                    }
                    dr.Close();
                    cmd.Dispose();
                    cnn.Close();                    
                }
            }


        }
    }
}
