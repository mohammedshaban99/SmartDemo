namespace SmartDemo.Components.Models
{
    public class OpeningBalanceModel
    {
        public decimal Quantity { get; set; }
        public string Unit { get; set; } = "قطعه";
        public string QuantityUnit { get; set; } = "قطعه";
        public decimal UnitCost { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime Date { get; set; } = DateTime.Today;
        public string LedgerAccount { get; set; } = "الأرصدة الإفتتاحية";
    }
}
