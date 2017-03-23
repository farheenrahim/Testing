

using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
    {
        static void Main(string[] args)
        {
        string url = "http://testing.todvachev.com/selectors/id/";
        string id = "testImage";
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        IWebElement element = driver.FindElement(By.Id(id));
        if(element.Displayed)
        {
            Greenmessage("Yes! I can see the element");
                   }
        else
        {
            Redmessage("Well something is wrong. I coudnt see the element");
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

