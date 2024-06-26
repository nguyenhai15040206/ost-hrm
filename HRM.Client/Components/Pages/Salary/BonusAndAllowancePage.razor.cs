﻿using HRM.Client.Models;
using HRM.Client.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace HRM.Client.Components.Pages.Salary
{
    public partial class BonusAndAllowancePage
    {
        [Inject] public IProgressService? _progressService { get; init; }
        public List<ComboboxModel>? ListUsers { get; set; }
        public BonusAndAllowanceModel SelectModel { get; set; } = new BonusAndAllowanceModel();
        public List<CollectTaxesArrearModel> ListGrids { get; set; } = new List<CollectTaxesArrearModel>();
        public EditContext? _EditContext { get; set; }
        public DateTime TuNgay { get; set; } = DateTime.Now;
        public DateTime DenNgay { get; set; } = DateTime.Now.AddDays(3);
        public int ActiveTabIndex { get; set; } = 0;

        public List<ComboboxModel>? ListLoaiThuong { get; set; }
        public List<ComboboxModel>? ListTinhTrang { get; set; }
        public List<ComboboxModel>? ListThoiDiemChiTra { get; set; }

        protected override async Task OnInitializedAsync()
        {
            _EditContext = new EditContext(SelectModel);
            try
            {
                await base.OnInitializedAsync();
                await _progressService!.Start();
                ListGrids = new List<CollectTaxesArrearModel>();
                ListGrids.Add(new CollectTaxesArrearModel()
                {
                    maNhanVien = "NV001",
                    tenNhanVien = "Nguyễn Văn A",
                    phongBan = "Phòng ban IT",
                    thangTrichNop = 4,
                    namTrichNop = 2024,
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
                createDataCombo();
            }
            catch (Exception) { }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {
                await _progressService!.SetPercent(0.4);
                await Task.Delay(500);
                await _progressService!.Done();
            }
        }


        private void createDataCombo()
        {
            ListLoaiThuong = new List<ComboboxModel>();
            ListLoaiThuong.Add(new ComboboxModel() { code = "LT001", name = "Quỹ khen thưởng đơn vị khôi phục" });
            ListLoaiThuong.Add(new ComboboxModel() { code = "LT002", name = "Thuế tháng 13" });
            SelectModel.loaiThuong = "LT001";

            ListTinhTrang = new List<ComboboxModel>();
            ListTinhTrang.Add(new ComboboxModel() { code = "TT001", name = "Tạo mới" });
            ListTinhTrang.Add(new ComboboxModel() { code = "TT002", name = "Đã duyệt" });
            ListTinhTrang.Add(new ComboboxModel() { code = "TT003", name = "Hủy" });
            SelectModel.tinhTrang = "TT001";

            ListThoiDiemChiTra = new List<ComboboxModel>();
            ListThoiDiemChiTra.Add(new ComboboxModel() { code = "TT001", name = "Lương kỳ 1" });
            ListThoiDiemChiTra.Add(new ComboboxModel() { code = "TT002", name = "Lương kỳ 2" });
            SelectModel.thoiDiemChiTra = "TT002";
        }
    }
}
