using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanTraSua.DAO
{
    public class Food
    {
        public Food(int id, string name, string idCategory, string price)
        {
            this.ID = iD;
            this.IDCategory = iDCategory;
            this.Name = name;
            this.Price = price;

        }
        public Food(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDCategory = (int)row["idcategory"];
            this.Name = row["name"].ToString();
            this.Price = row["price"].ToString();

        }
        private string price;
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        private int iDCategory;
        public int IDCategory
        {
            get { return iDCategory; }
            set { iDCategory = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
