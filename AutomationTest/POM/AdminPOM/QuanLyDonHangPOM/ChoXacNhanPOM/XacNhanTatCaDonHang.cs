using AutomationTest.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTest.POM.AdminPOM.QuanLyDonHangPOM.ChoXacNhanPOM
{
    public class XacNhanTatCaDonHang
    {
        IWebDriver driver;
        By choXacNhan = By.XPath("//a[contains(.,'Chờ xác nhận')]");
        By xacNhanTatCa = By.XPath("//a[contains(.,'Xác nhận tất cả')]");
        By successNoti = By.XPath("(//div[contains(.,'Đã xác nhận đơn hàng!')])[3]");
        public XacNhanTatCaDonHang(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void XacNhanTatCaThanhCong()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(choXacNhan);
            Thread.Sleep(2000);
            getElement.GetElementAndClick(xacNhanTatCa);
            Thread.Sleep(2000);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(successNoti);
            Thread.Sleep(2000);
        }
    }
}
