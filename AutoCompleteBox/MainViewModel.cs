using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight.Command;
using ViewModelBase = GalaSoft.MvvmLight.ViewModelBase;

namespace AutoCompleteBox
{
    public class MainViewModel : ViewModelBase
    {
        private PlayerModel _selectedPlayer;
        private string _searchText;

        public PlayerModel SelectedPlayer
        {
            get { return _selectedPlayer; }
            set { Set(() => SelectedPlayer, ref _selectedPlayer, value); }
        }

        public string SearchText
        {
            get { return _searchText; }
            set { Set(() => SearchText, ref _searchText, value); }
        }

        public ObservableCollection<PlayerModel> PlayersList { get; set; }

        public MainViewModel()
        {
            PlayersList = new ObservableCollection<PlayerModel>
            {
                new PlayerModel {Id = 1, Name = "Wassim AZIRAR"},
                new PlayerModel {Id = 2, Name = "Novak Djokovic"},
                new PlayerModel {Id = 3, Name = "Andy Murray"},
                new PlayerModel {Id = 4, Name = "Roger Federer"},
                new PlayerModel {Id = 5, Name = "Rafael Nadal"},
                new PlayerModel {Id = 6, Name = "Lleyton Hewitt"},
                new PlayerModel {Id = 7, Name = "Pete Sampras"},
                new PlayerModel {Id = 8, Name = "Andre Agassi"},
                new PlayerModel {Id = 9, Name = "Petra Kvitová"},
                new PlayerModel {Id = 10, Name = "Marion Bartoli"},
                new PlayerModel {Id = 11, Name = "Serena Williams"},
                new PlayerModel {Id = 12, Name = "Venus Williams"},
                new PlayerModel {Id = 13, Name = "Maria Sharapova"},
                new PlayerModel {Id = 14, Name = "Lindsay Davenport"},
            };
        }

        private RelayCommand _selectPlayerCommand;

        public RelayCommand SelectPlayerCommand
        {
            get { return _selectPlayerCommand ?? (_selectPlayerCommand = new RelayCommand(SelectPlayerCommandExecute)); }
        }

        private void SelectPlayerCommandExecute()
        {
            SelectedPlayer = PlayersList.FirstOrDefault(player => player.Name == SearchText);

            /*if (SelectedPlayer != null)
            {
                RadMessageBox.ShowAsync(string.Format("Player id = {0}, name = {1}", SelectedPlayer.Id, SelectedPlayer.Name));
            }*/
        }
    }
}
