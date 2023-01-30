using AutomationTest.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTest.POM.AdminPOM.LoginPOM
{
    public class DangNhapNguoiDung_POM
    {
        IWebDriver driver;

        //B1: Lấy địa chỉ của những button,... mình cần
        By username = By.XPath("//input[@id='username']");
        By password = By.XPath("//input[@id='password']");
        By submitButton = By.XPath("//button[@type='submit'][contains(.,'Đăng nhập')]");
        By unsuccessNoti = By.XPath("(//div[contains(.,'Sai tên tài khoản hoặc mật khẩu!')])[3]");
        By successNoti = By.XPath("//div[@class='toast-message'][contains(.,'Đăng nhập thành công!')]");
        By requiredNoti = By.XPath("//div[contains(,.'Please fill out this field.'");
        public DangNhapNguoiDung_POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        //B2: Đăng nhập thành công
        public void LoginSuccess()
        {
            var getElement = new GetElementAndDoSomething(driver);
            //hanh dong cho username
            getElement.GetElementAndClick(username);
            getElement.GetElementAndSendKey(username, "trang");
            //hanh dong cho password
            getElement.GetElementAndClick(password);
            getElement.GetElementAndSendKey(password, "123456");
            //hanh dong cho button
            getElement.GetElementAndClick(submitButton);
            //kiem tra hanh dong noti
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(successNoti);
        }

        public void LoginFailed()
        {
            var getElement = new GetElementAndDoSomething(driver);
            //hanh dong cho username
            getElement.GetElementAndClick(username);
            getElement.GetElementAndSendKey(username, "trangwwwwww");
            //hanh dong cho password
            getElement.GetElementAndClick(password);
            getElement.GetElementAndSendKey(password, "123456");
            //hanh dong cho button
            getElement.GetElementAndClick(submitButton);
            //kiem tra hanh dong noti
            Thread.Sleep(1500);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(unsuccessNoti);
        }
        public void LoginWithoutRequiredField()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndSendKey(password, "adfadsf");
            getElement.GetElementAndClick(submitButton);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplay(requiredNoti);

        }
    }
}
