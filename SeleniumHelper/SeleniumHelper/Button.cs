using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace SeleniumHelper
{
    public class Button : Control 
    {
        private String text;
 
 
        public Button(String text, IWebDriver webDriver):base(webDriver) {           
            this.text = text;
        }
 
 
   
        public String getQuery() {            
            return this.parent.getQuery() + String.Format(".query(\"button[text='{0}']\")[0]", text);
            
        }
 
 
        public void click() {
            webDriver.FindElement(By.Id(getId())).Click();
        }
    }
}
