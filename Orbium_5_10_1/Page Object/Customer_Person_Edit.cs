using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Unit_Desktop.Page_Object
{
    class Customer_Person_Edit
    {
        [FindsBy(How = How.Id, Using = "slideMain_lblName")] 
        public IWebElement name { get; set; }

        
        [FindsBy(How = How.Id, Using = "slideMain_lblTaxID1")] //CPF
        public IWebElement taxid1 { get; set; }
        
        
        [FindsBy(How = How.Id, Using = "slideMain_lblGender")]
        public IWebElement gender { get; set; }

        
        [FindsBy(How = How.Id, Using = "slideMain_lblTelephone1")]
        public IWebElement telephone1 { get; set; }


        [FindsBy(How = How.Id, Using = "slideMain_lblTelephone2")]
        public IWebElement telephone2 { get; set; }


        [FindsBy(How = How.Id, Using = "slideMain_lblTelephone3")]
        public IWebElement telephone3 { get; set; }

        
        [FindsBy(How = How.Id, Using = "slideMain_lblMobile")]
        public IWebElement mobile { get; set; }

        
        [FindsBy(How = How.Id, Using = "slideMain_lblTaxID2")] //RG
        public IWebElement taxid2 { get; set; }
        
        
        [FindsBy(How = How.Id, Using = "slideMain_lblNickName")] //APELIDO
        public IWebElement nickname { get; set; }


        [FindsBy(How = How.Id, Using = "slideMain_lblFax")]
        public IWebElement fax { get; set; }


        [FindsBy(How = How.Id, Using = "slideMain_lblBirthDate")]
        public IWebElement birthdate { get; set; }


        [FindsBy(How = How.Id, Using = "slideMain_lblPostalCode")]
        public IWebElement cep { get; set; }


        [FindsBy(How = How.Id, Using = "slideMain_lblPostOfficeBox")]
        public IWebElement postalcode { get; set; }


        [FindsBy(How = How.Id, Using = "slideMain_lblAddress")]
        public IWebElement address { get; set; }


        [FindsBy(How = How.Id, Using = "slideMain_LblAdressLine2")]
        public IWebElement addressline2 { get; set; }


        [FindsBy(How = How.Id, Using = "slideMain_lblCountry")]
        public IWebElement country { get; set; }


        [FindsBy(How = How.Id, Using = "slideMain_lblCity")]
        public IWebElement city { get; set; }


        [FindsBy(How = How.Id, Using = "slideMain_lblEmail1")]
        public IWebElement email1 { get; set; }


        [FindsBy(How = How.Id, Using = "slideMain_lblEmail2")]
        public IWebElement email2 { get; set; }


        [FindsBy(How = How.Id, Using = "slideMain_lblURL")]
        public IWebElement url { get; set; }


        [FindsBy(How = How.Id, Using = "slideMain_lblSocialMedia2")]
        public IWebElement url_twitter { get; set; }


        [FindsBy(How = How.Id, Using = "slideMain_lblSocialMedia1")]
        public IWebElement url_facebook { get; set; }


        [FindsBy(How = How.Id, Using = "slideMain_lblNotes")]
        public IWebElement notes { get; set; }


    }
}
