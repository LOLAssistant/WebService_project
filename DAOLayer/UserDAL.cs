using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAOLayer
{
    public class UserDAL
    {
        private Data.LOLDataDataContext ldc = new Data.LOLDataDataContext();
        public Data.LOLAccount SelectRecordByUsername(string username)
        {
            try
            {
                return (from l in ldc.LOLAccount where l.username == username select l).Single();
            }
            catch (InvalidOperationException ex)
            {

                return null;
            }
        }
    }
}
