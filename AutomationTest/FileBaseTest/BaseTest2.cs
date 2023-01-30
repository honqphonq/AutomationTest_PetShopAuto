using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.FileBaseTest
{
    public class BaseTest2
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("C:\\Users\\Admin\\Downloads\\chromedriver_win32");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:3000/admin/login");
        }

        [TearDown]
        public void Close()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
