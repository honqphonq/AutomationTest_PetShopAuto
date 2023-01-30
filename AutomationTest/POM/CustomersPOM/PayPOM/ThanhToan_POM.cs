using AutomationTest.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.POM.CustomersPOM.PayPOM
{
    public class ThanhToan_POM
    {
        IWebDriver driver;
        By giohang = By.XPath("//a[@class='cart-nav']");
        By thanhtoan = By.XPath("//a[@href='/checkout'][contains(.,'Thanh toán')]");
        By thanhtoan2 = By.XPath("//button[contains(.,'Thanh toán')]");
        By diachi = By.XPath("//input[contains(@id,'address')]");
        public ThanhToan_POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ThanhToanThieuField()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndMoveTo(giohang);
            getElement.GetElementAndClick(giohang);
            getElement.GetElementAndMoveTo(thanhtoan);
            getElement.GetElementAndClick(thanhtoan);
            getElement.GetElementAndClick(thanhtoan2);
            var check = new CheckElementDisplayed(driver);
            check.CheckElementDisplayWithText(diachi, "Please fill out this field.");
        }

    }

}
