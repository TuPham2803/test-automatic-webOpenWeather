using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Threading;

namespace UnitTestOpenWeather
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver tu_62_web;
        public TestContext TestContext { get; set; }


        [TestInitialize]
        public void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.PageLoadStrategy = PageLoadStrategy.Eager;
            options.AddArgument("--start-maximized");
            tu_62_web = new ChromeDriver(options);
            tu_62_web.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(180);
            tu_62_web.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [TestCleanup]
        public void Cleanup()
        {
            tu_62_web.Quit();
        }



        [TestMethod]
        public void TC001_LoginSuccess_Tu62()
        {
            string username = "tupham2832003@gmail.com";
            string password = "tuphamnguyen1";
            tu_62_web.Navigate().GoToUrl("https://home.openweathermap.org/users/sign_in");

            tu_62_web.FindElement(By.Id("user_email")).SendKeys(username);
            tu_62_web.FindElement(By.Name("user[password]")).SendKeys(password);
            tu_62_web.FindElement(By.Name("commit")).Click();

            string actualmessage_tu62 = tu_62_web.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div/div/div[2]")).Text;
            string expectmessage_tu62 = "Signed in successfully.";


            Assert.AreEqual(expectmessage_tu62, actualmessage_tu62);
        }
       
        [TestMethod]
        public void TC0021_LoginFailUser_Tu62()
        {
            string username = "tu2832003@gmail.com";
            string password = "tuphamnguyen1";
            tu_62_web.Navigate().GoToUrl("https://home.openweathermap.org/users/sign_in");


            tu_62_web.FindElement(By.Id("user_email")).SendKeys(username);
            tu_62_web.FindElement(By.Name("user[password]")).SendKeys(password);
            tu_62_web.FindElement(By.Name("commit")).Click();

            string actualmessage_tu62 = tu_62_web.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div/div/div[2]")).Text;
            string expectmessage_tu62 = "Invalid Email or password.";

            Assert.AreEqual(expectmessage_tu62, actualmessage_tu62);
        }

       
        [TestMethod]
        public void TC0022_LoginFailPass_Tu62()
        {
            string username = "tupham2832003@gmail.com";
            string password = "123";
            tu_62_web.Navigate().GoToUrl("https://home.openweathermap.org/users/sign_in");

            tu_62_web.FindElement(By.Id("user_email")).SendKeys(username);
            tu_62_web.FindElement(By.Name("user[password]")).SendKeys(password);
            tu_62_web.FindElement(By.Name("commit")).Click();

            string actualmessage_tu62 = tu_62_web.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div/div/div[2]")).Text;
            string expectmessage_tu62 = "Invalid Email or password.";

            Assert.AreEqual(expectmessage_tu62, actualmessage_tu62);
        }

        [TestMethod]
        public void TC0023_LoginMissPass_Tu62()
        {
            string username = "tupham2832003@gmail.com";
            string password = "";
            tu_62_web.Navigate().GoToUrl("https://home.openweathermap.org/users/sign_in");

            tu_62_web.FindElement(By.Id("user_email")).SendKeys(username);
            tu_62_web.FindElement(By.Name("user[password]")).SendKeys(password);
            tu_62_web.FindElement(By.Name("commit")).Click();

            string actualmessage_tu62 = tu_62_web.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div/div/div[2]")).Text;
            string expectmessage_tu62 = "Invalid Email or password.";

            Assert.AreEqual(expectmessage_tu62, actualmessage_tu62);
        }

        [TestMethod]
        public void TC0024_LoginMissUser_Tu62()
        {
            string username = "";
            string password = "123";
            tu_62_web.Navigate().GoToUrl("https://home.openweathermap.org/users/sign_in");

            tu_62_web.FindElement(By.Id("user_email")).SendKeys(username);
            tu_62_web.FindElement(By.Name("user[password]")).SendKeys(password);
            tu_62_web.FindElement(By.Name("commit")).Click();

            string actualmessage_tu62 = tu_62_web.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div/div/div[2]")).Text;
            string expectmessage_tu62 = "Invalid Email or password.";

            Assert.AreEqual(expectmessage_tu62, actualmessage_tu62);
        }

        
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\62_Tu_DataLogin\62_Tu_Login.csv",
          "62_Tu_Login#csv", DataAccessMethod.Sequential)]
        [TestMethod]

        public void Test_Data_Login_Tu62()
        {
           
            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();
            string expectmessage_tu62 = TestContext.DataRow[2].ToString();


            tu_62_web.Navigate().GoToUrl("https://home.openweathermap.org/users/sign_in");

            tu_62_web.FindElement(By.Id("user_email")).SendKeys(username);
            tu_62_web.FindElement(By.Name("user[password]")).SendKeys(password);

            tu_62_web.FindElement(By.Name("commit")).Click();

            string actualmessage_tu62 = tu_62_web.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div/div/div[2]")).Text;


            Assert.AreEqual(expectmessage_tu62, actualmessage_tu62);
        }
    }
}
//tupham2832003@gmail.com,"",Invalid Email or password.
//"",123,Invalid Email or password.