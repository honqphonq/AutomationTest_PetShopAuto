using AutomationTest.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTest.POM.AdminPOM.RegisterPOM
{
    public class Register_POM 
    {
        IWebDriver driver;
        //Khai bao
        By nutDangKy = By.XPath("//a[@href='/sign-up'][contains(.,'Tạo tài khoản')]");
        By Ho = By.XPath("//input[contains(@name,'firstname')]");
        By Ten = By.XPath("//input[contains(@name,'lastname')]");
        By Sdt = By.XPath("//input[contains(@name,'phone')]");
        By CMND = By.XPath("//input[contains(@name,'cmnd')]");
        By taikhoan = By.XPath("//input[contains(@name,'username')]");
        By email = By.XPath("//input[contains(@type,'email')]");
        By matkhau = By.XPath("//input[contains(@id,'pass1')]");
        By xacnhanmatkhau = By.XPath("//input[contains(@id,'pass2')]");
        By taotaikhoan = By.XPath("//button[@class='btn btn-block btn-primary'][contains(.,'Tạo tài khoản')]");
        By thongbaothanhcong = By.XPath("(//div[contains(.,'Tạo tài khoản thành công!')])[3]");
        By thongbaothieu = By.XPath("(//span[contains(.,'Please fill out this field.')])");

        public Register_POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void RegisterSuccess()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(nutDangKy);
            getElement.GetElementAndSendRandomString(Ho, "Nguyen");
            getElement.GetElementAndSendRandomString(Ten, "");
            getElement.GetElementAndSendRandomNumber(Sdt, "");
            getElement.GetElementAndSendRandomNumber(CMND, "");
            getElement.GetElementAndSendRandomString(taikhoan, "trang");
            getElement.GetElementAndSendRandomEmail(email);
            getElement.GetElementAndSendKey(matkhau, "123456");
            getElement.GetElementAndSendKey(xacnhanmatkhau, "123456");
            getElement.GetElementAndClick(taotaikhoan);
            Thread.Sleep(1000);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(thongbaothanhcong);
        }
        public void RegisterWithoutRequiredField()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(nutDangKy);
            getElement.GetElementAndClick(taotaikhoan);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(thongbaothieu);
        }
    }
}
