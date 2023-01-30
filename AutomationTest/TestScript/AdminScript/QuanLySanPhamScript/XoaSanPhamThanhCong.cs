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
    public class XoaSanPhamThanhCong : BaseTest2
    {
        [Test, Category("Xoa San Pham")]
        public void XoaSanPham()
        {
            //dang nhap
            var login = new DangNhapAdmin_POM(driver);
            login.LoginSuccess();
            //xoa san pham
            var xoa = new XoaSanPham_POM(driver);
            xoa.XoaSanPhamThanhCong();
        }
    }
}
