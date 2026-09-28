namespace SmartDemo.Components.Models
{
    public class UnitRowModel
    {
        public string Barcode { get; set; } = "";
        public int PiecesCount { get; set; } = 1;
        public string Unit { get; set; } = "";
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public bool IsDefaultPurchase { get; set; }
        public bool IsDefaultSale { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
