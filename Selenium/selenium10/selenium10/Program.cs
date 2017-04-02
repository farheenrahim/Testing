


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class Program
{
    private static IWebElement Checkbox;

    static void Main(string[] args)
    {
        string url = "http://testing.todvachev.com/special-elements/check-button-test-3/";
         string option = "1";
       // string option = "3";
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        Checkbox= driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child("+option+")"));
        //System.Console.WriteLine(Checkbox.GetAttribute("value"));
        // option = "3";
        //Checkbox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));
        //System.Console.WriteLine(Checkbox.GetAttribute("value"));
        Checkbox.Click();
        //if(Checkbox.GetAttribute("checked")=="true")
        //    {
        //    System.Console.WriteLine("The checkbox is checked");
        //}
        //else
        //{
        //    System.Console.WriteLine("The checkbox is not checked");
        //}
        Thread.Sleep(5000);
        driver.Quit();
        
    }
}
