using System;
using Android.Media;
using BeatMaster.Droid;
using BeatMaster.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(AudioService))]
namespace BeatMaster.Droid
{
    public class AudioService : IAudio
    {
        MediaPlayer mp ;

        public AudioService() { mp = new MediaPlayer(); }


        public bool PlayMp3File(string fileName)
        {
            var afd = Android.App.Application.Context.Assets.OpenFd(fileName);

            mp.Reset();
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

        public void SetSpeed(float factor)
        {
            if (mp.IsPlaying && factor % 0.005f==0)
            {
                PlaybackParams playbackParams = new PlaybackParams();
                playbackParams.SetSpeed(factor + 1.0f);
                mp.PlaybackParams = playbackParams;
                mp.PlaybackParams.SetSpeed(factor + 1.0f);
            }
        }
    }
}