using AutomationTest.FileBaseTest;
using AutomationTest.POM.AdminPOM.LoginPOM;
using AutomationTest.POM.CustomersPOM.HomePOM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.TestScript.AdminScript.HomeScript
{
    public class CheckCategoryNameTest : BaseTest
    {
        [Test]
        public void CheckName()
        {
            var login = new DangNhapNguoiDung_POM(driver);
            login.LoginSuccess();

            var check = new Home_POM(driver);
            check.ClickCategorySuccess();
        }
    }
}
