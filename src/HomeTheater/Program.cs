using System;
using HomeTheater.Appliences;
using HomeTheater.HomeThreateFacade;

namespace HomeTheater
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fancyName = "Top-O-Line";

            var popper     = new FancyPopcornPopper();
            var lights     = new FancyThreaterLights(fancyName);
            var screen     = new FancyScreen();
            var projector  = new FancyProjector();
            var cd         = new FancyCdPlayer(fancyName);
            var dvd        = new FancyDvdPlayer(fancyName);
            var tuner      = new FancyTuner(fancyName);
            var amp        = new FancyAmplifier(fancyName);

            IHomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, tuner, dvd, cd, 
                projector, lights, screen, popper);

            homeTheater.WatchMovie("Raiders of the Lost Ark");
            homeTheater.EndMovie();

            Console.ReadLine();
        }
    }
}
