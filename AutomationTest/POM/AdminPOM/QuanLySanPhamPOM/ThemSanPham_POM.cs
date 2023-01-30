using AutomationTest.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTest.POM.AdminPOM.QuanLySanPhamPOM
{
    public class ThemSanPham_POM
    {
        IWebDriver driver;
        By quanLySanPham = By.XPath("//a[contains(.,'Quản lý sản phẩm')]");
        By themSanPham = By.XPath("//a[contains(.,'Thêm sản phẩm')]");
        By tenSanPham = By.XPath("//input[contains(@name,'productname')]");
        By noiDungMoTa = By.XPath("//div[contains(@class,'fr-element fr-view')]");
        By chonAnh = By.XPath("");
        By giaBan = By.XPath("//input[contains(@name,'price')]");
        By nhaCungCap = By.XPath("//select[@name='supplier']");
        By danhMuc = By.XPath("//select[@name='categories']");
        By trangThai = By.XPath("//select[contains(@name,'status')]");
        By nutSubmit = By.XPath("//button[contains(.,'Thêm sản phẩm')]");
        By successNoti = By.XPath("(//div[contains(.,'Thêm sản phẩm thành công')])[3]");
        By requiredField = By.XPath("(//div[contains(.,'Thiếu dữ liệu')])");
        By invalidField = By.XPath("(//div[contains(.,'Dữ liệu không hợp lệ')])");

        public ThemSanPham_POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ThemSanPhamThanhCong()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(quanLySanPham);
            getElement.GetElementAndClick(themSanPham);
            //form them san pham
            getElement.GetElementAndSendRandomString(tenSanPham, "San Pham ");
            getElement.GetElementAndSendRandomString(noiDungMoTa, "Noi dung cua san pham nay la ");
            getElement.GetElementAndSendKey(giaBan, "100000");
            //chon nha cung cap
            getElement.GetElementAndClick(nhaCungCap);
            SelectElement dropDownNhaCungCap = new SelectElement(driver.FindElement(By.XPath("//select[contains(@name,'supplier')]")));
            dropDownNhaCungCap.SelectByIndex(1);
            Thread.Sleep(2000);
            //chon danh muc
            getElement.GetElementAndClick(danhMuc);
            SelectElement dropDownDanhMuc = new SelectElement(driver.FindElement(By.XPath("//select[contains(@name,'categories')]")));
            dropDownDanhMuc.SelectByIndex(1);
            Thread.Sleep(2000);
            //chon trang thai
            getElement.GetElementAndClick(trangThai);
            SelectElement dropDownTrangThai = new SelectElement(driver.FindElement(By.XPath("//select[contains(@name,'status')]")));
            dropDownTrangThai.SelectByIndex(2);
            //click them san pham
            IWebElement chontep1 = driver.FindElement(By.XPath("//input[@type='file']"));
            chontep1.SendKeys(@"D:\Phong\DATN-Trang-CNPM\DATN-PetShop\uploads\084612_a3_XPMN.jpg");
            getElement.GetElementAndMoveTo(nutSubmit);
            getElement.GetElementAndClick(nutSubmit);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(successNoti);
        }

        public void ThemSanPhamVoiDuLieuKhongHopLe()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(quanLySanPham);
            getElement.GetElementAndClick(themSanPham);
            //form them san pham
            getElement.GetElementAndSendKey(tenSanPham, "San Pham ten qua dai San Pham ten qua dai San Pham ten qua dai San Pham ten qua dai San Pham ten qua dai San Pham ten qua dai ");
            getElement.GetElementAndSendRandomString(noiDungMoTa, "Noi dung cua san pham nay la ");
            getElement.GetElementAndSendKey(giaBan, "100000");
            //click them san pham
            getElement.GetElementAndClick(themSanPham);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(invalidField);
        }

        public void ThemSanPhamVoiDuLieuThieu()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(quanLySanPham);
            getElement.GetElementAndClick(themSanPham);
            //form them san pham - Khong them gi ca
            //click them san pham
            getElement.GetElementAndClick(themSanPham);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(requiredField);
        }
    }
}
