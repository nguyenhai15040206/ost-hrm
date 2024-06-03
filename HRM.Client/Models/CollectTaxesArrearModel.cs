namespace HRM.Client.Models
{
    public class CollectTaxesArrearModel
    {
        public string? maNhanVien {  get; set; }
        public string? tenNhanVien {  get; set; }
        public string? phongBan {  get; set; }
        public int thangTrichNop{  get; set; }
        public int namTrichNop {  get; set; }
        public int thangTruyThu { get; set; }
        public int namTruyThu { get; set; }
        public decimal luongCoBan { get; set; }
        public decimal phuCapLuong { get; set; }
        public decimal phuCapBHXH { get; set; }
        public decimal luongBHXH { get; set; }
        public decimal luongBHTN { get; set; }
        public bool daTruyThu { get; set; }
        public decimal bhxhCty { get; set; }
        public decimal bhxhNV { get; set; }
        public decimal bhytCty { get; set; }
        public decimal bhytNV { get; set; }
        public decimal bhtnCty { get; set; }
        public decimal bhtnNV { get; set; }
        public decimal bhtnLD { get; set; }
        public string? ghiChu { get; set; }
    }
}
