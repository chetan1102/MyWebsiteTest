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
    class Registration
    {
        private IWebDriver driver;
       
        [FindsBy(How = How.Id, Using = "TextBox1")]
        [CacheLookup]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.Id, Using = "TextBox5")]
        [CacheLookup]
        public IWebElement DoB { get; set; }

        [FindsBy(How = How.Id, Using = "TextBox3")]
        [CacheLookup]
        public IWebElement Address { get; set; }

        [FindsBy(How = How.Id, Using = "TextBox4")]
        [CacheLookup]
        public IWebElement Contact { get; set; }

        [FindsBy(How = How.Name, Using = "Button1")]
        [CacheLookup]
        public IWebElement Submit { get; set; }

        [FindsBy(How = How.Name, Using = "Button2")]
        [CacheLookup]
        public IWebElement Reset { get; set; }

        public Registration(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        public void Register()
        {
            Name.SendKeys("Test User");
            DoB.SendKeys("11/11/11");
            Address.SendKeys("125 King Street, Auckland");
            Contact.SendKeys("+64100200300");
            Submit.Click();
            commonLib cl = new commonLib();
            cl.popup(this.driver);


        }


    }
}
