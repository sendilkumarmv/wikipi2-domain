
using Wikipi.Domain.Domain;
using Wikipi.Domain.Domain.Contracts;
using Wikipi.Domain.Mapper;
using Wikipi.Domain.Repository;
using Wikipi.Domain.Repository.Interfaces;
using Wikipi.Domain.Repository.MongoDb;

namespace Wikipi.Domain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);

            var isection = builder.Configuration.GetSection(RepositorySettings.SECTION);
            builder.Services.Configure<RepositorySettings>(isection);

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddScoped<IProductsHandler, ProductsHandler>();
            builder.Services.AddScoped<IUserHandler, UserHandler>();
            builder.Services.AddScoped<IDbFactory, DbFactory>();
            builder.Services.AddScoped<IBaseRepository, MongoDBRepository>();

            builder.Services.AddAutoMapper(typeof(ProductMapper));
            builder.Services.AddCors(b => b.AddPolicy("local",
                x => x.WithOrigins("https://localhost:4200")
                     .AllowAnyHeader()
                     .AllowAnyMethod()
                ));

            var app = builder.Build();
            app.UseCors("local");
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
