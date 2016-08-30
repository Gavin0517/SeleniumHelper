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
    public class Control
    {
        protected IWebDriver webDriver; 
 
        protected Control parent;

        public Control(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
 
 
        public String getQuery() {
            return String.Empty;
        }
 
 
        public String getId() {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)webDriver;
            return(String) executor.ExecuteScript("return "+this.getQuery() +".id");
        }

    }
}
