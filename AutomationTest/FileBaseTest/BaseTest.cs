using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace AutomationTest.FileBaseTest
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("C:\\Users\\Admin\\Downloads\\chromedriver_win32");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:3000/login");
        }

        [TearDown]
        public void Close()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
