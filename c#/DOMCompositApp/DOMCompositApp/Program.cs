using System;
using System.IO;
using DOMCompositApp.Model;


namespace DOMCompositApp
{
    class Program
    {
        static void Main()
        {
            DivTag rootdiv = new DivTag("div");

            DivTag userNameDiv = new DivTag("div");
            DivTag userName = new DivTag("p","Username:");
            userName.AddTag(new IndividualTag("input","text"));
            userNameDiv.AddTag(userName);

            DivTag userPassDiv = new DivTag("div");
            DivTag userPass = new DivTag("p","Password:");
            userPass.AddTag(new IndividualTag("input", "password"));
            userPassDiv.AddTag(userPass);

            rootdiv.AddTag(userNameDiv);
            rootdiv.AddTag(userPassDiv);
            rootdiv.AddTag(new IndividualTag("input", "submit"));
            Console.WriteLine(rootdiv.Display(""));

            //html file creater
            HtmlCreater(rootdiv.Display(""));          
            Console.ReadKey();
        }
        public static void HtmlCreater(string htmlScript)
        {
            string filePath = @"E:\swabhav\c#\OOP\C#\DOMCompositApp\DomDemo.html";
            if (File.Exists(filePath))
                File.Delete(filePath);
            File.WriteAllText(filePath, htmlScript);
        }
    }
}
