using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class UserBLL
    {
        private DAOLayer.UserDAL objUserDAL= new DAOLayer.UserDAL();
        public Data.LOLAccount SelectRecordByUsername(string username)
        {
            return objUserDAL.SelectRecordByUsername(username);
        }
    }
}
