using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AgileCraftTests

{
    public class WebDriverSingleton
    {

        public static IWebDriver driver;

        public static IWebDriver getInstance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
            return driver;
        }

    }
}
