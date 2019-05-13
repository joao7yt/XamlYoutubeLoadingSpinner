using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamlYoutubeLoadingSpinner
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private LoadingSpinner.SpinnerStates _state = LoadingSpinner.SpinnerStates.Loading;
        public LoadingSpinner.SpinnerStates State
        {
            get => _state;
            set
            {
                _state = value;
                OnPropertyChanged();
            }
        }

        private double _radius = 25;
        public double Radius
        {
            get => _radius;
            set
            {
                _radius = value;
                OnPropertyChanged();
            }
        }

        private double _thickness = 5;
        public double Thickness
        {
            get => _thickness;
            set
            {
                _thickness = value;
                OnPropertyChanged();
            }
        }

        private double _loadingRevolutionsPerSecond = (double)5 / 7;
        public double LoadingRevolutionsPerSecond
        {
            get => _loadingRevolutionsPerSecond;
            set
            {
                _loadingRevolutionsPerSecond = value;
                OnPropertyChanged();
            }
        }

        private double _hangingRevolutionsPerSecond = 0.5;
        public double HangingRevolutionsPerSecond
        {
            get => _hangingRevolutionsPerSecond;
            set
            {
                _hangingRevolutionsPerSecond = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
