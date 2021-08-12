using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

[SetUpFixture]
public class SetupTrace
{
    [OneTimeSetUp]
    public void StartTest()
    {
        Trace.Listeners.Add(new ConsoleTraceListener());
    }

    [OneTimeTearDown]
    public void EndTest()
    {
        Trace.Flush();
    }
}

namespace UITestProject
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        object _LockMe = new object();

        IApp app;
        Platform platform;

        string defaultMsg = DateTime.Now.ToLongTimeString();
        string LogFile = @"c:\temp\debug.log";

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            //WriteFile(""); //New Line For each TEST
            //WriteFile("BeforeEachTest - START");

            app = AppInitializer.StartApp(platform);

            //WriteFile("BeforeEachTest - END");


        }

        

        [Test]
        public void UITestScreen()
        {
            //AppResult[] results = app.WaitForElement(c => c.Class
            //AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            //app.Screenshot("Welcome screen.");
            //Assert.IsTrue(results.Any());
            //btnMyButton

            app.Tap(c => c.Marked("tstBtnTest"));
            FileInfo fi = app.Screenshot("UI_TEST_Screen");
            WriteFile(fi.FullName);
            //string[] note = { "Line 1", fi.FullName };
            //File.WriteAllLines(@"c:\temp\screen_shot.txt", note);
            //fi.CopyTo(@"c:\temp\screen_shot.png");

        }

        //[Test]
        //public void ReadAppSettingsTest()
        //{
        //    //WriteFile("ReadAppSettingsTest - START");
        //    //string configName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".dll.config";
        //    //string path = Path.Combine(Directory.GetCurrentDirectory(), configName);
        //    ////WriteFile(path); //Debug

        //    //tdevere();
        //    try
        //    {
        //        //WriteFile(@"var reader = new AppSettingsReader();");
        //        var reader = new AppSettingsReader();

        //        var stringSetting = reader.GetValue("tdevere", typeof(string));
        //        //WriteFile("tdevere: " + stringSetting);

        //        Assert.IsTrue(string.IsNullOrEmpty(stringSetting.ToString()));
        //    }
        //    catch (Exception ex)
        //    {
        //        //WriteFile("ReadAppSettingsTest - EXCEPTION");
        //        //WriteFile(ex.Message);
        //        Assert.IsTrue(false);
        //    }

        //    //WriteFile("ReadAppSettingsTest - END");
        //}

        [Test]
        public void WriteFileTest()
        {
            WriteFile("//WriteFileTest");
        }

        [Test]
        public void GetExecutingAssembly()
        {
            WriteFile("GetExecutingAssembly - START");
            WriteFile(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name); //Debug
            WriteFile("GetExecutingAssembly - END");
        }

        [Test]
        public void GetProcessName()
        {
            WriteFile("GetProcessName - START");
            WriteFile($"NAME: {System.Diagnostics.Process.GetCurrentProcess().ProcessName} ID:{System.Diagnostics.Process.GetCurrentProcess().Id.ToString()}");            
            WriteFile("GetProcessName - END");
        }

        [Test]
        public void ReadProjectSettings()
        {
            WriteFile(Properties.Settings.Default.Setting1);
            WriteFile(Properties.Settings.Default.Setting2);
        }


        public void WriteFile(string msg)
        {
            Debug.WriteLine(msg + " " + DateTime.Now.ToLongTimeString());

            //lock (_LockMe)
            //{
            //    if (File.Exists(LogFile))
            //    {
            //        using (StreamWriter sw = new StreamWriter(LogFile, true))
            //        {
            //            //sw.WriteLine(System.Environment.NewLine);
            //            sw.WriteLine(msg + " " + DateTime.Now.ToLongTimeString());
            //        }
            //    }
            //}
        }
    }
}
