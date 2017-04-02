
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class Program
{
    static IWebDriver driver = new ChromeDriver();
    static IAlert alert;
    static IWebElement image;
    static void Main(string[] args)
    {
        string url = "http://testing.todvachev.com/special-elements/alert-box/";

        driver.Navigate().GoToUrl(url);
        alert = driver.SwitchTo().Alert();
        System.Console.WriteLine(alert.Text);
        alert.Accept();
        image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));
        try
        {
            if (image.Displayed)
            {
                System.Console.WriteLine("The image is displayed");
            }

        }

        catch (NoSuchElementException)
        {
            System.Console.WriteLine("The image is displayed");
        }
        Thread.Sleep(5000);
        driver.Quit();

    }
}

