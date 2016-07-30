using System.Windows.Input;
using Xamarin.Forms;

namespace BeatMaster { 
    public class PieceOfBeat
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public ICommand PlaySong { get; set; }
    }
}