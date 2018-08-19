using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewProfile : Form
    {
        //SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\H S Umer Farooq\mydb.db");
        SQLiteConnection scn = new SQLiteConnection(@"Data Source=mydb.db");

        SQLiteCommand sq;
        public NewProfile()
        {
            InitializeComponent();
        }

        private void NewProfile_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            scn.Open();
            sq = new SQLiteCommand(String.Format("insert into users (Name,password) values ('{0}','{1}')",
                  textBox1.Text,
                  textBox2.Text), scn);
            
            
            sq.ExecuteNonQuery();
            scn.Close();
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //sq.Dispose();
            MessageBox.Show("Entry submitted");
        }
    }
}
