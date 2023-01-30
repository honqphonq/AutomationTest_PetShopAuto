using AutomationTest.FileBaseTest;
using AutomationTest.POM.AdminPOM.QuanLyDanhMucPOM;
using AutomationTest.POM.CustomersPOM.LoginPOM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.TestScript.AdminScript.QuanLyDanhMucScript
{
    public class ThemDanhMucVoiThieuDuLieu : BaseTest2
    {
        [Test, Category("Them danh muc")]
        public void ThemDanhMuc()
        {
            var login = new DangNhapAdmin_POM(driver);
            login.LoginSuccess();
            var them = new ThemDanhMuc_POM(driver);
            them.ThemTenDanhMucVoiThieuDuLieu();
        }
    }
}
