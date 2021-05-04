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
            var store = GetStoreById(str.ID);

            store.Name = str.Name;
            store.Address = str.Address;
            store.Responsible_Employee = str.Responsible_Employee;

            db.SaveChanges();

            return str;
        }

        public List<Store> GetAllStores()
        {
            return db.Stores.ToList();
        }

        public void DeleteStoreByStore(Store store)
        {
            db.Stores.Remove(store);
            db.SaveChanges();
        }

        public void DeleteStoreById(int id)
        {
            DeleteStoreByStore(GetStoreById(id));
        }
    }
}
