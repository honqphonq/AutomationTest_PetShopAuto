using AutomationTest.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTest.POM.CustomersPOM.LoginPOM
{
    public class DangNhapAdmin_POM
    {
        IWebDriver driver;

        //B1: Lấy địa chỉ của những button,... mình cần
        By username = By.XPath("//input[@id='username']");
        By password = By.XPath("//input[@id='password']");
        By submitButton = By.XPath("//button[@type='submit'][contains(.,'Đăng nhập')]");
        By unsuccessNoti = By.XPath("(//div[contains(.,'Sai tên tài khoản hoặc mật khẩu!')])[3]");
        By successNoti = By.XPath("(//div[contains(.,'Đăng nhập thành công!')])[3]");
        By requiredNoti = By.XPath("//div[contains(,.'Please fill out this field.'");
        public DangNhapAdmin_POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        //B2: Đăng nhập thành công
        public void LoginSuccess()
        {
            var getElement = new GetElementAndDoSomething(driver);
            //hanh dong cho username
            getElement.GetElementAndClick(username);
            getElement.GetElementAndSendKey(username, "abc");
            //hanh dong cho password
            getElement.GetElementAndClick(password);
            getElement.GetElementAndSendKey(password, "123");
            //hanh dong cho button
            getElement.GetElementAndClick(submitButton);
            //kiem tra hanh dong noti
            //var check = new CheckElementDisplayed(driver);
            //check.CheckElementDisplay(successNoti);
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
            Thread.Sleep(1000);
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
