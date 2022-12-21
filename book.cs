using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookreader.Drivers
{
    public class book
    {
        public IWebDriver driver;
        public void bookreader()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://restful-booker.herokuapp.com/");
            driver.Manage().Window.Maximize();
        }

    }
}
