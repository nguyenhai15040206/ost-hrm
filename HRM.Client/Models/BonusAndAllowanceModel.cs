namespace HRM.Client.Models
{
    public class BonusAndAllowanceModel
    {
        public string loaiThuong { get; set; }
        public string tenNhanVien { get; set; }
        public string soPhieu { get; set; }
        public DateTime ngayLap { get; set; } = DateTime.Now;
        public string tinhTrang { get; set; }
        public string soQuyetDinh { get; set; }
        public DateTime ngayKi { get; set; } = DateTime.Now;
        public string nguoiLap { get; set; }
        public string nguoiKi { get; set; }
        public decimal tongTienThuong { get; set; }
        public DateTime thangThuong { get; set; } = DateTime.Now;
        public DateTime thangChiTra { get; set; } = DateTime.Now;
        public DateTime thangTinhThue { get; set; } = DateTime.Now;
        public string thoiDiemChiTra { get; set; }
        public string noiDung { get; set; }
    }
}
