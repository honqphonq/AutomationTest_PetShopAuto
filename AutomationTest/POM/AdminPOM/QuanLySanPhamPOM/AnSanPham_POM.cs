using AutomationTest.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTest.POM.AdminPOM.QuanLySanPhamPOM
{
    public class AnSanPham_POM
    {
        IWebDriver driver;
        By quanLySanPham = By.XPath("//a[contains(.,'Quản lý sản phẩm')]");
        By nutAn1 = By.XPath("(//i[contains(@class,'fas fa-eye-slash')])[1]");
        By successNoti = By.XPath("(//div[contains(.,'Ẩn/Hiện thông tin thành công')])[3]");

        public AnSanPham_POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AnSanPhamThanhCong()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(quanLySanPham);
            getElement.GetElementAndClick(nutAn1);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(successNoti);
        }
    }
}
