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
    class LoginPage
    {
        //private IWebDriver driver;


        [FindsBy(How = How.Id, Using = "Login1_UserName")]
        [CacheLookup]
        public IWebElement userName { get; set; }

        [FindsBy(How = How.Id, Using = "Login1_Password")]
        [CacheLookup]
        public IWebElement passWord { get; set; }


        [FindsBy(How = How.Name, Using = "Login1$LoginButton")]
        [CacheLookup]
        public IWebElement loginButton { get; set; }

        [FindsBy(How = How.XPath, Using = (".//*[@id='HyperLink1']"))]
        [CacheLookup]
        public IWebElement home { get; set; }


        [FindsBy(How = How.XPath, Using = (".//*[@id='Login1_RememberMe']"))]
        [CacheLookup]
        public IWebElement rememberMe { get; set; }

              

        public void Login()
        {
            userName.SendKeys("Username");
            passWord.SendKeys("passWord");
            rememberMe.Click();
            loginButton.Click();
        }
    }
}
