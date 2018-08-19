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
    public partial class Form2 : Form
    {
        public String admin { get; set; }
        public Form2()
        {
            InitializeComponent();
            this.admin = userNameBox.Text;
        }
        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // Inside Form2
        // Create a public property to serve the value
        public string TheValue
        {
            get { return this.admin; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection scn = new SQLiteConnection(@"Data Source=mydb.db");

            scn.Open();
            SQLiteCommand sq;
            this.admin = userNameBox.Text;
            Console.Write(this.admin);
            //sq = new SQLiteCommand("select name,cnic,entry_t,exit_t from table1 WHERE exit_t !='-'", scn);
            sq = new SQLiteCommand("select password from users WHERE name ='" + this.admin + "'", scn);


            //SQLiteDataReader dr = sq.ExecuteReader();
            //dr.Read();
            //Console.WriteLine(dr["name"]);
            //Console.WriteLine(dr["password"]);
            string password;
            try
            {
                password = sq.ExecuteScalar().ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("user not found");
                return;
            }

            if (password == passwordTextbox.Text)
            {

                scn.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                Form1 frm1 = new Form1();
                frm1.CurrentAdmin = userNameBox.Text;
                this.Hide();
                frm1.Show();

            }
            else
            {
                MessageBox.Show("sorry");
                scn.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            //SQLiteConnection scn = new SQLiteConnection(@"Data Source=mydb.db");

            //scn.Open();
            //SQLiteCommand sq;
            //this.admin = userNameBox.Text;
            //Console.Write(this.admin);
            ////sq = new SQLiteCommand("select name,cnic,entry_t,exit_t from table1 WHERE exit_t !='-'", scn);
            //sq = new SQLiteCommand("select name,password from users WHERE name ='"+this.admin+"'", scn);

            //SQLiteDataReader dr = sq.ExecuteReader();
            //dr.Read();
            ////Console.WriteLine(dr["name"]);
            ////Console.WriteLine(dr["password"]);

            // if (userNameBox.Text.ToString().Equals(dr["name"]) && passwordTextbox.Text.ToString().Equals(dr["password"]))
            ////if(true)
            //{


            //    // Form2 frm2 = new Form2();
            //    //frm2.admin = userNameBox.Text.ToString();
            //    //Console.WriteLine(frm2.admin);

            //    Form1 frm1 = new Form1();
            //    frm1.CurrentAdmin = userNameBox.Text;
            //    scn.Close();
            //    GC.Collect();
            //    GC.WaitForPendingFinalizers();
            //    sq.Dispose();
            //    frm1.Show();

            //}
            //else
            //{
            //    MessageBox.Show("sorry");
            //    scn.Close();
            //    GC.Collect();
            //    GC.WaitForPendingFinalizers();
            //}

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
