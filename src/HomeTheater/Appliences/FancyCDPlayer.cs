using System;

namespace HomeTheater.Appliences
{
    class FancyCdPlayer : ICdPlayer
    {
        private readonly string _name;
        private string _selectedCd;

        public FancyCdPlayer(string name)
        {
            _name = name;
            _selectedCd = string.Empty;
        }

        public void On()
        {
            Console.WriteLine($"{_name} CD Player on");
        }

        public void Off()
        {
            Console.WriteLine($"{_name} CD Player off");
        }

        public void Eject()
        {
            Console.WriteLine($"{_name} CD Player Eject");
        }

        public void Pause()
        {
            Console.WriteLine($"{_name} CD Player paused");
        }

        public void Play()
        {
            Console.WriteLine($"{_name} CD Player playing \"{_selectedCd}\"");
        }

        public void Play(string cd)
        {
            _selectedCd = cd;
            Console.WriteLine($"{_name} CD Player playing \"{_selectedCd}\"");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name} CD Player stopped \"{_selectedCd}\"");
        }

        public string GetName()
        {
            return _name;
        }
    }
}
