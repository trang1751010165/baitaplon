using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanTraSua
{
    public class Account
    {
        private static Account instance;

       public static Account Instance
        {
            get { if (instance == null) instance = new Account(); return instance;  }
            private set { instance = value;  }
        }
        private Account() { }
        public bool Login (string userName, string passWord )
        {
            return false;
        }
    }
}
