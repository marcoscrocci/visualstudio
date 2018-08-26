using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ControleFinanceiroWeb.Data;
using ControleFinanceiroWeb.Models;
using ControleFinanceiroWeb.Services;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Localization;
using ControleFinanceiroWeb.Validation;

namespace ControleFinanceiroWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddApplicationInsightsTelemetry(Configuration);

            /*** Configurações dos idiomas do sistema ***/
            services.AddLocalization(options => { options.ResourcesPath = "Resources"; });
            services.AddMvc(options =>
            {
                var F = services.BuildServiceProvider().GetService<IStringLocalizerFactory>();
                var L = F.Create("ModelBindingMessages", "ControleFinanceiroWeb");
                options.ModelBindingMessageProvider.SetValueIsInvalidAccessor(
                    (x) => L["The value '{0}' is invalid."]);
                options.ModelBindingMessageProvider.SetValueMustBeANumberAccessor(
                    (x) => L["The field {0} must be a number."]);
                options.ModelBindingMessageProvider.SetMissingBindRequiredValueAccessor(
                    (x) => L["A value for the '{0}' property was not provided.", x]);
                options.ModelBindingMessageProvider.SetAttemptedValueIsInvalidAccessor(
                    (x, y) => L["The value '{0}' is not valid for {1}.", x, y]);
                options.ModelBindingMessageProvider.SetMissingKeyOrValueAccessor(
                    () => L["The {0} field is required."]);
                options.ModelBindingMessageProvider.SetUnknownValueIsInvalidAccessor(
                    (x) => L["The supplied value is invalid for {0}.", x]);
                options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(
                    (x) => L["Null value is invalid.", x]);
                options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(
                   value => SiteResources.CustomImplicitRequired);
                options.ModelBindingMessageProvider.SetAttemptedValueIsInvalidAccessor(
                   (value, fieldName) => string.Format(SiteResources.CustomInvalidValue, value));
                options.ModelBindingMessageProvider.SetValueMustBeANumberAccessor(
                    fieldName => string.Format(SiteResources.CustomNumeric, fieldName));
                options.ModelMetadataDetailsProviders.Add(
                    new CustomValidationMetadataProvider("ControleFinanceiroWeb.SiteResources",
                        typeof(SiteResources)));
            })
            .AddDataAnnotationsLocalization()
            .AddViewLocalization();
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("en"),
                    new CultureInfo("pt-br")
                };
                options.DefaultRequestCulture = new RequestCulture("pt-br", "pt-br");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });

            /*** Configurações do banco de dados ***/
            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<ControleFinanceiroDbContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("ControleFinanceiroConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            //services.AddIdentity<ApplicationUser, IdentityRole>(
            //    options => {
            //        options.Password.RequireDigit = true;
            //        options.Password.RequiredLength = 8;
            //        options.Password.RequiredUniqueChars = 2;
            //        options.Password.RequireLowercase = true;
            //        options.Password.RequireNonAlphanumeric = true;
            //        options.Password.RequireUppercase = true;
            //    })
            //    .AddEntityFrameworkStores<ApplicationDbContext>()
            //    .AddDefaultTokenProviders();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            /*** Configurações dos idiomas do sistema ***/
            var supportedCultures = new[] { new CultureInfo("en"), new CultureInfo("pt-br") };
            app.UseRequestLocalization(new RequestLocalizationOptions()
            {
                DefaultRequestCulture = new RequestCulture(new CultureInfo("en")),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            // Código automático
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
