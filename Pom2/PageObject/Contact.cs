using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pom2.PageObjects
{
    public class Contact
    {
        IWebDriver driver;

        public Contact(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//input[@type='tel']")]
        public IWebElement EnterContactNum { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[@class='VfPpkd-vQzf8d'])[1]")]
        public IWebElement ClickNxtBtn2 { get; set; }
        public void NavigateToThirdPage()
        {
            Thread.Sleep(3000);
            EnterContactNum.SendKeys("9650733199");
            Thread.Sleep(3000);
            ClickNxtBtn2.Click();

        }
    }
}
