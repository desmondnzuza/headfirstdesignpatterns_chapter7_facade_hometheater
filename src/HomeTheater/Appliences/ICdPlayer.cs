namespace HomeTheater.Appliences
{
    interface ICdPlayer
    {
        void On();
        void Off();
        void Eject();
        void Pause();
        void Play();
        void Play(string cd);
        void Stop();
        string GetName();
    }
}
