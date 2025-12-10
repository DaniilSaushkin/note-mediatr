using note_mediatr.api.Repositories;

namespace note_mediatr.api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
            });
            
            builder.Services.AddTransient(typeof(MediatR.IPipelineBehavior<,>), typeof(Behaviors.LoggingBehavior<,>));
            builder.Services.AddTransient(typeof(MediatR.IPipelineBehavior<,>), typeof(Behaviors.ValidationBehavior<,>));

            builder.Services.AddSingleton<Database.Database, Database.Database>();
            builder.Services.AddScoped<OrderRepository, OrderRepository>();
            builder.Services.AddScoped<ProductRepository, ProductRepository>();

            builder.Services.AddControllers();
            
            var app = builder.Build();

            app.MapControllers();

            app.Run();
        }
    }
}
