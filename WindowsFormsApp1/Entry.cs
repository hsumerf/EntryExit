using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Entry
    {
        private DateTime EntryTime;
        private DateTime ExitTime;
        private string VisitPurpose;

        public DateTime entryTime { get; set; }
        public DateTime exitTime  { get; set; }
        public string visitPurpose { get; set; }

        public Entry(DateTime EntryTime,string VisitPurpose)
        {
            this.EntryTime = EntryTime;
            this.VisitPurpose = VisitPurpose;
        }
        public Entry()
        {

        }
    }





}
