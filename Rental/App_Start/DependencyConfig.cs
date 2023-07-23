using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using Rental.Data.Repositories;
using Rental.DataAccess.Repositories.MembershipTypes;
using Rental.Models;
using Rental.Models.ViewModels;
using Rental.Services.CustomerServices;
using Rental.Services.Validations.PasswordsValidations;
using Rental.Validations.CustomersValidations;

namespace Rental.App_Start
{
    public static class DependencyConfig
    {
        public static void ConfigureDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().InstancePerLifetimeScope();

            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            builder.RegisterType<MembershipTypesRepository>().As<IMembershipTypesRepository>();
            builder.RegisterType<CustomerValidationService>().As<ICustomerValidationService>();
            builder.RegisterType<CustomerService>().As<ICustomerService>();
            builder.RegisterType<PasswordHelper>().As<IPasswordHelper>();

            // Register the controller types
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

        }
    }
}