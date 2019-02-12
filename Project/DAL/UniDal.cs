using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DBL;

namespace Project.DAL
{
    static class UniDal
    {
        public static DataTable GetAll()
        {
            var result = DbLayer.ExecuteQuery("select * from University");
            return result;
        }

        public static DataRow GetById(int id)
        {

            DataRow result;
            DataTable dt = DbLayer.ExecuteQuery($"select * from University where id={id}");

            if (dt.Rows.Count == 1)
            {
                result = dt.Rows[0];
            }
            else
            {
                result = null;
            }

            return result;
        }

        
    }
}
