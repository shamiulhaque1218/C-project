using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManagerRepo
    {
        RMSEntities db;
        public ManagerRepo(RMSEntities db)
        {
            this.db = db;
        }
        public void Add(Manager e)
        {
            db.Managers.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Managers.Remove(db.Managers.FirstOrDefault(e => e.Id == id));
            db.SaveChanges();
        }

        public void Edit(Manager e)
        {
            var u = db.Managers.FirstOrDefault(en => en.Id == e.Id);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Manager> Get()
        {
            return db.Managers.ToList();
        }

        public Manager Get(int id)
        {
            return db.Managers.FirstOrDefault(e => e.Id == id);
        }
    }
}


