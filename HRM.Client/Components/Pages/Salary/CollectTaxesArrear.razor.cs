using HRM.Client.Models;
namespace HRM.Client.Components.Pages.Salary
{
    public partial class CollectTaxesArrear
    {
        public int ActiveTabIndex { get; set; } = 0;
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

        public CollectTaxesArrearModel SelectModel { get; set; } = new CollectTaxesArrearModel();
        public List<CollectTaxesArrearModel> ListGrids { get; set; } = new List<CollectTaxesArrearModel>();

        #region
        protected override void OnInitialized()
        {
            base.OnInitialized();
            ListGrids = new List<CollectTaxesArrearModel>();
            ListGrids.Add(new CollectTaxesArrearModel()
            {
                maNhanVien = "NV001",
                tenNhanVien= "Nguyễn Văn A",
                phongBan= "Phòng ban IT",
                thangTrichNop = 4,
                namTrichNop= 2024,
                thangTruyThu = 4,
                namTruyThu = 2024,
                luongCoBan = 5000000,
                daTruyThu = true
            });
            ListGrids.Add(new CollectTaxesArrearModel()
            {
                maNhanVien = "NV002",
                tenNhanVien = "Nguyễn Văn B",
                phongBan = "Phòng ban IT",
                thangTrichNop = 4,
                namTrichNop = 2024,
                thangTruyThu = 4,
                namTruyThu = 2024,
                luongCoBan = 5000000,
                daTruyThu = true
            });
        }
        protected void ShowPopupHandler()
        {
            PopupVisible = true;
        }
        #endregion
    }
}
