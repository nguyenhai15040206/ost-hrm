namespace HRM.Client.Models
{
    public class MenuModel
    {
        public int Id { get; set; }
        public string? MenuCode { get; set; }
        public string? MenuName { get; set; }
        public string? Icon { get; set; }
        public string? IconType { get; set; }
        public string? Link { get; set; }
        public string? Controller { get; set; }
        public string? ParentCode { get; set; }
        public int Level { get; set; }
        public bool IsVisible { get; set; }
        public int OrdinalNumber { get; set; }
    }
}
