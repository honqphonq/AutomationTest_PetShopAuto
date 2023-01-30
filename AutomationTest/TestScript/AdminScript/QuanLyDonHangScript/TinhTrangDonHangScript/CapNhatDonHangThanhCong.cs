using AutomationTest.FileBaseTest;
using AutomationTest.POM.AdminPOM.QuanLyDonHangPOM.TinhTrangDonHangPOM;
using AutomationTest.POM.CustomersPOM.LoginPOM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.TestScript.AdminScript.QuanLyDonHangScript
{
    public class CapNhatDonHangThanhCong : BaseTest2
    {
        [Test, Category("Cap Nhat Don hang")]
        public void CapNhatDonHang()
        {
            //dang nhap
            var login = new DangNhapAdmin_POM(driver);
            login.LoginSuccess();
            //cap nnhat
            var capnhat = new CapNhatDonHang_POM(driver);
            capnhat.CapNhatDonHangThanhCong();
        }
    }
}
