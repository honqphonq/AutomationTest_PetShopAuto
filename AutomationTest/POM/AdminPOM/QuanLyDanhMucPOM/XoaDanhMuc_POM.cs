using AutomationTest.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTest.POM.AdminPOM.QuanLyDanhMucPOM
{
    public class XoaDanhMuc_POM 
    {
        IWebDriver driver;
        By quanLyDanhMucButton = By.XPath("//a[@class='nav-link'][contains(.,'Quản lý danh mục')]");
        By trangThu2 = By.XPath("//a[@href='/admin/dashboard/categories-manager/2 ']");
        By thungRac = By.XPath("(//i[contains(@class,'fas fa-trash')])[1]");
        By successNoti = By.XPath("(//div[contains(.,'Xóa danh mục thành công!')])[3]");

        public XoaDanhMuc_POM(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        public void XoaDanhMucThanhCong()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(quanLyDanhMucButton);
            Thread.Sleep(2000);
            getElement.GetElementAndClick(trangThu2);
            Thread.Sleep(2000);
            getElement.GetElementAndClick(thungRac);
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(successNoti);
        }
    }
}
