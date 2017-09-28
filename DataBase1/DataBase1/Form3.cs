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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string connectionString = @"provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\Database1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            myOleDbConnection.Open();
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = "SELECT * FROM FIRM";
            DataSet ds = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter(myOleDbCommand);
            adapter.Fill(ds, "FIRM");
            dataGridView1.DataSource = ds.Tables["FIRM"].DefaultView; // выводим данные в DataGridView
            myOleDbConnection.Close();
        }
    }
}
