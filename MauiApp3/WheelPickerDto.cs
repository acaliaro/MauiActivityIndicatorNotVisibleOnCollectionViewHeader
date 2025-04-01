using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp3
{
    public partial class WheelPickerDto : ObservableObject
    {
        [ObservableProperty] object _originalObject;
        [ObservableProperty] int _originalObjectPosition;
        [ObservableProperty] int _wheelPosition;
        [ObservableProperty] string _wheelText;
    }
}
