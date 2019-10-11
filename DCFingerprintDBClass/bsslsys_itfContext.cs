using System;
using DCFingerprintClasses.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DCFingerprintDBClass
{
    public partial class bsslsys_itfContext : DbContext
    {
        public bsslsys_itfContext()
        {
        }

        public bsslsys_itfContext(DbContextOptions<bsslsys_itfContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Stafftab> Stafftab { get; set; }
        public virtual DbSet<Useracct> Useracct { get; set; }
        public virtual DbSet<Fingerprint> Fingerprints { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\sqlexpress01;database=bsslsys_itf;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Stafftab>(entity =>
            {
                entity.ToTable("stafftab");

                entity.HasIndex(e => e.Office)
                    .HasName("office");

                entity.Property(e => e.Accountid)
                    .HasColumnName("accountid")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Accountid1)
                    .HasColumnName("accountid1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Acctname)
                    .HasColumnName("acctname")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Acctype)
                    .HasColumnName("acctype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amtdue)
                    .HasColumnName("amtdue")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Amtduebal)
                    .HasColumnName("amtduebal")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BSalary)
                    .HasColumnName("bSalary")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Bankcode1)
                    .HasColumnName("bankcode1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bankid)
                    .HasColumnName("bankid")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bar1).HasColumnName("bar1");

                entity.Property(e => e.BloodGrp)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bonus)
                    .HasColumnName("bonus")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Branchcode1)
                    .HasColumnName("branchcode1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Btype)
                    .HasColumnName("btype")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cadre)
                    .HasColumnName("cadre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cardno)
                    .HasColumnName("cardno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cat2)
                    .HasColumnName("cat2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cc)
                    .HasColumnName("cc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cesdate)
                    .HasColumnName("cesdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cessation).HasColumnName("cessation");

                entity.Property(e => e.Children)
                    .HasColumnName("children")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Copny)
                    .HasColumnName("copny")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cstaff).HasColumnName("cstaff");

                entity.Property(e => e.Datebirth)
                    .HasColumnName("datebirth")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dayw).HasColumnName("dayw");

                entity.Property(e => e.Deptcode)
                    .HasColumnName("deptcode")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Disable).HasColumnName("disable");

                entity.Property(e => e.Djoin)
                    .HasColumnName("djoin")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dpromo)
                    .HasColumnName("dpromo")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dpromoted)
                    .HasColumnName("dpromoted")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dtengaged)
                    .HasColumnName("dtengaged")
                    .HasColumnType("datetime");

                entity.Property(e => e.Effedate)
                    .HasColumnName("effedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Effewdays)
                    .HasColumnName("effewdays")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EntryYrExp).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EyeColor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fmark).HasColumnName("FMark");

                entity.Property(e => e.Freemethod)
                    .HasColumnName("freemethod")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Function1)
                    .HasColumnName("FUNCTION1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gradelvl)
                    .HasColumnName("gradelvl")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gynotype)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Haircolor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Height).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Housecode)
                    .HasColumnName("housecode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Indu).HasColumnName("indu");

                entity.Property(e => e.Initials)
                    .HasColumnName("initials")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lastpay)
                    .HasColumnName("lastpay")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Middlename)
                    .HasColumnName("middlename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Natidno)
                    .HasColumnName("natidno")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Nhf).HasColumnName("nhf");

                entity.Property(e => e.Nsitf1).HasColumnName("nsitf1");

                entity.Property(e => e.Nysccdday)
                    .HasColumnName("nysccdday")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nysccdgroup)
                    .HasColumnName("nysccdgroup")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nysccdno)
                    .HasColumnName("nysccdno")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Office)
                    .HasColumnName("office")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Office2)
                    .HasColumnName("office2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Oldval)
                    .HasColumnName("OLDVAL")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Othernames)
                    .HasColumnName("othernames")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Overtime).HasColumnName("overtime");

                entity.Property(e => e.Ovtcum)
                    .HasColumnName("ovtcum")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Paystatus)
                    .HasColumnName("paystatus")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Paywhen)
                    .HasColumnName("paywhen")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Pdate)
                    .HasColumnName("pdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pendate)
                    .HasColumnName("pendate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Peneffewdays)
                    .HasColumnName("peneffewdays")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Penrate)
                    .HasColumnName("penrate")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Penwdays)
                    .HasColumnName("penwdays")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Percent2).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Perovt)
                    .HasColumnName("perovt")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Pfa)
                    .HasColumnName("PFA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Picpath)
                    .HasColumnName("picpath")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Pleave).HasColumnName("pleave");

                entity.Property(e => e.Positionid)
                    .HasColumnName("positionid")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Posting)
                    .HasColumnName("posting")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ppay).HasColumnName("ppay");

                entity.Property(e => e.Relatives)
                    .HasColumnName("relatives")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Rentad).HasColumnName("rentad");

                entity.Property(e => e.Rsapin)
                    .HasColumnName("rsapin")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Scodee)
                    .HasColumnName("scodee")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Signpic)
                    .HasColumnName("signpic")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Sortcode)
                    .HasColumnName("sortcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sreason)
                    .HasColumnName("sreason")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Staffid)
                    .HasColumnName("staffid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stafftype)
                    .HasColumnName("stafftype")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Subaccount)
                    .HasColumnName("subaccount")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.Suboffice)
                    .HasColumnName("suboffice")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Suspdate)
                    .HasColumnName("suspdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Suspended).HasColumnName("suspended");

                entity.Property(e => e.Suspperm)
                    .HasColumnName("suspperm")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Susstatus)
                    .HasColumnName("susstatus")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Taxable).HasColumnName("taxable");

                entity.Property(e => e.Taxref)
                    .HasColumnName("taxref")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Taxregion)
                    .HasColumnName("taxregion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("tdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Terminate)
                    .HasColumnName("terminate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Testadmin).HasColumnName("testadmin");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tumbpic)
                    .HasColumnName("tumbpic")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Union1).HasColumnName("union1");

                entity.Property(e => e.Zone)
                    .HasColumnName("zone")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Useracct>(entity =>
            {
                entity.HasKey(e => e.Pkvalue)
                    .HasName("PK_useracct_1");

                entity.ToTable("USERACCT");

                entity.Property(e => e.Pkvalue)
                    .HasColumnName("pkvalue")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Accslvl)
                    .HasColumnName("accslvl")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AcctPay).HasColumnName("acct_pay");

                entity.Property(e => e.AcctRec).HasColumnName("acct_rec");

                entity.Property(e => e.AcctSetup).HasColumnName("acct_setup");

                entity.Property(e => e.Addybook).HasColumnName("addybook");

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.Analysis).HasColumnName("analysis");

                entity.Property(e => e.Audit).HasColumnName("audit");

                entity.Property(e => e.BankCash).HasColumnName("bank_cash");

                entity.Property(e => e.Budget).HasColumnName("budget");

                entity.Property(e => e.Compcode)
                    .IsRequired()
                    .HasColumnName("compcode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Coordination).HasColumnName("coordination");

                entity.Property(e => e.Datein)
                    .HasColumnName("datein")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Expiredate)
                    .HasColumnName("expiredate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FixdAsst).HasColumnName("fixd_asst");

                entity.Property(e => e.Gledger).HasColumnName("gledger");

                entity.Property(e => e.GovBudget).HasColumnName("gov_budget");

                entity.Property(e => e.Grpcode)
                    .HasColumnName("grpcode")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Lastlogin)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Loggedon).HasColumnName("loggedon");

                entity.Property(e => e.Modidate)
                    .HasColumnName("modidate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Newlogin).HasColumnName("newlogin");

                entity.Property(e => e.Nvrexpire).HasColumnName("nvrexpire");

                entity.Property(e => e.Patsalinvo).HasColumnName("patsalinvo");

                entity.Property(e => e.Procurement)
                    .HasColumnName("procurement")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Project).HasColumnName("project");

                entity.Property(e => e.Prtaccess).HasColumnName("prtaccess");

                entity.Property(e => e.Pwd)
                    .HasColumnName("pwd")
                    .IsUnicode(false);

                entity.Property(e => e.Raccess).HasColumnName("raccess");

                entity.Property(e => e.Revenue).HasColumnName("revenue");

                entity.Property(e => e.Rptaccess).HasColumnName("rptaccess");

                entity.Property(e => e.StockInvent).HasColumnName("stock_invent");

                entity.Property(e => e.StockReq).HasColumnName("stock_req");

                entity.Property(e => e.Suspend).HasColumnName("suspend");

                entity.Property(e => e.Uaccess).HasColumnName("uaccess");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Warrant).HasColumnName("warrant");

                entity.Property(e => e.Zcopny)
                    .HasColumnName("zcopny")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
        }
    }
}
