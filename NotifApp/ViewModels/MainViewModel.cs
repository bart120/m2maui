using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NotifApp.ViewModels;
public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string messageToSend = "";

    [RelayCommand]
    private async Task SendMessage()
    {
        MessageToSend = $"Bonjour  {MessageToSend}";
    }


}