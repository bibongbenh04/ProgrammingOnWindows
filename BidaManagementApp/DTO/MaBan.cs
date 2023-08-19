using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidaManagementApp.DTO
{

    internal class MaBan
    {
        private string idBan;
        private string trangthai;
        private float price;

        public MaBan(DataRow row)
        {
            this.idBan = (string)row["MABAN"];
            if (row["TRANGTHAI"].ToString() == "0")
                this.trangthai = "Chưa Sử Dụng";
            else
                this.trangthai = "Đang Sử Dụng";
            this.price = (float)Convert.ToDouble(row["price"].ToString());
        }
    }
}
