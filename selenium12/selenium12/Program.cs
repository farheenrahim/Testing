
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class Program
{
    private static IWebElement dropdownmenu;
    public static IWebElement elementdropdownmenu;

    static void Main(string[] args)
    {
        string url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
        string dropdownelement= "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";


        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        dropdownmenu=driver.FindElement(By.Name("DropDownTest"));
        System.Console.WriteLine("The selected element is "+dropdownmenu.GetAttribute("value"));
        elementdropdownmenu = driver.FindElement(By.CssSelector(dropdownelement));
        System.Console.WriteLine("The Third  element is " + elementdropdownmenu.GetAttribute("value"));
        elementdropdownmenu.Click();
        System.Console.WriteLine("The selected element is " + dropdownmenu.GetAttribute("value"));
        for(int i=1;i<=4;i++)
        {
            dropdownelement = "#post-6 > div > p:nth-child(6) > select > option:nth-child("+i+")";
            elementdropdownmenu = driver.FindElement(By.CssSelector(dropdownelement));
            System.Console.WriteLine("The"+i+"  element is " + elementdropdownmenu.GetAttribute("value"));

        }

        Thread.Sleep(5000);


    }
}

