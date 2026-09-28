namespace SmartDemo.Components.Models
{
    public class DropdownItem
    {
        public string Name { get; set; } = "";
        public string Code { get; set; } = "";
        public string Extra { get; set; } = "";

        public DropdownItem() { }

        public DropdownItem(string name, string code = "", string extra = "")
        {
            Name = name;
            Code = code;
            Extra = extra;
        }
    }
}
