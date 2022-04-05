using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerRepo
    {
        RMSEntities db;
        public CustomerRepo(RMSEntities db)
        {
            this.db = db;
        }
        public void Add(Customer e)
        {
            db.Customers.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Customers.Remove(db.Customers.FirstOrDefault(e => e.Id == id));
            db.SaveChanges();
        }

        public void Edit(Customer e)
        {
            var u = db.Customers.FirstOrDefault(en => en.Id == e.Id);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Customer> Get()
        {
            return db.Customers.ToList();
        }

        public Customer Get(int id)
        {
            return db.Customers.FirstOrDefault(e => e.Id == id);
        }
    }
}
