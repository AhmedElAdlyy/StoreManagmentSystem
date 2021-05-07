using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem.Repos
{
    class ItemDb
    {
        StoreManagmentContext db = new StoreManagmentContext();

        public void AddItem(Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
        }

        public List<Item> GetAllItems()
        {
            return db.Items.ToList();
        }

        public Item GetItemById(int id)
        {
            return db.Items.Find(id);
        }

        public void EditItem(Item newItem)
        {
            Item item = GetItemById(newItem.ID);

            item.Name = newItem.Name;
            item.Code = newItem.Code;
            item.Measure_Unit_ID = newItem.Measure_Unit_ID;

            db.SaveChanges();
        }

        public void DeleteItemByItem(Item item)
        {
            db.Items.Remove(item);
            db.SaveChanges();
        }

        public void DeleteItemById(int id)
        {
            DeleteItemByItem(GetItemById(id));
        }
    }
}
