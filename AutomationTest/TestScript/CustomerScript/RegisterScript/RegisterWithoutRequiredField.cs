using AutomationTest.FileBaseTest;
using AutomationTest.POM.AdminPOM.RegisterPOM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.TestScript.AdminScript.RegisterScript
{
    public class RegisterWithoutRequiredField : BaseTest
    {
        [Test, Category("Dang Ky")]
        public void Register()
        {
            var dangky = new Register_POM(driver);
            dangky.RegisterWithoutRequiredField();
        }
    }
}
