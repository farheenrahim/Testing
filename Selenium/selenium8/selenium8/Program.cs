


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class Program
    {
    static IWebDriver driver = new ChromeDriver();
    static IWebElement textbox;

        static void Main(string[] args)
        {
        string url = "http://testing.todvachev.com/special-elements/text-input-field/";
        driver.Navigate().GoToUrl(url);
        textbox = driver.FindElement(By.Name("username"));
        textbox.SendKeys("Test test");
        Thread.Sleep(3000);
        //System.Console.WriteLine(textbox.GetAttribute("value"));
        System.Console.WriteLine(textbox.GetAttribute("maxlength"));
        Thread.Sleep(3000);
        driver.Quit();




        }
    }

