using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static RMSEntities db;
        static DataAccessFactory()
        {
            db = new RMSEntities();
        }
        public static IRepository<Manager, int> ManagersDataAccess()
        {
            return new ManagerRepo(db);
        }
        public static IRepository<Customer, int> CustomerDataAccess()
        {
            return new CustomerRepo(db);
        }

    }
}