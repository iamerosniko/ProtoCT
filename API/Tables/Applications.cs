using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Tables
{
    public class Applications
    {
        public int AppID { get; set; }
        public string AppName { get; set; }
        public string AppMemberName { get; set; }
        public string AppUrl { get; set; }
        public string AppSecurityKey { get; set; }
    }
}
