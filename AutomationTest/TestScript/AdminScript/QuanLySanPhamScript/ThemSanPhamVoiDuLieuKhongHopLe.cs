using AutomationTest.FileBaseTest;
using AutomationTest.POM.AdminPOM.QuanLySanPhamPOM;
using AutomationTest.POM.CustomersPOM.LoginPOM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.TestScript.AdminScript.QuanLySanPhamScript
{
    public class ThemSanPhamVoiDuLieuKhongHopLe : BaseTest2
    {
        [Test, Category("Them San Pham")]
        public void ThemSanPham()
        {
            //dang nhap
            var login = new DangNhapAdmin_POM(driver);
            login.LoginSuccess();
            //them san pham
            var them = new ThemSanPham_POM(driver);
            them.ThemSanPhamVoiDuLieuKhongHopLe();
        }
    }
}
