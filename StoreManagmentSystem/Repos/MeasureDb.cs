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

        public List<AllMeasuresCb> settingDisplayOfCb_AllMeasures(List<Measure> measures)
        {
            List<AllMeasuresCb> allMeasures = new List<AllMeasuresCb>();

            foreach (var measure in measures)
            {
                AllMeasuresCb m = new AllMeasuresCb
                {
                    Id = measure.ID,
                    Description = measure.Main_Measure + " - " + measure.Sub_Measure + " - " + measure.Quantity
                };

                allMeasures.Add(m);
            }

            return allMeasures;
        }
    }
}
