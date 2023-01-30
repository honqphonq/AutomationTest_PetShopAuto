using AutomationTest.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.POM.AdminPOM.QuanLySanPhamPOM
{
    public class SuaSanPham_POM
    {
        IWebDriver driver;
        By quanLySanPham = By.XPath("//a[contains(.,'Quản lý sản phẩm')]");
        By edit1 = By.XPath("(//i[contains(@class,'fas fa-edit')])[1]");
        By themSanPham = By.XPath("//a[contains(.,'Thêm sản phẩm')]");
        By tenSanPham = By.XPath("//input[contains(@name,'productname')]");
        By noiDungMoTa = By.XPath("//div[contains(@class,'fr-element fr-view')]");
        By chonAnh = By.XPath("");
        By giaBan = By.XPath("//input[contains(@name,'price')]");
        By nhaCungCap = By.XPath("//select[@name='supplier']");
        By danhMuc = By.XPath("//select[@name='categories']");
        By trangThai = By.XPath("//select[contains(@name,'status')]");
        By successNoti = By.XPath("(//div[contains(.,'Cập nhật thông tin thành công')])[3]");
        By requiredField = By.XPath("(//div[contains(.,'Thiếu dữ liệu')])");
        By invalidField = By.XPath("(//div[contains(.,'Dữ liệu không hợp lệ')])");
        By capNhatThongTin = By.XPath("//button[@type='submit']");

        public SuaSanPham_POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SuaSanPhamThanhCong()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(quanLySanPham);
            getElement.GetElementAndClick(edit1);
            getElement.GetElementAndCtrlAndBackspace(tenSanPham);
            getElement.GetElementAndSendRandomString(tenSanPham, "San Pham ");
            getElement.GetElementAndCtrlAndBackspace(noiDungMoTa);
            getElement.GetElementAndSendRandomString(noiDungMoTa, "Noi dung mo ta cua san pham nay la ");
            IWebElement chontep1 = driver.FindElement(By.XPath("//input[@type='file']"));
            chontep1.SendKeys(@"D:\Phong\DATN-Trang-CNPM\DATN-PetShop\uploads\084612_a3_XPMN.jpg");
            getElement.GetElementAndClick(capNhatThongTin);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(successNoti);
        }

        public void SuaSanPhamVoiDuLieuThieu()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(quanLySanPham);
            getElement.GetElementAndClick(edit1);
            getElement.GetElementAndCtrlAndBackspace(tenSanPham);
            getElement.GetElementAndCtrlAndBackspace(noiDungMoTa);
            getElement.GetElementAndSendRandomString(noiDungMoTa, "Noi dung mo ta cua san pham nay la ");
            getElement.GetElementAndClick(capNhatThongTin);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(requiredField);
        }

        public void SuaSanPhamVoiDuLieuKhongHopLe()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(quanLySanPham);
            getElement.GetElementAndClick(edit1);
            getElement.GetElementAndCtrlAndBackspace(tenSanPham);
            getElement.GetElementAndSendRandomString(tenSanPham, "Ten san pham nay rat dai Ten san pham nay rat dai Ten san pham nay rat dai Ten san pham nay rat dai Ten san pham nay rat dai Ten san pham nay rat dai Ten san pham nay rat dai ");
            getElement.GetElementAndCtrlAndBackspace(noiDungMoTa);
            getElement.GetElementAndSendRandomString(noiDungMoTa, "Noi dung mo ta cua san pham nay la ");
            getElement.GetElementAndClick(capNhatThongTin);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(invalidField);
        }
    }
}
