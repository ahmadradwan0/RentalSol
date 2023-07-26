using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Rental.App_Start;
using Rental.Models;

namespace Rental
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //for autofac ... 
            //------------------------------------------------------------------------
            var builder = new ContainerBuilder();
            DependencyConfig.ConfigureDependencies(builder);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //-----------------------------------------------------------------------

            // ASP.NET Identity configuration
            string connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["ApplicationDbContext"].ConnectionString;
            ApplicationDbContext context = new ApplicationDbContext(connectionString);

            // Create user manager and role manager
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            // Configure user manager
            userManager.UserValidator = new UserValidator<ApplicationUser>(userManager)
            {
                RequireUniqueEmail = true,
                AllowOnlyAlphanumericUserNames = false
            };

            // Configure cookie authentication
            var cookieOptions = new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                ExpireTimeSpan = TimeSpan.FromMinutes(30),
                SlidingExpiration = true,
                CookieHttpOnly = true
            };
            app.UseCookieAuthentication(cookieOptions);


            //----------------------------------------------------------
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
