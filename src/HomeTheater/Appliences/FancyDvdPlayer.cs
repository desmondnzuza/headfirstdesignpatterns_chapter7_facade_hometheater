using System;

namespace HomeTheater.Appliences
{
    class FancyDvdPlayer : IDvdPlayer
    {
        private readonly string _name;
        private string _selectedMovie;

        public FancyDvdPlayer(string name)
        {
            _name = name;
            _selectedMovie = string.Empty;
        }

        public void On()
        {
            Console.WriteLine($"{_name} DVD Player on");
        }

        public void Off()
        {
            Console.WriteLine($"{_name} DVD Player off");
        }

        public void Eject()
        {
            Console.WriteLine($"{_name} DVD Player eject");
        }

        public void Pause()
        {
            Console.WriteLine($"{_name} DVD Player paused");
        }

        public void Play()
        {
            Console.WriteLine($"{_name} DVD Player playing \"{_selectedMovie}\"");
        }

        public void Play(string movie)
        {
            _selectedMovie = movie;
            Console.WriteLine($"{_name} DVD Player playing \"{_selectedMovie}\"");
        }

        public void SetSurroundAudio()
        {
            Console.WriteLine($"{_name} DVD surround sound on (5 speaker, 1 subwoofer)");
        }

        public void SetTwoChannelAudio()
        {
            Console.WriteLine($"{_name} DVD two channel audio on");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name} DVD Player stopped \"{_selectedMovie}\"");
        }

        public string GetName()
        {
            return _name;
        }
    }
}
