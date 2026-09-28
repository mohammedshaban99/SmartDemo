namespace SmartDemo.Components.Models
{
    public class AccountsTreeNode
    {
        public string Name { get; set; } = "";
        public string Code { get; set; } = "";
        public int Level { get; set; } = 0;
        public bool IsExpanded { get; set; } = true;
        public List<AccountsTreeNode> Children { get; set; } = new();

        public AccountsTreeNode() { }

        public AccountsTreeNode(string name, string code = "", int level = 0, bool isExpanded = true)
        {
            Name = name;
            Code = code;
            Level = level;
            IsExpanded = isExpanded;
        }
    }
}
