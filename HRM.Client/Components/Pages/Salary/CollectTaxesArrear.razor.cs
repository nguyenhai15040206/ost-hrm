using HRM.Client.Models;
namespace HRM.Client.Components.Pages.Salary
{
    public partial class CollectTaxesArrear
    {
        public bool PopupVisible { get; set; }
        public string? SoPhieu { get; set; }
        public string? TrangThai { get; set; } = "TaoMoi";
        public DateTime NgayDangKi { get; set; } = DateTime.Now;
        public string? PhongBan { get; set; } = "PTHC";
        public string? LoaiDangKi { get; set; } = "TTCTQD";
        public string? NguoiLap { get; set; } = "";
        public string? NhanVien { get; set; } = "";
        public string? LyDo { get; set; } = "";

        public DateTime TuNgay { get; set; } = DateTime.Now;
        public DateTime DenNgay { get; set; } = DateTime.Now.AddDays(3);


        public List<ComboboxModel>? ListTrangThai { get; set; }
        public List<ComboboxModel>? ListPhongBan { get; set; }
        public List<ComboboxModel>? ListLoaiDangKi { get; set; }
        public List<ComboboxModel>? ListUsers { get; set; }
    }
}
