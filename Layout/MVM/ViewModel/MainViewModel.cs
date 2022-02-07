using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layout.Core;

namespace Layout.MVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand CreateNewViewCommand { get; set; }
        public RelayCommand EditLayoutViewCommand { get; set; }
        public RelayCommand LayoutViewCommand { get; set; }


        public HomeViewModel HomeVM { get; set; }
        public CreateNewViewModel CreateNewVM { get; set; }
        public LayoutViewModel LayoutVM { get; set; }
        public EditLayoutViewModel EditVM { get; set; }


        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();

            CreateNewVM = new CreateNewViewModel();
            LayoutVM = new LayoutViewModel();
            EditVM = new EditLayoutViewModel();

            CurrentView = HomeVM;
            

            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentView = HomeVM;
            });

            CreateNewViewCommand = new RelayCommand(o =>
            {
                CurrentView = CreateNewVM;
            });

            LayoutViewCommand = new RelayCommand(o =>
            {
                CurrentView = LayoutVM;
            });

            EditLayoutViewCommand = new RelayCommand(o =>
            {
                CurrentView = EditVM;
            });


        }
    }
}
