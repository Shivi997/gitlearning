using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace BillApplication.Model
{
    [Table("tbbill")]
    public class Bill
    {
        [Key]
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Itemprice { get; set; } 
        public string Image { get; set; } =string.Empty;
    }

    public  class BillContext : DbContext
    {
        public DbSet<Bill> billing { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var strConnection = @"Data Source=W-674PY03-1;Initial Catalog=Shivam;Persist Security Info=True;User ID=sa;Password=Password@12345;TrustServerCertificate=True";
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(strConnection);
        }
    }
    public interface IBillComponent
    {
        List<Bill> GetAllBill();
        Bill GetBilling(int id);
        void AddBillNo(Bill bills);
        void UpdateBillNo(Bill bills);
        void DeleteBillNo(int id);
    }
    public class BillComponent : IBillComponent
    {
        public void AddBillNo(Bill bills)
        {
            var context = new BillContext();
            context.billing.Add(bills);
            context.SaveChanges();
        }

        public void DeleteBillNo(int id)
        {
            var context = new BillContext();
            var rec = context.billing.FirstOrDefault(e => e.Id == id);
            if (rec != null)
            {
                context.billing.Remove(rec);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Bill N not found to delete");
            }
        }

        public List<Bill> GetAllBill()
        {
            var context = new BillContext();
            return context.billing.ToList();
        }

        public Bill GetBilling(int id)
        {
            var context = new BillContext();
            var rec = context.billing.FirstOrDefault(e => e.Id == id);
            if (rec != null)
            {
                return rec;
            }
            else
            {
                throw new Exception("BillNo not found to delete");
            }
        }

        public void UpdateBillNo(Bill bills)
        {
            var context = new BillContext();
            var rec = context.billing.FirstOrDefault(e => e.Id == bills.Id);
            if (rec != null)
            {
                rec.ItemName = bills.ItemName;
               rec.Itemprice = bills.Itemprice;
                rec.Image = bills.Image;
                // rec.FullName = phone.FullName;

                context.SaveChanges();
            }
            else
            {
                throw new Exception("ItemeNo not found to update");
            }
        }
    }
}
