namespace HomeTheater.Appliences
{
    interface IAmplifier
    {
        void On();
        void Off();
        void SetCd(ICdPlayer cdPlayer);
        void SetDvd(IDvdPlayer dvdPlayer);
        void SetSurroundSound();
        void SetTuner(ITuner tuner);
        void SetVolume(int level);
    }
}
