using AutomationTest.FileBaseTest;
using AutomationTest.POM.AdminPOM.QuanLyDonHangPOM.ChoXacNhanPOM;
using AutomationTest.POM.CustomersPOM.LoginPOM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.TestScript.AdminScript.QuanLyDonHangScript.TinhTrangDonHangScript
{
    public class HuyTinhTrangDonHangThanhCong : BaseTest2
    {
        [Test, Category("Huy Don Hang")]
        public void HuyTinhTrangDonHang()
        {
            var login = new DangNhapAdmin_POM(driver);
            login.LoginSuccess();

            var huy = new HuyDonHang_POM(driver);
            huy.HuyDonHangThanhCong();
        }
    }
}
