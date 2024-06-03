using HRM.Client.Models;
using Microsoft.AspNetCore.Components.Forms;
namespace HRM.Client.Components.Pages.Salary
{
    public partial class CollectTaxesArrear
    {
        public bool PopupVisible { get; set; }

        public DateTime TuNgay { get; set; } = DateTime.Now;
        public DateTime DenNgay { get; set; } = DateTime.Now.AddDays(3);
        public EditContext? _EditContext { get; set; }
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

            _EditContext = new EditContext(SelectModel);
        }
        protected void ShowPopupHandler()
        {
            PopupVisible = true;
        }

        protected void OnSaveHandler()
        {
            try
            {
                var checkData = _EditContext!.Validate();
                if (!checkData) return;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected void RefreshHandler()
        {
            _EditContext = new EditContext(SelectModel);
            StateHasChanged();
        }
        #endregion
    }
}
