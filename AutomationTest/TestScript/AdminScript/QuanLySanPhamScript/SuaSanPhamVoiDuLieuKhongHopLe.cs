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
    public class SuaSanPhamVoiDuLieuKhongHopLe : BaseTest2
    {
        [Test, Category("Sua San Pham")]
        public void SuaSanPham()
        {
            //dang nhap
            var login = new DangNhapAdmin_POM(driver);
            login.LoginSuccess();
            //sua
            var sua = new SuaSanPham_POM(driver);
            sua.SuaSanPhamVoiDuLieuKhongHopLe();
        }
    }
}
