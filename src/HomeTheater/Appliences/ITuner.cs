namespace HomeTheater.Appliences
{
    interface ITuner
    {
        void On();
        void Off();
        void SetAm();
        void SetFm();
        void SetFrequency(string frequency);
        string GetName();
    }
}
