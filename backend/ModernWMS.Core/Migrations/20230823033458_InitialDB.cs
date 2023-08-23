using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModernWMS.Core.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "asn",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    asnno = table.Column<string>(name: "asn_no", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    asnstatus = table.Column<byte>(name: "asn_status", type: "tinyint unsigned", nullable: false),
                    spuid = table.Column<int>(name: "spu_id", type: "int", nullable: false),
                    skuid = table.Column<int>(name: "sku_id", type: "int", nullable: false),
                    asnqty = table.Column<int>(name: "asn_qty", type: "int", nullable: false),
                    actualqty = table.Column<int>(name: "actual_qty", type: "int", nullable: false),
                    sortedqty = table.Column<int>(name: "sorted_qty", type: "int", nullable: false),
                    shortageqty = table.Column<int>(name: "shortage_qty", type: "int", nullable: false),
                    moreqty = table.Column<int>(name: "more_qty", type: "int", nullable: false),
                    damageqty = table.Column<int>(name: "damage_qty", type: "int", nullable: false),
                    weight = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    volume = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    supplierid = table.Column<int>(name: "supplier_id", type: "int", nullable: false),
                    suppliername = table.Column<string>(name: "supplier_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    goodsownerid = table.Column<int>(name: "goods_owner_id", type: "int", nullable: false),
                    goodsownername = table.Column<string>(name: "goods_owner_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    creator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    isvalid = table.Column<bool>(name: "is_valid", type: "tinyint(1)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asn", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "asnsort",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    asnid = table.Column<int>(name: "asn_id", type: "int", nullable: false),
                    sortedqty = table.Column<int>(name: "sorted_qty", type: "int", nullable: false),
                    creator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    isvalid = table.Column<bool>(name: "is_valid", type: "tinyint(1)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnsort", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    categoryname = table.Column<string>(name: "category_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    parentid = table.Column<int>(name: "parent_id", type: "int", nullable: false),
                    creator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    isvalid = table.Column<bool>(name: "is_valid", type: "tinyint(1)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    companyname = table.Column<string>(name: "company_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    city = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    manager = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contacttel = table.Column<string>(name: "contact_tel", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    customername = table.Column<string>(name: "customer_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    city = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    manager = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contacttel = table.Column<string>(name: "contact_tel", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    creator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    isvalid = table.Column<bool>(name: "is_valid", type: "tinyint(1)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dispatchlist",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dispatchno = table.Column<string>(name: "dispatch_no", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dispatchstatus = table.Column<byte>(name: "dispatch_status", type: "tinyint unsigned", nullable: false),
                    customerid = table.Column<int>(name: "customer_id", type: "int", nullable: false),
                    customername = table.Column<string>(name: "customer_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    skuid = table.Column<int>(name: "sku_id", type: "int", nullable: false),
                    qty = table.Column<int>(type: "int", nullable: false),
                    weight = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    volume = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    creator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    damageqty = table.Column<int>(name: "damage_qty", type: "int", nullable: false),
                    lockqty = table.Column<int>(name: "lock_qty", type: "int", nullable: false),
                    pickedqty = table.Column<int>(name: "picked_qty", type: "int", nullable: false),
                    intrasitqty = table.Column<int>(name: "intrasit_qty", type: "int", nullable: false),
                    packageqty = table.Column<int>(name: "package_qty", type: "int", nullable: false),
                    weighingqty = table.Column<int>(name: "weighing_qty", type: "int", nullable: false),
                    actualqty = table.Column<int>(name: "actual_qty", type: "int", nullable: false),
                    signqty = table.Column<int>(name: "sign_qty", type: "int", nullable: false),
                    packageno = table.Column<string>(name: "package_no", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    packageperson = table.Column<string>(name: "package_person", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    packagetime = table.Column<DateTime>(name: "package_time", type: "datetime(6)", nullable: false),
                    weighingno = table.Column<string>(name: "weighing_no", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    weighingperson = table.Column<string>(name: "weighing_person", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    weighingweight = table.Column<decimal>(name: "weighing_weight", type: "decimal(65,30)", nullable: false),
                    waybillno = table.Column<string>(name: "waybill_no", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    carrier = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    freightfee = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dispatchlist", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "freightfee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    carrier = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    departurecity = table.Column<string>(name: "departure_city", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    arrivalcity = table.Column<string>(name: "arrival_city", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    priceperweight = table.Column<decimal>(name: "price_per_weight", type: "decimal(65,30)", nullable: false),
                    pricepervolume = table.Column<decimal>(name: "price_per_volume", type: "decimal(65,30)", nullable: false),
                    minpayment = table.Column<decimal>(name: "min_payment", type: "decimal(65,30)", nullable: false),
                    creator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    isvalid = table.Column<bool>(name: "is_valid", type: "tinyint(1)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_freightfee", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "goodslocation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    warehouseid = table.Column<int>(name: "warehouse_id", type: "int", nullable: false),
                    warehousename = table.Column<string>(name: "warehouse_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    warehouseareaname = table.Column<string>(name: "warehouse_area_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    warehouseareaproperty = table.Column<byte>(name: "warehouse_area_property", type: "tinyint unsigned", nullable: false),
                    locationname = table.Column<string>(name: "location_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    locationlength = table.Column<decimal>(name: "location_length", type: "decimal(65,30)", nullable: false),
                    locationwidth = table.Column<decimal>(name: "location_width", type: "decimal(65,30)", nullable: false),
                    locationheigth = table.Column<decimal>(name: "location_heigth", type: "decimal(65,30)", nullable: false),
                    locationvolume = table.Column<decimal>(name: "location_volume", type: "decimal(65,30)", nullable: false),
                    locationload = table.Column<decimal>(name: "location_load", type: "decimal(65,30)", nullable: false),
                    roadwaynumber = table.Column<string>(name: "roadway_number", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    shelfnumber = table.Column<string>(name: "shelf_number", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    layernumber = table.Column<string>(name: "layer_number", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tagnumber = table.Column<string>(name: "tag_number", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    isvalid = table.Column<bool>(name: "is_valid", type: "tinyint(1)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false),
                    warehouseareaid = table.Column<int>(name: "warehouse_area_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_goodslocation", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "goodsowner",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    goodsownername = table.Column<string>(name: "goods_owner_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    city = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    manager = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contacttel = table.Column<string>(name: "contact_tel", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    creator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    isvalid = table.Column<bool>(name: "is_valid", type: "tinyint(1)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_goodsowner", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "menu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    menuname = table.Column<string>(name: "menu_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    module = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vuepath = table.Column<string>(name: "vue_path", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vuepathdetail = table.Column<string>(name: "vue_path_detail", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vuedirectory = table.Column<string>(name: "vue_directory", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sort = table.Column<int>(type: "int", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rolemenu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    userroleid = table.Column<int>(name: "userrole_id", type: "int", nullable: false),
                    menuid = table.Column<int>(name: "menu_id", type: "int", nullable: false),
                    authority = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rolemenu", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "spu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    spucode = table.Column<string>(name: "spu_code", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    spuname = table.Column<string>(name: "spu_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    categoryid = table.Column<int>(name: "category_id", type: "int", nullable: false),
                    spudescription = table.Column<string>(name: "spu_description", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    barcode = table.Column<string>(name: "bar_code", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    supplierid = table.Column<int>(name: "supplier_id", type: "int", nullable: false),
                    suppliername = table.Column<string>(name: "supplier_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    brand = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    origin = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lengthunit = table.Column<byte>(name: "length_unit", type: "tinyint unsigned", nullable: false),
                    volumeunit = table.Column<byte>(name: "volume_unit", type: "tinyint unsigned", nullable: false),
                    weightunit = table.Column<byte>(name: "weight_unit", type: "tinyint unsigned", nullable: false),
                    creator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    isvalid = table.Column<bool>(name: "is_valid", type: "tinyint(1)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spu", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "stock",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    skuid = table.Column<int>(name: "sku_id", type: "int", nullable: false),
                    goodslocationid = table.Column<int>(name: "goods_location_id", type: "int", nullable: false),
                    qty = table.Column<int>(type: "int", nullable: false),
                    goodsownerid = table.Column<int>(name: "goods_owner_id", type: "int", nullable: false),
                    isfreeze = table.Column<bool>(name: "is_freeze", type: "tinyint(1)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stock", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "stockadjust",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    jobcode = table.Column<string>(name: "job_code", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    skuid = table.Column<int>(name: "sku_id", type: "int", nullable: false),
                    goodsownerid = table.Column<int>(name: "goods_owner_id", type: "int", nullable: false),
                    goodslocationid = table.Column<int>(name: "goods_location_id", type: "int", nullable: false),
                    qty = table.Column<int>(type: "int", nullable: false),
                    creator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false),
                    isupdatestock = table.Column<bool>(name: "is_update_stock", type: "tinyint(1)", nullable: false),
                    jobtype = table.Column<byte>(name: "job_type", type: "tinyint unsigned", nullable: false),
                    sourcetableid = table.Column<int>(name: "source_table_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stockadjust", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "stockfreeze",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    jobcode = table.Column<string>(name: "job_code", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jobtype = table.Column<bool>(name: "job_type", type: "tinyint(1)", nullable: false),
                    skuid = table.Column<int>(name: "sku_id", type: "int", nullable: false),
                    goodsownerid = table.Column<int>(name: "goods_owner_id", type: "int", nullable: false),
                    goodslocationid = table.Column<int>(name: "goods_location_id", type: "int", nullable: false),
                    handler = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    handletime = table.Column<DateTime>(name: "handle_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stockfreeze", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "stockmove",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    jobcode = table.Column<string>(name: "job_code", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    movestatus = table.Column<byte>(name: "move_status", type: "tinyint unsigned", nullable: false),
                    skuid = table.Column<int>(name: "sku_id", type: "int", nullable: false),
                    origgoodslocationid = table.Column<int>(name: "orig_goods_location_id", type: "int", nullable: false),
                    destgoogslocationid = table.Column<int>(name: "dest_googs_location_id", type: "int", nullable: false),
                    qty = table.Column<int>(type: "int", nullable: false),
                    goodsownerid = table.Column<int>(name: "goods_owner_id", type: "int", nullable: false),
                    handler = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    handletime = table.Column<DateTime>(name: "handle_time", type: "datetime(6)", nullable: false),
                    creator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stockmove", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "stockprocess",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    jobcode = table.Column<string>(name: "job_code", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jobtype = table.Column<bool>(name: "job_type", type: "tinyint(1)", nullable: false),
                    processstatus = table.Column<bool>(name: "process_status", type: "tinyint(1)", nullable: false),
                    processor = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    processtime = table.Column<DateTime>(name: "process_time", type: "datetime(6)", nullable: false),
                    creator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stockprocess", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "stocktaking",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    jobcode = table.Column<string>(name: "job_code", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jobstatus = table.Column<bool>(name: "job_status", type: "tinyint(1)", nullable: false),
                    skuid = table.Column<int>(name: "sku_id", type: "int", nullable: false),
                    goodsownerid = table.Column<int>(name: "goods_owner_id", type: "int", nullable: false),
                    goodslocationid = table.Column<int>(name: "goods_location_id", type: "int", nullable: false),
                    bookqty = table.Column<int>(name: "book_qty", type: "int", nullable: false),
                    countedqty = table.Column<int>(name: "counted_qty", type: "int", nullable: false),
                    differenceqty = table.Column<int>(name: "difference_qty", type: "int", nullable: false),
                    creator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false),
                    handler = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    handletime = table.Column<DateTime>(name: "handle_time", type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stocktaking", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "supplier",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    suppliername = table.Column<string>(name: "supplier_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    city = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    manager = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contacttel = table.Column<string>(name: "contact_tel", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    creator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    isvalid = table.Column<bool>(name: "is_valid", type: "tinyint(1)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplier", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    usernum = table.Column<string>(name: "user_num", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    username = table.Column<string>(name: "user_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contacttel = table.Column<string>(name: "contact_tel", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    userrole = table.Column<string>(name: "user_role", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sex = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isvalid = table.Column<bool>(name: "is_valid", type: "tinyint(1)", nullable: false),
                    authstring = table.Column<string>(name: "auth_string", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    creator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "userrole",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rolename = table.Column<string>(name: "role_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isvalid = table.Column<bool>(name: "is_valid", type: "tinyint(1)", nullable: false),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userrole", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "warehouse",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    warehousename = table.Column<string>(name: "warehouse_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    city = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    manager = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contacttel = table.Column<string>(name: "contact_tel", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    creator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    isvalid = table.Column<bool>(name: "is_valid", type: "tinyint(1)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warehouse", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "warehousearea",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    warehouseid = table.Column<int>(name: "warehouse_id", type: "int", nullable: false),
                    areaname = table.Column<string>(name: "area_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    parentid = table.Column<int>(name: "parent_id", type: "int", nullable: false),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    isvalid = table.Column<bool>(name: "is_valid", type: "tinyint(1)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false),
                    areaproperty = table.Column<byte>(name: "area_property", type: "tinyint unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warehousearea", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dispatchpicklist",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dispatchlistid = table.Column<int>(name: "dispatchlist_id", type: "int", nullable: false),
                    goodsownerid = table.Column<int>(name: "goods_owner_id", type: "int", nullable: false),
                    goodslocationid = table.Column<int>(name: "goods_location_id", type: "int", nullable: false),
                    skuid = table.Column<int>(name: "sku_id", type: "int", nullable: false),
                    pickqty = table.Column<int>(name: "pick_qty", type: "int", nullable: false),
                    pickedqty = table.Column<int>(name: "picked_qty", type: "int", nullable: false),
                    isupdatestock = table.Column<bool>(name: "is_update_stock", type: "tinyint(1)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dispatchpicklist", x => x.id);
                    table.ForeignKey(
                        name: "FK_dispatchpicklist_dispatchlist_dispatchlist_id",
                        column: x => x.dispatchlistid,
                        principalTable: "dispatchlist",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sku",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    spuid = table.Column<int>(name: "spu_id", type: "int", nullable: false),
                    skucode = table.Column<string>(name: "sku_code", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    skuname = table.Column<string>(name: "sku_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    weight = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    lenght = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    width = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    height = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    volume = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    unit = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cost = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    createtime = table.Column<DateTime>(name: "create_time", type: "datetime(6)", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sku", x => x.id);
                    table.ForeignKey(
                        name: "FK_sku_spu_spu_id",
                        column: x => x.spuid,
                        principalTable: "spu",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "stockprocessdetail",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    stockprocessid = table.Column<int>(name: "stock_process_id", type: "int", nullable: false),
                    skuid = table.Column<int>(name: "sku_id", type: "int", nullable: false),
                    goodsownerid = table.Column<int>(name: "goods_owner_id", type: "int", nullable: false),
                    goodslocationid = table.Column<int>(name: "goods_location_id", type: "int", nullable: false),
                    qty = table.Column<int>(type: "int", nullable: false),
                    lastupdatetime = table.Column<DateTime>(name: "last_update_time", type: "datetime(6)", nullable: false),
                    tenantid = table.Column<long>(name: "tenant_id", type: "bigint", nullable: false),
                    issource = table.Column<bool>(name: "is_source", type: "tinyint(1)", nullable: false),
                    isupdatestock = table.Column<bool>(name: "is_update_stock", type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stockprocessdetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_stockprocessdetail_stockprocess_stock_process_id",
                        column: x => x.stockprocessid,
                        principalTable: "stockprocess",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_dispatchpicklist_dispatchlist_id",
                table: "dispatchpicklist",
                column: "dispatchlist_id");

            migrationBuilder.CreateIndex(
                name: "IX_sku_spu_id",
                table: "sku",
                column: "spu_id");

            migrationBuilder.CreateIndex(
                name: "IX_stockprocessdetail_stock_process_id",
                table: "stockprocessdetail",
                column: "stock_process_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asn");

            migrationBuilder.DropTable(
                name: "asnsort");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "dispatchpicklist");

            migrationBuilder.DropTable(
                name: "freightfee");

            migrationBuilder.DropTable(
                name: "goodslocation");

            migrationBuilder.DropTable(
                name: "goodsowner");

            migrationBuilder.DropTable(
                name: "menu");

            migrationBuilder.DropTable(
                name: "rolemenu");

            migrationBuilder.DropTable(
                name: "sku");

            migrationBuilder.DropTable(
                name: "stock");

            migrationBuilder.DropTable(
                name: "stockadjust");

            migrationBuilder.DropTable(
                name: "stockfreeze");

            migrationBuilder.DropTable(
                name: "stockmove");

            migrationBuilder.DropTable(
                name: "stockprocessdetail");

            migrationBuilder.DropTable(
                name: "stocktaking");

            migrationBuilder.DropTable(
                name: "supplier");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "userrole");

            migrationBuilder.DropTable(
                name: "warehouse");

            migrationBuilder.DropTable(
                name: "warehousearea");

            migrationBuilder.DropTable(
                name: "dispatchlist");

            migrationBuilder.DropTable(
                name: "spu");

            migrationBuilder.DropTable(
                name: "stockprocess");
        }
    }
}
