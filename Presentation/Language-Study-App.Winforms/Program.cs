using Language_Study_App.Application.Features.Commands;
using Language_Study_App.Application.Features.Queries;
using Language_Study_App.Application.Repositories;
using Language_Study_App.Persistence.Contexts;
using Language_Study_App.Persistence.Repositories;
using Language_Study_App.Winforms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

static class Program
{
    [STAThread]
    static void Main()
    {
        System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
        System.Windows.Forms.Application.EnableVisualStyles();
        System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        System.Windows.Forms.Application.Run(ServiceProvider.GetRequiredService<HomePage>());
    }
    public static IServiceProvider ServiceProvider { get; private set; }
    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<LanguageStudyAppDb>(o => o.UseSqlServer(Language_Study_App.Persistence.Configurations.Configuration.ConnectionString));
                services.AddScoped<IWordWriteRepository, WordWriteRepository>();
                services.AddScoped<IWordReadRepository, WordReadRepository>();
                services.AddScoped<IAllEntiteWriteRepository, AllEntitieWriteRepository>();
                services.AddScoped<IAllEntitieReadRepository, AllEntitieReadRepository>();
                services.AddScoped<ITranslateReadRepository, TranslateReadRepository>();
                services.AddScoped<ITranslateWriteRepository, TranslateWriteRepository>();
                services.AddScoped<IPVReadRepository, PVReadRepository>();
                services.AddScoped<IPVWriteRepository, PVWriteRepository>();
                services.AddScoped<AddCommand>();
                services.AddScoped<UpdateCommand>();
                services.AddScoped<GetCount>();
                services.AddScoped<GetRandom>();
                services.AddScoped<GetByIdQuery>();
                services.AddScoped<GetByQuery>();
                services.AddScoped<GetWhereQuery>();
                services.AddScoped<HomePage>();
            });
    }
}