using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Elements.Base;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Composite
{
    public class FileInput : UIElement
    {
        public FileInput(By byLocator) : base(byLocator)
        {
        }

        /// <summary>
        /// Select file using file input
        /// </summary>
        /// <param name="filepath">full path to file</param>
        public void SelectFile(string filepath)
        {
            if (WebElement.Enabled)
            {
                WebElement.SendKeys(filepath);
            }
        }
    }
}
