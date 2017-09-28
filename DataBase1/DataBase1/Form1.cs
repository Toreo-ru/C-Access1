using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace DataBase1
{
    public partial class Form1 : Form
    {
       


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int s = 0;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
               
            }
            else
            {
                 s = 1;
            }
            
            if (string.IsNullOrEmpty(textBox2.Text)) 
            {
                
            }
            else
            {
                s = 2;
            }
               
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                
            }
            else
            {
                s = 3;
            }

            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)))
            {

            }
            else
            {
                s = 4;
            }

            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox3.Text)))
            {

            }
            else
            {
                s = 5;
            }

            if ((string.IsNullOrEmpty(textBox2.Text)) || (string.IsNullOrEmpty(textBox3.Text)))
            {

            }
            else
            {
                s = 6;
            }

            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)) || (string.IsNullOrEmpty(textBox3.Text)))
            {

            }
            else
            {
                s = 7;
            }

            string connectionString = @"provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\Database1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            myOleDbConnection.Open();
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
            DataSet ds = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter(myOleDbCommand);

            switch (s)
            {
                case 1:
                        
                        myOleDbCommand.Parameters.Add("@p", SqlDbType.NChar);
                        myOleDbCommand.Parameters["@p"].Value = textBox1.Text;
                        myOleDbCommand.CommandText = "SELECT FIRM.NAME AS [Название фирмы], JUR_CITY.NAME AS [Город юридического адреса], POST_CITY.NAME AS [Город почтового адреса] FROM (FIRM INNER JOIN CITY AS JUR_CITY ON FIRM.JUR_CITY_ID = JUR_CITY.CITY_ID) INNER JOIN CITY AS POST_CITY ON FIRM.POST_CITY_ID = POST_CITY.CITY_ID WHERE FIRM.NAME = @p";
                        adapter.Fill(ds, "CITY");
                        dataGridView1.DataSource = ds.Tables["CITY"].DefaultView; // выводим данные в DataGridView
                        myOleDbConnection.Close();
                    break;
                case 2:

                        myOleDbCommand.Parameters.Add("@p", SqlDbType.NChar);
                        myOleDbCommand.Parameters["@p"].Value = textBox2.Text;
                        myOleDbCommand.CommandText = "SELECT FIRM.NAME AS [Название фирмы], JUR_CITY.NAME AS [Город юридического адреса], POST_CITY.NAME AS [Город почтового адреса] FROM (FIRM INNER JOIN CITY AS JUR_CITY ON FIRM.JUR_CITY_ID = JUR_CITY.CITY_ID) INNER JOIN CITY AS POST_CITY ON FIRM.POST_CITY_ID = POST_CITY.CITY_ID WHERE JUR_CITY.NAME = @p";                     
                        adapter.Fill(ds, "CITY");
                        dataGridView1.DataSource = ds.Tables["CITY"].DefaultView; // выводим данные в DataGridView
                        myOleDbConnection.Close();
                    break;
                case 3:
                        
                       
                        myOleDbCommand.Parameters.Add("@p", SqlDbType.NChar);
                        myOleDbCommand.Parameters["@p"].Value = textBox3.Text;
                        myOleDbCommand.CommandText = "SELECT FIRM.NAME AS [Название фирмы], JUR_CITY.NAME AS [Город юридического адреса], POST_CITY.NAME AS [Город почтового адреса] FROM (FIRM INNER JOIN CITY AS JUR_CITY ON FIRM.JUR_CITY_ID = JUR_CITY.CITY_ID) INNER JOIN CITY AS POST_CITY ON FIRM.POST_CITY_ID = POST_CITY.CITY_ID WHERE POST_CITY.NAME = @p";                        
                        adapter.Fill(ds, "CITY");
                        dataGridView1.DataSource = ds.Tables["CITY"].DefaultView; // выводим данные в DataGridView
                        myOleDbConnection.Close();

                    break;
                case 4:

                    myOleDbCommand.Parameters.Add("@p", SqlDbType.NChar);
                    myOleDbCommand.Parameters["@p"].Value = textBox1.Text;
                    myOleDbCommand.Parameters.Add("@z", SqlDbType.NChar);
                    myOleDbCommand.Parameters["@z"].Value = textBox2.Text;
                    myOleDbCommand.CommandText = "SELECT FIRM.NAME AS [Название фирмы], JUR_CITY.NAME AS [Город юридического адреса], POST_CITY.NAME AS [Город почтового адреса] FROM (FIRM INNER JOIN CITY AS JUR_CITY ON FIRM.JUR_CITY_ID = JUR_CITY.CITY_ID) INNER JOIN CITY AS POST_CITY ON FIRM.POST_CITY_ID = POST_CITY.CITY_ID WHERE FIRM.NAME = @p AND JUR_CITY.NAME = @z";                  
                    adapter.Fill(ds, "CITY");
                    dataGridView1.DataSource = ds.Tables["CITY"].DefaultView; // выводим данные в DataGridView
                    myOleDbConnection.Close();

                    break;
                case 5:
 
                    myOleDbCommand.Parameters.Add("@p", SqlDbType.NChar);
                    myOleDbCommand.Parameters["@p"].Value = textBox1.Text;
                    myOleDbCommand.Parameters.Add("@z", SqlDbType.NChar);
                    myOleDbCommand.Parameters["@z"].Value = textBox3.Text;
                    myOleDbCommand.CommandText = "SELECT FIRM.NAME AS [Название фирмы], JUR_CITY.NAME AS [Город юридического адреса], POST_CITY.NAME AS [Город почтового адреса] FROM (FIRM INNER JOIN CITY AS JUR_CITY ON FIRM.JUR_CITY_ID = JUR_CITY.CITY_ID) INNER JOIN CITY AS POST_CITY ON FIRM.POST_CITY_ID = POST_CITY.CITY_ID WHERE FIRM.NAME = @p AND POST_CITY.NAME = @z";                   
                    adapter.Fill(ds, "CITY");
                    dataGridView1.DataSource = ds.Tables["CITY"].DefaultView; // выводим данные в DataGridView
                    myOleDbConnection.Close();

                    break;
                case 6:
 
                    myOleDbCommand.Parameters.Add("@p", SqlDbType.NChar);
                    myOleDbCommand.Parameters["@p"].Value = textBox2.Text;
                    myOleDbCommand.Parameters.Add("@z", SqlDbType.NChar);
                    myOleDbCommand.Parameters["@z"].Value = textBox3.Text;
                    myOleDbCommand.CommandText = "SELECT FIRM.NAME AS [Название фирмы], JUR_CITY.NAME AS [Город юридического адреса], POST_CITY.NAME AS [Город почтового адреса] FROM (FIRM INNER JOIN CITY AS JUR_CITY ON FIRM.JUR_CITY_ID = JUR_CITY.CITY_ID) INNER JOIN CITY AS POST_CITY ON FIRM.POST_CITY_ID = POST_CITY.CITY_ID WHERE JUR_CITY.NAME = @p AND POST_CITY.NAME = @z";                   
                    adapter.Fill(ds, "CITY");
                    dataGridView1.DataSource = ds.Tables["CITY"].DefaultView; // выводим данные в DataGridView
                    myOleDbConnection.Close();

                    break;
                case 7:                  
                    myOleDbCommand.Parameters.Add("@x", SqlDbType.NChar);
                    myOleDbCommand.Parameters["@x"].Value = textBox1.Text;
                    myOleDbCommand.Parameters.Add("@p", SqlDbType.NChar);
                    myOleDbCommand.Parameters["@p"].Value = textBox2.Text;
                    myOleDbCommand.Parameters.Add("@z", SqlDbType.NChar);
                    myOleDbCommand.Parameters["@z"].Value = textBox3.Text;
                    myOleDbCommand.CommandText = "SELECT FIRM.NAME AS [Название фирмы], JUR_CITY.NAME AS [Город юридического адреса], POST_CITY.NAME AS [Город почтового адреса] FROM (FIRM INNER JOIN CITY AS JUR_CITY ON FIRM.JUR_CITY_ID = JUR_CITY.CITY_ID) INNER JOIN CITY AS POST_CITY ON FIRM.POST_CITY_ID = POST_CITY.CITY_ID WHERE FIRM.NAME = @x AND JUR_CITY.NAME = @p AND POST_CITY.NAME = @z";                    
                    adapter.Fill(ds, "CITY");
                    dataGridView1.DataSource = ds.Tables["CITY"].DefaultView; // выводим данные в DataGridView
                    myOleDbConnection.Close();

                    break;
            }
        }

        private void показатьТаблицуCITYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            
        }

        private void показатьТаблицуFIRMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
