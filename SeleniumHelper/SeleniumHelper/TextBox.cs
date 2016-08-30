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
    public class TextBox:Control
    {
         private String text;
 
 
        public TextBox(String text, IWebDriver webDriver):base(webDriver) {           
            this.text = text;
        }

        public String getQuery()
        {
            return this.parent.getQuery() + String.Format(".query(\"input[name='{0}']\")[0]", text);

        }

        public void setValue(string strValue)
        {
            webDriver.FindElement(By.Id(getId())).SendKeys(strValue);
        }
    }
}
