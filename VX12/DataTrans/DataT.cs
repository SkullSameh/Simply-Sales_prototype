using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using VX12.Models;

namespace VX12.DataTrans
{
    public class DataT
    {
        public string Path;
        private SQLiteConnection conn;

        public DataT(string dbPAth)
        {
            Path = dbPAth;
        }

        public void Init()
        {
            conn = new SQLiteConnection(Path);
            conn.CreateTable<Client>();
            conn.CreateTable<Sales>();
            conn.CreateTable<Assignment>();
        }

        public void Add(Client customer)
        {
            conn = new SQLiteConnection(Path);
            conn.Insert(customer);
        }

        public List<Client> GetClientList()
        {
            return conn.Table<Client>().ToList();

        }


        public int DeleteOneClient(int num)
        {
            int res = 0;
            res = conn.Delete<Client>(num);
            return res;
        }

        /*/////////////*/

        public void Add(Sales Sales)
        {
            conn = new SQLiteConnection(Path);
            conn.Insert(Sales);
        }


        public List<Sales> GetSalesList()
        {
            return conn.Table<Sales>().ToList();

        }

        public int DeleteOneSales(int num)
        {
            int res = 0;
            res = conn.Delete<Sales>(num);
            return res;
        }

        /**/

        public void AddAssignment(Assignment A)
        {
            conn = new SQLiteConnection(Path);
            conn.Insert(A);
        }

        public List<Assignment> GetAssignmentList()
        {
            return conn.Table<Assignment>().ToList();

        }


        public int DeleteOneAssignment(int num)
        {
            int res = 0;
            res = conn.Delete<Assignment>(num);
            return res;
        }

    }
}