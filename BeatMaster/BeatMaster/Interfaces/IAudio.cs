namespace BeatMaster.Interfaces
{
    public interface IAudio
    {
        bool PlayMp3File(string fileName);
        bool PlayWavFile(string fileName);
        void SetSpeed(float factor);
    }
}