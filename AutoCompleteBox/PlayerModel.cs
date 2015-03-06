using GalaSoft.MvvmLight;

namespace AutoCompleteBox
{
    public class PlayerModel : ObservableObject
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { Set(() => Id, ref _id, value); }
        }

        public string Name
        {
            get { return _name; }
            set { Set(() => Name, ref _name, value); }
        }
    }
}
