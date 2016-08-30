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
    public abstract class CompositeControl: Control{
        protected List <Control> children;


        public CompositeControl(IWebDriver webDriver): base(webDriver)
        {           
            children =new List<Control> ();
        }
 
 
        public void addChild(Control control) {
            this.children.Add(control);
            control=this;
        }
    }
}
