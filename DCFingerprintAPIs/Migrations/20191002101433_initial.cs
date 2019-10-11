using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DCFingerprintAPIs.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "stafftab",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        staffid = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        surname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
            //        othernames = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
            //        firstname = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
            //        middlename = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
            //        initials = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
            //        deptcode = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
            //        gradelvl = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
            //        paystatus = table.Column<decimal>(type: "numeric(1, 0)", nullable: true),
            //        stafftype = table.Column<decimal>(type: "numeric(1, 0)", nullable: true),
            //        taxable = table.Column<bool>(nullable: true),
            //        accountid = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
            //        overtime = table.Column<bool>(nullable: true),
            //        taxregion = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        union1 = table.Column<bool>(nullable: true),
            //        bankid = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        suspended = table.Column<bool>(nullable: true),
            //        positionid = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
            //        title = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        sex = table.Column<decimal>(type: "numeric(1, 0)", nullable: true),
            //        children = table.Column<decimal>(type: "numeric(3, 0)", nullable: true),
            //        relatives = table.Column<decimal>(type: "numeric(3, 0)", nullable: true),
            //        housecode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        paywhen = table.Column<decimal>(type: "numeric(1, 0)", nullable: true),
            //        disable = table.Column<bool>(nullable: true),
            //        lastpay = table.Column<decimal>(type: "numeric(2, 0)", nullable: true),
            //        status = table.Column<decimal>(type: "numeric(1, 0)", nullable: true),
            //        freemethod = table.Column<decimal>(type: "numeric(1, 0)", nullable: true),
            //        office = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        suboffice = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        subaccount = table.Column<decimal>(type: "numeric(20, 0)", nullable: true),
            //        rentad = table.Column<bool>(nullable: true),
            //        cc = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        picpath = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
            //        copny = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        email = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
            //        natidno = table.Column<string>(unicode: false, maxLength: 70, nullable: true),
            //        Percent2 = table.Column<decimal>(type: "numeric(3, 0)", nullable: true),
            //        effedate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        effewdays = table.Column<decimal>(type: "numeric(18, 2)", nullable: true),
            //        penrate = table.Column<decimal>(type: "numeric(18, 2)", nullable: true),
            //        Pensionable = table.Column<bool>(nullable: true),
            //        nsitf1 = table.Column<bool>(nullable: true),
            //        OLDVAL = table.Column<decimal>(type: "numeric(18, 2)", nullable: true),
            //        Promoted = table.Column<bool>(nullable: true),
            //        nhf = table.Column<bool>(nullable: true),
            //        peneffewdays = table.Column<decimal>(type: "numeric(18, 2)", nullable: true),
            //        Penongross = table.Column<bool>(nullable: true),
            //        Promoted2 = table.Column<bool>(nullable: true),
            //        dayw = table.Column<bool>(nullable: true),
            //        susstatus = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        pdate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        tdate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        djoin = table.Column<DateTime>(type: "datetime", nullable: true),
            //        bonus = table.Column<decimal>(type: "numeric(18, 2)", nullable: true),
            //        sreason = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        cat2 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        terminate = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        ovtcum = table.Column<decimal>(type: "numeric(18, 2)", nullable: true),
            //        cessation = table.Column<bool>(nullable: true),
            //        cesdate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        datebirth = table.Column<DateTime>(type: "datetime", nullable: true),
            //        dpromoted = table.Column<DateTime>(type: "datetime", nullable: true),
            //        taxref = table.Column<string>(unicode: false, maxLength: 35, nullable: true),
            //        PFA = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
            //        pendate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        penwdays = table.Column<decimal>(type: "numeric(18, 2)", nullable: true),
            //        country = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
            //        amtdue = table.Column<decimal>(type: "numeric(18, 2)", nullable: true),
            //        suspdate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        suspperm = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
            //        perovt = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
            //        FMark = table.Column<bool>(nullable: true),
            //        BloodGrp = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        Gynotype = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        EyeColor = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
            //        Height = table.Column<decimal>(type: "numeric(18, 2)", nullable: true),
            //        Haircolor = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
            //        dtengaged = table.Column<DateTime>(type: "datetime", nullable: true),
            //        tumbpic = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
            //        signpic = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
            //        EntryYrExp = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
            //        dpromo = table.Column<DateTime>(type: "datetime", nullable: true),
            //        bSalary = table.Column<decimal>(type: "numeric(18, 2)", nullable: true),
            //        amtduebal = table.Column<decimal>(type: "numeric(18, 2)", nullable: true),
            //        testadmin = table.Column<bool>(nullable: true),
            //        cardno = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        posting = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        nysccdno = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "('')"),
            //        nysccdday = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "('')"),
            //        nysccdgroup = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "('')"),
            //        pleave = table.Column<bool>(nullable: true),
            //        cstaff = table.Column<bool>(nullable: true),
            //        scodee = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        bar1 = table.Column<bool>(nullable: true),
            //        ppay = table.Column<bool>(nullable: true),
            //        btype = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
            //        indu = table.Column<bool>(nullable: true),
            //        rsapin = table.Column<string>(unicode: false, maxLength: 18, nullable: true),
            //        cadre = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        acctype = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        bankcode1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        branchcode1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        FUNCTION1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        sortcode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        accountid1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        zone = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        office2 = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        acctname = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_stafftab", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "USERACCT",
            //    columns: table => new
            //    {
            //        pkvalue = table.Column<decimal>(type: "numeric(18, 0)", nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        userid = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
            //        pwd = table.Column<string>(unicode: false, nullable: true),
            //        grpcode = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
            //        username = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        suspend = table.Column<bool>(nullable: true),
            //        loggedon = table.Column<bool>(nullable: true),
            //        deleted = table.Column<bool>(nullable: true),
            //        raccess = table.Column<bool>(nullable: true),
            //        uaccess = table.Column<bool>(nullable: true),
            //        compcode = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
            //        newlogin = table.Column<bool>(nullable: true),
            //        expiredate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        nvrexpire = table.Column<bool>(nullable: true),
            //        rptaccess = table.Column<bool>(nullable: true),
            //        prtaccess = table.Column<bool>(nullable: true),
            //        admin = table.Column<bool>(nullable: true),
            //        gledger = table.Column<bool>(nullable: true),
            //        acct_pay = table.Column<bool>(nullable: true),
            //        acct_rec = table.Column<bool>(nullable: true),
            //        fixd_asst = table.Column<bool>(nullable: true),
            //        acct_setup = table.Column<bool>(nullable: true),
            //        budget = table.Column<bool>(nullable: true),
            //        stock_invent = table.Column<bool>(nullable: true),
            //        analysis = table.Column<bool>(nullable: true),
            //        revenue = table.Column<bool>(nullable: true),
            //        bank_cash = table.Column<bool>(nullable: true),
            //        gov_budget = table.Column<bool>(nullable: true),
            //        project = table.Column<bool>(nullable: true),
            //        addybook = table.Column<bool>(nullable: true),
            //        audit = table.Column<bool>(nullable: true),
            //        warrant = table.Column<bool>(nullable: true),
            //        stock_req = table.Column<bool>(nullable: true),
            //        coordination = table.Column<bool>(nullable: true),
            //        procurement = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
            //        accslvl = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
            //        zcopny = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        modidate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        datein = table.Column<DateTime>(type: "datetime", nullable: true),
            //        patsalinvo = table.Column<bool>(nullable: true),
            //        Lastlogin = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_useracct_1", x => x.pkvalue);
            //    });

            migrationBuilder.CreateTable(
                name: "Fingerprints",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StafftabId = table.Column<int>(nullable: false),
                    FPfile = table.Column<byte[]>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fingerprints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fingerprints_stafftab_StafftabId",
                        column: x => x.StafftabId,
                        principalTable: "stafftab",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fingerprints_StafftabId",
                table: "Fingerprints",
                column: "StafftabId");

            //migrationBuilder.CreateIndex(
            //    name: "office",
            //    table: "stafftab",
            //    column: "office");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Fingerprints");

            //migrationBuilder.DropTable(
            //    name: "USERACCT");

            //migrationBuilder.DropTable(
            //    name: "stafftab");
        }
    }
}
