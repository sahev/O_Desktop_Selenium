using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace Unit_Desktop
{

    class Comandos
    {

        #region Browser & Login

        public static IWebDriver GetBrowserLocal(IWebDriver driver, String browser)
        {
            switch (browser)
            {
                case "chrome":
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    break;
                case "ie":
                    driver = new InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    break;
            }

            driver.Navigate().GoToUrl("https://orbqa.nccserver.com.br/Desktop/User_Login.aspx");
            //{
            //    WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(2));
            //    wait.Until(driver => driver.FindElement(By.Id("Login1_UserName")).Enabled);
            //}
            Thread.Sleep(3000);
            driver.FindElement(By.Id("Login1_UserName")).SendKeys("ree.pittman");
            driver.FindElement(By.Id("Login1_Password")).SendKeys("password1");
            driver.FindElement(By.Id("Login1_LoginButton")).Click();

            return driver;
        }

        #endregion

        #region Remote Browser
        public static IWebDriver GetBrowserRemote(IWebDriver driver, String browser, String uri)
        {
            switch (browser)
            {
                case "chrome":
                    ChromeOptions rem_chrome = new ChromeOptions();
                    driver = new RemoteWebDriver(new Uri(uri), rem_chrome);
                    driver.Manage().Window.Maximize();
                    break;
                case "ie":
                    InternetExplorerOptions rem_ie = new InternetExplorerOptions();
                    driver = new RemoteWebDriver(new Uri(uri), rem_ie);
                    driver.Manage().Window.Maximize();
                    break;
                case "firefox":
                    FirefoxOptions rem_ff = new FirefoxOptions();
                    driver = new RemoteWebDriver(new Uri(uri), rem_ff);
                    driver.Manage().Window.Maximize();
                    break;
            }

            driver.Navigate().GoToUrl("https://orbqa.nccserver.com.br/Desktop/User_Login.aspx");
            //{
            //    WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(2));
            //    wait.Until(driver => driver.FindElement(By.Id("Login1_UserName")).Enabled);
            //}
            Thread.Sleep(3000);
            driver.FindElement(By.Id("Login1_UserName")).SendKeys("ree.pittman");
            driver.FindElement(By.Id("Login1_Password")).SendKeys("password1");
            driver.FindElement(By.Id("Login1_LoginButton")).Click();

            return driver;


        }
        #endregion

    }
}