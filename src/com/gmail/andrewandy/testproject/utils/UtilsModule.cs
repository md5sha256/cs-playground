
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace com.gmail.andrewandy.TestProject {

    public class UtilsModule {
        
        public UtilsModule() {
        }
        
        /// <summary>
        /// Configure a given IServiceCollection with the services this module provides
        /// </summary>
        /// <param name="context">The HostBuilderContext instance</param>
        /// <param name="services">The IServiceCollection to configure</param>
        public void Services(HostBuilderContext context, IServiceCollection services) {
            // Init singleton
            services.AddSingleton<IPrinter, SimplePrinter>()
            // Init dummy object
                    .AddSingleton<DummyObject, DummyObject>();
        }



    }


}