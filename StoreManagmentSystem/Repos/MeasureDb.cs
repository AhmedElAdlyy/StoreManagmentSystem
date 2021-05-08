using StoreManagmentSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem.Repos
{
    class MeasureDb
    {
        StoreManagmentContext db = new StoreManagmentContext();

        public Measure addMeasure(Measure measure)
        {
            db.Measures.Add(measure);
            db.SaveChanges();

            return measure;
        }

        public List<Measure> GetAllMeasures()
        {
            return db.Measures.ToList();
        }

        public Measure GetMeasureById(int id)
        {
            return db.Measures.Find(id);
        }

        public Measure EditMeasure(Measure m)
        {
            Measure measure = GetMeasureById(m.ID);

            measure.Main_Measure = m.Main_Measure;
            measure.Quantity = m.Quantity;
            measure.Sub_Measure = m.Sub_Measure;

            db.SaveChanges();

            return measure;
        }

        public void DeleteMeasureById(int id)
        {
            DeleteMeasureByMeasure(GetMeasureById(id));
        }

        public void DeleteMeasureByMeasure(Measure measure)
        {
            db.Measures.Remove(measure);
            db.SaveChanges();
        }

        public Measure GetMeasureByItem(int itemId)
        {
            return db.Items.Find(itemId).Measure;
        }

        public List<string> GetMeasureItem(int invoiceId)
        {
            Measure measure = db.Supply_Invoice.Find(invoiceId).Store_Item_Quantity.Store_Item.Item.Measure;

            return new List<string> { measure.Main_Measure, measure.Sub_Measure };

        }

    }
}
