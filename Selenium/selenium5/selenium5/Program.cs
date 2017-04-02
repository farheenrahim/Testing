


using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {
        string url = "http://testing.todvachev.com/selectors/css-path/";
        string csspath = "#post-108 > div > figure > img";
        string xpath = "//*[@id=\"post-108\"]/div/figure/img";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        IWebElement csselement = driver.FindElement(By.CssSelector(csspath));
        IWebElement xpathelement = driver.FindElement(By.XPath(xpath));
        if(csselement.Displayed)
        {
            Greenmessage("I can see the css element");
                    }
        else
        {
            Redmessage("I cannot see the css element");
                    }
        if(xpathelement.Displayed)
        {
            Greenmessage("I can see the xpath element");
        }
        else
        {
            Greenmessage("I can see the xpath element");
        }
        driver.Quit();
    }

    private static void Redmessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void Greenmessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;

    }
}

