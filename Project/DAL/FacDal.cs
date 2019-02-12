using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DBL;

namespace Project.DAL
{
    static class FacDal
    {

        public static DataTable GetAll()
        {
            var result = DbLayer.ExecuteQuery("select * from Faculty");
            return result;
        }

        public static DataTable GetFacultyByUniId(int id)
        {
            var result = DbLayer.ExecuteQuery($"select * from Faculty where fk_University={id}");
            return result;
        }

      
    }
}
