using System;

namespace HomeTheater.Appliences
{
    class FancyScreen : IScreen
    {
        public void Up()
        {
            Console.WriteLine("Theater screen going up");
        }

        public void Down()
        {
            Console.WriteLine("Theater screen going down");
        }
    }
}
