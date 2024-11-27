using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Toolkit.Hosting;

namespace MauiDotnet9;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        var services = builder.Services;
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureSyncfusionToolkit()
            .ConfigureMauiHandlers(handlers =>
            {
            })
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("SegoeUI-Semibold.ttf", "SegoeSemibold");
                fonts.AddFont("FluentSystemIcons-Regular.ttf", FluentUI.FontFamily);
            });

#if DEBUG
		builder.Logging.AddDebug();
        services.AddLogging(configure => configure.AddDebug());
#endif

        services.AddSingleton<ProjectRepository>();
        services.AddSingleton<TaskRepository>();
        services.AddSingleton<CategoryRepository>();
        services.AddSingleton<TagRepository>();
        services.AddSingleton<SeedDataService>();
        services.AddSingleton<ModalErrorHandler>();
        services.AddSingleton<MainPageModel>();
        services.AddSingleton<ProjectListPageModel>();
        services.AddSingleton<ManageMetaPageModel>();

        services.AddTransientWithShellRoute<ProjectDetailPage, ProjectDetailPageModel>("project");
        services.AddTransientWithShellRoute<TaskDetailPage, TaskDetailPageModel>("task");

        return builder.Build();
    }
}
