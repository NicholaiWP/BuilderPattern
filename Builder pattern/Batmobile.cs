using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    class Batmobile: ICarBuilder
    {
        private Car car;

        public Batmobile()
        {
            car = new Car();
        }

        public void BuildEngine()
        {
            car.SetEngine("V5");
        }

        public void BuildWheels()
        {
            car.SetWheels("big wheels");
        }

        public void BuildCarSkeleton()
        {
            car.SetCarSkeleton("void painted skeleton");
        }

        public void BuildCarWindows()
        {
            car.SetCarWindows("toned black windows");
        }

        public Car GetResult()
        {
            return car;
        }
    }
}
