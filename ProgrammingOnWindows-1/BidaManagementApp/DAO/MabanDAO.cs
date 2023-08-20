using BidaManagementApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidaManagementApp.DAO
{
    internal class MabanDAO
    {
        private static MabanDAO instance;

        public static MabanDAO Instance
        {
            get { if (instance == null) instance = new MabanDAO(); return MabanDAO.instance; }
            private set { MabanDAO.instance = value; }
        }

        private MabanDAO() { }

        public List<MaBan> getListMaBan()
        {
            List<MaBan> list = new List<MaBan>();

            string query = "select * from BANBIDA ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MaBan maban = new MaBan(item);
                list.Add(maban);
            }
            return list;
        }
    }
}
