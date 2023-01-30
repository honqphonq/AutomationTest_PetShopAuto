using AutomationTest.FileBaseTest;
using AutomationTest.POM.AdminPOM.QuanLyDonHangPOM.ChoXacNhanPOM;
using AutomationTest.POM.CustomersPOM.LoginPOM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.TestScript.AdminScript.QuanLyDonHangScript
{
    public class HuyDonHangThanhCong : BaseTest2
    {
        [Test, Category("Huy don hang")]
        public void HuyDonHang()
        {
            var login = new DangNhapAdmin_POM(driver);
            login.LoginSuccess();
            var huy = new HuyDonHang_POM(driver);
            huy.HuyDonHangThanhCong();
        }

    }
}
