using AutomationTest.FileBaseTest;
using AutomationTest.POM.AdminPOM.LoginPOM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.TestScript.AdminScript.LoginScript
{
    public class LoginWithoutRequiredField : BaseTest
    {
        [Test, Category("Login Test Case")]
        public void Login()
        {
            var login = new DangNhapNguoiDung_POM(driver);
            login.LoginWithoutRequiredField();
        }
    }
}
