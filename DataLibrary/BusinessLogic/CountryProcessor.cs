using DataLibrary.BusinessModel;
using DataLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class CountryProcessor
    {
        public static List<Country> LoadCountry()
        {
            string sql = "select * from country";

            return SqlDataAccess.LoadData<Country>(sql);

        }
    }
}
