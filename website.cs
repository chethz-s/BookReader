using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookreader.Pages
{
    public class website
    {
        public website(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath,Using = "/html/body/div[1]/div/div[2]/div/p/a[2]")]
        public IWebElement web { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/section/div/div/div[2]/div[2]/button")]
        public IWebElement read { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div/div[2]/p/a")]
        public IWebElement purchase { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/p/a[3]")]
        public IWebElement code { get; set; }

        [FindsBy(How = How.XPath,Using = "/html/body/div[2]/div[3]/div[3]/a/img")]
        public IWebElement ait { get; set; }

        [FindsBy(How = How.XPath,Using = "//*[@id=\"collapsingNavbar3\"]/ul/li[4]/a")]
        public IWebElement training { get; set; }

        [FindsBy(How = How.XPath,Using = "//*[@id=\"collapsingNavbar3\"]/ul/li[4]/a")]
        public IWebElement online { get; set; }

        [FindsBy(How = How.XPath,Using = "//*[@id=\"collapsingNavbar3\"]/ul/li[1]/a")]
        public IWebElement blog { get; set; }
    }
}
