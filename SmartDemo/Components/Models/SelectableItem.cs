namespace SmartDemo.Components.Models
{
    public class SelectableItem
    {
        public string Name { get; set; } = "";
        public string Code { get; set; } = "";
        public bool IsSelected { get; set; }

        public SelectableItem() { }

        public SelectableItem(string name, bool isSelected = false, string code = "")
        {
            Name = name;
            IsSelected = isSelected;
            Code = code;
        }
    }
}
