using BeatMaster.Interfaces;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BeatMaster
{
    public class MainMVVM : BaseViewModel
    {
        public ObservableCollection<PieceOfBeat> introItems { get; set; }
     
        public MainMVVM()
        {
            var PlaySong1 = new Command(main =>
            {
                DependencyService.Get<IAudio>().PlayMp3File("1.mp3");
            });
            var PlaySong2 = new Command(main =>
            {
                DependencyService.Get<IAudio>().PlayMp3File("2.mp3");
            });

            introItems = new ObservableCollection<PieceOfBeat> {
                new PieceOfBeat()            { Name = "Bateria I", Category="Rock", PlaySong = PlaySong1 },
                new PieceOfBeat()            { Name = "Rapidito", Category="Rock", PlaySong = PlaySong2 },
                new PieceOfBeat()            { Name = "Jazz III", Category="Pop",PlaySong = PlaySong1 },
                new PieceOfBeat()            { Name = "Ska", Category="Pop", PlaySong = PlaySong2 },
                new PieceOfBeat()            { Name = "Fusa 3", PlaySong = PlaySong1 },
                new PieceOfBeat()            { Name = "Rock", PlaySong = PlaySong2 },
                new PieceOfBeat()            { Name = "Pop", PlaySong = PlaySong1 },
                new PieceOfBeat()            { Name = "Progresivo", PlaySong = PlaySong2 },
            };
        }
    }
}
