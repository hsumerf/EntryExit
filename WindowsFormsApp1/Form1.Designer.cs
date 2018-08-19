namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.visitorName = new System.Windows.Forms.TextBox();
            this.cnic = new System.Windows.Forms.TextBox();
            this.contactNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SerialNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InPerson = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNICNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.fatherName = new System.Windows.Forms.TextBox();
            this.fatherNameLabel = new System.Windows.Forms.Label();
            this.visitPurpose = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // visitorName
            // 
            this.visitorName.Location = new System.Drawing.Point(141, 76);
            this.visitorName.Name = "visitorName";
            this.visitorName.Size = new System.Drawing.Size(156, 20);
            this.visitorName.TabIndex = 1;
            this.visitorName.Text = "a";
            this.visitorName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cnic
            // 
            this.cnic.Location = new System.Drawing.Point(141, 30);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(156, 20);
            this.cnic.TabIndex = 0;
            // 
            // contactNo
            // 
            this.contactNo.Location = new System.Drawing.Point(141, 183);
            this.contactNo.Name = "contactNo";
            this.contactNo.Size = new System.Drawing.Size(156, 20);
            this.contactNo.TabIndex = 3;
            this.contactNo.Text = "03-3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "CNIC";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(19, 187);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(53, 16);
            this.contactLabel.TabIndex = 7;
            this.contactLabel.Text = "Contact";
            this.contactLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(178, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(27, 325);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(266, 58);
            this.address.TabIndex = 6;
            this.address.Text = "sdr";
            this.address.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Visit Purpose";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(137, 289);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker3.TabIndex = 5;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Records";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SerialNo,
            this.InPerson,
            this.CNICNumber,
            this.Time});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(343, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(471, 438);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // SerialNo
            // 
            this.SerialNo.Text = "S. No";
            this.SerialNo.Width = 73;
            // 
            // InPerson
            // 
            this.InPerson.Text = "In person";
            this.InPerson.Width = 118;
            // 
            // CNICNumber
            // 
            this.CNICNumber.Text = "CNIC";
            this.CNICNumber.Width = 148;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 122;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(739, 528);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(467, 20);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(166, 26);
            this.status.TabIndex = 34;
            this.status.Text = "Current Status";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(419, 528);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // fatherName
            // 
            this.fatherName.Location = new System.Drawing.Point(141, 128);
            this.fatherName.Name = "fatherName";
            this.fatherName.Size = new System.Drawing.Size(156, 20);
            this.fatherName.TabIndex = 2;
            this.fatherName.Text = "b";
            // 
            // fatherNameLabel
            // 
            this.fatherNameLabel.AutoSize = true;
            this.fatherNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatherNameLabel.Location = new System.Drawing.Point(12, 132);
            this.fatherNameLabel.Name = "fatherNameLabel";
            this.fatherNameLabel.Size = new System.Drawing.Size(86, 16);
            this.fatherNameLabel.TabIndex = 37;
            this.fatherNameLabel.Text = "Father Name";
            // 
            // visitPurpose
            // 
            this.visitPurpose.Location = new System.Drawing.Point(141, 223);
            this.visitPurpose.Name = "visitPurpose";
            this.visitPurpose.Size = new System.Drawing.Size(156, 20);
            this.visitPurpose.TabIndex = 4;
            this.visitPurpose.Text = "check";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 563);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visitPurpose);
            this.Controls.Add(this.fatherNameLabel);
            this.Controls.Add(this.fatherName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.status);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.address);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contactNo);
            this.Controls.Add(this.cnic);
            this.Controls.Add(this.visitorName);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox visitorName;
        private System.Windows.Forms.TextBox cnic;
        private System.Windows.Forms.TextBox contactNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader SerialNo;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader CNICNumber;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader InPerson;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox fatherName;
        private System.Windows.Forms.Label fatherNameLabel;
        private System.Windows.Forms.TextBox visitPurpose;
        private System.Windows.Forms.Label label2;
    }
}

