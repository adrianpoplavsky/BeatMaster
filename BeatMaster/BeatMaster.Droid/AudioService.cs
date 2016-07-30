using Android.Media;
using BeatMaster.Droid;
using BeatMaster.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(AudioService))]
namespace BeatMaster.Droid
{
    public class AudioService : IAudio
    {
        public AudioService() { }


        public bool PlayMp3File(string fileName)
        {
            var afd = Android.App.Application.Context.Assets.OpenFd(fileName);

            var mp = new MediaPlayer();
            mp.SetDataSource(afd.FileDescriptor, afd.StartOffset, afd.Length);
            mp.Prepare();
            mp.Start();

            return true;
        }

        public bool PlayWavFile(string fileName)
        {
            var afd = Android.App.Application.Context.Assets.OpenFd(fileName);

            var mp = new MediaPlayer();
            mp.SetDataSource(afd.FileDescriptor, afd.StartOffset, afd.Length);
            mp.Prepare();
            mp.Start();

            return true;
        }
    }
}