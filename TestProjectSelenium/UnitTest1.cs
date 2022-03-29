using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace TestProjectSelenium
{
    public class Tests
    {
        IWebDriver driver;
        string path = @"\TestProjectSelenium\TestProjectSelenium\drivers\";

        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver(path);
        }

        [Test]
        public void Test1()
        {
            
            driver.Url = "http://uitestingplayground.com/";

            string Title = driver.Title;
            int TitleLength = driver.Title.Length;
            Console.WriteLine("Title of the page is : " + Title);
            Console.WriteLine("Length of the Title is : " + TitleLength);
            string PageSource = driver.PageSource;
            Console.WriteLine("Page Source of the page is : " + PageSource);



            Assert.Pass();
      
        }

        [TearDown]
        public void EndTest()
        {

            driver.Close();
            driver.Quit();


        }
    }
}