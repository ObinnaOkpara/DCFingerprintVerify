﻿// <auto-generated />
using System;
using DCFingerprintDBClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DCFingerprintAPIs.Migrations
{
    [DbContext(typeof(bsslsys_itfContext))]
    [Migration("20191009115848_Fingerprint")]
    partial class Fingerprint
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DCFingerprintClasses.Models.Fingerprint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded");

                    b.Property<byte[]>("FPfile");

                    b.Property<int>("StafftabId");

                    b.HasKey("Id");

                    b.HasIndex("StafftabId");

                    b.ToTable("Fingerprints");
                });

            modelBuilder.Entity("DCFingerprintClasses.Models.Stafftab", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Accountid")
                        .HasColumnName("accountid")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Accountid1")
                        .HasColumnName("accountid1")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Acctname")
                        .HasColumnName("acctname")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("Acctype")
                        .HasColumnName("acctype")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<decimal?>("Amtdue")
                        .HasColumnName("amtdue")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<decimal?>("Amtduebal")
                        .HasColumnName("amtduebal")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<decimal?>("BSalary")
                        .HasColumnName("bSalary")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<string>("Bankcode1")
                        .HasColumnName("bankcode1")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Bankid")
                        .HasColumnName("bankid")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<bool?>("Bar1")
                        .HasColumnName("bar1");

                    b.Property<string>("BloodGrp")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<decimal?>("Bonus")
                        .HasColumnName("bonus")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<string>("Branchcode1")
                        .HasColumnName("branchcode1")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Btype")
                        .HasColumnName("btype")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("Cadre")
                        .HasColumnName("cadre")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Cardno")
                        .HasColumnName("cardno")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Cat2")
                        .HasColumnName("cat2")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Cc")
                        .HasColumnName("cc")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Cesdate")
                        .HasColumnName("cesdate")
                        .HasColumnType("datetime");

                    b.Property<bool?>("Cessation")
                        .HasColumnName("cessation");

                    b.Property<decimal?>("Children")
                        .HasColumnName("children")
                        .HasColumnType("numeric(3, 0)");

                    b.Property<string>("Copny")
                        .HasColumnName("copny")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Country")
                        .HasColumnName("country")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<bool?>("Cstaff")
                        .HasColumnName("cstaff");

                    b.Property<DateTime?>("Datebirth")
                        .HasColumnName("datebirth")
                        .HasColumnType("datetime");

                    b.Property<bool?>("Dayw")
                        .HasColumnName("dayw");

                    b.Property<string>("Deptcode")
                        .HasColumnName("deptcode")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<bool?>("Disable")
                        .HasColumnName("disable");

                    b.Property<DateTime?>("Djoin")
                        .HasColumnName("djoin")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Dpromo")
                        .HasColumnName("dpromo")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Dpromoted")
                        .HasColumnName("dpromoted")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Dtengaged")
                        .HasColumnName("dtengaged")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Effedate")
                        .HasColumnName("effedate")
                        .HasColumnType("datetime");

                    b.Property<decimal?>("Effewdays")
                        .HasColumnName("effewdays")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.Property<decimal?>("EntryYrExp")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("EyeColor")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Firstname")
                        .HasColumnName("firstname")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<bool?>("Fmark")
                        .HasColumnName("FMark");

                    b.Property<bool>("FpAuthorised");

                    b.Property<decimal?>("Freemethod")
                        .HasColumnName("freemethod")
                        .HasColumnType("numeric(1, 0)");

                    b.Property<string>("Function1")
                        .HasColumnName("FUNCTION1")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Gradelvl")
                        .HasColumnName("gradelvl")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Gynotype")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Haircolor")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<decimal?>("Height")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<string>("Housecode")
                        .HasColumnName("housecode")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<bool?>("Indu")
                        .HasColumnName("indu");

                    b.Property<string>("Initials")
                        .HasColumnName("initials")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<decimal?>("Lastpay")
                        .HasColumnName("lastpay")
                        .HasColumnType("numeric(2, 0)");

                    b.Property<string>("Middlename")
                        .HasColumnName("middlename")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Natidno")
                        .HasColumnName("natidno")
                        .HasMaxLength(70)
                        .IsUnicode(false);

                    b.Property<bool?>("Nhf")
                        .HasColumnName("nhf");

                    b.Property<bool?>("Nsitf1")
                        .HasColumnName("nsitf1");

                    b.Property<string>("Nysccdday")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("nysccdday")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Nysccdgroup")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("nysccdgroup")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Nysccdno")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("nysccdno")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Office")
                        .HasColumnName("office")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Office2")
                        .HasColumnName("office2")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<decimal?>("Oldval")
                        .HasColumnName("OLDVAL")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<string>("Othernames")
                        .HasColumnName("othernames")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<bool?>("Overtime")
                        .HasColumnName("overtime");

                    b.Property<decimal?>("Ovtcum")
                        .HasColumnName("ovtcum")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<decimal?>("Paystatus")
                        .HasColumnName("paystatus")
                        .HasColumnType("numeric(1, 0)");

                    b.Property<decimal?>("Paywhen")
                        .HasColumnName("paywhen")
                        .HasColumnType("numeric(1, 0)");

                    b.Property<DateTime?>("Pdate")
                        .HasColumnName("pdate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Pendate")
                        .HasColumnName("pendate")
                        .HasColumnType("datetime");

                    b.Property<decimal?>("Peneffewdays")
                        .HasColumnName("peneffewdays")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<bool?>("Penongross");

                    b.Property<decimal?>("Penrate")
                        .HasColumnName("penrate")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<bool?>("Pensionable");

                    b.Property<decimal?>("Penwdays")
                        .HasColumnName("penwdays")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<decimal?>("Percent2")
                        .HasColumnType("numeric(3, 0)");

                    b.Property<decimal?>("Perovt")
                        .HasColumnName("perovt")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("Pfa")
                        .HasColumnName("PFA")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Picpath")
                        .HasColumnName("picpath")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.Property<bool?>("Pleave")
                        .HasColumnName("pleave");

                    b.Property<string>("Positionid")
                        .HasColumnName("positionid")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Posting")
                        .HasColumnName("posting")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool?>("Ppay")
                        .HasColumnName("ppay");

                    b.Property<bool?>("Promoted");

                    b.Property<bool?>("Promoted2");

                    b.Property<decimal?>("Relatives")
                        .HasColumnName("relatives")
                        .HasColumnType("numeric(3, 0)");

                    b.Property<bool?>("Rentad")
                        .HasColumnName("rentad");

                    b.Property<string>("Rsapin")
                        .HasColumnName("rsapin")
                        .HasMaxLength(18)
                        .IsUnicode(false);

                    b.Property<string>("Scodee")
                        .HasColumnName("scodee")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<decimal?>("Sex")
                        .HasColumnName("sex")
                        .HasColumnType("numeric(1, 0)");

                    b.Property<string>("Signpic")
                        .HasColumnName("signpic")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    b.Property<string>("Sortcode")
                        .HasColumnName("sortcode")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Sreason")
                        .HasColumnName("sreason")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Staffid")
                        .HasColumnName("staffid")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<decimal?>("Stafftype")
                        .HasColumnName("stafftype")
                        .HasColumnType("numeric(1, 0)");

                    b.Property<decimal?>("Status")
                        .HasColumnName("status")
                        .HasColumnType("numeric(1, 0)");

                    b.Property<decimal?>("Subaccount")
                        .HasColumnName("subaccount")
                        .HasColumnType("numeric(20, 0)");

                    b.Property<string>("Suboffice")
                        .HasColumnName("suboffice")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Surname")
                        .HasColumnName("surname")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Suspdate")
                        .HasColumnName("suspdate")
                        .HasColumnType("datetime");

                    b.Property<bool?>("Suspended")
                        .HasColumnName("suspended");

                    b.Property<decimal?>("Suspperm")
                        .HasColumnName("suspperm")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("Susstatus")
                        .HasColumnName("susstatus")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<bool?>("Taxable")
                        .HasColumnName("taxable");

                    b.Property<string>("Taxref")
                        .HasColumnName("taxref")
                        .HasMaxLength(35)
                        .IsUnicode(false);

                    b.Property<string>("Taxregion")
                        .HasColumnName("taxregion")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Tdate")
                        .HasColumnName("tdate")
                        .HasColumnType("datetime");

                    b.Property<string>("Terminate")
                        .HasColumnName("terminate")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<bool?>("Testadmin")
                        .HasColumnName("testadmin");

                    b.Property<string>("Title")
                        .HasColumnName("title")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Tumbpic")
                        .HasColumnName("tumbpic")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    b.Property<bool?>("Union1")
                        .HasColumnName("union1");

                    b.Property<string>("Zone")
                        .HasColumnName("zone")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("Office")
                        .HasName("office");

                    b.ToTable("stafftab");
                });

            modelBuilder.Entity("DCFingerprintClasses.Models.Useracct", b =>
                {
                    b.Property<decimal>("Pkvalue")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("pkvalue")
                        .HasColumnType("numeric(18, 0)")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Accslvl")
                        .HasColumnName("accslvl")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<bool?>("AcctPay")
                        .HasColumnName("acct_pay");

                    b.Property<bool?>("AcctRec")
                        .HasColumnName("acct_rec");

                    b.Property<bool?>("AcctSetup")
                        .HasColumnName("acct_setup");

                    b.Property<bool?>("Addybook")
                        .HasColumnName("addybook");

                    b.Property<bool?>("Admin")
                        .HasColumnName("admin");

                    b.Property<bool?>("Analysis")
                        .HasColumnName("analysis");

                    b.Property<bool?>("Audit")
                        .HasColumnName("audit");

                    b.Property<bool?>("BankCash")
                        .HasColumnName("bank_cash");

                    b.Property<bool?>("Budget")
                        .HasColumnName("budget");

                    b.Property<string>("Compcode")
                        .IsRequired()
                        .HasColumnName("compcode")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<bool?>("Coordination")
                        .HasColumnName("coordination");

                    b.Property<DateTime?>("Datein")
                        .HasColumnName("datein")
                        .HasColumnType("datetime");

                    b.Property<bool?>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<DateTime?>("Expiredate")
                        .HasColumnName("expiredate")
                        .HasColumnType("datetime");

                    b.Property<bool?>("FixdAsst")
                        .HasColumnName("fixd_asst");

                    b.Property<bool?>("Gledger")
                        .HasColumnName("gledger");

                    b.Property<bool?>("GovBudget")
                        .HasColumnName("gov_budget");

                    b.Property<string>("Grpcode")
                        .HasColumnName("grpcode")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Lastlogin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<bool?>("Loggedon")
                        .HasColumnName("loggedon");

                    b.Property<DateTime?>("Modidate")
                        .HasColumnName("modidate")
                        .HasColumnType("datetime");

                    b.Property<bool?>("Newlogin")
                        .HasColumnName("newlogin");

                    b.Property<bool?>("Nvrexpire")
                        .HasColumnName("nvrexpire");

                    b.Property<bool?>("Patsalinvo")
                        .HasColumnName("patsalinvo");

                    b.Property<bool?>("Procurement")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("procurement")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("Project")
                        .HasColumnName("project");

                    b.Property<bool?>("Prtaccess")
                        .HasColumnName("prtaccess");

                    b.Property<string>("Pwd")
                        .HasColumnName("pwd")
                        .IsUnicode(false);

                    b.Property<bool?>("Raccess")
                        .HasColumnName("raccess");

                    b.Property<bool?>("Revenue")
                        .HasColumnName("revenue");

                    b.Property<bool?>("Rptaccess")
                        .HasColumnName("rptaccess");

                    b.Property<bool?>("StockInvent")
                        .HasColumnName("stock_invent");

                    b.Property<bool?>("StockReq")
                        .HasColumnName("stock_req");

                    b.Property<bool?>("Suspend")
                        .HasColumnName("suspend");

                    b.Property<bool?>("Uaccess")
                        .HasColumnName("uaccess");

                    b.Property<string>("Userid")
                        .HasColumnName("userid")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Username")
                        .HasColumnName("username")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool?>("Warrant")
                        .HasColumnName("warrant");

                    b.Property<string>("Zcopny")
                        .HasColumnName("zcopny")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("Pkvalue")
                        .HasName("PK_useracct_1");

                    b.ToTable("USERACCT");
                });

            modelBuilder.Entity("DCFingerprintClasses.Models.Fingerprint", b =>
                {
                    b.HasOne("DCFingerprintClasses.Models.Stafftab", "Staff")
                        .WithMany("Fingerprints")
                        .HasForeignKey("StafftabId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
