using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    class CarDirector
    {
        private ICarBuilder builder;
        public CarDirector(ICarBuilder builder)
        {           
            this.builder = builder;
        }
        public Car Construct()
        {
            builder.BuildCarSkeleton();
            builder.BuildCarWindows();
            builder.BuildEngine();
            builder.BuildWheels();
            return builder.GetResult();

        }
    }
}
