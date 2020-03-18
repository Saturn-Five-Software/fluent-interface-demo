using System;
namespace FluentInterfaceDemo
{
    public class Spaceship
    {
        public string Name;
        public int Width;
        public int Height;
        public bool HasThrusters;

        private Spaceship()
        {
        }

        public static Spaceship Create()
        {
            return new Spaceship() { Name = "My spaceship", Width = 100, Height = 100 };
        }

        public Spaceship WithName(string name)
        {
            Name = name;
            return this;
        }

        public Spaceship OfSize(int width, int height)
        {
            Width = width;
            Height = height;
            return this;
        }

        public Spaceship WithThrusters()
        {
            HasThrusters = true;
            return this;
        }

        public override string ToString()
        {
            return string.Format("Spaceship\nName: {0}\nWidth: {1}\nHeight: {2}\nThrusters: {3}", Name, Width, Height, HasThrusters);
        }
    }

    public static class MySpaceships
    {
        public static Spaceship OfSmallSize(this Spaceship spaceship)
        {
            spaceship.Width = 10;
            spaceship.Height = 10;
            return spaceship;
        }

        public static Spaceship OfMediumSize(this Spaceship spaceship)
        {
            spaceship.Width = 100;
            spaceship.Height = 100;
            return spaceship;
        }

        public static Spaceship OfLargeSize(this Spaceship spaceship)
        {
            spaceship.Width = 1000;
            spaceship.Height = 1000;
            return spaceship;
        }

        public static Spaceship OfSize(this Spaceship spaceship, int width, int height)
        {
            spaceship.Width = width;
            spaceship.Height = height;

            if (spaceship.Height < 100)
                spaceship.HasThrusters = false;
            return spaceship;
        }

    }
}
