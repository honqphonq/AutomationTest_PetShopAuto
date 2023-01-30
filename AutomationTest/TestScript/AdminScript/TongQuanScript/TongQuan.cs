using AutomationTest.FileBaseTest;
using AutomationTest.POM.AdminPOM.TongQuanPOM;
using AutomationTest.POM.CustomersPOM.LoginPOM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.TestScript.AdminScript.TongQuanScript
{
    public class TongQuan : BaseTest2
    {
        [Test, Category("Tong Quan")]
        public void HienThiTongQuan()
        {
            //login 
            var login = new DangNhapAdmin_POM(driver);
            login.LoginSuccess();
            //hien thi tong quan
            var hienthi = new TongQuan_POM(driver);
            hienthi.HienThiTongQuan();
        }
        
    }
}
