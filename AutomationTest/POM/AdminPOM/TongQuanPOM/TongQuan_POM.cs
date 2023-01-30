using AutomationTest.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.POM.AdminPOM.TongQuanPOM
{
    public class TongQuan_POM
    {
        IWebDriver driver;
        By tongquan = By.XPath("");
        By tongDoanhThu = By.XPath("");
        By soSanPham = By.XPath("");
        By soDonDatHang = By.XPath("");
        By soDonBiHuy = By.XPath("");

        public TongQuan_POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void HienThiTongQuan()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndShowInfor(tongDoanhThu);
            getElement.GetElementAndShowInfor(soSanPham);
            getElement.GetElementAndShowInfor(soDonDatHang);
            getElement.GetElementAndShowInfor(soDonBiHuy);

        }
    }
}
