using AutomationTest.FileBaseTest;
using AutomationTest.POM.AdminPOM.QuanLyDanhMucPOM;
using AutomationTest.POM.CustomersPOM.LoginPOM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.TestScript.AdminScript.QuanLyDanhMucScript
{
    public class SuaDanhMucVoiDuLieuKhongHopLe : BaseTest2
    {
        [Test, Category("Sua Danh Muc")]
        public void SuaDanhMuc()
        {
            var login = new DangNhapAdmin_POM(driver);
            login.LoginSuccess();

            var sua = new SuaDanhMuc_POM(driver);
            sua.SuaDanhMucKhiDuLieuKhongHopLe();
        }
    }
}
