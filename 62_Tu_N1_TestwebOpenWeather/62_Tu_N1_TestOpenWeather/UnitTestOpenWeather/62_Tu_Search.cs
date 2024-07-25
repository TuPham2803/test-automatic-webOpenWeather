using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Threading;

namespace UnitTestOpenWeather
{
    [TestClass]
    public class UnitTest2
    {
        private IWebDriver tu_62_web;
        public TestContext TestContext { get; set; }


        [TestInitialize]
        public void Initialize()
        {
            ChromeOptions options = new ChromeOptions();

            options.PageLoadStrategy = PageLoadStrategy.Eager;

            tu_62_web = new ChromeDriver(options);
        }

        [TestCleanup]
        public void Cleanup()
        {
            tu_62_web.Quit();
        }

        //Nhập từ khóa không tìm thấy
        [TestMethod]
        public void TC001_NotFoundKey_Tu62()
        {

            tu_62_web.Navigate().GoToUrl("https://openweathermap.org/find");
            tu_62_web.FindElement(By.CssSelector("#search_str")).SendKeys("Do an");


            Actions action = new Actions(tu_62_web);
            action.SendKeys(Keys.Enter).Perform();

            Thread.Sleep(5000);
            string actualmessage_tu62 = tu_62_web.FindElement(By.ClassName("alert")).Text.ToString();
            string expectmessage_tu62 = "×\r\nNot found";

            Assert.AreEqual(expectmessage_tu62, actualmessage_tu62);


        }

        // Tìm kiếm thành công
        [TestMethod]
        public void TC002_SearchSuccess_Tu62()
        {
            tu_62_web.Navigate().GoToUrl("https://openweathermap.org/find");
            tu_62_web.FindElement(By.CssSelector("#search_str")).SendKeys("Mexico");


            Actions action = new Actions(tu_62_web);
            action.SendKeys(Keys.Enter).Perform();

            Thread.Sleep(5000);

            IWebElement divlement = tu_62_web.FindElement(By.Id("forecast_list_ul"));
            IList<IWebElement> trElements = divlement.FindElements(By.TagName("tr"));
            Console.WriteLine(trElements.Count);


            for (int i = 0; i < trElements.Count; i++)
            {
                Thread.Sleep(5000);
                //Lấy phần tử<tr> thứ i
                IWebElement trElement = trElements[i];

                //Lấy tất cả các phần tử<td> bên trong phần tử < tr > thứ i
                IList<IWebElement> tdElements = trElement.FindElements(By.TagName("td"));
                IWebElement tdElement = tdElements[1];
                IWebElement aElement = tdElement.FindElement(By.TagName("a"));
                string aText = aElement.Text;

                //Kiểm tra xem chuỗi "Mexico" có tồn tại trong nội dung của thẻ a hay không
                Assert.IsTrue(aText.Contains("Mexico"), $"Không tìm thấy từ khóa 'Mexico' trong nội dung của thẻ <a>. Nội dung thực tế: '{aText}'");
            }
        }

        [TestMethod]
        public void TC003_NotInPutKey_Tu62()
        {
            tu_62_web.Navigate().GoToUrl("https://openweathermap.org/find");
            tu_62_web.FindElement(By.CssSelector("#search_str")).SendKeys("");

            Actions action = new Actions(tu_62_web);
            action.SendKeys(Keys.Enter).Perform();

            Thread.Sleep(5000);

            //Tìm thẻ div cha
            IWebElement parentDiv = tu_62_web.FindElement(By.Id("forecast_list_ul"));

            //Tìm tất cả các thẻ div bên trong thẻ cha
            IList<IWebElement> childDivs = parentDiv.FindElements(By.TagName("div"));

            //Tìm tất cả các thẻ table bên trong thẻ cha
            IList<IWebElement> tables = parentDiv.FindElements(By.TagName("table"));

            //Kiểm tra xem có tồn tại thẻ div hoặc table bên trong thẻ cha hay không
            if (childDivs.Count > 0 || tables.Count > 0)
            {
                Assert.Fail("Trong thẻ div có tồn tại thêm thẻ div hoặc table.");
            }
        }

    }
}



