using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace MyWebsiteTest.PageObjects
{

    class HomePage
    {
        //private IWebDriver driver;
      

        [FindsBy(How = How.Id, Using = "TextBox1")][CacheLookup]
        public IWebElement TextBox1 { get; set; }


        [FindsBy(How = How.Name, Using = "Button1")]
        [CacheLookup]
        public IWebElement DisplayName { get; set; }

        [FindsBy(How = How.XPath, Using =(".//*[@id='Label2']"))]
        [CacheLookup]
        public IWebElement nameLabel { get; set; }


        [FindsBy(How = How.XPath, Using = (".//*[@id='LoginStatus1']"))]
        [CacheLookup]
        public IWebElement login { get; set; }

        [FindsBy(How = How.XPath, Using = (".//*[@id='HyperLink2']"))]
        [CacheLookup]
        public IWebElement registration { get; set; }

      
        //public HomePage(IWebDriver driver)
        //{
        //    this.driver = driver;
        //    PageFactory.InitElements(driver, this);
        //}

        public void displayName()
        {
            string Name = "";
            commonLib cl = new commonLib();
            for (int i = 0; i < 10; i++) Name = cl.generateRandomName(5);
            TextBox1.SendKeys(Name);
             DisplayName.Click();
            Assert.That(nameLabel.Text.Contains(Name));
        }

        public void clickLoginLink()
        {
            login.Click();
            
        }

        internal void clickRegistrationLink()
        {
            registration.Click();
        }
    }
}
