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
    public class XacNhan1DonHang_POM
    {
        IWebDriver driver;
        By quanLyDonHang = By.XPath("//a[contains(.,'Quản lý đơn hàng')]");
        By choXacNhan = By.XPath("//a[contains(.,'Chờ xác nhận')]");
        By click1 = By.XPath("(//i[contains(@class,'fas fa-check')])[1]");
        By successNoti = By.XPath("(//div[contains(.,'Đã xác nhận đơn hàng!')])[3]");
        public XacNhan1DonHang_POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void XacNhanDonHang()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(choXacNhan);
            Thread.Sleep(2000);
            getElement.GetElementAndClick(click1);
            Thread.Sleep(1000);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(successNoti);
            Thread.Sleep(2000);
        }
    }
}
