// -------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows.Forms;
// using VastGIS.Api.Concrete;
using VastGIS.DI.Castle;
using VastGIS.Helpers;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Services.Concrete;
using VastGIS.Shared;
using VastGIS.Views;
// using VastGIS.DI.LightInject;
// using VastGIS.DI.Ninject;
// using VastGIS.DI.Unity;

namespace VastGIS
{
    internal static class Program
    {
        public static Stopwatch Timer = new Stopwatch();

        private static IApplicationContainer CreateContainer()
        {
            // Switch the class here and change the using directive above to use another one
            // Also switch references.

            // LightInjectContainer
            // NinjectContainer
            // UnityApplicationContainer
            // return  new NinjectContainer();
            return new WindsorCastleContainer();
        }

        //private static void DumpFormats()
        //{
        //    var manager = new DriverManager();
        //    manager.DumpExtensions(true);

        //    manager.DumpExtensions(false);
        //}

        private static void LoadConfig(IApplicationContainer container)
        {
            Logger.Current.Trace("Start LoadConfig");
            MapInitializer.InitMapConfig();

            Logger.Current.Trace("Before container.GetSingleton");
            var configService = container.GetSingleton<IConfigService>();
            Logger.Current.Trace("After container.GetSingleton");

            configService.LoadAll();
            Logger.Current.Trace("End LoadConfig");
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            ExceptionHandler.Attach();

            //DumpFormats();

            var logger = new LoggingService();
            logger.Info("APPLICATION STARTUP");

            ShowSplashScreen();

            Timer.Start();

            var container = CreateContainer();
            CompositionRoot.Compose(container);

            SplashView.Instance.ShowStatus("引导配置");
            LoadConfig(container);

            SplashView.Instance.ShowStatus("启动程序");
            container.Run<MainPresenter>();
        }

        private static void ShowSplashScreen()
        {
            var splashScreen = SplashView.Instance;
            splashScreen.ShowStatus("程序容器注入");
            splashScreen.Show();
            Application.DoEvents();
        }
    }
}