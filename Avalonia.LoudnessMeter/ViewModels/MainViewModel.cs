
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia.LoudnessMeter.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string boldTitle = "AVALONIA";
    
    [ObservableProperty]
    private string regularTitle= "LOUDNESS METER";

}
