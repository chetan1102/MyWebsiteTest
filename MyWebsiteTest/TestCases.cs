using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using MyWebsiteTest.PageObjects;
using System.Threading;

namespace MyWebsiteTest.TestCases
{
    [TestFixture]
    [Parallelizable]
    class TestCases : AutomationCore
    {
       
        [Test]
        [TestCaseSource(typeof(AutomationCore),"BrowserToRun")]
        public void Launch(String browserName)
        {
            startTest(browserName);
            Assert.AreEqual("Home", driver.Title);
        }

        [Test]
        [TestCaseSource(typeof(AutomationCore), "BrowserToRun")]
        public void checkName(String browserName)
        {
            startTest(browserName);
            homepage.displayName();
        }

        [Test]
        [TestCaseSource(typeof(AutomationCore), "BrowserToRun")]
        public void LoginLink(String browserName)
        {
            startTest(browserName);
            homepage.clickLoginLink();
            Assert.AreEqual("Login", driver.Title);

        }

        [Test]
        [TestCaseSource(typeof(AutomationCore), "BrowserToRun")]
        public void LoginFunction(String browserName)
        {
            startTest(browserName);
            homepage.clickLoginLink();
            loginpage.Login();
        }

        [Test]
        [TestCaseSource(typeof(AutomationCore), "BrowserToRun")]
        public void Registration(String browserName)
        {
            startTest(browserName);
            homepage.clickRegistrationLink();
            registrationpage.Register();


        }
    }
}
