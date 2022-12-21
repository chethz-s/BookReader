using bookreader.Drivers;
using bookreader.Pages;
using Microsoft.VisualBasic;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;

namespace bookreader.StepDefinitions
{
    [Binding]
    public class BookreaderStepDefinitions : book
    {
        [Given(@"I am on the homepage")]
        public void GivenIamonthehomepage()
        {
            bookreader();
            //throw new PendingStepException();
        }

        [When(@"I click the website link")]
        public void WhenIClickTheWebsiteLink()
        {
            website web1 = new website(driver);
            web1.web.Click();
            //throw new PendingStepException();
        }

        [When(@"Once I am there I click the read more button")]
        public void WhenOnceIAmThereIClickTheReadMoreButton()
        {
            website read1 = new website(driver);
            read1.read.Click();
            //throw new PendingStepException();
        }

        [When(@"browse down the page and then click the purchase Testing Web APIs Now button")]
        public void WhenBrowseDownThePageAndThenClickThePurchaseTestingWebAPIsNowButton()
        {
            website purchase1 = new website(driver);
            purchase1.purchase.Click();
            //throw new PendingStepException();
        }

        [Then(@"it is navigating to testing web APIs")]
        public void ThenItIsNavigatingToTestingWebAPIs()
        {
            driver.Navigate().Back();
            driver.Navigate().Back();
            driver.Quit();
            //throw new PendingStepException();
        }
        [Given(@"Iam on the homepage")]
        public void GivenIamOnTheHomepage()
        {
            bookreader();
            //throw new PendingStepException();
        }
        [Given(@"I click the code link")]
        public void GivenIClickTheCodeLink()
        {
            website code1 = new website(driver);
            code1.code.Click();
            //throw new PendingStepException();
        }

        [Then(@"it is navigating to github website")]
        public void ThenItIsNavigatingToGithubWebsite()
        {
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Actions action = new Actions(driver);
            action.SendKeys(OpenQA.Selenium.Keys.End).Build().Perform();
            driver.Quit();
            //throw new PendingStepException();
        }
        [Given(@"I am on homepage")]
        public void GivenIAmOnHomepage()
        {
            bookreader();
            //throw new PendingStepException();
        }

        [When(@"I click the AIT training link")]
        public void WhenIClickTheAITTrainingLink()
        {
            website ait1 = new website(driver);
            ait1.ait.Click();
            //throw new PendingStepException();
        }

        [When(@"it shows some information about public training and clicks the training button")]
        public void WhenItShowsSomeInformationAboutPublicTrainingAndClicksTheTrainingbutton()
        {
            website training1 = new website(driver);
            training1.training.Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            //throw new PendingStepException();
        }

        [When(@"after moving to the previous page it clicks on online courses button")]
        public void WhenAfterMovingToThePreviousPageItClicksOnOnlineCoursesButton()
        {
            website online1 = new website(driver);
            online1.online.Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            //throw new PendingStepException();
        }

        [When(@"after moving to the previous page it clicks on blog button")]
        public void WhenAfterMovingToThePreviousPageItClicksOnBlogButton()
        {
            website blog1 = new website(driver);
            blog1.blog.Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            //throw new PendingStepException();
        }

        [Then(@"it navigates to the home page")]
        public void TheItNavigatesToTheHomePage()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            driver.Quit();
            //throw new PendingStepException();
        }

    }
}
