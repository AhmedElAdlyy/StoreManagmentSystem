using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem.Repos
{
    class StoreItemDb
    {
        StoreManagmentContext db = new StoreManagmentContext();

        public Store_Item GetByID(int id)
        {
            return db.Store_Item.Find(id);
        }
    }
}
