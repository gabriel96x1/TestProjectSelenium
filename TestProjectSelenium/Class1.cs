using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestProjectSelenium
{
    internal class Class1
    {
        String url;

        public Class1(String Url)
        {
            url = Url;
        }
        public IWebDriver testingTests(IWebDriver driver)
        {
            driver.Url = url;
            string Title = driver.Title;
            int TitleLength = driver.Title.Length;
            Console.WriteLine("Title of the page is : " + Title);
            Console.WriteLine("Length of the Title is : " + TitleLength);
            string PageSource = driver.PageSource;
            Console.WriteLine("Page Source of the page is : " + PageSource);



            Assert.Pass();

            return driver;
        }

        public IWebDriver testLinkTexts(IWebDriver driver)
        {
            driver.Url = url;
            int counter = 0;
            driver.FindElement(By.LinkText("Dynamic ID")).Click();
            if (driver.Url != url)
            {
                counter++;
            }
            driver.Navigate().Back();

            driver.FindElement(By.LinkText("Class Attribute")).Click();
            if (driver.Url != url)
            {
                counter++;
            }
            driver.Navigate().Back();

            driver.FindElement(By.LinkText("Hidden Layers")).Click();
            if (driver.Url != url)
            {
                counter++;
            }
            driver.Navigate().Back();

            driver.FindElement(By.LinkText("Load Delay")).Click();
            if (driver.Url != url)
            {
                counter++;
            }
            driver.Navigate().Back();

            driver.FindElement(By.LinkText("AJAX Data")).Click();
            if (driver.Url != url)
            {
                counter++;
            }
            driver.Navigate().Back();

            driver.FindElement(By.LinkText("Client Side Delay")).Click();
            if (driver.Url != url)
            {
                counter++;
            }
            driver.Navigate().Back();

            driver.FindElement(By.LinkText("Click")).Click();
            if (driver.Url != url)
            {
                counter++;
            }
            driver.Navigate().Back();

            if(counter == 7)
            {
                Assert.Pass();
            } else
            {
                Assert.Fail();
            }


            return driver;
        }

    }
}
