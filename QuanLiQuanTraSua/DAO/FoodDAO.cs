
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanTraSua.DAO
{
   public class FoodDAO
    {
        
    
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }
        public static int FoodWidth = 100;
        public static int FoodHeight = 100;
        private FoodDAO() { }
        public List<Food> LoadFoodList()
        {
            List<Food> foodlist = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery("usp_FoodList2");
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                foodlist.Add(food);
            }

            return foodlist;
        }
    }
    
}
