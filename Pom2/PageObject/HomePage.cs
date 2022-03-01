using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Pom2.PageObjects
{
    public class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }


        [FindsBy(How=How.Id,Using="firstName")]
            public IWebElement EnterFirstName { get; set; }
       
        [FindsBy(How=How.Id, Using ="lastName")]
        public IWebElement EnterLastName { get; set;}

        [FindsBy(How = How.Id,Using ="username")]
        public IWebElement EnterUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Passwd")]
        public IWebElement EnterPswd { get; set; }

        [FindsBy(How = How.Name, Using = "ConfirmPasswd")]
        public IWebElement EnterCnfrPswd { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='VfPpkd-muHVFf-bMcfAe']")]
        public IWebElement ClickShowBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[@class='VfPpkd-vQzf8d'])[2]")]
        public IWebElement ClickNxtBtn { get; set; }

        public Contact NavigateToSecondPage()
        {
            EnterFirstName.SendKeys("Sahil");
            EnterLastName.SendKeys("Arora");
            EnterUserName.SendKeys("Sahil07feb2thousand");
            EnterPswd.SendKeys("Sahil07feb2000");
            EnterCnfrPswd.SendKeys("Sahil07feb2000");
            ClickShowBtn.Click();
            Thread.Sleep(3000);
            ClickNxtBtn.Click();
            return new Contact(driver);

        }

    }
}
