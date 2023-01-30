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
    public class XoaDanhMucThanhCong : BaseTest2
    {
        [Test, Category("Xoa danh muc san pham")]
        public void XoaDanhMuc()
        {
            var login = new DangNhapAdmin_POM(driver);
            login.LoginSuccess();
            var xoa = new XoaDanhMuc_POM(driver);
            xoa.XoaDanhMucThanhCong();
        }

    }
}
