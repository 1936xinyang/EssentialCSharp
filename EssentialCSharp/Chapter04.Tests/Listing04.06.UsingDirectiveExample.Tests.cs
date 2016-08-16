﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_06.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void Main_WriteMyName()
        {
            string view = "Hello, my name is Inigo Montoya";

            Intellitect.ConsoleView.Tester.Test(view,
            () =>
            {
                HelloWorld.ChapterMain();
            });
        }
    }
}