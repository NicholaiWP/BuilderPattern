using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    class SimpleBuilder: ICarBuilder
    {
        private Car car;

        public SimpleBuilder()
        {
            car = new Car();
        }

     public void BuildEngine()
        {
            car.SetEngine("V2");
        }

     public void BuildWheels()
        {
            car.SetWheels("rubber tire");
        }

     public void BuildCarSkeleton()
        {
            car.SetCarSkeleton("standard skeleton");
        }

     public void BuildCarWindows()
        {
            car.SetCarWindows("regular car window");
        }

        public Car GetResult()
        {
            return car;
        }
    }
}
