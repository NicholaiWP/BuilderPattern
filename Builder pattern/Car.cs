using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    class Car
    {
        private string engine;
        private string wheels;
        private string carSkeleton;
        private string Carwindows;

        public void SetEngine(string value)
        {
            engine = value;
        }

        public void SetWheels(string value)
        {
            wheels = value;
        }

        public void SetCarSkeleton(string value)
        {
            carSkeleton = value;
        }

        public void SetCarWindows(string value)
        {
            Carwindows = value;
        }

        public void GetInfo()
        {
            Console.WriteLine(engine);
            Console.WriteLine(wheels);
            Console.WriteLine(carSkeleton);
            Console.WriteLine(Carwindows);

        }

    }
}
