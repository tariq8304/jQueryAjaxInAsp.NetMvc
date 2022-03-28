using jQueryAjaxInAsp.NetMvc.Areas.ACEP.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.Data
{
    public class ACEPDBContext : DbContext
    {
        public ACEPDBContext()
            : base("name=ACEPDBContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // throw new UnintentionalCodeFirstException();
            modelBuilder.HasDefaultSchema("ACEP");

            base.OnModelCreating(modelBuilder);
        }

        //public virtual DbSet<TBL> Employees { get; set; }
        public DbSet<TBL_ACEP_BILL_PURCHASE_DISCOUNT> TBL_ACEP_BILL_PURCHASE_DISCOUNT { get; set; }
        public DbSet<TBL_ACEP_DATA_ENTRY_STATUS> TBL_ACEP_DATA_ENTRY_STATUS { get; set; }
        public DbSet<TBL_ACEP_ECON_PUR_CATEGORY> TBL_ACEP_ECON_PUR_CATEGORY { get; set; }
        public  DbSet<TBL_ACEP_ECON_PUR_SUB_CATEGORY> TBL_ACEP_ECON_PUR_SUB_CATEGORY { get; set; }
        public  DbSet<TBL_ACEP_ECON_PUR_TRANSACTION> TBL_ACEP_ECON_PUR_TRANSACTION { get; set; }
        public  DbSet<TBL_ACEP_ECON_SECTOR_CATEGORY> TBL_ACEP_ECON_SECTOR_CATEGORY { get; set; }
        public  DbSet<TBL_ACEP_ECON_SEC_SUB_CATEGORY> TBL_ACEP_ECON_SEC_SUB_CATEGORY { get; set; }
        public  DbSet<TBL_ACEP_ECON_SEC_TRANSACTION> TBL_ACEP_ECON_SEC_TRANSACTION { get; set; }
        public  DbSet<TBL_ACEP_REPORTING_CONFIG> TBL_ACEP_REPORTING_CONFIG { get; set; }
        public  DbSet<TBL_RBL_OFFICE_LIST> TBL_RBL_OFFICE_LIST { get; set; }

    }
}