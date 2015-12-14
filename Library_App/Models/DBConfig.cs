using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App.Models
{
    enum DbAuthType
    {
        Sql = 0, Windows = 1
    }

    class DbConfig
    {
        public string ServerName { get; set; }
        public DbAuthType AuthType { get; set; }
        public string SqlLogin { get; set; }
        public string SqlPassword { get; set; }
    }
}
