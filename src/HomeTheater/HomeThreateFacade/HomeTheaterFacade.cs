using System;
using HomeTheater.Appliences;

namespace HomeTheater.HomeThreateFacade
{
    class HomeTheaterFacade : IHomeTheaterFacade
    {
        private readonly IAmplifier _amp;
        private readonly ITuner _tuner;
        private readonly IDvdPlayer _dvd;
        private readonly ICdPlayer _cd;
        private readonly IProjector _projector;
        private readonly IThreaterLights _lights;
        private readonly IScreen _screen;
        private readonly IPopcornPopper _popper;

        public HomeTheaterFacade(
            IAmplifier amp,
            ITuner tuner,
            IDvdPlayer dvd,
            ICdPlayer cd,
            IProjector projector,
            IThreaterLights lights,
            IScreen screen,
            IPopcornPopper popper)
        {
            _amp = amp;
            _tuner = tuner;
            _dvd = dvd;
            _cd = cd;
            _projector = projector;
            _lights = lights;
            _screen = screen;
            _popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _popper.On();
            _popper.Pop();
            _lights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amp.On();
            _amp.SetDvd(_dvd);
            _amp.SetSurroundSound();
            _amp.SetVolume(5);
            _dvd.On();
            _dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _dvd.Stop();
            _dvd.Eject();
            _dvd.Off();
        }

        public void ListenToCd()
        {
            throw new System.NotImplementedException();
        }

        public void EndCd()
        {
            throw new System.NotImplementedException();
        }

        public void ListenToRadio()
        {
            throw new System.NotImplementedException();
        }

        public void EndRadio()
        {
            throw new System.NotImplementedException();
        }
    }
}
