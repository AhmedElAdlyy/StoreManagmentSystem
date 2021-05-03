using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem.Repos
{
    class StoreDb
    {
        StoreManagmentContext db = new StoreManagmentContext();

        public Store AddStore(Store str)
        {
            db.Stores.Add(str);
            db.SaveChanges();

            return str;
        }

        public Store GetStoreById(int id)
        {
            return db.Stores.Find(id);
        }

        public Store EditStore(Store str)
        {
            db.Entry(str).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return str;
        }

        public List<Store> GetAllStores()
        {
            return db.Stores.ToList();
        }
    }
}
