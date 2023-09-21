using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace VX12.Models
{
    public class Sales
    {
        [PrimaryKey , AutoIncrement] public int S_ID { get; set; }
        public string S_Name { get; set; }
        public string S_L_Name { get; set; }
        public string S_Tel { get; set; }
        public string S_INter { get; set;}
    }
}
