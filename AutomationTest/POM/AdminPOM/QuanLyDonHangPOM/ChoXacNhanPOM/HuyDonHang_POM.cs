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
    public class HuyDonHang_POM
    {
        IWebDriver driver;
        By choXacNhan = By.XPath("//a[contains(.,'Chờ xác nhận')]");
        By tinhTrangDonhang = By.XPath("//a[contains(.,'Tình trạng đơn hàng')]");
        By huy1 = By.XPath("(//i[contains(@class,'fas fa-times')])[1]");
        By successNoti = By.XPath("(//div[contains(.,'Đã hủy đơn hàng!')])[3]");
        public HuyDonHang_POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void HuyDonHangThanhCong()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(tinhTrangDonhang);
            Thread.Sleep(2000);
            getElement.GetElementAndClick(huy1);
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(successNoti);
            Thread.Sleep(2000);
       
        }
    }
}
