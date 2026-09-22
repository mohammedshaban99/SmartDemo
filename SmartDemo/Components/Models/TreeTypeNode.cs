namespace SmartDemo.Components.Models
{
    public class TreeTypeNode
    {
        public string Name { get; set; } = "";
        public string Code { get; set; } = "";
        public int Level { get; set; } = 0;
        public bool IsExpanded { get; set; } = false;
        public List<TreeTypeNode> Children { get; set; } = new();
    }
}
