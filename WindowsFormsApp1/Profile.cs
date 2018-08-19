using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Profile
    {
        private string Name;
        private string CNIC;
        private string ContactNo;
        private string Purpose;
        private string Entry_t;
        private string Exit_t;
        private string Date;
        private string Admin;
//private Entry Entries;

        public string name { get; set; }
        public string cnic { get; set; }
        public string contactNo { get; set; }
        public string purpose { get; set; }
        public string entry_t { get; set; }
        public string exit_t { get; set; }
        public string date { get; set; }
        public string admin { get; set; }


        public Profile(string Name,string CNIC, string ContactNo, string Purpose, string Entry_t, string Exit_t,string Date,string Admin)
        {
            this.Name = Name;
            this.CNIC = CNIC;
            this.ContactNo = ContactNo;
            this.Purpose = Purpose;
            this.Entry_t = Entry_t;
            this.Exit_t = Exit_t;
            this.Date = Date;
            this.Admin = Admin;
        }
    }
}
