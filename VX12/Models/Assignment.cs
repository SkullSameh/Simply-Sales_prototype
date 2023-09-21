using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace VX12.Models
{
    public class Assignment
    {
        [PrimaryKey , AutoIncrement] public int Id { get; set; }
        public int C_Id { get; set; }
        public int S_Id { get; set; }
    }
}
