using AutomationTest.FileBaseTest;
using AutomationTest.POM.AdminPOM.LoginPOM;
using AutomationTest.POM.CustomersPOM.PayPOM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.TestScript.CustomerScript.PayScript
{
    public class ThanhToanThieuDuLieu : BaseTest
    {
        [Test]  
        public void ThanhToan()
        {
            var login = new DangNhapNguoiDung_POM(driver);
            login.LoginSuccess();

            var thanhtoan = new ThanhToan_POM(driver);
            thanhtoan.ThanhToanThieuField();
        }
    }
}
