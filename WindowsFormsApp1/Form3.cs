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
using System.Diagnostics;
namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            //SQLiteConnection scn = new SQLiteConnection(@"Data Source=C:\Users\H S Umer Farooq\mydb.db");
            SQLiteConnection scn = new SQLiteConnection(@"Data Source=mydb.db");

            scn.Open();
            SQLiteCommand sq;
            sq = new SQLiteCommand("select * from table1 where date between '" + dateTimePicker2.Text + "' and '" + dateTimePicker3.Text + "'", scn);
            SQLiteDataReader dr = sq.ExecuteReader();

            while (dr.Read())
            {

                listView1.Items.Add(new ListViewItem(new[] { dr["id"].ToString(),

                                                             dr["cnic"].ToString(),
                                                             dr["name"].ToString(),
                                                             dr["fathername"].ToString(),
                                                             dr["contact"].ToString(),
                                                             dr["address"].ToString(),
                                                             
                                                             dr["purpose"].ToString(),
                                                             dr["entry_time"].ToString(),
                                                             dr["exit_time"].ToString(),
                                                             dr["date"].ToString(),
                                                             dr["admin"].ToString()}));
            }
            scn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SQLiteConnection scn = new SQLiteConnection(@"Data Source=C:\Users\H S Umer Farooq\mydb.db");
            SQLiteConnection scn = new SQLiteConnection(@"Data Source=mydb.db");

            scn.Open();
            SQLiteCommand sq;
            sq = new SQLiteCommand("update table1 set exit_time='" + DateTime.Now.ToShortTimeString() + "' where id='" + listView1.SelectedItems[0].Text + "'", scn);
            sq.ExecuteNonQuery();
            button4.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewProfile np = new NewProfile();
            np.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                ExportToExcel("history.csv", listView1);
            
        }

        private void ExportToExcel(string path, ListView listsource)
        {
            StringBuilder CVS = new StringBuilder();
            for (int i = 0; i < listsource.Columns.Count; i++)
            {
                CVS.Append(listsource.Columns[i].Text + ",");
            }
            CVS.Append(Environment.NewLine);
            for (int i = 0; i < listsource.Items.Count; i++)
            {
                for (int j = 0; j < listsource.Columns.Count; j++)
                {
                    CVS.Append(listsource.Items[i].SubItems[j].Text + ",");
                }
                CVS.Append(Environment.NewLine);
            }
            System.IO.File.WriteAllText(path, CVS.ToString());
            Process.Start(path);
        }
    }
}
