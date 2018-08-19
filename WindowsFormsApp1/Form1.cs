using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Threading;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {

          
        public string CurrentAdmin { get; set; }

        //SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\H S Umer Farooq\mydb.db");
        

        SQLiteCommand command;
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // for sing in username
            listView1.Items.Clear();
            //SQLiteConnection scn = new SQLiteConnection(@"Data Source=C:\Users\H S Umer Farooq\mydb.db");

           SQLiteConnection scn = new SQLiteConnection(@"Data Source=mydb.db");
            scn.Open();
            SQLiteCommand sq = new SQLiteCommand("INSERT INTO table1 (cnic,name,fathername,contact,address,purpose,entry_time,exit_time,date,admin) " +
                                               "values ('" + cnic.Text + "','" + visitorName.Text + "','" + fatherName.Text + "','" + contactNo.Text + "','" + address.Text + "','" + visitPurpose.Text + "','"

                                               + DateTime.Now.ToShortTimeString().ToString() + "','" + "-" + "','" + dateTimePicker3.Text + "','" + CurrentAdmin + "')", scn);
            sq.ExecuteNonQuery();
            scn.Close();
            button3.PerformClick();
            //SQLiteConnection scn = new SQLiteConnection(@"Data Source=mydb.db");

            //scn.Open();
           
            //command = new SQLiteCommand(scn);
        

            //if (!File.Exists(DatabaseFile))
            //{

            //    SQLiteConnection.CreateFile(DatabaseFile);
            //    command.CommandText = CreateTableQuery;
            //    command.ExecuteNonQuery();

            //}
            //Entry entries = new Entry(DateTime.Now, VisitPurpose.Text);
            
            //command.CommandText = ;
            //command.ExecuteNonQuery();
            //conn.Close();
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //command.Dispose();
            MessageBox.Show("by"+ CurrentAdmin);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Active Window";
            MessageBox.Show(CurrentAdmin);
            button3.PerformClick();

            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            //SQLiteConnection scn = new SQLiteConnection(@"Data Source=C:\Users\H S Umer Farooq\mydb.db");
            SQLiteConnection scn = new SQLiteConnection(@"Data Source=mydb.db");

            scn.Open();
            SQLiteCommand sq;
            sq = new SQLiteCommand("select id,name,cnic,entry_time from table1 WHERE exit_time='-'", scn);
            SQLiteDataReader dr = sq.ExecuteReader();
           
            while (dr.Read())
            {
                //String indexTab = index.ToString();
                listView1.Items.Add(new ListViewItem(new[] {
                                                            dr["id"].ToString(),
                                                             dr["name"].ToString(),
                                                             dr["cnic"].ToString(),
                                                             dr["entry_time"].ToString(),
                                                            
                                                             }));
               


            }
            scn.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            sq.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SQLiteConnection scn = new SQLiteConnection(@"Data Source=mydb.db");

            scn.Open();
            SQLiteCommand sq;
            sq = new SQLiteCommand("update table1 set exit_time='" + DateTime.Now.ToShortTimeString() + "' where id='" + listView1.SelectedItems[0].Text + "'", scn);
            Console.WriteLine(listView1.SelectedItems[0].Text);
            sq.ExecuteNonQuery();
            button3.PerformClick();
            //
            
        }
    }
}

