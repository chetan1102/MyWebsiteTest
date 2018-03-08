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
        public void Launch()
        {
            Assert.AreEqual("Home", driver.Title);
        }

        [Test]
        public void checkName()
        {
           homepage.displayName();
        }

        [Test]
        public void LoginLink()
        {
            homepage.clickLoginLink();
            Assert.AreEqual("Login", driver.Title);

        }

        [Test]
        public void LoginFunction()
        {
            homepage.clickLoginLink();
            loginpage.Login();
        }

        [Test]
        public void Registration()
        {
            homepage.clickRegistrationLink();
            registrationpage.Register();


        }
    }
}
