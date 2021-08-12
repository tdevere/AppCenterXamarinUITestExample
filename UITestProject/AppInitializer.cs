using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestProject
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .EnableLocalScreenshots()
                    .ApkFile(@"C:\temp\AppCenterXamrain_Test_Example\CrossPlatSampleForUITest\CrossPlatSampleForUITest.Android\bin\Release\com.companyname.crossplatsampleforuitest.apk")
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}