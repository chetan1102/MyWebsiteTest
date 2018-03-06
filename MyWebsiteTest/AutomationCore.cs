using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using MyWebsiteTest.PageObjects;
using System.Threading;

namespace MyWebsiteTest.TestCases
{
    [TestFixture]
    public class AutomationCore
    {
        private IWebDriver driver;
        HomePage homepage;
        LoginPage loginpage;
        Registration registrationpage;

        [SetUp]
        public void startTest()
        {
            driver = new ChromeDriver();
            //driver.Url = "http://172.22.76.49/";
            commonLib cl = new commonLib();
            var WebApp_ContainerIP = cl.GetEnvVarFromRegistry("WEB_APP_IP");
            if (WebApp_ContainerIP.ToString() == "")
            {
                Console.WriteLine("Alert : Web Application Container IP not available");
                Thread.CurrentThread.Abort();
            }
            else
            {
                driver.Url = "http://" + WebApp_ContainerIP.ToString() + "/";
                homepage = new HomePage();
                PageFactory.InitElements(driver, homepage);
                loginpage = new LoginPage();
                PageFactory.InitElements(driver, loginpage);
                registrationpage = new Registration(driver);
                PageFactory.InitElements(driver, registrationpage);
            }
        }

        [TearDown]
        public void endTest()
        {
            driver.Quit();
        }

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
