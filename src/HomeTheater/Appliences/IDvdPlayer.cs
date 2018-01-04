namespace HomeTheater.Appliences
{
    interface IDvdPlayer
    {
        void On();
        void Off();
        void Eject();
        void Pause();
        void Play();
        void Play(string movie);
        void SetSurroundAudio();
        void SetTwoChannelAudio();
        void Stop();
        string GetName();
    }
}
