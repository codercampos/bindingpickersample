using System;
using System.Collections.Generic;
using System.Windows.Input;
using PickerSample.Models;
using Xamarin.Forms;

namespace PickerSample
{
    public class MainViewModel : BindableObject
    {
        private List<Person> _people;
        public List<Person> People
        {
            get => _people;
            set
            {
                _people = value;
                OnPropertyChanged(nameof(People));
            }
        }

        private string _selectedName;
        public string SelectedName
        {
            get => _selectedName;
            set
            {
                _selectedName = value;
                OnPropertyChanged(nameof(SelectedName));
            }
        }

        public ICommand SelectedCommand => new Command(thePicker =>
        {
            var picker = (Picker)thePicker;
            if (picker == null) return;
            SelectedName = ((Person)picker.SelectedItem).Name;
        });
        public MainViewModel()
        {
            People = new List<Person>
            {
                new Person { Id = 1, Name = "Karin" },
                new Person { Id = 1, Name = "Carlos" },
                new Person { Id = 1, Name = "Leomaris" },
                new Person { Id = 1, Name = "Jessica" },
                new Person { Id = 1, Name = "Max" },
            };
        }
    }
}
