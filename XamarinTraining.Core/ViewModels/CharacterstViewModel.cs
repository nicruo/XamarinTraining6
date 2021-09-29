using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using Xamarin.Essentials;
using XamarinTraining.Core.Domain;

namespace XamarinTraining.Core.ViewModels
{
    public class CharactersViewModel : ViewModelBase
    {
        private ObservableCollection<Character> characters = new ObservableCollection<Character>
            {
                                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste43" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste23" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste" },
                new Character { Name = "Teste2" },
                new Character { Name = "Teste3" }
            };
        public ObservableCollection<Character> Characters
        {
            get => characters;
            set => Set(nameof(Characters), ref characters, value);
        }
    }
}