namespace SmartDemo.Components.Models
{
    public class TaxAccountItem
    {
        public string Name { get; set; } = "";
        public string SalesRate { get; set; } = "";
        public string PurchaseRate { get; set; } = "";

        public TaxAccountItem() { }

        public TaxAccountItem(string name, string salesRate, string purchaseRate)
        {
            Name = name;
            SalesRate = salesRate;
            PurchaseRate = purchaseRate;
        }
    }
}
