﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;

class Program
    {
    static void Main(string[] args)
    {

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://testing.todvachev.com/selectors/name/");
        IWebElement element = driver.FindElement(By.Name("myName"));
        if (element.Displayed)
        {
            GreenMessage("Yes! I can see the element");
        }
        else
        {
            RedMessage("Well something is wrong ! I cannot see the element");

        }
        driver.Quit();
    }
       
    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
            }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }



        }

