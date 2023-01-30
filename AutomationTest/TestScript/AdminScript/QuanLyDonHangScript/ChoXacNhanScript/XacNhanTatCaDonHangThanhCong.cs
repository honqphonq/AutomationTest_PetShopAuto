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
    public class XacNhanTatCaDonHangThanhCong : BaseTest2
    {
        [Test,Category("Xac nhan don hang")]
        public void XacNhanDonHang()
        {
            var login = new DangNhapAdmin_POM(driver);
            login.LoginSuccess();
            var xacnhan = new XacNhanTatCaDonHang(driver);
            xacnhan.XacNhanTatCaThanhCong();
        }
    }
}
