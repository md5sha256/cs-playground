using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace com.gmail.andrewandy.TestProject {

    public class Program {

        public static void Main(string[] args) {
            IHostBuilder builder = CreateHostBuilder(args);
            IHost host = builder.Build();
            IServiceProvider serviceProvider = host.Services;
            DummyObject obj = serviceProvider.GetService<DummyObject>();
            obj.Test("Hello!");
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices(new UtilsModule().Services);

    }

}