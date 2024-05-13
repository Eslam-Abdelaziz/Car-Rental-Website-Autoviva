using CarRental.Application.Authentication;
using CarRental.Application.Contracts;
using CarRental.Application.Contracts.Entities;
using CarRental.Application.Repositories;
using CarRental.Application.Repositories.Entities;
using CarRental.Data.Configurations;
using CarRental.Data.Models;
using System.Reflection;
using AutoMapper;
namespace CarRental.API
{
    public class Program
    {

		public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddHttpContextAccessor();


            builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("EmailSettings"));


            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddScoped<ICarImageService, CarImageService>();



            builder.Services.AddTransient<IEmailSender, EmailSender>();
            builder.Services.AddTransient<IAuthService, AuthService>();
            builder.Services.AddScoped<IBranchService, BranchService>();
            builder.Services.AddScoped<IColorService,ColorService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IBrandService, BrandService>();
            builder.Services.AddScoped<ICarService, CarService>();
			builder.Services.AddScoped<IRentalService, RentalService>();
			builder.Services.AddScoped<IModelService, ModelService>();
			builder.Services.AddScoped<IPaymentService, PaymentService>();

			builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.UseJwtBearer(builder.Configuration);

            builder.Services.RegisterIdentity(builder.Configuration);


            //builder.Services.AddSwaggerGen(options =>
            //{
            //    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
            //    {
            //        Description = "Standard Authorization header using the Bearer scheme (\"bearer {token}\")",
            //        In = ParameterLocation.Header,
            //        Name = "Authorization",
            //        Type = SecuritySchemeType.ApiKey
            //    });

            //    options.OperationFilter<SecurityRequirementsOperationFilter>();
            //});
            //builder.Services.AddTransient<IValidatorInterceptor, UseCustomErrorModelInterceptor>();

            //.ConfigureApiBehaviorOptions(options =>
            //{
            //    options.InvalidModelStateResponseFactory = context =>
            //    {
            //        var errors = context.ModelState.Values
            //            .SelectMany(v => v.Errors)
            //            .Select(e => JsonSerializer.Deserialize<Error>(e.ErrorMessage));

            //        return new BadRequestObjectResult(errors);
            //    };
            //});




            //builder.Services.AddValidatorsFromAssemblyContaining<AuthValidator>(); // register validators
            //builder.Services.AddFluentValidationAutoValidation(x => 
            //{
            //    x.DisableDataAnnotationsValidation = true;
            //}); // the same old MVC pipeline behavior
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseAuthentication();

            app.MapControllers();


			app.Run();
        }

    }

}