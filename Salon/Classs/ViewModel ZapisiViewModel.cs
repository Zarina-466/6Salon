using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Salon.Classs
{
    public class ZapisiViewModel : ViewModel
    {
        private ObservableCollection<ZapisiModel> _zapisi;
        private ZapisiModel _selectedZapisi;

        public ObservableCollection<ZapisiModel> Zapisi
        {
            get => _zapisi;
            set
            {
                _zapisi = value;
                OnPropertyChanged();
            }
        }

        public ZapisiModel SelectedZapisi
        {
            get => _selectedZapisi;
            set
            {
                _selectedZapisi = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand AddZapisiCommand { get; set; }
        public RelayCommand EditZapisiCommand { get; set; }
        public RelayCommand DeleteZapisiCommand { get; set; }

        public ZapisiViewModel()
        {
            Zapisi = new ObservableCollection<ZapisiModel>();

            AddZapisiCommand = new RelayCommand(AddZapisi);
            EditZapisiCommand = new RelayCommand(EditZapisi, CanExecuteSelectedZapisi);
            DeleteZapisiCommand = new RelayCommand(DeleteZapisi, CanExecuteSelectedZapisi);
        }

        private void AddZapisi(object parameter)
        {
            // Логика добавления записи
        }

        private void EditZapisi(object parameter)
        {
            // Логика редактирования записи
        }

        private void DeleteZapisi(object parameter)
        {
            Zapisi.Remove(SelectedZapisi);
        }

        private bool CanExecuteSelectedZapisi(object parameter) => SelectedZapisi != null;
    }
}