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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = @"provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\Database1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            myOleDbConnection.Open();
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = "SELECT * FROM CITY";
            DataSet ds = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter(myOleDbCommand);
            adapter.Fill(ds, "CITY");
            dataGridView1.DataSource = ds.Tables["CITY"].DefaultView; // выводим данные в DataGridView
            myOleDbConnection.Close();
        }
    }
}
