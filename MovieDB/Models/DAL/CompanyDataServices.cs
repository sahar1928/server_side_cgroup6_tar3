using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieDB.Models.DAL
{
    public class CompanyDataServices
    {
        static List<Company> companyList;

        public int InsertCompany(Company c)
        {
            if (companyList == null)
            {
                companyList = new List<Company>();
            }

            companyList.Add(c);
            return 1;
        }

        public List<Company> Get()
        {
            return companyList;
        }

        public CompanyDataServices()
        {

        }


    }
}