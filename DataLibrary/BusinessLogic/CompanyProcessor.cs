using DataLibrary.BusinessModel;
using DataLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class CompanyProcessor
    {
        public static bool SaveCompany(Company data)
        {
            string sql = "Insert Into Company(CompanyName, CompanyEmail, Password, Address, CountryId)"
                        + "Values(@CompanyName,@CompanyEmail, @Password, @Address, @CountryId )";

            int rowAffected = SqlDataAccess.SaveData<Company>(sql, data);
            if (rowAffected > 0)
            {
                return true;
            }
            return false;
        }
    }
}
