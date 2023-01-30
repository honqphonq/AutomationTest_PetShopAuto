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
    public class XacNhan1DonHangThanhCong : BaseTest2
    {
        [Test, Category("Xac Nhan Don Hang")]
        public void XacNhanDonHang1()
        {
            var login = new DangNhapAdmin_POM(driver);
            login.LoginSuccess();
            var xacnhan = new XacNhan1DonHang_POM(driver);
            xacnhan.XacNhanDonHang();
        }
    }
}
