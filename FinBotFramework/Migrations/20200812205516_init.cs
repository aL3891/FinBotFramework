using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinBotFramework.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Exchange = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Strategy",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strategy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AD",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_AD_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ADOSC",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    FastPeriod = table.Column<int>(type: "int", nullable: false),
                    SlowPeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ADOSC_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ADX",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ADX_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ADXR",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ADXR_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "APO",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    FastPeriod = table.Column<int>(type: "int", nullable: false),
                    SlowPeriod = table.Column<int>(type: "int", nullable: false),
                    MaType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_APO_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AROON",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_AROON_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AROONOSC",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_AROONOSC_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ATR",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ATR_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BBANDS",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false),
                    nbdevup = table.Column<int>(type: "int", nullable: false),
                    nbdevdn = table.Column<int>(type: "int", nullable: false),
                    matype = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_BBANDS_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BOP",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_BOP_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CCI",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CCI_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CMO",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CMO_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DEMA",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_DEMA_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DX",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_DX_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EMA",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_EMA_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HT_DCPERIOD",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_HT_DCPERIOD_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HT_DCPHASE",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_HT_DCPHASE_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HT_PHASOR",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_HT_PHASOR_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HT_SINE",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_HT_SINE_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HT_TRENDLINE",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_HT_TRENDLINE_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HT_TRENDMODE",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_HT_TRENDMODE_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KAMA",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_KAMA_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MACD",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    FastPeriod = table.Column<int>(type: "int", nullable: false),
                    SlowPeriod = table.Column<int>(type: "int", nullable: false),
                    SignalPeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_MACD_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MACDEXT",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    FastPeriod = table.Column<int>(type: "int", nullable: false),
                    SlowPeriod = table.Column<int>(type: "int", nullable: false),
                    SignalPeriod = table.Column<int>(type: "int", nullable: false),
                    FastMaType = table.Column<int>(type: "int", nullable: false),
                    SlowMaType = table.Column<int>(type: "int", nullable: false),
                    SignalMaType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_MACDEXT_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MAMA",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    FastLimit = table.Column<float>(type: "real", nullable: false),
                    SlowLimit = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_MAMA_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MFI",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_MFI_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MIDPOINT",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_MIDPOINT_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MIDPRICE",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_MIDPRICE_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MINUS_DI",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_MINUS_DI_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MINUS_DM",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_MINUS_DM_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MOM",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_MOM_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NATR",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_NATR_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OBV",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_OBV_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PLUS_DI",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_PLUS_DI_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PLUS_DM",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_PLUS_DM_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PPO",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    FastPeriod = table.Column<int>(type: "int", nullable: false),
                    SlowPeriod = table.Column<int>(type: "int", nullable: false),
                    matype = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_PPO_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ROC",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ROC_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ROCR",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ROCR_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RSI",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_RSI_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SAR",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    acceleration = table.Column<int>(type: "int", nullable: false),
                    maximum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_SAR_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMA",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_SMA_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "STOCH",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    fastkperiod = table.Column<int>(type: "int", nullable: false),
                    slowkperiod = table.Column<int>(type: "int", nullable: false),
                    slowdperiod = table.Column<int>(type: "int", nullable: false),
                    slowkmatype = table.Column<int>(type: "int", nullable: false),
                    slowdmatype = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_STOCH_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "STOCHRSI",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false),
                    fastkperiod = table.Column<int>(type: "int", nullable: false),
                    fastdperiod = table.Column<int>(type: "int", nullable: false),
                    fastdmatype = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_STOCHRSI_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "STOCKF",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    fastkperiod = table.Column<int>(type: "int", nullable: false),
                    fastdperiod = table.Column<int>(type: "int", nullable: false),
                    fastdmatype = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_STOCKF_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockPrice",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    TimeSpan = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockPrice", x => new { x.Date, x.StockId });
                    table.ForeignKey(
                        name: "FK_StockPrice_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T3",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_T3_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TEMA",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_TEMA_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TRANGE",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_TRANGE_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TRIMA",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_TRIMA_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TRIX",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_TRIX_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ULTOSC",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod1 = table.Column<int>(type: "int", nullable: false),
                    TimePeriod2 = table.Column<int>(type: "int", nullable: false),
                    TimePeriod3 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ULTOSC_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VWAP",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_VWAP_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WILLR",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_WILLR_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WMA",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interval = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_WMA_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Agent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StratId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agent_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agent_Strategy_StratId",
                        column: x => x.StratId,
                        principalTable: "Strategy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AD_StockId",
                table: "AD",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_ADOSC_StockId",
                table: "ADOSC",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_ADX_StockId",
                table: "ADX",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_ADXR_StockId",
                table: "ADXR",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Agent_AccountId",
                table: "Agent",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Agent_StratId",
                table: "Agent",
                column: "StratId");

            migrationBuilder.CreateIndex(
                name: "IX_APO_StockId",
                table: "APO",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_AROON_StockId",
                table: "AROON",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_AROONOSC_StockId",
                table: "AROONOSC",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_ATR_StockId",
                table: "ATR",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_BBANDS_StockId",
                table: "BBANDS",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_BOP_StockId",
                table: "BOP",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_CCI_StockId",
                table: "CCI",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_CMO_StockId",
                table: "CMO",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_DEMA_StockId",
                table: "DEMA",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_DX_StockId",
                table: "DX",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_EMA_StockId",
                table: "EMA",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_HT_DCPERIOD_StockId",
                table: "HT_DCPERIOD",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_HT_DCPHASE_StockId",
                table: "HT_DCPHASE",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_HT_PHASOR_StockId",
                table: "HT_PHASOR",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_HT_SINE_StockId",
                table: "HT_SINE",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_HT_TRENDLINE_StockId",
                table: "HT_TRENDLINE",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_HT_TRENDMODE_StockId",
                table: "HT_TRENDMODE",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_KAMA_StockId",
                table: "KAMA",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_MACD_StockId",
                table: "MACD",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_MACDEXT_StockId",
                table: "MACDEXT",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_MAMA_StockId",
                table: "MAMA",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_MFI_StockId",
                table: "MFI",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_MIDPOINT_StockId",
                table: "MIDPOINT",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_MIDPRICE_StockId",
                table: "MIDPRICE",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_MINUS_DI_StockId",
                table: "MINUS_DI",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_MINUS_DM_StockId",
                table: "MINUS_DM",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_MOM_StockId",
                table: "MOM",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_NATR_StockId",
                table: "NATR",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_OBV_StockId",
                table: "OBV",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_AccountId",
                table: "Order",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PLUS_DI_StockId",
                table: "PLUS_DI",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_PLUS_DM_StockId",
                table: "PLUS_DM",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_PPO_StockId",
                table: "PPO",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_ROC_StockId",
                table: "ROC",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_ROCR_StockId",
                table: "ROCR",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_RSI_StockId",
                table: "RSI",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_SAR_StockId",
                table: "SAR",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_SMA_StockId",
                table: "SMA",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_STOCH_StockId",
                table: "STOCH",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_STOCHRSI_StockId",
                table: "STOCHRSI",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_STOCKF_StockId",
                table: "STOCKF",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_StockPrice_StockId",
                table: "StockPrice",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_T3_StockId",
                table: "T3",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_TEMA_StockId",
                table: "TEMA",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_TRANGE_StockId",
                table: "TRANGE",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_TRIMA_StockId",
                table: "TRIMA",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_TRIX_StockId",
                table: "TRIX",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_ULTOSC_StockId",
                table: "ULTOSC",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_VWAP_StockId",
                table: "VWAP",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_WILLR_StockId",
                table: "WILLR",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_WMA_StockId",
                table: "WMA",
                column: "StockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AD");

            migrationBuilder.DropTable(
                name: "ADOSC");

            migrationBuilder.DropTable(
                name: "ADX");

            migrationBuilder.DropTable(
                name: "ADXR");

            migrationBuilder.DropTable(
                name: "Agent");

            migrationBuilder.DropTable(
                name: "APO");

            migrationBuilder.DropTable(
                name: "AROON");

            migrationBuilder.DropTable(
                name: "AROONOSC");

            migrationBuilder.DropTable(
                name: "ATR");

            migrationBuilder.DropTable(
                name: "BBANDS");

            migrationBuilder.DropTable(
                name: "BOP");

            migrationBuilder.DropTable(
                name: "CCI");

            migrationBuilder.DropTable(
                name: "CMO");

            migrationBuilder.DropTable(
                name: "DEMA");

            migrationBuilder.DropTable(
                name: "DX");

            migrationBuilder.DropTable(
                name: "EMA");

            migrationBuilder.DropTable(
                name: "HT_DCPERIOD");

            migrationBuilder.DropTable(
                name: "HT_DCPHASE");

            migrationBuilder.DropTable(
                name: "HT_PHASOR");

            migrationBuilder.DropTable(
                name: "HT_SINE");

            migrationBuilder.DropTable(
                name: "HT_TRENDLINE");

            migrationBuilder.DropTable(
                name: "HT_TRENDMODE");

            migrationBuilder.DropTable(
                name: "KAMA");

            migrationBuilder.DropTable(
                name: "MACD");

            migrationBuilder.DropTable(
                name: "MACDEXT");

            migrationBuilder.DropTable(
                name: "MAMA");

            migrationBuilder.DropTable(
                name: "MFI");

            migrationBuilder.DropTable(
                name: "MIDPOINT");

            migrationBuilder.DropTable(
                name: "MIDPRICE");

            migrationBuilder.DropTable(
                name: "MINUS_DI");

            migrationBuilder.DropTable(
                name: "MINUS_DM");

            migrationBuilder.DropTable(
                name: "MOM");

            migrationBuilder.DropTable(
                name: "NATR");

            migrationBuilder.DropTable(
                name: "OBV");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "PLUS_DI");

            migrationBuilder.DropTable(
                name: "PLUS_DM");

            migrationBuilder.DropTable(
                name: "PPO");

            migrationBuilder.DropTable(
                name: "ROC");

            migrationBuilder.DropTable(
                name: "ROCR");

            migrationBuilder.DropTable(
                name: "RSI");

            migrationBuilder.DropTable(
                name: "SAR");

            migrationBuilder.DropTable(
                name: "SMA");

            migrationBuilder.DropTable(
                name: "STOCH");

            migrationBuilder.DropTable(
                name: "STOCHRSI");

            migrationBuilder.DropTable(
                name: "STOCKF");

            migrationBuilder.DropTable(
                name: "StockPrice");

            migrationBuilder.DropTable(
                name: "T3");

            migrationBuilder.DropTable(
                name: "TEMA");

            migrationBuilder.DropTable(
                name: "TRANGE");

            migrationBuilder.DropTable(
                name: "TRIMA");

            migrationBuilder.DropTable(
                name: "TRIX");

            migrationBuilder.DropTable(
                name: "ULTOSC");

            migrationBuilder.DropTable(
                name: "VWAP");

            migrationBuilder.DropTable(
                name: "WILLR");

            migrationBuilder.DropTable(
                name: "WMA");

            migrationBuilder.DropTable(
                name: "Strategy");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Stock");
        }
    }
}
