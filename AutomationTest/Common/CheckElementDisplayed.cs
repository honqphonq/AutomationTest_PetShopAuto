using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.Common
{
    public class CheckElementDisplayed
    {
        IWebDriver driver;
        public CheckElementDisplayed(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void CheckElementDisplay(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement element = wait.Until(driver => driver.FindElement(by));
            if (element.Displayed)
            {
                Console.WriteLine(element.Text);
            }
            else
            {
                Console.WriteLine("Test failed, check and run again");
                Assert.Fail();
            }
        }

        public void CheckElementDisplayWithText(By by, string text)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement element = wait.Until(driver => driver.FindElement(by));
            string bodyText = driver.FindElement(by).GetAttribute("uname");
            Console.WriteLine(bodyText + " leu");
            if(bodyText == text)
            {
                Console.WriteLine(bodyText);
            }
            else
            {
                Console.WriteLine("Test failed, check and run again");
                Assert.Fail();
            }
        }

        public void CheckFocusError(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement element = wait.Until(driver => driver.FindElement(by));
            if (element.Equals(driver.SwitchTo().ActiveElement()))
            {
                Console.WriteLine(by + " is focused");
            }
            else
            {
                Console.WriteLine("Test failed, check and run again");
                Assert.Fail();
            }
        }
    }
}