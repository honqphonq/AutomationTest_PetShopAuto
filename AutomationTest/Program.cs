using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Khởi tạo một driver chrome
            //IWebDriver driver = new ChromeDriver();

            ////Điều hướng trang web tới trang google
            //driver.Navigate().GoToUrl("https://www.google.com.vn");
            //driver.Navigate().GoToUrl("localhost:808");
            //driver.Manage().Window.Maximize();

            ////Tìm kiếm phần tử có name = q
            //IWebElement ele = driver.FindElement(By.XPath("//input[@name='q']"));
            ////Click phần tử ele
            //ele.SendKeys("Unitop");

            ////Tìm phần tử có phần tử có name = btnK
            //IWebElement ele1 = driver.FindElement(By.Name("btnK"));
            ////Click ele1
            //ele1.Click();

            //IWebElement ele2 = driver.FindElement(By.XPath("//h3[@class='LC20lb MBeuO DKV0Md'][contains(.,'Unitop: Khóa học Lập Trình Web FullStack Online - Lộ Trình ...')]"));
            //ele2.Click();

            ////Đóng trình duyệt.
            //driver.Close();

        }
    }
}
