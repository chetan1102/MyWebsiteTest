using Microsoft.Win32;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyWebsiteTest.PageObjects
{
    class commonLib
    {
        public Random r = new Random();//used for Random Name

       public string generateRandomName(int len)
        {

            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;

        }

        public void popup(IWebDriver driver)
        {
            IAlert simpleAlert = driver.SwitchTo().Alert();
            String alertText = simpleAlert.Text;
            Console.WriteLine("Alert text is " + alertText);
            simpleAlert.Accept();
        }



        public object GetEnvVarFromRegistry(string envVar)
        {
            string defaultValue = null;
            var safeDefault = defaultValue ?? String.Empty;
            var value = (String)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment", envVar, safeDefault);
            return value;
        }
     }
}
