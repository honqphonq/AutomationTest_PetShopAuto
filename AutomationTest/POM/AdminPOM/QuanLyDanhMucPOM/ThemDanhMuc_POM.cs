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
    public class ThemDanhMuc_POM
    {
        IWebDriver driver;
        By quanLyDanhMucButton = By.XPath("//a[@href='/admin/dashboard/categories-manager']");
        By themDanhMucButton = By.XPath("//a[@href='/admin/dashboard/categories-manager/add']");
        By tenDanhMuc = By.XPath("//input[@name='name']");
        By chonTep = By.XPath("//input[@type='file']");
        By themDanhMuc = By.XPath("//button[@type='submit']");
        By successNoti = By.XPath("(//div[contains(.,'Thêm danh mục thành công!')])[3]");
        By requiredNoti = By.XPath("(//div[contains(.,'Vui lòng điền vào trường này')])");
        By invalidNoti = By.XPath("(//div[contains(.,'Vui lòng điền dữ liệu hợp lệ')])");
        public ThemDanhMuc_POM(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        public void ThemMoiDanhMucThanhCong()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(quanLyDanhMucButton);
            getElement.GetElementAndClick(themDanhMucButton);
            getElement.GetElementAndSendRandomString(tenDanhMuc, "Danh Muc");
            //getElement.GetElementAndClick(chonTep);
            IWebElement chontep1 = driver.FindElement(By.XPath("//input[@type='file']"));
            chontep1.SendKeys(@"D:\Phong\DATN-Trang-CNPM\DATN-PetShop\uploads\084612_a3_XPMN.jpg");
            //buoc chon tep chua lam
            getElement.GetElementAndClick(themDanhMuc);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(successNoti);
        }
        public void ThemTenDanhMucVoiThieuDuLieu()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(quanLyDanhMucButton);
            getElement.GetElementAndClick(themDanhMucButton);
            //getElement.GetElementAndClick(chonTep);
            getElement.GetElementAndSendKey(chonTep, "C:\\Users\\Admin\\Desktop\\ĐỒ ÁN TỐT NGHIỆP\\PETSHOP\\uploads\\2.png");
            getElement.GetElementAndClick(themDanhMuc);
            Thread.Sleep(1000);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(requiredNoti);
        }

        public void ThemTenDanhMucVoiDuLieuKhongHopLy()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(quanLyDanhMucButton);
            getElement.GetElementAndClick(themDanhMucButton);
            getElement.GetElementAndSendKey(tenDanhMuc, "12343234324234234sdfssd");
            getElement.GetElementAndClick(chonTep);
            //buoc chon tep chua lam
            getElement.GetElementAndClick(themDanhMuc);
            Thread.Sleep(1000);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(invalidNoti);
        }


    }
}
