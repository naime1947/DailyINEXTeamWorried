using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessModel
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
    }
}
