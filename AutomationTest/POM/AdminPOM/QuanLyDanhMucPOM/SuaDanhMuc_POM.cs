using AutomationTest.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.POM.AdminPOM.QuanLyDanhMucPOM
{
    public class SuaDanhMuc_POM
    {
        IWebDriver driver;
        By quanLyDanhMucButton = By.XPath("//a[@href='/admin/dashboard/categories-manager']");
        By themDanhMucButton = By.XPath("//a[@href='/admin/dashboard/categories-manager/add']");
        By nutSua = By.XPath("(//i[contains(@class,'fas fa-edit')])[1]");
        By tenDanhMuc = By.XPath("//input[@name='name']");
        By chonTep = By.XPath("//input[@type='file']");
        By themDanhMuc = By.XPath("//button[@type='submit']");
        By capNhatDanhMuc = By.XPath("//button[@type='submit']");
        By successNoti = By.XPath("(//div[contains(.,'Thêm danh mục thành công!')])[3]");
        By requiredNoti = By.XPath("(//div[contains(.,'Vui lòng điền vào trường này')])");
        By invalidNoti = By.XPath("(//div[contains(.,'Vui lòng điền dữ liệu hợp lệ')])");

        public SuaDanhMuc_POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SuaDanhMucThanhCong()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(quanLyDanhMucButton);
            getElement.GetElementAndClick(nutSua);
            getElement.GetElementAndCtrlAndBackspace(tenDanhMuc);
            getElement.GetElementAndSendKey(tenDanhMuc, "Thu cung ");
            IWebElement chontep1 = driver.FindElement(By.XPath("//input[@type='file']"));
            chontep1.SendKeys(@"D:\Phong\DATN-Trang-CNPM\DATN-PetShop\uploads\084612_a3_XPMN.jpg");
            //chon tep
            getElement.GetElementAndClick(capNhatDanhMuc);
        }

        public void SuaDanhMucKhiThieuDuLieu()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(quanLyDanhMucButton);
            getElement.GetElementAndClick(nutSua);
            getElement.GetElementAndCtrlAndBackspace(tenDanhMuc);
            getElement.GetElementAndClick(capNhatDanhMuc);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(requiredNoti);
        }

        public void SuaDanhMucKhiDuLieuKhongHopLe()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(quanLyDanhMucButton);
            getElement.GetElementAndClick(nutSua);
            getElement.GetElementAndCtrlAndBackspace(tenDanhMuc);
            getElement.GetElementAndSendKey(tenDanhMuc, " 324 fsgsf");
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(invalidNoti);
        }
    }
}
