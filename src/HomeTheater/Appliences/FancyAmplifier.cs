using System;

namespace HomeTheater.Appliences
{
    class FancyAmplifier : IAmplifier
    {
        private readonly string _name;

        public FancyAmplifier(string name)
        {
            _name = name;
        }

        public void On()
        {
            Console.WriteLine($"{_name} Amplifier on");
        }

        public void Off()
        {
            Console.WriteLine($"{_name} Amplifier off");
        }

        public void SetCd(ICdPlayer cdPlayer)
        {
            Console.WriteLine($"{_name} Amplifier setting CD player to {cdPlayer.GetName()}");
        }

        public void SetDvd(IDvdPlayer dvdPlayer)
        {
            Console.WriteLine($"{_name} Amplifier setting DVD player to {dvdPlayer.GetName()}");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine($"{_name} Amplifier surround sound on (5 speaker, 1 subwoofer)");
        }

        public void SetTuner(ITuner tuner)
        {
            Console.WriteLine($"{_name} Amplifier setting tuner to {tuner.GetName()}");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"{_name} Amplifier setting volume to {level}");
        }
    }
}
