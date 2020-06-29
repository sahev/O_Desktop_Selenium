﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using OpenQA.Selenium.IE;
using Unit_Desktop.Page_Object;
using OpenQA.Selenium.Support.PageObjects;
using Unit_Desktop;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace ST01Desktop

{

    public class ST01Customers
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;

        [SetUp]
        public void SetUp()
        {
            driver = Comandos.GetBrowserRemote(driver, "chrome", "http://192.168.0.106:5556/wd/hub");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }

        [TearDown]
        protected void TearDown()
        {
            Thread.Sleep(3000);

            driver.SwitchTo().Window(driver.WindowHandles[0]);

            driver.FindElement(By.CssSelector("#cmdLogoff")).Click();

            driver.Quit();
        }

        [Test]
        public void CST01ValidarCamposObrigatoriosTela()
        {

            // Módulo Clientes
            driver.FindElement(By.CssSelector("#navbar > ul > li:nth-child(4) > a")).Click();

            // switch para o frame Clientes
            driver.SwitchTo().Frame(1);

            // aguarda o item ser visivel para continuação da thread
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='tbr_t0']/tbody/tr/td[2]")));

            // botão Nova pessoa
            driver.FindElement(By.XPath("//*[@id='tbr_t0']/tbody/tr/td[2]")).Click();

            // switch para o pop-up
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            // botão Salvar
            driver.FindElement(By.CssSelector("#tbr_i0")).Click();

            // Validação dos campos obrigatórios
            StringAssert.Contains("Por favor verifique os seguintes itens:", driver.FindElement(By.Id("slideMain_valSummary")).Text);

        }
        
        [Test]
        public void CST01ValidarLayoutTela()
        {

            //Thread.Sleep(5000);
            // EXPLICT WAIT
            //wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#navbar > ul > li:nth-child(4) > a")));

            driver.FindElement(By.CssSelector("#navbar > ul > li:nth-child(4) > a")).Click();

            driver.SwitchTo().Frame(1);


            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='tbr_t0']/tbody/tr/td[2]")));

            driver.FindElement(By.XPath("//*[@id='tbr_t0']/tbody/tr/td[2]")).Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);


            //Page object

            Customer_Person_Edit customer = new Customer_Person_Edit();

            PageFactory.InitElements(driver, customer);

            //driver.FindElement(By.CssSelector("#nav-menu-item-5643 .item_text")).Click();

            //Thread.Sleep(5000);

            Assert.IsTrue(customer.name.Enabled);
            Assert.IsTrue(customer.taxid1.Enabled);
            Assert.IsTrue(customer.gender.Enabled);
            Assert.IsTrue(customer.telephone1.Enabled);
            Assert.IsTrue(customer.telephone2.Enabled);
            Assert.IsTrue(customer.telephone3.Enabled);
            Assert.IsTrue(customer.mobile.Enabled);
            Assert.IsTrue(customer.taxid2.Enabled);
            Assert.IsTrue(customer.nickname.Enabled);
            Assert.IsTrue(customer.fax.Enabled);
            Assert.IsTrue(customer.birthdate.Enabled);
            Assert.IsTrue(customer.cep.Enabled);
            Assert.IsTrue(customer.postalcode.Enabled);
            Assert.IsTrue(customer.address.Enabled);
            Assert.IsTrue(customer.addressline2.Enabled);
            Assert.IsTrue(customer.country.Enabled);
            Assert.IsTrue(customer.city.Enabled);
            Assert.IsTrue(customer.email1.Enabled);
            Assert.IsTrue(customer.email2.Enabled);
            Assert.IsTrue(customer.url.Enabled);
            Assert.IsTrue(customer.url_twitter.Enabled);
            Assert.IsTrue(customer.url_facebook.Enabled);
            Assert.IsTrue(customer.notes.Enabled);


        }

    }
}

