#nullable disable
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiDotnet9.Models;

namespace MauiDotnet9.PageModels;

public partial class ProjectListPageModel(ProjectRepository projectRepository) : ObservableObject
{
    private readonly ProjectRepository _projectRepository = projectRepository;

    [ObservableProperty]
    private List<Project> _projects = [];

    [RelayCommand]
    private async Task Appearing()
    {
        Projects = await _projectRepository.ListAsync();
    }

    [RelayCommand]
    private Task NavigateToProject(Project project)
        => Shell.Current.GoToAsync($"project?id={project.ID}");

    [RelayCommand]
    private async Task AddProject()
    {
        await Shell.Current.GoToAsync($"project");
    }
}
