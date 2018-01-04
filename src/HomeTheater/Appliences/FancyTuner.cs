using System;

namespace HomeTheater.Appliences
{
    class FancyTuner : ITuner
    {
        private readonly string _name;
        private string _selectedFrequency;

        public FancyTuner(string name)
        {
            _name = name;
            _selectedFrequency = "99.5FM";
        }

        public void On()
        {
            Console.WriteLine($"{_name} Tuner on");
        }

        public void Off()
        {
            Console.WriteLine($"{_name} Tuner off");
        }

        public void SetAm()
        {
            Console.WriteLine($"{_name} Tuner set to AM \"{_selectedFrequency}\"");
        }

        public void SetFm()
        {
            Console.WriteLine($"{_name} Tuner set to FM at \"{_selectedFrequency}\"");
        }

        public void SetFrequency(string frequency)
        {
            _selectedFrequency = frequency;
            Console.WriteLine($"{_name} Tuner frequency set to \"{_selectedFrequency}\"");
        }

        public string GetName()
        {
            return _name;
        }
    }
}
