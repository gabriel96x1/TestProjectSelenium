using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace TestProjectSelenium
{
    public class Tests
    {
        IWebDriver driver;
        string path = @"C:\Users\win 10\source\repos\TestProjectSelenium\TestProjectSelenium\drivers\";

        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver(path);
        }

        [Test]
        public void Test1()
        {
            

            Class1 runTests = new Class1("http://uitestingplayground.com/");

            driver = runTests.testingTests(driver);


      
        }
        //testLinkTexts


        [Test]
        public void Test2()
        {

            Class1 runTests = new Class1("http://uitestingplayground.com/");

            driver = runTests.testLinkTexts(driver);


        }


        [TearDown]
        public void EndTest()
        {

            driver.Close();
            driver.Quit();


        }
    }
}