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
            builder.Services.AddControllers();
            builder.Services.AddSingleton<Database.Database, Database.Database>();

            var app = builder.Build();

            app.MapControllers();

            app.Run();
        }
    }
}
