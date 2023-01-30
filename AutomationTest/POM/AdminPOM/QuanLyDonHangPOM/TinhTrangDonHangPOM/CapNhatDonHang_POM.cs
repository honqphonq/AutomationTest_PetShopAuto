using AutomationTest.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTest.POM.AdminPOM.QuanLyDonHangPOM.TinhTrangDonHangPOM
{
    public class CapNhatDonHang_POM
    {
        IWebDriver driver;
        By quanLyDonHang = By.XPath("//a[contains(.,'Quản lý đơn hàng')]");
        By tinhTrangDonHang = By.XPath("//a[contains(.,'Tình trạng đơn hàng')]");
        By click1 = By.XPath("(//i[contains(@class,'fas fa-edit')])[1]");
        //vao trang cap nhat
        By chonTinhThanh = By.XPath("//select[contains(@id,'city')]");
        By chonQuanHuyen = By.XPath("//select[contains(@id,'district')]");
        By chonPhuongXa = By.XPath("//select[contains(@id,'ward')]");
        By soNhaSoDuong = By.XPath("//input[contains(@name,'address')]");
        By nutXacNhan = By.XPath("//button[contains(@type,'submit')]");
        By successNoti = By.XPath("(//div[contains(.,'Cập nhật thông tin đơn hàng thành công!')])[3]");
        By requiredField = By.XPath("");
        By invalidField = By.XPath("");
        public CapNhatDonHang_POM(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void CapNhatDonHangThanhCong()
        {
            var getElement = new GetElementAndDoSomething(driver);
            //getElement.GetElementAndClick(quanLyDonHang);
            //Thread.Sleep(1000);
            getElement.GetElementAndClick(tinhTrangDonHang);
            Thread.Sleep(1000);
            getElement.GetElementAndClick(click1);
            Thread.Sleep(1000);
            //update
            getElement.GetElementAndClick(chonTinhThanh);
            SelectElement dropDown = new SelectElement(driver.FindElement(By.XPath("//select[contains(@id,'city')]")));
            dropDown.SelectByValue("01");
            Thread.Sleep(2000);

            getElement.GetElementAndClick(chonQuanHuyen);
            SelectElement dropDown2 = new SelectElement(driver.FindElement(By.XPath("//select[contains(@id,'district')]")));
            dropDown2.SelectByValue("001");
            Thread.Sleep(2000);

            getElement.GetElementAndClick(chonPhuongXa);
            SelectElement dropDown3 = new SelectElement(driver.FindElement(By.XPath("//select[contains(@id,'ward')]")));
            dropDown3.SelectByValue("00001");
            Thread.Sleep(2000);
            getElement.GetElementAndClick(nutXacNhan);
            Thread.Sleep(1000);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(successNoti);
        }

        public void CapNhapDonHangVoiDuLieuThieu()
        {
            var getElement = new GetElementAndDoSomething(driver);
            //getElement.GetElementAndClick(quanLyDonHang);
            //Thread.Sleep(1000);
            getElement.GetElementAndClick(tinhTrangDonHang);
            Thread.Sleep(1000);
            getElement.GetElementAndClick(click1);
            Thread.Sleep(1000);
            //update
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(requiredField);
        }

        public void CapNhatDonHangVoiDuLieuKhongHopLe()
        {
            var getElement = new GetElementAndDoSomething(driver);
            //getElement.GetElementAndClick(quanLyDonHang);
            //Thread.Sleep(1000);
            getElement.GetElementAndClick(tinhTrangDonHang);
            Thread.Sleep(1000);
            getElement.GetElementAndClick(click1);
            Thread.Sleep(1000);
            //update
            getElement.GetElementAndClick(chonTinhThanh);
            SelectElement dropDown = new SelectElement(driver.FindElement(By.XPath("//select[contains(@id,'city')]")));
            dropDown.SelectByValue("01");
            Thread.Sleep(2000);

            getElement.GetElementAndClick(chonQuanHuyen);
            SelectElement dropDown2 = new SelectElement(driver.FindElement(By.XPath("//select[contains(@id,'district')]")));
            dropDown2.SelectByValue("001");
            Thread.Sleep(2000);

            getElement.GetElementAndClick(chonPhuongXa);
            SelectElement dropDown3 = new SelectElement(driver.FindElement(By.XPath("//select[contains(@id,'ward')]")));
            dropDown3.SelectByValue("00001");
            Thread.Sleep(2000);
            getElement.GetElementAndCtrlAndBackspace(soNhaSoDuong);
            getElement.GetElementAndSendKey(soNhaSoDuong, "So nha nay qua dai So nha nay qua dai So nha nay qua dai So nha nay qua dai So nha nay qua dai So nha nay qua dai ");
            getElement.GetElementAndClick(nutXacNhan);
            Thread.Sleep(1000);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(invalidField);
        }
    }
}