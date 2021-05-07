using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem.Repos
{
    class VendorDb
    {
        StoreManagmentContext db = new StoreManagmentContext();

        public Vendor AddVendor(Vendor ven)
        {
            db.Vendors.Add(ven);
            db.SaveChanges();

            return ven;
        }

        public List<Vendor> GetAllVedors()
        {
            return db.Vendors.ToList();
        }

        public Vendor GetVendorById(int id)
        {
            return db.Vendors.Find(id);
        }

        public Vendor EditVendor(Vendor ven)
        {
            Vendor vendor = GetVendorById(ven.ID);

            vendor.Mobile = ven.Mobile;
            vendor.Name = ven.Name;
            vendor.Telephone = ven.Telephone;
            vendor.Email = ven.Email;
            vendor.Website = ven.Website;
            vendor.Fax = ven.Fax;

            db.SaveChanges();

            return ven;
        }

        public void DeleteVendorByVedndor(Vendor ven)
        {
            db.Vendors.Remove(ven);
            db.SaveChanges();
        }

        public void DeleteVendorById(int id)
        {
            DeleteVendorByVedndor(GetVendorById(id));
        }
    }
}
