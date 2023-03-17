using cnet_db_op.Domain.Data;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace cnet_db_op.Service.ClearDbservise
{
    
    public interface InterfceService
    {
        bool Delet();
    }
    public class Articl : InterfceService
    {
        private readonly Cnet2016Context cnet2016Context;
        public Articl(Cnet2016Context cnet2016Context)
        {
            this.cnet2016Context = cnet2016Context;
        }
        public bool Delet()
        {
            bool result = false;
            string[] tabls = new string[] { "common.Article", "common.Gsltax", "common.Value", "common.StockLevel", 
                "common.StockBalance", "common.SerialDefinition", "common.Gslnote", "common.GslacctRequirement" ,
                "common.ProductExtension","common.OptionalCode","cinema.MovieSchedule" };
            foreach (var table in tabls)
            {
                var qury = $"delete from {table}";
                cnet2016Context.Database.ExecuteSqlRaw(qury);
                cnet2016Context.SaveChanges();
            }
            return result;
        }
    }
    public class CommonGslandVocher : InterfceService
    {
        private readonly Cnet2016Context cnet2016Context;
        public CommonGslandVocher(Cnet2016Context cnet2016Context)
        {
            this.cnet2016Context = cnet2016Context;
        }
        public bool Delet()
        {
            var result = false;
            string[] tabls = new string[] { "common.OrganizationUnitDefinition", 
                "common.OrganizationUnit" };
            foreach (var table in tabls)
            {
                var qury = $"delete from {table}";
                cnet2016Context.Database.ExecuteSqlRaw(qury);
                cnet2016Context.SaveChanges();
            }
            return result;
        }
    }
    public class Common : InterfceService
    {
        private readonly Cnet2016Context cnet2016Context;
        public Common(Cnet2016Context cnet2016Context)
        {
            this.cnet2016Context = cnet2016Context;
        }
        public bool Delet()
        {
            bool result = false;
            string[] tables = new string[] { "common.Address", "common.TransactionLimit", "common.BankAccountDetail",
                "common.Relation", "common.Beginning", "common.IdDefinition", "common.AccountMap", "common.ObjectState", 
                "pos.DisplayOrder", "common.ValueFactorDefinition" };

            foreach (var table in tables)
            {
                var qury = $"delete from {table}";
                cnet2016Context.Database.ExecuteSqlRaw(qury);
                cnet2016Context.SaveChanges();
            }
            return result; ;
        }
    }
    public class Organiztion : InterfceService
    {
        private readonly Cnet2016Context cnet2016Context;
        public Organiztion(Cnet2016Context cnet2016Context)
        {
            this.cnet2016Context = cnet2016Context;
        }
        public bool Delet()
        {
            bool result = false;
            string[] tables = new string[] { "common.Organization", "common.IndustryInvolved" };

            foreach (var table in tables)
            {
                var qury = $"delete from {table}";
                cnet2016Context.Database.ExecuteSqlRaw(qury);
                cnet2016Context.SaveChanges();
            }
            return result;
        }
    }
        public class Persons : InterfceService
        {
            private readonly Cnet2016Context cnet2016Context;
            public Persons(Cnet2016Context cnet2016Context)
            {
                this.cnet2016Context = cnet2016Context;
            }
            public bool Delet()
            {
                bool result = false;
                string[] tables = new string[] { "hrms.Career", "common.CommunicationSource", "common.Person" };
                foreach (var table in tables)
                {
                    var query = $"delete from {table}";
                    cnet2016Context.Database.ExecuteSqlRaw(query);
                    cnet2016Context.SaveChanges();
                }
                return result;
            }
        }
    public class Vocher : InterfceService
    {
        private readonly Cnet2016Context cnet2016Context;
        public Vocher(Cnet2016Context cnet2016Context)
        {
            this.cnet2016Context = cnet2016Context;
        }
        public bool Delet()
        {
            bool result = false;
            string[] tables = new string[] { "common.Voucher", "common.Lifetime", "common.TransactionReference", 
                "common.StoreTransaction", "common.VoucherValues", "common.TaxTransaction", 
                "common.VoucherExtensionTransaction", "common.ClosedRelation", "common.NonCashTransaction", 
                "common.VoucherTerm", "common.VoucherNote", "common.CartTransaction", "common.OtherConsignees", 
                "common.JournalDetail" };
            foreach (var table in tables)
            {
                var query = $"delete from {table}";
                cnet2016Context.Database.ExecuteSqlRaw(query);
                cnet2016Context.SaveChanges();

            }

            return result; ;
        }
    }
}
