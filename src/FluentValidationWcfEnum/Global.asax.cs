using System;
using System.Web;
using Castle.Facilities.WcfIntegration;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Ukpeewee.Examples.WcfService.Contracts;
using Ukpeewee.Examples.WcfService.Service;

namespace Ukpeewee.Examples.WcfService
{
    public class Global : HttpApplication
    {
        private IWindsorContainer _container;

        protected void Application_Start(object sender, EventArgs e)
        {
            _container = new WindsorContainer();

            _container.AddFacility<WcfFacility>();

            _container.Register(Component.For<ISampleService>()
                .ImplementedBy<SampleService>()
                .AsWcfService(new DefaultServiceModel().Hosted()));
        }

        protected void Application_End(object sender, EventArgs e)
        {
            _container.Dispose();
        }
    }
}