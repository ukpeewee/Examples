using System;
using System.Web;
using Castle.Facilities.WcfIntegration;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Ukpeewee.Examples.FluentValidationWcfEnum.Contracts;
using Ukpeewee.Examples.FluentValidationWcfEnum.Service;

namespace Ukpeewee.Examples.FluentValidationWcfEnum
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