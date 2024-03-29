﻿using Autofac;
using CFDISharp.CoreLib.Helpers;
using CFDISharp.CoreLib.Services;
using CFDISharp.Winforms.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFDISharp.Winforms.Helpers
{
    public static class Startup
    {

        public static void Configure()
        {
            try
            {
                ConfigureAppSecrets();
                ConfigureWS();
                ConfigureContainer();
                //RunMigrations();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        private static void ConfigureAppSecrets()
        {
            AppServices.AppSettings = AppServices.DeserializeFromJsonFile<List<AppSetting>>("Appsettings.json");
            AppServices.AppSecrets = AppServices.DeserializeFromJsonFile<List<AppSecret>>("AppSecrets.json");
            AppServices.AppSetting = AppServices.AppSettings.FirstOrDefault(x => x.Key.Contains("StandardAppSecret"));
            AppServices.AppSecret = AppServices.AppSecrets.FirstOrDefault(x => x.AppSecretName.Contains(AppServices.AppSetting.Value));

            if (AppServices.AppSecret == null)
            {
                MessageBox.Show("Bad system startup configuration: AppSecret");
                Application.Exit();
            }
        }
        private static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AppdbContext>()
                   .WithParameter("options", DbContextOptionsFactory.Get(AppServices.AppSecret.StandardSecurityConnectionString()))
                   .InstancePerLifetimeScope();


            // Scan all Repositories DataAccesLayer
            builder.RegisterAssemblyTypes(System.AppDomain.CurrentDomain.GetAssemblies())
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces();



            // Register individual components
            builder.RegisterType<MigrationService>().As<IMigrationService>().SingleInstance();
            builder.RegisterType<WSHelperTest>().As<IWSHelperTest>().SingleInstance();
            builder.RegisterType<PaymentService>().As<IPaymentService>().SingleInstance();
            builder.RegisterType<InvoiceService>().As<IInvoiceService>().SingleInstance();
            builder.RegisterType<CFDIHelper>().As<ICFDIHelper>().SingleInstance();
            builder.RegisterType<WSHelperTest>().As<IWSHelperTest>().SingleInstance();
            builder.RegisterType<Form1>().As<Form1>().SingleInstance();

            Program.Container = builder.Build();
        }
        private static void RunMigrations()
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IMigrationService>();
                service.Migrate();
            }
        }
        private static void ConfigureWS()
        {
            Constants.WS_TEST_ENDPOINT = AppServices.GetAppSettingValueByKey("WsTestEndPoint");
            Constants.WS_TEST_TOKEN = AppServices.GetAppSettingValueByKey("WsTestToken");
            Constants.WS_TEST_USER = AppServices.GetAppSettingValueByKey("WsTestUser");
            Constants.WS_TEST_PASS = AppServices.GetAppSettingValueByKey("WsTestPassword");


            var path = Path.Combine(AppServices.GetAppSettingValueByKey("Xslt_Path"),
                                    AppServices.GetAppSettingValueByKey("Xslt_Name"));
            Constants.XSLT_PATH = path;
        }
    }
}
