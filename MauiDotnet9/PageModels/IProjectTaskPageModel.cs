using CommunityToolkit.Mvvm.Input;
using MauiDotnet9.Models;

namespace MauiDotnet9.PageModels;

public interface IProjectTaskPageModel
{
    IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
    bool IsBusy { get; }
}
