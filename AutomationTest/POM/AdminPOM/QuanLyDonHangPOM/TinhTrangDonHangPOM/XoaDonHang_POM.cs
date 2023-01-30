using AutomationTest.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.POM.AdminPOM.QuanLyDonHangPOM.TinhTrangDonHangPOM
{
    public class XoaDonHang_POM
    {
        IWebDriver driver;
        By tinhTrangDonHang = By.XPath("//a[contains(.,'Tình trạng đơn hàng')]");
        By xoa1 = By.XPath("(//i[contains(@class,'fas fa-times')])[1]");
        By thongbaoHuy = By.XPath("(//div[contains(.,'Đã hủy đơn hàng!')])");
        public XoaDonHang_POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void XoaDonHangThanhCong()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(tinhTrangDonHang);
            getElement.GetElementAndClick(xoa1);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(thongbaoHuy);
        }
    }
}
