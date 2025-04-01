using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp3
{
    public partial class RigaDto : ObservableObject
    {
        [ObservableProperty] string nome;
        [ObservableProperty] string cognome;

        public RigaDto(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }
    }
}
