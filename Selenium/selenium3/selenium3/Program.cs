﻿

using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {
        string url = "http://testing.todvachev.com/selectors/class-name/";
        string classname = "testClass";
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        IWebElement element = driver.FindElement(By.ClassName(classname));
        Console.WriteLine(element.Text);
        driver.Quit();
        Console.ReadKey();
    }
   
  
}

