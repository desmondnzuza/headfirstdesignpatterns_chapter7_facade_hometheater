using System;

namespace HomeTheater.Appliences
{
    class FancyThreaterLights : IThreaterLights
    {
        private readonly string _area;

        public FancyThreaterLights(string area)
        {
            _area = area;
        }
        public void On()
        {
            Console.WriteLine($"Theater {_area} Lights on");
        }

        public void Off()
        {
            Console.WriteLine($"Theater {_area} Lights off");
        }

        public void Dim(int level)
        {
            Console.WriteLine($"Theater {_area} Lights dimming to {level}%");
        }
    }
}
