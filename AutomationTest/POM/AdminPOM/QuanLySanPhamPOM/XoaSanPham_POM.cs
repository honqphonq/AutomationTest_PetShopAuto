using AutomationTest.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.POM.AdminPOM.QuanLySanPhamPOM
{
    public class XoaSanPham_POM
    {
        IWebDriver driver;
        By quanLySanPham = By.XPath("//a[contains(.,'Quản lý sản phẩm')]");
        By nutXoa1 = By.XPath("(//i[contains(@class,'fas fa-trash')])[1]");
        By successNoti = By.XPath("(//div[contains(.,'Xóa thông tin thành công')])[3]");

        public XoaSanPham_POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void XoaSanPhamThanhCong()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(quanLySanPham);
            getElement.GetElementAndClick(nutXoa1);
            driver.SwitchTo().Alert().Accept();
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(successNoti);
        }
    }
}
