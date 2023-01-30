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
    public class AnSanPhamThanhCong : BaseTest2
    {
        [Test, Category("An San Pham")]
        public void AnSanPham()
        {
            //dang nhap
            var login = new DangNhapAdmin_POM(driver);
            login.LoginSuccess();
            //an san pham
            var an = new AnSanPham_POM(driver);
            an.AnSanPhamThanhCong();
        }
    }
}
