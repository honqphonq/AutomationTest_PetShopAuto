using AutomationTest.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTest.POM.CustomersPOM.HomePOM
{
    public class Home_POM
    {
        IWebDriver driver;

        By anhtho = By.XPath("//h4[contains(.,'THỎ')]");
        By categoryName = By.XPath("//h3[contains(.,'THỎ')]");
        By tholunhalan = By.XPath("//h6[contains(.,'THỎ LÙN HÀ LAN')]");
        By tentholunhalan = By.XPath("//h6[contains(.,'THỎ LÙN HÀ LAN')]");
        By checktuoi = By.XPath("//span[contains(.,'Tuổi: 3 tháng')]");


        public Home_POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickCategorySuccess()
        {
            var getElement = new GetElementAndDoSomething(driver);
            getElement.GetElementAndClick(anhtho);
            var check = new CheckElementDisplayed(driver);
            Thread.Sleep(2000);
            check.CheckElementDisplay(categoryName);
            getElement.GetElementAndClick(tholunhalan);
            Thread.Sleep(2000);
            check.CheckElementDisplay(tentholunhalan);
        }
    }
}
