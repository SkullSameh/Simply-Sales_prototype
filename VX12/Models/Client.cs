using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VX12.Models
{
    public class Client
    {
        [PrimaryKey , AutoIncrement] public int C_ID { get; set; }

        public string C_Name { get; set; }
        public string C_L_Name { get; set; }
        public string C_Tel { get; set; }
        public string C_Main_One { get; set; }
        public string C_Main_Two { get; set; }
    }
}
