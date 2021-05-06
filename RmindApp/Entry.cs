using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmindApp
{
    class Entry
    {
        public string title { get; set; }
        public DateTime expiredDate { get; set; }
        public DateTime reminderDate { get; set; }
        public string reminderCategory { get; set; }
        public string note { get; set; }
    }
}
