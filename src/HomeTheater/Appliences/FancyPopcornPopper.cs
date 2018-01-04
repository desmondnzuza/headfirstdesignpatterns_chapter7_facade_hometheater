using System;

namespace HomeTheater.Appliences
{
    class FancyPopcornPopper : IPopcornPopper
    {
        public void On()
        {
            Console.WriteLine("Popcorn Popper is on");
        }

        public void Off()
        {
            Console.WriteLine("Popcorn Popper is off");
        }

        public void Pop()
        {
            Console.WriteLine("Popcorn Popper popping popcorn");
        }
    }
}
