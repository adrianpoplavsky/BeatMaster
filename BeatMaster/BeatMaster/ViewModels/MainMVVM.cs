using BeatMaster.Interfaces;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BeatMaster
{
    public class MainMVVM : BaseViewModel
    {
        float _sliderValue;

        public ObservableCollection<PieceOfBeat> introItems { get; set; }

        public float SliderValue
        {
            get { return _sliderValue; }
            set
            {
                _sliderValue = value;
                DependencyService.Get<IAudio>().SetSpeed(_sliderValue);
                OnPropertyChanged("SliderValue");
            }
        }

        public MainMVVM()
        {
            var PlaySong1 = new Command(main =>
            {
                SliderValue = 0;
                DependencyService.Get<IAudio>().PlayMp3File("1.mp3");
            });
            var PlaySong2 = new Command(main =>
            {
                SliderValue = 0;
                DependencyService.Get<IAudio>().PlayMp3File("2.mp3");
            });

            introItems = new ObservableCollection<PieceOfBeat> {
                new PieceOfBeat()            { Name = "Bateria I", ShortDescription="Bateria compás La.", Category="Rock", PlaySong = PlaySong1 },
                new PieceOfBeat()            { Name = "Rapidito", ShortDescription="Bateria compás La." ,Category="Rock", PlaySong = PlaySong2 },
                new PieceOfBeat()            { Name = "Jazz III", ShortDescription="Bateria compás La.",Category="Pop",PlaySong = PlaySong1 },
                new PieceOfBeat()            { Name = "Ska", ShortDescription="Bateria compás La.", Category="Pop", PlaySong = PlaySong2 },
                new PieceOfBeat()            { Name = "Fusa 3", ShortDescription="Bateria compás La.", PlaySong = PlaySong1 },
            };
        }
    }
}
