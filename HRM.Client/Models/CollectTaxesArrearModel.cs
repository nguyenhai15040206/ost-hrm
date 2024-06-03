using System.ComponentModel.DataAnnotations;

namespace HRM.Client.Models
{
    public class CollectTaxesArrearModel
    {
        [Required(ErrorMessage = "Vui lòng điền [Mã nhân viên]")]
        public string? maNhanVien {  get; set; }
        [Required(ErrorMessage = "Vui lòng điền [Tên nhân viên]")]
        public string? tenNhanVien {  get; set; }
        public string? phongBan {  get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "Vui lòng điền [Tháng trích nộp]")]
        public int thangTrichNop{  get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "Vui lòng điền [Năm trích nộp]")]
        public int namTrichNop {  get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "Vui lòng điền [Tháng truy thu]")]
        public int thangTruyThu { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "Vui lòng điền [Năm truy thu]")]
        public int namTruyThu { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "Vui lòng điền [Lương cơ bản]")]
        public decimal luongCoBan { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "Vui lòng điền [Phụ cấp lương]")]
        public decimal phuCapLuong { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "Vui lòng điền [Phụ cấp bảo hiểm xã hội]")]
        public decimal phuCapBHXH { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "Vui lòng điền [Lương bảo hiểm xã hội]")]
        public decimal luongBHXH { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "Vui lòng điền [Lương bảo hiểm thất nghiệp]")]
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
