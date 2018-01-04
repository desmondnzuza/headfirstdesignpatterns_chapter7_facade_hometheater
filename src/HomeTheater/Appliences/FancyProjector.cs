using System;

namespace HomeTheater.Appliences
{
    class FancyProjector : IProjector
    {
        private const string NAME = "Top-O-Line";

        public void On()
        {
            Console.WriteLine($"{NAME} projector on");
        }

        public void Off()
        {
            Console.WriteLine($"{NAME} projector off");
        }

        public void TVMode()
        {
            Console.WriteLine($"{NAME} projector in TV mode");
        }

        public void WideScreenMode()
        {
            Console.WriteLine($"{NAME} projector in widescreen mode (16 X 9) aspect ratio");
        }
    }
}
