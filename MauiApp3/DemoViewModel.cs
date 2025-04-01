using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiApp3
{
    public partial class DemoViewModel : ObservableObject
    {
        [ObservableProperty] ObservableCollection<RigaDto> _righe = [];
        [ObservableProperty] ObservableCollection<WheelPickerDto> _wheelRows = [];
        [ObservableProperty] bool _hasBackButton = true;
        [ObservableProperty] bool _isBackButtonEnabled = false;
        [ObservableProperty] bool _isActivityIndicatorVisible = false;

        [ObservableProperty][NotifyCanExecuteChangedFor(nameof(AddCommand))]
        string _nome;
        
        [ObservableProperty][NotifyCanExecuteChangedFor(nameof(AddCommand))]
        string _cognome;

        public bool CanAdd => string.IsNullOrEmpty(Nome) == false && string.IsNullOrEmpty(Cognome) == false;

        public DemoViewModel()
        {

            Righe.Add(new RigaDto("Mario", "Rossi"));
            Righe.Add(new RigaDto("Mario", "Rossi"));
            Righe.Add(new RigaDto("Mario", "Rossi"));
            Righe.Add(new RigaDto("Mario", "Rossi"));
            Righe.Add(new RigaDto("Mario", "Rossi"));
            Righe.Add(new RigaDto("Mario", "Rossi"));
            Righe.Add(new RigaDto("Mario", "Rossi"));
            Righe.Add(new RigaDto("Mario", "Rossi"));
            Righe.Add(new RigaDto("Mario", "Rossi"));
            Righe.Add(new RigaDto("Mario", "Rossi"));
            Righe.Add(new RigaDto("Mario", "Rossi"));
            Righe.Add(new RigaDto("Mario", "Rossi"));
            Righe.Add(new RigaDto("Mario", "Rossi"));
            Righe.Add(new RigaDto("Mario", "Rossi"));
            Righe.Add(new RigaDto("Mario", "Rossi"));
            Righe.Add(new RigaDto("Mario", "Rossi"));
            Righe.Add(new RigaDto("Mario", "Rossi"));

        }


        [RelayCommand(CanExecute = nameof(CanAdd))]
        private void Add()
        {
            Righe.Add(new RigaDto(Nome, Cognome));
            Nome = string.Empty;
            Cognome = string.Empty;
        }

        [RelayCommand]
        private async void NavBarBackButton()
        {
            await Shell.Current.DisplayAlert("Attenzione", "test", "Ok");
        }

        [RelayCommand]
        private async void Delete(RigaDto riga)
        {
            int idx = Righe.IndexOf(riga);
            if (idx != -1)
            {
                if (await Shell.Current.DisplayAlert("Attenzione", $"Sei sicuro di voler eliminare {riga.Nome} {riga.Cognome}?", "Si", "No"))
                    Righe.RemoveAt(idx);
            }
        }

        [RelayCommand]
        private void ShowActivityIndicator()
        {
            IsActivityIndicatorVisible = true;
        }

     
    }
}
