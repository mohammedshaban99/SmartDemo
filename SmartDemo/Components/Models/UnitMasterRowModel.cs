namespace SmartDemo.Components.Models
{
    public class UnitMasterRowModel
    {
        public string Code { get; set; } = "";
        public string Name { get; set; } = "";
        public int PiecesCount { get; set; } = 1;
        public string Currency { get; set; } = "جنية";
        public bool IsDefaultPurchase { get; set; }
        public bool IsDefaultSale { get; set; }

        public UnitMasterRowModel() { }

        public UnitMasterRowModel(string code, string name, int piecesCount = 1, string currency = "جنية", bool isDefaultPurchase = false, bool isDefaultSale = false)
        {
            Code = code;
            Name = name;
            PiecesCount = piecesCount;
            Currency = currency;
            IsDefaultPurchase = isDefaultPurchase;
            IsDefaultSale = isDefaultSale;
        }
    }
}
