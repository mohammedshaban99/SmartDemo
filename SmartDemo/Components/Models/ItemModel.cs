namespace SmartDemo.Components.Models
{
    public class ItemModel
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string EnglishName { get; set; } = "";
        public string ItemType { get; set; } = "مخزون";
        public string ItemTypeNote { get; set; } = "";
        public string QrType { get; set; } = "";
        public string BarcodeNumber { get; set; } = "";
        public bool IsActive { get; set; } = true;
        public string SupplierName { get; set; } = "";
        public string DistributionPolicy { get; set; } = "";
        public string GroupCategory { get; set; } = "";
        public string GeneralLedgerAccount { get; set; } = "";
        public string GlobalBarcodeType { get; set; } = "GS1";
        public string GlobalBarcodeValue { get; set; } = "";
        public string MeasurementUnit { get; set; } = "";
        public string ValuationMethod { get; set; } = "";
        public string OpeningBalance { get; set; } = "";
        public string SalesAccount { get; set; } = "";
        public string CogsAccount { get; set; } = "";
        public string SalesReturnAccount { get; set; } = "";
        public string VatApplicable { get; set; } = "نعم";
        public string TaxAccount { get; set; } = "";
        public decimal TaxSalesRate { get; set; } = 15;
        public decimal TaxPurchaseRate { get; set; } = 15;
        public bool PriceIncludesTax { get; set; }
        public string DiscountTaxApplicable { get; set; } = "كما بالفاتورة";
        public string DiscountTaxAccount { get; set; } = "";
        public decimal DiscountTaxRate { get; set; }
        public int MinLimit { get; set; } = 10;
        public int MaxLimit { get; set; } = 50;
        public int StagnationPeriod { get; set; } = 10;
        public bool CashDiscountApplicable { get; set; }
        public string DiscountMethod { get; set; } = "بالنسبة";
        public decimal PurchaseDiscount { get; set; }
        public decimal SalesDiscount { get; set; }
        public string CostCenter { get; set; } = "";
        public decimal AdditionalCost { get; set; }
        public string SerialNumber { get; set; } = "24040";
        public string Description { get; set; } = "";
        public string LocationOne { get; set; } = "";
        public string LocationTwo { get; set; } = "";
        public string LocationThree { get; set; } = "";
        public string Keywords { get; set; } = "";
        public string GpcValue { get; set; } = "";
        public string Manufacturer { get; set; } = "";
        public string ActiveIngredient { get; set; } = "";
        public DateTime ActiveFromDate { get; set; } = DateTime.Today;
        public string TouchScreenSize { get; set; } = "";
        public bool HideFromTouchScreen { get; set; }
        public string AdditionalLength { get; set; } = "0";
        public string AdditionalWidth { get; set; } = "0";
        public string AdditionalHeight { get; set; } = "0";
        public string AdditionalPanels { get; set; } = "0";
        public DateTime ExpenseDate { get; set; } = DateTime.Today;
        public List<UnitRowModel> UnitsTableRows { get; set; } = new();
        public List<EquationRowModel> EquationRows { get; set; } = new();
    }
}
