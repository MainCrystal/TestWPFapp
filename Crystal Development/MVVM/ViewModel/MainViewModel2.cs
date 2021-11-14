using Crystal_Development.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crystal_Development.MVVM.ViewModel
{
    internal class MainViewModel2 : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public RelayCommand GamesViewCoammnd { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }
        public GamesViewModel GamesVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public HomeViewModel HomeViewModel{ get; private set; }

        public MainViewModel2()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            GamesVM = new GamesViewModel();


            CurrentView = new HomeViewModel();

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });

            GamesViewCoammnd = new RelayCommand(o =>
            {
                CurrentView = GamesVM;
            });


        }
    }
}
